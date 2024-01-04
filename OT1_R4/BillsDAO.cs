using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OT1_R4
{
    internal class BillsDAO
    {
        string conString = "datasource=localhost; port=3307; username=root; password=Ruutti; database=vn";

        //Gets all the bills from the database, returns them in a List<Bill> form
        public List<Bill> GetAllBills()
        {
            List<Bill> returnThese = new List<Bill>();

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select l.lasku_id, l.varaus_id, l.summa, l.alv, l.maksettu, a.asiakas_id, a.email " +
                    "from lasku l join varaus v " +
                    "on l.varaus_id = v.varaus_id " +
                    "join asiakas a " +
                    "on a.asiakas_id = v.asiakas_id", con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bill b = new Bill
                        {
                            BillID = reader.GetInt32(0),
                            ReservationID = reader.GetInt32(1),
                            Amount = reader.GetDouble(2),
                            Alv = reader.GetDouble(3),
                            Paid = reader.GetInt32(4) > 0 ? true : false,
                            CustomerID = reader.GetInt32(5),
                            CustomerEmail = reader.GetString(6)
                        };

                        returnThese.Add(b);
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

        //Creates a new bill with the reservationID, the ID of the bill will be the same as the reservation, this prevents the creation
        //of multiple bills for the same reservation returns 1 if successful, -1 if unsuccessful
        public int AddBill(int reservID, double totalPrice, double alv)
        {
            int ret = -1;

            try
            {
                if (CheckBillExists(reservID) != 0)
                {
                    MessageBox.Show("Ei voida luoda laskua, koska se varauksesta on jo luotu lasku!", "Virhe!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("insert into lasku (lasku_id, varaus_id, summa, alv) values (@billID, @reservID, @totalPrice, @alv)", con);
                    cmd.Parameters.AddWithValue("billID", reservID);
                    cmd.Parameters.AddWithValue("reservID", reservID);
                    cmd.Parameters.AddWithValue("totalPrice", totalPrice);
                    cmd.Parameters.AddWithValue("alv", alv);

                    ret = cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        //Deletes a bill from the database based on bill ID, returns 1 if succesful, -1 if unsuccesful
        public int DeleteBill(int id)
        {
            int ret = -1;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("delete from lasku where lasku_id = @id", con);

                cmd.Parameters.AddWithValue("@id", id);

                ret = cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        //Returns if a bill with a certain ID already existst, retursn 1 if exists, 0 if not, -1 if the search failed
        public int CheckBillExists(int billID)
        {
            int ret = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select count(*) from lasku where lasku_id = @id", con);
                cmd.Parameters.AddWithValue("@id", billID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret = reader.GetInt32(0);
                    }
                }

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        //Updating the bills paid status, returns how many rows were affecter (should be 1 if succesfully updated)
        public int ChangePaidStatus(int billID, int paidStatus)
        {
            int ret = -1;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("update lasku set maksettu = @paidStatus where lasku_id = @billID", con);
                cmd.Parameters.AddWithValue("@paidStatus", paidStatus);
                cmd.Parameters.AddWithValue("@billID", billID);

                ret = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        public List<Bill> SearchBills(string email)
        {
            List<Bill> returnThese = new List<Bill>();

            string searchEmail = "%" + email + "%";

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select l.lasku_id, l.varaus_id, l.summa, l.alv, l.maksettu, a.asiakas_id, a.email from lasku l join varaus v " +
                    "on l.varaus_id = v.varaus_id " +
                    "join asiakas a " +
                    "on a.asiakas_id = v.asiakas_id " +
                    "where a.email like @searchName " +
                    "order by l.lasku_id", con);
                cmd.Parameters.AddWithValue("@searchName", searchEmail);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bill b = new Bill
                        {
                            BillID = reader.GetInt32(0),
                            ReservationID = reader.GetInt32(1),
                            Amount = reader.GetDouble(2),
                            Alv = reader.GetDouble(3),
                            Paid = reader.GetInt32(4) > 0 ? true : false,
                            CustomerID = reader.GetInt32(5),
                            CustomerEmail = reader.GetString(6)
                        };

                        returnThese.Add(b);
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
