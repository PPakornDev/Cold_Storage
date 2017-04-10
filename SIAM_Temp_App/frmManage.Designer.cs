namespace SIAM_Temp_App
{
    partial class frmManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManage));
            this.lblBack = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.LinkLabel();
            this.btnEdit = new System.Windows.Forms.LinkLabel();
            this.btnDel = new System.Windows.Forms.LinkLabel();
            this.lstObjects = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnNewData = new System.Windows.Forms.Button();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.lblBarCodeImg = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBack.Location = new System.Drawing.Point(0, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(629, 53);
            this.lblBack.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnAdd.LinkColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(16, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = true;
            this.btnAdd.Text = "ADD";
            this.btnAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAdd_LinkClicked);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnEdit.LinkColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(97, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 24);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.TabStop = true;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnEdit_LinkClicked);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnDel.LinkColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(185, 13);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(84, 24);
            this.btnDel.TabIndex = 4;
            this.btnDel.TabStop = true;
            this.btnDel.Text = "DELETE";
            this.btnDel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDel_LinkClicked);
            // 
            // lstObjects
            // 
            this.lstObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstObjects.FormattingEnabled = true;
            this.lstObjects.ItemHeight = 25;
            this.lstObjects.Location = new System.Drawing.Point(23, 86);
            this.lstObjects.Name = "lstObjects";
            this.lstObjects.Size = new System.Drawing.Size(233, 379);
            this.lstObjects.TabIndex = 5;
            this.lstObjects.SelectedIndexChanged += new System.EventHandler(this.lstObjects_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bar Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Name";
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.Location = new System.Drawing.Point(427, 140);
            this.txtProName.Multiline = true;
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(146, 25);
            this.txtProName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(427, 199);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(146, 25);
            this.txtCompany.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(427, 260);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(80, 25);
            this.txtWeight.TabIndex = 13;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPlan.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlan.Location = new System.Drawing.Point(543, 13);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(74, 24);
            this.lblPlan.TabIndex = 14;
            this.lblPlan.Text = "Plan A";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(350, 321);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(192, 23);
            this.lblWarning.TabIndex = 15;
            this.lblWarning.Text = "กรุณาใส่ข้อมูลให้ครบ";
            // 
            // btnNewData
            // 
            this.btnNewData.Location = new System.Drawing.Point(532, 84);
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(42, 26);
            this.btnNewData.TabIndex = 16;
            this.btnNewData.Text = "Run";
            this.btnNewData.UseVisualStyleBackColor = true;
            this.btnNewData.Click += new System.EventHandler(this.btnNewData_Click);
            // 
            // picBarcode
            // 
            this.picBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBarcode.Location = new System.Drawing.Point(321, 387);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(123, 62);
            this.picBarcode.TabIndex = 18;
            this.picBarcode.TabStop = false;
            this.picBarcode.Click += new System.EventHandler(this.picBarcode_Click);
            // 
            // picQR
            // 
            this.picQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picQR.Location = new System.Drawing.Point(479, 387);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(94, 78);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQR.TabIndex = 19;
            this.picQR.TabStop = false;
            this.picQR.Click += new System.EventHandler(this.picQR_Click);
            // 
            // lblBarCodeImg
            // 
            this.lblBarCodeImg.AutoSize = true;
            this.lblBarCodeImg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarCodeImg.Location = new System.Drawing.Point(351, 452);
            this.lblBarCodeImg.Name = "lblBarCodeImg";
            this.lblBarCodeImg.Size = new System.Drawing.Size(64, 16);
            this.lblBarCodeImg.TabIndex = 20;
            this.lblBarCodeImg.Text = "XXXXXXX";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBarCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Location = new System.Drawing.Point(427, 84);
            this.txtBarCode.Multiline = true;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(100, 25);
            this.txtBarCode.TabIndex = 21;
            this.txtBarCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyUp);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.DisabledLinkColor = System.Drawing.Color.Silver;
            this.btnView.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.btnView.Location = new System.Drawing.Point(528, 263);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(39, 19);
            this.btnView.TabIndex = 22;
            this.btnView.TabStop = true;
            this.btnView.Text = "ดูรูป";
            this.btnView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnView_LinkClicked);
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 497);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.lblBarCodeImg);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.btnNewData);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstObjects);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManage";
            this.Load += new System.EventHandler(this.frmManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.LinkLabel btnAdd;
        private System.Windows.Forms.LinkLabel btnEdit;
        private System.Windows.Forms.LinkLabel btnDel;
        private System.Windows.Forms.ListBox lstObjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnNewData;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Label lblBarCodeImg;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.LinkLabel btnView;
    }
}