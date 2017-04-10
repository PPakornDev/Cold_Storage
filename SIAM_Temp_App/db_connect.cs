using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAM_Temp_App
{
    public class db_connect
    {
        public MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string pwd;
        private string charset;

        public db_connect()
        {
            this.DbInitialize();
        }

        private void DbInitialize()
        {
            server = "119.59.120.4";
            port = "3306";
            database = "ppakorni_siamT";
            uid = "ppakorni_siamT";
            pwd = "22012539";
            charset = "utf8";

            string connectionString = "server=" + server + ";" + "port=" + port + ";" + "database=" +
                                      database + ";" + "uid=" + uid + ";" + "pwd=" + pwd + ";" + "charset=" + charset + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show($"Error code: {ex.Number}\n" +
                                        $"Error message : Cannot connect to server. Contact administrator."
                                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;

                    case 1045:
                        MessageBox.Show($"Error code: {ex.Number}\n" +
                                        $"Error message : Invalid username/password, please try again..."
                                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;

                    case 1042:
                        MessageBox.Show($"Error code: {ex.Number}\n" +
                                        $"Error message : Unable to connect to any of the specified MySQL hosts."
                                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    default:
                        MessageBox.Show($"Error code : {ex.Number}\n" +
                                        $"Error message : {ex.Message}"
                                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error code: {ex.Number}\n" +
                                $"Error message : {ex.Message}"
                                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }
    }
}
