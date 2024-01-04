using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Windows.Input;

namespace OT1_R4
{
    internal class ReservationsDAO
    {

        string connectionString = "server=127.0.0.1;port=3307;database=vn;uid=root;pwd=Ruutti;";


        public List<Reservation> getReservations()
        {
            List<Reservation> returnThese = new List<Reservation>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM VARAUS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    Reservation r1 = new Reservation
                    {
                        Varaus_ID = reader.GetInt32(0),
                        Asiakas_ID = reader.GetInt32(1),
                        Mokki_ID = reader.GetInt32(2),
                        Varaus_pvm = reader.GetDateTime(3),
                        Vahvistus_pvm = reader.GetDateTime(4),
                        Varauksen_alku_pvm = reader.GetDateTime(5),
                        Varauksen_loppu_pvm = reader.GetDateTime(6)
                    };
                    returnThese.Add(r1);
                }

            }
            connection.Close();

            return returnThese;
        }


        public List<Reservation> searchReservations(String searchTerm)
        {
            List<Reservation> returnThese = new List<Reservation>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM VARAUS V JOIN ASIAKAS A ON V.ASIAKAS_ID = A.ASIAKAS_ID WHERE EMAIL LIKE @search";
            command.Parameters.AddWithValue("@search", searchPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    Reservation r1 = new Reservation
                    {
                        Varaus_ID = reader.GetInt32(0),
                        Asiakas_ID = reader.GetInt32(1),
                        Mokki_ID = reader.GetInt32(2),
                        Varaus_pvm = reader.GetDateTime(3),
                        Vahvistus_pvm = reader.GetDateTime(4),
                        Varauksen_alku_pvm = reader.GetDateTime(5),
                        Varauksen_loppu_pvm = reader.GetDateTime(6)
                    };
                    returnThese.Add(r1);
                }

            }
            connection.Close();

            return returnThese;
        }



        internal int addOneReservation(Reservation reservation)
        {
            int newRows = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if reservation dates are valid
                    DateTime currentDateTime = DateTime.Now;
                   /* if (reservation.Varauksen_alku_pvm < currentDateTime || reservation.Varauksen_loppu_pvm < currentDateTime || reservation.Varauksen_loppu_pvm < reservation.Varauksen_alku_pvm)
                    {
                        // Invalid reservation dates, return 0
                        return newRows;
                    }*/

                    // Check for overlapping reservations
                    using (MySqlCommand overlapCheck = new MySqlCommand("SELECT COUNT(*) FROM `varaus` WHERE " +
                        "`MOKKI_MOKKI_ID` = @mokki_ID AND " +
                        "((@varattu_alkupvm >= `VARATTU_ALKUPVM` AND @varattu_alkupvm < `VARATTU_LOPPUPVM`) OR " +
                        "(@varattu_loppupvm > `VARATTU_ALKUPVM` AND @varattu_loppupvm <= `VARATTU_LOPPUPVM`) OR " +
                        "(@varattu_alkupvm <= `VARATTU_ALKUPVM` AND @varattu_loppupvm >= `VARATTU_LOPPUPVM`))", connection))
                    {
                        overlapCheck.Parameters.AddWithValue("@mokki_ID", reservation.Mokki_ID);
                        overlapCheck.Parameters.AddWithValue("@varattu_alkupvm", reservation.Varauksen_alku_pvm);
                        overlapCheck.Parameters.AddWithValue("@varattu_loppupvm", reservation.Varauksen_loppu_pvm);

                        int overlapCount = Convert.ToInt32(overlapCheck.ExecuteScalar());

                        if (overlapCount > 0)
                        {
                            // Overlapping reservation found, return 0
                            return newRows;
                        }
                    }

                    // No overlapping reservations and valid reservation dates, proceed with insert
                    using (MySqlCommand command = new MySqlCommand("INSERT INTO `varaus` " +
                        "( `ASIAKAS_ID`, `MOKKI_MOKKI_ID`, `VARATTU_PVM`, `VARATTU_ALKUPVM`, `VARATTU_LOPPUPVM`, `VAHVISTUS_PVM`) " +
                        "VALUES (@asiakas_ID, @mokki_ID, @varattu_pvm, @varattu_alkupvm, @varattu_loppupvm, @vahvistus_pvm)", connection))
                    {
                        command.Parameters.AddWithValue("@asiakas_ID", reservation.Asiakas_ID);
                        command.Parameters.AddWithValue("@mokki_ID", reservation.Mokki_ID);
                        command.Parameters.AddWithValue("@varattu_pvm", reservation.Varaus_pvm);
                        command.Parameters.AddWithValue("@varattu_alkupvm", reservation.Varauksen_alku_pvm);
                        command.Parameters.AddWithValue("@varattu_loppupvm", reservation.Varauksen_loppu_pvm);
                        command.Parameters.AddWithValue("@vahvistus_pvm", reservation.Vahvistus_pvm);

                        newRows = command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                Console.WriteLine("Virhe lisäyksessä: " + ex.Message);
            }
            return newRows;
        }




        public int EditReservation(Reservation reservation)
        {
            int ret = -1;
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // check if start date and end date are not in the past
                if (reservation.Varauksen_alku_pvm < DateTime.Today || reservation.Varauksen_loppu_pvm < DateTime.Today)
                {
                    MessageBox.Show("Varauksen alkupäivä tai loppupäivä on menneisyydessä!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ret;
                }

                //check if there are any overlapping reservations
                MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM varaus WHERE mokki_mokki_id = @mokki_id " +
                    "AND ((@varauksen_alku_pvm < varattu_loppupvm AND @varauksen_loppu_pvm > varattu_alkupvm) " +
                    "OR (@varauksen_alku_pvm >= varattu_loppupvm AND @varauksen_loppu_pvm > varattu_alkupvm) " +
                    "OR (@varauksen_alku_pvm < varattu_loppupvm AND @varauksen_loppu_pvm <= varattu_alkupvm)) " +
                    "AND (varaus_id != @varaus_id)", connection);
                checkCmd.Parameters.AddWithValue("@varaus_id", reservation.Varaus_ID);
                checkCmd.Parameters.AddWithValue("@mokki_id", reservation.Mokki_ID);
                checkCmd.Parameters.AddWithValue("@varauksen_alku_pvm", reservation.Varauksen_alku_pvm);
                checkCmd.Parameters.AddWithValue("@varauksen_loppu_pvm", reservation.Varauksen_loppu_pvm);
                int overlappingReservations = Convert.ToInt32(checkCmd.ExecuteScalar());


                if (overlappingReservations == 0)
                {
                    // no overlapping reservations found, update the reservation
                    MySqlCommand cmd = new MySqlCommand("UPDATE varaus SET asiakas_id = @asiakas_id, mokki_mokki_id = @mokki_id, " +
                        "varattu_pvm = @varattu_pvm, vahvistus_pvm = @vahvistus_pvm, varattu_alkupvm = @varattu_alkupvm, " +
                        "varattu_loppupvm = @varattu_loppupvm WHERE varaus_id = @varaus_id", connection);
                    cmd.Parameters.AddWithValue("@varaus_id", reservation.Varaus_ID);
                    cmd.Parameters.AddWithValue("@asiakas_id", reservation.Asiakas_ID);
                    cmd.Parameters.AddWithValue("@mokki_id", reservation.Mokki_ID);
                    cmd.Parameters.AddWithValue("@varattu_pvm", reservation.Varaus_pvm);
                    cmd.Parameters.AddWithValue("@vahvistus_pvm", reservation.Vahvistus_pvm);
                    cmd.Parameters.AddWithValue("@varattu_alkupvm", reservation.Varauksen_alku_pvm);
                    cmd.Parameters.AddWithValue("@varattu_loppupvm", reservation.Varauksen_loppu_pvm);

                    ret = cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Mökki on jo varattu näille päiville!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }





        public int deleteReservation(int reservationID)
        {

            int ret = -1;
            try
            {
                if (CheckUsageBills(reservationID) != 0 || CheckUsageServicesInReservation(reservationID) !=0)
                {
                    MessageBox.Show("Ei voida poistaa varausta, koska siitä on tehty lasku tai varaukselle on palveluita!", "Virhe!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("delete from varaus where varaus_id = @id", connection);

                    cmd.Parameters.AddWithValue("@id", reservationID);

                    ret = cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;

        }


        // Returns how many reservations use a services

        public int CheckUsageServicesInReservation(int id)
        {

            int ret = -1;

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select count(*) from varauksen_palvelut where varaus_id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret = reader.GetInt32(0);
                    }
                }

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;


        }

        //Returns how many bills use a specific reservation_id
        public int CheckUsageBills(int id)
        {
            int ret = -1;

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select count(*) from lasku where varaus_id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret = reader.GetInt32(0);
                    }
                }

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }




        //Returns the price of the cottage based on reservation_id, return of -1 means rearch failed
        public double GetCottagePrice(int reservID)
        {
            double ret = -1;

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT m.hinta FROM varaus v JOIN mokki m ON v.mokki_mokki_id = m.mokki_id WHERE v.varaus_id = @reservID", connection);
                command.Parameters.AddWithValue("@reservID", reservID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        ret = reader.GetDouble(0);
                    }

                }
                connection.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        //Returns the beginning date and the ending date of the reservation. ret[0] = beginning date, ret[1] = ending date
        public DateTime[] GetStartAndEndDate(int reservID)
        {
            DateTime[] ret = new DateTime[2];

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT varattu_alkupvm, varattu_loppupvm FROM varaus WHERE varaus_id = @reservID", connection);
                command.Parameters.AddWithValue("@reservID", reservID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        ret[0] = reader.GetDateTime(0);
                        ret[1] = reader.GetDateTime(1);
                    }

                }
                connection.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        //Returns the used services of a reservation in list form
        public List<ReservedService> GetServices(int reservID)
        {
            List<ReservedService> ret = new List<ReservedService>();

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT p.palvelu_id, p.alue_id, p.nimi, p.kuvaus, p.hinta, p.alv, vp.lkm FROM varaus v JOIN varauksen_palvelut vp " +
                    "ON v.varaus_id = vp.varaus_id " +
                    "JOIN palvelu p " +
                    "ON p.palvelu_id = vp.palvelu_id " +
                    "WHERE v.varaus_id = @reservID;", connection);
                command.Parameters.AddWithValue("@reservID", reservID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservedService a = new ReservedService
                        {
                            Service_ID = reader.GetInt32(0),
                            Area_ID = reader.GetInt32(1),
                            Name = reader.GetString(2),
                            Description = reader.GetString(3),
                            Price = reader.GetDouble(4),
                            Alv = reader.GetDouble(5),
                            Count = reader.GetInt32(6)
                        };

                        ret.Add(a);
                    }
                }
                connection.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        public string[] GetCustomerAddress(int reservID)
        {
            string[] ret = new string[3];

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT a.lahiosoite, p.postinro, p.toimipaikka " +
                    "FROM varaus v JOIN asiakas a " +
                    "ON v.asiakas_id = a.asiakas_id " +
                    "JOIN posti p " +
                    "ON p.postinro = a.postinro " +
                    "WHERE v.varaus_id = @reservID;", connection);
                command.Parameters.AddWithValue("@reservID", reservID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret[0] = reader.GetString(0);
                        ret[1] = reader.GetString(1);
                        ret[2] = reader.GetString(2);
                    }
                }
                connection.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }
    }
}