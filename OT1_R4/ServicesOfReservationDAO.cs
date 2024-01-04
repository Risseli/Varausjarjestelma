using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OT1_R4
{
    internal class ServicesOfReservationDAO
    {

        string conString = "datasource=localhost; port=3307; username=root; password=Ruutti; database=vn";


        //Gets all the services of reservation from the database, returns them in a List<ServiceOfReservation> form
        public List<ServicesOfReservation> GetAllServiceOfReservation()
        {
            List<ServicesOfReservation> returnThese = new List<ServicesOfReservation>();

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select * from varauksen_palvelut", con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ServicesOfReservation services = new ServicesOfReservation
                        {
                            Varaus_ID = reader.GetInt32(0),
                            Palvelu_ID = reader.GetInt32(1),
                            Lkm = reader.GetInt32(2),
                       
                        };

                        returnThese.Add(services);
                    }
                }

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return returnThese;
        }


        // Adds a new service of reservation, returns 1 if successful, -1 if unsuccessful
        public int AddNewServiceOfReservation(ServicesOfReservation newService)
        {
            int ret = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO varauksen_palvelut (varaus_id, palvelu_id, lkm) VALUES (@varausID, @palveluID, @lkm)", con);
                cmd.Parameters.AddWithValue("@varausID", newService.Varaus_ID);
                cmd.Parameters.AddWithValue("@palveluID", newService.Palvelu_ID);
                cmd.Parameters.AddWithValue("@lkm", newService.Lkm);

                ret = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }






        // deletes service of reservation
        public void DeleteServiceOfReservation(int varausID, int palveluID)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM varauksen_palvelut WHERE varaus_id=@varausID AND palvelu_id=@palveluID", con);
                cmd.Parameters.AddWithValue("@varausID", varausID);
                cmd.Parameters.AddWithValue("@palveluID", palveluID);

                int rowsAffected = cmd.ExecuteNonQuery();

                con.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public int EditServiceOfReservation(ServicesOfReservation servicesofreservation)
        {
            int rowsAffected = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE varauksen_palvelut SET palvelu_id=@palveluID, lkm=@maara WHERE varaus_id=@varausID AND palvelu_id=@palveluID", con);
                cmd.Parameters.AddWithValue("@varausID", servicesofreservation.Varaus_ID);
                cmd.Parameters.AddWithValue("@palveluID", servicesofreservation.Palvelu_ID);
                cmd.Parameters.AddWithValue("@maara", servicesofreservation.Lkm);

                rowsAffected = cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rowsAffected;
        }






        // gets all the services of reservation using same reservation id
        public List<ServicesOfReservation> GetServiceOfReservationByReservationId(int reservationId)
        {
            List<ServicesOfReservation> returnThese = new List<ServicesOfReservation>();

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM varauksen_palvelut WHERE varaus_id = @reservationId", con);
                cmd.Parameters.AddWithValue("@reservationId", reservationId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ServicesOfReservation services = new ServicesOfReservation
                        {
                            Varaus_ID = reader.GetInt32(0),
                            Palvelu_ID = reader.GetInt32(1),
                            Lkm = reader.GetInt32(2)
                        };

                        returnThese.Add(services);
                    }
                }

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return returnThese;
        }


    }
}
