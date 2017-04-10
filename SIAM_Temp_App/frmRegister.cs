using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCharpWebCam;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace SIAM_Temp_App
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            cmbDegree.SelectedIndex = 3;
            this.ActiveControl = txtUser;
        }

        WebCam webcam;
        private void frmRegister_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref picCapture);
        }

        private void btnWebCam_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(btnWebCam.Tag) == 0)
            {
                webcam.Start();
                btnWebCam.Tag = 1;
                btnWebCam.Text = "ถ่ายรูป";
            }
            else
            {
                var img = picCapture.Image;
                webcam.Stop();
                picCapture.Image = img;
                btnWebCam.Tag = 0;
                btnWebCam.Text = "เปิดกล้อง";
            }
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            webcam.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text != "") && (txtPass.Text != "") && (txtRePass.Text != "")
              && (txtName.Text != "") && (txtIdCard.Text != ""))
            {
                if (txtPass.Text.Equals(txtRePass.Text))
                {
                    if (txtIdCard.TextLength == 13)
                    {
                        if (picCapture.Image == null)
                        {
                            MessageBox.Show("กรุณาถ่ายรูปพนักงาน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        Cursor.Current = Cursors.WaitCursor;
                        char sex;
                        if (rdoM.Checked) sex = 'M';
                        else sex = 'F';

                        Image img = picCapture.Image;
                        MemoryStream mem = new MemoryStream();
                        img.Save(mem, ImageFormat.Png);
                        byte[] imgByte = mem.ToArray();

                        string sql = "INSERT INTO tblEmployees " +
                            "(User_Emp,Pass_Emp,Name_Emp,IdCard_Emp,Gender_Emp,Address_Emp,Age_Emp,Edu_Emp,img_Emp) " +
                            "VALUES (@User_Emp, @Pass_Emp, @Name_Emp, @IdCard_Emp, @Gender_Emp, @Address_Emp, @Age_Emp, @Edu_Emp, @img_Emp)";

                        var db_conn = new db_connect();
                        if (db_conn.OpenConnection())
                        {
                            MySqlCommand cmd = new MySqlCommand(sql, db_conn.connection);
                            cmd.Parameters.Add("@User_Emp", MySqlDbType.VarChar, 30);
                            cmd.Parameters.Add("@Pass_Emp", MySqlDbType.VarChar, 30);
                            cmd.Parameters.Add("@Name_Emp", MySqlDbType.VarChar, 50);
                            cmd.Parameters.Add("@IdCard_Emp", MySqlDbType.VarChar, 13);
                            cmd.Parameters.Add("@Gender_Emp", MySqlDbType.VarChar, 1);
                            cmd.Parameters.Add("@Address_Emp", MySqlDbType.Text);
                            cmd.Parameters.Add("@Age_Emp", MySqlDbType.Int16, 2);
                            cmd.Parameters.Add("@Edu_Emp", MySqlDbType.VarChar, 20);
                            cmd.Parameters.Add("@img_Emp", MySqlDbType.MediumBlob);

                            cmd.Parameters["@User_Emp"].Value = txtUser.Text;
                            cmd.Parameters["@Pass_Emp"].Value = txtRePass.Text;
                            cmd.Parameters["@Name_Emp"].Value = txtName.Text;
                            cmd.Parameters["@IdCard_Emp"].Value = txtIdCard.Text;
                            cmd.Parameters["@Gender_Emp"].Value = sex;
                            cmd.Parameters["@Address_Emp"].Value = txtAddress.Text;
                            cmd.Parameters["@Age_Emp"].Value = Convert.ToInt32(numricAge.Value);
                            cmd.Parameters["@Edu_Emp"].Value = cmbDegree.Text;
                            cmd.Parameters["@img_Emp"].Value = imgByte;

                            int RowsAffected = cmd.ExecuteNonQuery();
                            if (RowsAffected > 0)
                            {
                                MessageBox.Show("บันทึกสำเร็จ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("กรุณาทำรายการใหม่", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            db_conn.connection.Close();
                            Cursor.Current = Cursors.Default;
                        }
                        else
                        {
                            MessageBox.Show("Cannot connect to server. Contact administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("เลขบัตรประชาชนไม่ครบ 13 หลัก", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("คุณใส่รหัสผ่านไม่ตรงกัน", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("คุณใส่ข้อมูลไม่ครบ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
