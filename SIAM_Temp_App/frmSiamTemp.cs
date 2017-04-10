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
    public partial class frmSiamTemp : Form
    {
        double temp, damp;
        string[] data;
        bool chkInsert = true;
        delegate void SetTextCallback(string text);

        public frmSiamTemp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialOpen();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SetText(serialPort1.ReadLine());     
        }

        private void SetText(string text)
        {
            if ((this.lblTemp.InvokeRequired) && (this.lblDamp.InvokeRequired))
            {
                try
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                catch
                {
                    Application.Exit();
                }
            }
            else
            {
                data = text.Split(',');
                if (data.Length != 2)
                {
                    this.lblTemp.Text = "";
                    this.lblDamp.Text = "";
                }
                else
                {
                    try
                    {
                        temp = Convert.ToDouble(data[0]);
                        damp = Convert.ToDouble(data[1]);
                    }
                    catch
                    {
                        return;
                    }
                    

                    if (temp >= 30)
                        lblTemp.BackColor = Color.Red;
                    else
                        lblTemp.BackColor = Color.Green;

                    if (damp >= 60)
                        lblDamp.BackColor = Color.Red;
                    else if ((damp >= 50) && (damp <= 59))
                        lblDamp.BackColor = Color.Orange;
                    else
                        lblDamp.BackColor = Color.Green;

                    this.lblTemp.Text = data[0];
                    this.lblDamp.Text = data[1];

                    if (chkInsert)
                    {
                        insertOfDay();
                        chkInsert = false;
                    }
                }
            }
        }

        private void serialOpen()
        {
            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                    lblError.Text = "";
                else
                    lblError.Text = "NOT CONNECTED " + serialPort1.PortName;
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show(ex.Message, "Error",
                                             MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                    serialOpen();
                else
                    this.Close();
            }
        }

        private void frmSiamTemp_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private async void insertOfDay()
        {
            lblStatus.Text = "Checking...";
            var manage = new db_manage();

            List<DataTable> dts;
            dts = manage.getLastData();

            for (int i = 0; i < dts.Count; i++)
            {
                if (dts[i].Rows.Count > 0)
                {
                    //ถ้าความชื้นยังไม่ได้บันทึก
                    if ((dts[i].TableName == "tblTemp") && (dts.Count == 1))
                    {
                        lblStatus.Text = "Saving...";
                        await Task.Delay(2000);
                        manage.insertDamp(damp);
                    }

                    //ถ้าอุณหภูมิยังไม่ได้บันทึก
                    else if ((dts[i].TableName == "tblDamp") && (dts.Count == 1))
                    {
                        lblStatus.Text = "Saving...";
                        await Task.Delay(2000);
                        manage.insertTemp(temp);
                    }

                    DateTime date = Convert.ToDateTime(dts[i].Rows[0][0].ToString());

                    //ถ้ายังไม่ได้บันทึกข้อมูลในวันนี้
                    if (date.Date != DateTime.Now.Date)
                    {
                        if (dts[i].TableName == "tblTemp")
                        {
                            lblStatus.Text = "Saving...";
                            await Task.Delay(2000);
                            manage.insertTemp(temp);
                        }
                        else if (dts[i].TableName == "tblDamp")
                        {
                            lblStatus.Text = "Saving...";
                            await Task.Delay(2000);
                            manage.insertDamp(damp);
                        }
                    }
                }
            }

            if (dts.Count == 1)
            {
                //ถ้าไม่ได้เชื่อมต่ออินเทอร์เน็ต
                if (dts[0].TableName == "No table")
                {
                    lblStatus.Text = "Connect to Internet for save today.";
                }
                else
                {
                    lblStatus.Text = "";
                    lblStatus.Hide();
                }
            }

            //ยังไม่มีข้อมูลอะไรเลย
            else if (dts.Count == 0)
            {
                lblStatus.Text = "Saving...";
                await Task.Delay(2000);
                manage.insertDamp(damp);
                manage.insertTemp(temp);
                lblStatus.Text = "";
                lblStatus.Hide();
            }
            else
            {
                lblStatus.Text = "";
                lblStatus.Hide();
            }
        }
    }
}
