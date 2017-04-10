namespace SIAM_Temp_App
{
    partial class frmSiamTemp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiamTemp));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblDamp = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Consolas", 60F, System.Drawing.FontStyle.Bold);
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(63, 170);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(260, 94);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "00.00";
            // 
            // lblDamp
            // 
            this.lblDamp.AutoSize = true;
            this.lblDamp.Font = new System.Drawing.Font("Consolas", 60F, System.Drawing.FontStyle.Bold);
            this.lblDamp.ForeColor = System.Drawing.Color.White;
            this.lblDamp.Location = new System.Drawing.Point(359, 170);
            this.lblDamp.Name = "lblDamp";
            this.lblDamp.Size = new System.Drawing.Size(260, 94);
            this.lblDamp.TabIndex = 3;
            this.lblDamp.Text = "00.00";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(135, 339);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(379, 43);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "NOT CONNECTED COM1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(66, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(390, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 47);
            this.label5.TabIndex = 6;
            this.label5.Text = "Humidity";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(9, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 28);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Checking...";
            // 
            // frmSiamTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 435);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDamp);
            this.Controls.Add(this.lblTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSiamTemp";
            this.Text = "Siam_Temp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSiamTemp_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTemp;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblDamp;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblStatus;
    }
}

