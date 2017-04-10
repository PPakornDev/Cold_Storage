using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAM_Temp_App
{
    public partial class frmImg : Form
    {
        public frmImg()
        {
            InitializeComponent();
        }

        public string barCode { get; set; }

        private void frmImg_Load(object sender, EventArgs e)
        {
            string sql = "SELECT date_Img,img_Name FROM tblObjectImg WHERE id_obj = '" + barCode + "' "+
                         "and date_Img IN (SELECT MAX(date_Img) FROM tblObjectImg) GROUP BY img_Name";
            var manage = new db_manage();
            string url = manage.lastImg(sql);
            if (url == "")
            {
                return;
            }

            pictureBox1.Load("http://www.ppakorn.info/siam_summaryDoc/img/coding2/" + url);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image.Save(folderBrowserDialog1.SelectedPath +
                                      "\\" + barCode + "OB.jpeg", ImageFormat.Jpeg);
                MessageBox.Show("Save.");
            }
        }
    }
}
