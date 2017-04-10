using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAM_Temp_App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frm = new frmManage();
        }

        public frmManage frm { get; set; }
        public string nameEmp { get; set; }
        public Image imgEmp { get; set; }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            string sql = "SELECT * FROM tblTemp WHERE DATE(date_Temp) = CURDATE()";
            var manage = new db_manage();
            DataTable dt = manage.getData(sql);
            this.chartTemp.Series["Temperature"].Points.AddXY(convertDate(dt), dt.Rows.Count == 0 ? 0 : dt.Rows[0][1]);

            sql = "SELECT * FROM tblDamp WHERE DATE(date_Damp) = CURDATE()";
            dt = manage.getData(sql);
            this.chartTemp.Series["Humidity"].Points.AddXY(convertDate(dt), dt.Rows.Count == 0 ? 0 : dt.Rows[0][1]);

            sql = "SELECT * FROM tblTemp WHERE DATE(date_Temp) = CURDATE() - 1";
            dt = manage.getData(sql);
            this.chartTemp.Series["Temperature"].Points.AddXY(convertDate(dt), dt.Rows.Count == 0 ? 0 : dt.Rows[0][1]);

            sql = "SELECT * FROM tblDamp WHERE DATE(date_Damp) = CURDATE() - 1";
            dt = manage.getData(sql);
            this.chartTemp.Series["Humidity"].Points.AddXY(convertDate(dt), dt.Rows.Count == 0 ? 0 : dt.Rows[0][1]);

            sql = "SELECT * FROM tblTemp WHERE DATE(date_Temp) = CURDATE() - 2";
            dt = manage.getData(sql);
            this.chartTemp.Series["Temperature"].Points.AddXY(convertDate(dt), dt.Rows.Count == 0 ? 0 : dt.Rows[0][1]);

            sql = "SELECT * FROM tblDamp WHERE DATE(date_Damp) = CURDATE() - 2";
            dt = manage.getData(sql);
            this.chartTemp.Series["Humidity"].Points.AddXY(convertDate(dt), dt.Rows.Count == 0 ? 0 : dt.Rows[0][1]);

            picEmp.Image = imgEmp;
            lblNmeEmp.Text = nameEmp;

            var db_conn = new db_connect();
            if (db_conn.OpenConnection())
            {
                lblDBName.Text = db_conn.connection.Database;
                lblDataSrc.Text = db_conn.connection.DataSource;
                lblIP.Text = Program.GetIP();
                lblServThread.Text = db_conn.connection.ServerThread.ToString();
                lblServVersion.Text = db_conn.connection.ServerVersion;
                lblServState.Text = db_conn.connection.State.ToString();
                lblHosting.Text = "www.ppakorni.info";
                db_conn.CloseConnection();
            }
            else
            {
                lblDBName.Text = $"Unknown";
                lblDataSrc.Text = $"Unknown";
                lblIP.Text = Program.GetIP();
                lblServThread.Text = $"Unknown";
                lblServVersion.Text = $"Unknown";
                lblServState.Text = $"Unknown";
                lblHosting.Text = $"Unknown";
            }
            UseWaitCursor = false;
        }

        private void btnPlanA_Click(object sender, EventArgs e)
        {
            frm = new frmManage();
            frm.area = "PA";
            frm.backColor = Color.LightSkyBlue;
            frm.ShowDialog();
        }

        private void btnPlanB_Click(object sender, EventArgs e)
        {
            frm = new frmManage();
            frm.area = "PB";
            frm.backColor = Color.LightGreen;
            frm.ShowDialog();
        }

        private void btnPlanC_Click(object sender, EventArgs e)
        {
            frm = new frmManage();
            frm.area = "PC";
            frm.backColor = Color.Coral;
            frm.ShowDialog();
        }

        private void btnPlanD_Click(object sender, EventArgs e)
        {
            frm = new frmManage();
            frm.area = "PD";
            frm.backColor = Color.Plum;
            frm.ShowDialog();
        }

        private void btnLogA_Click(object sender, EventArgs e)
        {
            frm = new frmManage();
            frm.area = "LA";
            frm.backColor = Color.Khaki;
            frm.ShowDialog();
        }

        private void btnLogB_Click(object sender, EventArgs e)
        {
            frm = new frmManage();
            frm.area = "LB";
            frm.backColor = Color.Pink;
            frm.ShowDialog();
        }

        private void btnLogC_Click(object sender, EventArgs e)
        {
            frm = new frmManage();
            frm.area = "LC";
            frm.backColor = Color.YellowGreen;
            frm.ShowDialog();
        }

        private void btnLogD_Click(object sender, EventArgs e)
        {
            frm = new frmManage();
            frm.area = "LD";
            frm.backColor = Color.Aquamarine;
            frm.ShowDialog();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            var frm = new frmSiamTemp();
            frm.ShowDialog();
        }

        private string convertDate(DataTable dt)
        {
            try
            {
                DateTime date = Convert.ToDateTime(dt.Rows[0][2]);
                return date.ToString("dd/MM/yyyy");
            }
            catch
            {
                return "No Data";
            }
        }
    }
}
