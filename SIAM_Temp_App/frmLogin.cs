using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SIAM_Temp_App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUser;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.chkConnect();
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new frmRegister();
            f.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT User_Emp,Pass_Emp,Name_Emp,img_Emp FROM tblEmployees WHERE " +
                                       "User_Emp = '{0}' and Pass_Emp = '{1}'", 
                                       txtUser.Text.Trim(), txtPass.Text.Trim());

            var manage = new db_manage();
            var emp = manage.chkUser(sql);    
            if (emp.Rows.Count > 0)
            { 
                this.Hide();
                var f = new frmMain();
                f.nameEmp = emp.Rows[0][2].ToString();

                byte[] bits = (byte[])emp.Rows[0][3];
                MemoryStream mem = new MemoryStream(bits);
                f.imgEmp = Image.FromStream(mem);

                emp.Dispose();
                f.ShowDialog();
                this.Close();
            }
        }

        private void chkConnect()
        {
            Cursor.Current = Cursors.WaitCursor;
            var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                status_info.BackColor = Color.LimeGreen;
                status_db_name.Text = $"The program is ready";
                db_conn.CloseConnection();
            }
            else
            {
                status_info.BackColor = Color.DarkOrange;
                status_db_name.Text = $"The program is not ready";
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
