using MySql.Data.MySqlClient;
using System;

namespace OT1_R4
{
    // for connecting database
    internal class Database
    {
        public static string connection_string = "datasource=localhost; port=3307; username=root;password=Ruutti; database=vn;";
        public MySqlConnection mySqlConnection = new MySqlConnection(connection_string);
        public bool connect_db()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool close_db()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
