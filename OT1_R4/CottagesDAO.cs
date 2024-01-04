using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OT1_R4
{
    internal class CottagesDAO
    {
        String conString = "datasource=localhost; port=3307; username=root; password=Ruutti; database=vn";

        //Gets all the cottages from the database, returns them in a List<Cottage> form
        public List<Cottage> GetAllCottages()
        {
            List<Cottage> returnThese = new List<Cottage>();

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select * from mokki", con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cottage c = new Cottage
                        {
                            ID = reader.GetInt32(0),
                            Area_ID = reader.GetInt32(1),
                            PostNum = reader.GetString(2),
                            Name = reader.GetString(3),
                            Address = reader.GetString(4),
                            Price = reader.GetString(5),
                            Description = reader.GetString(6),
                            Headcount = reader.GetInt32(7),
                            Equipment = reader.GetString(8),
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

        //Gets cottages from the database based on search parameters, returns them in a List<Cottage> form
        public List<Cottage> SearchCottages(string name, string area, int price, int headcount, string equipment)
        {
            List<Cottage> returnThese = new List<Cottage>();

            string searchName = "%" + name + "%";
            string searchArea = "%" + area + "%";
            string searchEquipment = "%" + equipment + "%";

            if (price == 0)
            {
                price = 99999999;
            }

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select mokki_id, mokki.alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, " +
                    "henkilomaara, varustelu from mokki join alue on mokki.alue_id = alue.alue_id " +
                    "where mokkinimi like @searchName " +
                    "and alue.nimi like @searchArea " +
                    "and hinta <= @price " +
                    "and henkilomaara >= @headcount " +
                    "and varustelu like @searchEquipment " +
                    "order by mokki_id", con);
                cmd.Parameters.AddWithValue("@searchName", searchName);
                cmd.Parameters.AddWithValue("@searchArea", searchArea);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@headcount", headcount);
                cmd.Parameters.AddWithValue("@searchEquipment", searchEquipment);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cottage c = new Cottage
                        {
                            ID = reader.GetInt32(0),
                            Area_ID = reader.GetInt32(1),
                            PostNum = reader.GetString(2),
                            Name = reader.GetString(3),
                            Address = reader.GetString(4),
                            Price = reader.GetString(5),
                            Description = reader.GetString(6),
                            Headcount = reader.GetInt32(7),
                            Equipment = reader.GetString(8),
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

        //Adds a new cottage, returns 1 if succesful, -1 if unsuccesful
        public int AddCottage(Cottage cot)
        {
            int ret = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("insert into mokki (alue_id, postinro, mokkinimi, katuosoite, hinta," +
                    "kuvaus, henkilomaara, varustelu) values (@area_id, @postnum, @cotname, @address, @price, @desc, @headcount, @equip)", con);
                cmd.Parameters.AddWithValue("@area_id", cot.Area_ID);
                cmd.Parameters.AddWithValue("@postnum", cot.PostNum);
                cmd.Parameters.AddWithValue("@cotname", cot.Name);
                cmd.Parameters.AddWithValue("@address", cot.Address);
                cmd.Parameters.AddWithValue("@price", cot.Price);
                cmd.Parameters.AddWithValue("@desc", cot.Description);
                cmd.Parameters.AddWithValue("@headcount", cot.Headcount);
                cmd.Parameters.AddWithValue("@equip", cot.Equipment);

                ret = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        //Editing an existing cottage, returns 1 if succesful, -1 if unsuccesful
        public int EditCottage(Cottage cot)
        {
            int ret = -1;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("update mokki set alue_id = @alue_id, postinro = @postinro, mokkinimi = @nimi," +
                    "katuosoite = @katuosoite, hinta = @hinta, kuvaus = @kuvaus, henkilomaara = @henkilomaara," +
                    "varustelu = @varustelu where mokki_id = @cottageID", con);
                cmd.Parameters.AddWithValue("@alue_id", cot.Area_ID);
                cmd.Parameters.AddWithValue("@postinro", cot.PostNum);
                cmd.Parameters.AddWithValue("@nimi", cot.Name);
                cmd.Parameters.AddWithValue("@katuosoite", cot.Address);
                cmd.Parameters.AddWithValue("@hinta", cot.Price);
                cmd.Parameters.AddWithValue("@kuvaus", cot.Description);
                cmd.Parameters.AddWithValue("@henkilomaara", cot.Headcount);
                cmd.Parameters.AddWithValue("@varustelu", cot.Equipment);

                cmd.Parameters.AddWithValue("@cottageID", cot.ID);

                ret = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        //Deletes a cottage from the database based on cottage ID, returns 1 if succesful, -1 if unsuccesful
        public int DeleteCottage(int id)
        {
            int ret = -1;
            try
            {
                if (CheckUsageReservations(id) != 0)
                {
                    MessageBox.Show("Ei voida poistaa mökkiä, koska se on käytössä jossain varauksessa!", "Virhe!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("delete from mokki where mokki_id = @id", con);

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

        //Returns how many reserevations use a specific cottage_id, if it returns -1 the search failed
        public int CheckUsageReservations(int id)
        {
            int ret = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select count(*) from varaus where mokki_mokki_id = @id", con);
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

        public int CheckPostcode(string postcode)
        {
            int ret = -1;

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select count(*) from posti where postinro = @postcode", con);
                cmd.Parameters.AddWithValue("@postcode", postcode);

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
