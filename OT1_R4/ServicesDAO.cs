using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OT1_R4
{
    internal class ServicesDAO
    {
        String conString = "datasource=localhost; port=3307; username=root;password=Ruutti; database=vn;";

        // Create method that contains list of all services

        public List<Services> GetAllServices()
        {
            List<Services> returnThese = new List<Services>();

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select * from palvelu", con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Services a = new Services
                        {

                            palvelu_ID = reader.GetInt32(0),
                            alue_ID = reader.GetInt32(1),
                            nimi = reader.GetString(2),
                            kuvaus = reader.GetString(3),
                            hinta = reader.GetDouble(4),
                            alv = reader.GetDouble(5)

                        };

                        returnThese.Add(a);
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

        public int AddService(Services service)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                // check if service already exists (prevents duplicates)
                MySqlCommand cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM palvelu WHERE nimi=@name AND kuvaus=@description AND hinta=@price AND alue_id = @area", con);
                cmdCheck.Parameters.AddWithValue("@name", service.nimi);
                cmdCheck.Parameters.AddWithValue("@description", service.kuvaus);
                cmdCheck.Parameters.AddWithValue("@price", service.hinta);
                cmdCheck.Parameters.AddWithValue("@area", service.alue_ID);

                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Palvelu " + service.nimi + " on jo tietokannassa.", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return -1;
                }

                    MySqlCommand cmd = new MySqlCommand("insert into palvelu (alue_ID,nimi,kuvaus, hinta, alv) VALUES (@areaID,@name,@description,@price, @alv)", con);

                cmd.Parameters.AddWithValue("@areaID", service.alue_ID);
                cmd.Parameters.AddWithValue("@name", service.nimi);
                cmd.Parameters.AddWithValue("@description", service.kuvaus);
                cmd.Parameters.AddWithValue("@price", service.hinta);
                cmd.Parameters.AddWithValue("@alv", service.alv);


                int ret = cmd.ExecuteNonQuery();
                con.Close();
                return ret;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1;


        }

        // this is place for update services
        public int UpdateService(Services service)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);

                con.Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE palvelu SET alue_ID = @areaID, nimi = @name, kuvaus = @description, hinta = @price, alv = @alv WHERE palvelu_ID = @serviceID", con);

                cmd.Parameters.AddWithValue("@serviceID", service.palvelu_ID);
                cmd.Parameters.AddWithValue("@areaID", service.alue_ID);
                cmd.Parameters.AddWithValue("@name", service.nimi);
                cmd.Parameters.AddWithValue("@description", service.kuvaus);
                cmd.Parameters.AddWithValue("@price", service.hinta);
                cmd.Parameters.AddWithValue("@alv", service.alv);

                int ret = cmd.ExecuteNonQuery();
                MessageBox.Show("Tiedot päivitetty!");

                con.Close();

                return ret;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        // function for deleting service
        public int DeleteService(Services service)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("delete from palvelu where palvelu_ID = @serviceID", con);
                cmd.Parameters.AddWithValue("@serviceID", service.palvelu_ID);

                int ret = cmd.ExecuteNonQuery();

                con.Close();

                return ret;
            }
            catch (Exception)
            {
                MessageBox.Show("Palvelu on käytössä, palvelua ei voida poistaa!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        public List<Services> GetServicesByName(string name)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM palvelu WHERE nimi LIKE @name", con);
               
                // get all services containing search string
                cmd.Parameters.AddWithValue("@name", "%" + name + "%"); 

                MySqlDataReader reader = cmd.ExecuteReader();

                List<Services> servicesList = new List<Services>();

                while (reader.Read())
                {
                    Services service = new Services
                    {
                        palvelu_ID = Convert.ToInt32(reader["palvelu_ID"]),
                        alue_ID = Convert.ToInt32(reader["alue_ID"]),
                        nimi = reader["nimi"].ToString(),
                        kuvaus = reader["kuvaus"].ToString(),
                        hinta = Convert.ToDouble(reader["hinta"]),
                        alv = Convert.ToDouble(reader["alv"])
                    };

                    servicesList.Add(service);
                }

                con.Close();

                return servicesList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
