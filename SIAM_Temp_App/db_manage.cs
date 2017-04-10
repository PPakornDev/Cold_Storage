using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAM_Temp_App
{
    public class db_manage
    {
        private MySqlCommand command;
        private MySqlDataReader dr;
        private List<DataTable> dts;
        string sql;

        public void insertTemp(double temp)
        {
            var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                sql = "INSERT INTO tblTemp (temp,date_Temp) " +
                      "VALUES (" + temp + ",NOW())";
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;
                dr = command.ExecuteReader();

                if (dr.RecordsAffected == 1)
                {
                    db_conn.CloseConnection();
                }
                else
                {
                    db_conn.CloseConnection();
                    MessageBox.Show("Error Save !!!");
                }
            }
            else
            {
                MessageBox.Show("Cannot connect to server. Contact administrator.");
            }
        }

        public void insertDamp(double damp)
        {
            var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                sql = "INSERT INTO tblDamp (damp,date_Damp) " +
                      "VALUES (" + damp + ",NOW())";
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;
                dr = command.ExecuteReader();

                if (dr.RecordsAffected == 1)
                {
                    db_conn.CloseConnection();
                }
                else
                {
                    db_conn.CloseConnection();
                    MessageBox.Show("Error Save !!!");
                }
            }
            else
            {
                MessageBox.Show("Cannot connect to server. Contact administrator.");
            }
        }

        public List<DataTable> getLastData()
        {
            var db_conn = new db_connect();
            dts = new List<DataTable>();
            DataTable dt = new DataTable();

            if (db_conn.OpenConnection())
            {
                sql = "SELECT date_Temp FROM tblTemp ORDER BY id_Temp DESC LIMIT 1";
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;
                dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);
                    dts.Add(dt);
                }

                sql = "SELECT date_Damp FROM tblDamp ORDER BY id_Damp DESC LIMIT 1";
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;

                db_conn.CloseConnection();
                if (db_conn.OpenConnection())
                {
                    dr = command.ExecuteReader();
                }

                if (dr.HasRows)
                {
                    dt = null;
                    dt = new DataTable();
                    dt.Load(dr);
                    dts.Add(dt);
                }

                db_conn.CloseConnection();
                return dts;
            }
            else
            {
                dt = new DataTable("No table");
                dts.Add(dt);
                return dts;
            }
        }

        public bool tranData(string sql)
        {
            var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;

                if (command.ExecuteNonQuery() == 1)
                {
                    db_conn.CloseConnection();
                    return true;
                }
                else
                {
                    db_conn.CloseConnection();
                    MessageBox.Show("Error Save !!!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Cannot connect to server. Contact administrator.");
                return false;
            }
        }

        public DataTable chkUser(string sql)
        {
            DataTable dt = new DataTable();
            var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;
                dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);
                    db_conn.CloseConnection();
                    MessageBox.Show("Login Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return dt;
                }
                else
                {
                    db_conn.CloseConnection();
                    MessageBox.Show("Username หรือ Password ผิด", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return dt;
                }
            }
            else
            {
                MessageBox.Show("Cannot connect to server. Contact administrator.");
                return dt;
            }
        }

        public string getPlan(string sql)
        {
            var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;
                dr = command.ExecuteReader();
                dr.Read();
                return dr["name_Area"].ToString();
            }
            else
            {
                MessageBox.Show("Cannot connect to server. Contact administrator.");
                return "";
            }
        }

        public int lastObj(string sql)
        {
            var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    int count = 0;
                    while(dr.Read())
                    {
                        count++;
                    }

                    return count;
                }
                else
                {
                    return 0;
                }
          
            }
            else
            {
                MessageBox.Show("Cannot connect to server. Contact administrator.");
                return -1;
            }
        }

        public DataTable getData(string sql)
        {
            DataTable dt = new DataTable();
            var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;
                dr = command.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            else
            {
                MessageBox.Show("Cannot connect to server. Contact administrator.");
                return dt;
            }
        }

        public string lastImg(string sql)
        { var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = db_conn.connection;
                dr = command.ExecuteReader();
                dr.Read();
                if (!dr.HasRows)
                {
                    return "";
                }
                return dr["img_Name"].ToString();
            }
            else
            {
                MessageBox.Show("Cannot connect to server. Contact administrator.");
                return "";
            }
        }
    }
}
