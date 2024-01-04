using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OT1_R4
{
    internal class AreasDAO
    {
        String conString = "datasource=localhost; port=3307; username=root;password=Ruutti; database=vn;";

        public List<Area> GetAllAreas()
        {
            List<Area> returnThese = new List<Area>();

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select * from alue", con);


                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Area a = new Area
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1)
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

        //Adding the new area, returns how many rows were affecter (should be 1 if succesfully added)
        public int AddArea(String name)
        {
            int ret = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("insert into alue (nimi) values (@name)", con);
                cmd.Parameters.AddWithValue("@name", name);

                ret = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        //Updating the area name, returns how many rows were affecter (should be 1 if succesfully updated)
        public int RenameArea(String newName, String oldName)
        {
            int ret = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("update alue set nimi = @newName where nimi = @oldName", con);
                cmd.Parameters.AddWithValue("@newName", newName);
                cmd.Parameters.AddWithValue("@oldName", oldName);

                ret = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        public int DeleteArea(int id)
        {
            int ret = 1;

            try
            {
                if (CheckUsageCottages(id) != 0)
                {
                    MessageBox.Show("Ei voida poistaa aluetta, koska se on käytössä jossain mökissä!", "Virhe!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckUsageServices(id) != 0)
                {
                    MessageBox.Show("Ei voida poistaa aluetta, koska se on käytössä jossain palvelussa!", "Virhe!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("delete from alue where alue_id = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);

                    ret = cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        //Returns how many cottages use a specific area_id, if it returns -1 the search failed
        public int CheckUsageCottages(int id)
        {
            int ret = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select count(*) from mokki where alue_id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);

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

        //Returns how many services use a specific area_id, if it returns -1 the search failed
        public int CheckUsageServices(int id)
        {
            int ret = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select count(*) from palvelu where alue_id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);

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
    }
}
