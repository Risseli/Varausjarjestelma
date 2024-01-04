using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OT1_R4
{
    internal class CustomerDAO
    {
        String conString = "datasource=localhost; port=3307; username=root; password=Ruutti; database=vn";

        public List<Customer> GetAllCustomer()
        {

            List<Customer> returnThese = new List<Customer>();
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select * from asiakas", con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer c = new Customer
                        {
                            ID = reader.GetInt32(0),
                            PostNum = reader.GetString(1),
                            Name = reader.GetString(2),
                            LastName = reader.GetString(3),
                            Address = reader.GetString(4),
                            Email = reader.GetString(5),
                            Number = reader.GetString(6)
                        };

                        returnThese.Add(c);
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
        public int AddCustomer(Customer cusi)
        {

            int ret = -1;
            try
            {

                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand command = new MySqlCommand("INSERT INTO asiakas (postinro, etunimi, sukunimi," +
                    " lahiosoite, email, puhelinnro) VALUES (@PostNum,@Name,@LastName,@Address,@Email,@Number)", con);




                command.Parameters.AddWithValue("@Name", cusi.Name);
                command.Parameters.AddWithValue("@LastName", cusi.LastName);
                command.Parameters.AddWithValue("@Email", cusi.Email);
                command.Parameters.AddWithValue("@Number", cusi.Number);
                command.Parameters.AddWithValue("@Address", cusi.Address);
                command.Parameters.AddWithValue("@PostNum", cusi.PostNum);

                ret = command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }
        public int DeleteCustomer(int id)
        {
            int ret = -1;
            try
            {
                
                    MySqlConnection con = new MySqlConnection(conString);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("delete from asiakas where asiakas_id = @id", con);

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
        public int EditCustomer(Customer cus)
        {
            int ret = -1;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand command = new MySqlCommand("update asiakas set postinro = @PostNum, etunimi = @Name, sukunimi = @LastName," +
                    "lahiosoite = @Address, email = @Email, puhelinnro = @Number where asiakas_id =@ID", con);
                command.Parameters.AddWithValue("@Name", cus.Name);
                command.Parameters.AddWithValue("@LastName", cus.LastName);
                command.Parameters.AddWithValue("@Email", cus.Email);
                command.Parameters.AddWithValue("@Number", cus.Number);
                command.Parameters.AddWithValue("@Address", cus.Address);
                command.Parameters.AddWithValue("@PostNum", cus.PostNum);
                command.Parameters.AddWithValue("@ID", cus.ID);


                ret = command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe tuli!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }
        public List<Customer> GetCustomerByEmail(string email)
        {
            

            List<Customer> returnThese = new List<Customer>();
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select * from asiakas where email='"+email+"'" , con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer c = new Customer
                        {
                            ID = reader.GetInt32(0),
                            PostNum = reader.GetString(1),
                            Name = reader.GetString(2),
                            LastName = reader.GetString(3),
                            Address = reader.GetString(4),
                            Email = reader.GetString(5),
                            Number = reader.GetString(6)
                        };

                        returnThese.Add(c);
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
