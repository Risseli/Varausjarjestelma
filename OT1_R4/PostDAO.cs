using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace OT1_R4
{
    internal class PostDAO
    {
        string conString = "datasource=localhost; port=3307; username=root; password=Ruutti; database=vn";

        public List<Post> GetAllPost()
        {
            List<Post> returnThese = new List<Post>();
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select * from posti", con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Post c = new Post
                        {
                            Postn = reader.GetString(0),
                            PostPlace = reader.GetString(1)

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