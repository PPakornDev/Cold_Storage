using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;
using System.Drawing.Imaging;
using System.IO;

namespace SIAM_Temp_App
{
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
            this.ActiveControl = txtBarCode;
            manage = new db_manage();
        }

        public string area { get; set; }
        public string barCode { get; set; }
        public string sql { get; set; }
        public bool run { get; set; }
        public db_manage manage { get; set; }
        public Color backColor { get; set; }

        private void frmManage_Load(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            lblBarCodeImg.Text = "";
            lblBack.BackColor = backColor;
            lblPlan.BackColor = backColor;
            btnAdd.BackColor = backColor;
            btnEdit.BackColor = backColor;
            btnDel.BackColor = backColor;

            sql = "SELECT * FROM tblArea WHERE id_Area = '" + area + "'";
            lblPlan.Text = manage.getPlan(sql);

            sql = "SELECT id_obj FROM tblObjects WHERE id_Area = '" + area + "' and action NOT IN('D')";
            DataTable dt = manage.getData(sql);
            foreach (DataRow row in dt.Rows)
            {
                lstObjects.Items.Add(row["id_obj"].ToString());
            }

            sql = string.Format("SELECT id_obj FROM tblObjects WHERE id_Area = '{0}'", area);
            barCode = area + (manage.lastObj(sql) + 1).ToString("00000");
            txtBarCode.Text = barCode;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            txtProName.Enabled = false;
            txtCompany.Enabled = false;
            txtWeight.Enabled = false;

            txtBarCode.Focus();
            txtBarCode.SelectAll();
        }

        private void lstObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstObjects.SelectedIndex != -1)
            {
                Cursor.Current = Cursors.WaitCursor;
                txtBarCode.ReadOnly = false;
                lblWarning.Text = "";
                sql = "SELECT * FROM tblObjects WHERE id_obj = '" + lstObjects.Text + "'";
                DataTable dt = manage.getData(sql);
                foreach (DataRow row in dt.Rows)
                {
                    txtBarCode.Text = row["id_obj"].ToString();
                    txtProName.Text = row["name_obj"].ToString();
                    txtCompany.Text = row["company_obj"].ToString();
                    txtWeight.Text = row["weight_obj"].ToString();
                }

                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                btnAdd.Enabled = false;
                txtProName.Enabled = true;
                txtCompany.Enabled = true;
                txtWeight.Enabled = true;

                this.genBarCode();
                Cursor.Current = Cursors.Default;
                this.ActiveControl = txtBarCode;
                txtBarCode.SelectAll();
            }
        }

        private void txtBarCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor.Current = Cursors.WaitCursor;
                lblWarning.Text = "";
                sql = "SELECT * FROM tblObjects WHERE id_obj = '" + txtBarCode.Text.Trim() + "' " +
                      "and action NOT IN('D') and id_Area = '" + area + "'";
                DataTable dt = manage.getData(sql);
                if (dt.Rows.Count == 0)
                {
                    this.clearText();
                    this.runNumber();
                    txtBarCode.ReadOnly = false;
                    btnAdd.Enabled = false;
                    lblWarning.Text = "ไม่พบข้อมูลในระบบ";
                    this.ActiveControl = txtBarCode;
                    txtBarCode.SelectAll();
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    txtBarCode.Text = row["id_obj"].ToString();
                    txtProName.Text = row["name_obj"].ToString();
                    txtCompany.Text = row["company_obj"].ToString();
                    txtWeight.Text = row["weight_obj"].ToString();
                }

                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                btnAdd.Enabled = false;
                txtProName.Enabled = true;
                txtCompany.Enabled = true;
                txtWeight.Enabled = true;

                this.genBarCode();
                Cursor.Current = Cursors.Default;
                txtBarCode.SelectAll();
            }
        }

        private void btnAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblWarning.Text = "";
            if (!chkData()) return;
            Cursor.Current = Cursors.WaitCursor;

            sql = string.Format("INSERT INTO tblObjects VALUES ('{0}', '{1}', '{2}', '{3}', {4}, NOW(), 'I')",
                                barCode, area, txtProName.Text, txtCompany.Text,
                                Convert.ToDouble(txtWeight.Text));
            if (manage.tranData(sql))
            {
                lblWarning.Text = "";
                lstObjects.Items.Add(barCode);
                MessageBox.Show("เพิ่มข้อมูลเรียบร้อยเเล้ว", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.runNumber();
            Cursor.Current = Cursors.Default;
        }

        private void btnEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblWarning.Text = "";
            if (!chkData()) return;
            Cursor.Current = Cursors.WaitCursor;

            sql = string.Format("UPDATE tblObjects SET name_obj = '{0}',company_obj = '{1}',weight_obj = {2}, action = 'E' " +
                                "WHERE id_obj = '{3}'", txtProName.Text, txtCompany.Text,
                                Convert.ToDouble(txtWeight.Text), lstObjects.Text);
            if (manage.tranData(sql))
            {
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อยเเล้ว", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnDel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องการจะลบรายการนี้ใช่ไหม ?", "Asterisk", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                sql = string.Format("UPDATE tblObjects SET action = '{0}' WHERE id_obj = '{1}'",
                                'D', lstObjects.Text);
                if (manage.tranData(sql))
                {
                    lblWarning.Text = "";
                    lstObjects.Items.Remove(lstObjects.Text);
                    txtProName.Text = "";
                    txtCompany.Text = "";
                    txtWeight.Text = "";
                }
                this.runNumber();
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.runNumber();
            txtBarCode.ReadOnly = true;
            btnAdd.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void picBarcode_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                picBarcode.Image.Save(folderBrowserDialog1.SelectedPath +
                                      "\\" + lstObjects.Text + ".jpeg", ImageFormat.Jpeg);
                MessageBox.Show("Save.");
            }
        }

        private void picQR_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                picQR.Image.Save(folderBrowserDialog1.SelectedPath +
                                      "\\" + lstObjects.Text + "QR.jpeg", ImageFormat.Jpeg);
                MessageBox.Show("Save.");
            }
        }

        private void btnView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmImg();
            if (lstObjects.Text.Trim() == "") return;
            frm.barCode = lstObjects.Text.Trim();
            frm.Show();
        }

        private void clearText()
        {
            txtBarCode.Text = "";
            txtProName.Text = "";
            txtCompany.Text = "";
            txtWeight.Text = "";
            lblWarning.Text = "";
            lblBarCodeImg.Text = "";
            picBarcode.Image = null;
            picQR.Image = null;
        }

        private void runNumber()
        {
            clearText();
            sql = string.Format("SELECT id_obj FROM tblObjects WHERE id_Area = '{0}'", area);
            barCode = area + (manage.lastObj(sql) + 1).ToString("00000");
            txtBarCode.Text = barCode;
            txtBarCode.ReadOnly = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = true;
            txtProName.Enabled = true;
            txtCompany.Enabled = true;
            txtWeight.Enabled = true;
        }

        private bool chkData()
        {
            if ((txtProName.Text == "") || (txtCompany.Text == "") || (txtWeight.Text == ""))
            {
                lblWarning.Text = "กรุณาใส่ข้อมูลให้ครบ";
                return false;
            }

            int weight;
            if (!int.TryParse(txtWeight.Text, out weight))
            {
                lblWarning.Text = "Weight ใส่ได้แต่ตัวเลข";
                return false;
            }

            return true;
        }

        private void genBarCode()
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            picBarcode.Image = barcode.Draw(txtBarCode.Text, 60);

            string qr = "http://www.ppakorn.info/siam_summaryDoc/page/coding2/coding2-index.html?qrCode=" +
                        txtBarCode.Text.Trim();
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            picQR.Image = qrcode.Draw(qr, 50);
            lblBarCodeImg.Text = txtBarCode.Text;
        }
    }
}
