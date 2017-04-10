namespace SIAM_Temp_App
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPlanA = new System.Windows.Forms.Button();
            this.btnPlanB = new System.Windows.Forms.Button();
            this.btnPlanC = new System.Windows.Forms.Button();
            this.btnPlanD = new System.Windows.Forms.Button();
            this.btnLogA = new System.Windows.Forms.Button();
            this.btnLogB = new System.Windows.Forms.Button();
            this.btnLogC = new System.Windows.Forms.Button();
            this.btnLogD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.picEmp = new System.Windows.Forms.PictureBox();
            this.lblNmeEmp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDBName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDataSrc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblServThread = new System.Windows.Forms.Label();
            this.lblServVersion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblServState = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHosting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTemp
            // 
            this.chartTemp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartTemp.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.SmallGrid;
            this.chartTemp.BorderlineColor = System.Drawing.Color.Black;
            this.chartTemp.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemp.Legends.Add(legend1);
            this.chartTemp.Location = new System.Drawing.Point(401, 48);
            this.chartTemp.Name = "chartTemp";
            this.chartTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Orange;
            series1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Humidity";
            this.chartTemp.Series.Add(series1);
            this.chartTemp.Series.Add(series2);
            this.chartTemp.Size = new System.Drawing.Size(419, 361);
            this.chartTemp.TabIndex = 1;
            this.chartTemp.Text = "chart1";
            // 
            // btnPlanA
            // 
            this.btnPlanA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPlanA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanA.FlatAppearance.BorderSize = 0;
            this.btnPlanA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanA.Location = new System.Drawing.Point(11, 13);
            this.btnPlanA.Name = "btnPlanA";
            this.btnPlanA.Size = new System.Drawing.Size(167, 51);
            this.btnPlanA.TabIndex = 0;
            this.btnPlanA.Text = "Plan A";
            this.btnPlanA.UseVisualStyleBackColor = false;
            this.btnPlanA.Click += new System.EventHandler(this.btnPlanA_Click);
            // 
            // btnPlanB
            // 
            this.btnPlanB.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlanB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanB.FlatAppearance.BorderSize = 0;
            this.btnPlanB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanB.Location = new System.Drawing.Point(184, 13);
            this.btnPlanB.Name = "btnPlanB";
            this.btnPlanB.Size = new System.Drawing.Size(163, 51);
            this.btnPlanB.TabIndex = 1;
            this.btnPlanB.Text = "Plan B";
            this.btnPlanB.UseVisualStyleBackColor = false;
            this.btnPlanB.Click += new System.EventHandler(this.btnPlanB_Click);
            // 
            // btnPlanC
            // 
            this.btnPlanC.BackColor = System.Drawing.Color.Coral;
            this.btnPlanC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanC.FlatAppearance.BorderSize = 0;
            this.btnPlanC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanC.Location = new System.Drawing.Point(11, 91);
            this.btnPlanC.Name = "btnPlanC";
            this.btnPlanC.Size = new System.Drawing.Size(70, 257);
            this.btnPlanC.TabIndex = 2;
            this.btnPlanC.Text = "Plan C";
            this.btnPlanC.UseVisualStyleBackColor = false;
            this.btnPlanC.Click += new System.EventHandler(this.btnPlanC_Click);
            // 
            // btnPlanD
            // 
            this.btnPlanD.BackColor = System.Drawing.Color.Plum;
            this.btnPlanD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanD.FlatAppearance.BorderSize = 0;
            this.btnPlanD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanD.Location = new System.Drawing.Point(110, 281);
            this.btnPlanD.Name = "btnPlanD";
            this.btnPlanD.Size = new System.Drawing.Size(204, 67);
            this.btnPlanD.TabIndex = 3;
            this.btnPlanD.Text = "Plan D";
            this.btnPlanD.UseVisualStyleBackColor = false;
            this.btnPlanD.Click += new System.EventHandler(this.btnPlanD_Click);
            // 
            // btnLogA
            // 
            this.btnLogA.BackColor = System.Drawing.Color.Khaki;
            this.btnLogA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogA.FlatAppearance.BorderSize = 0;
            this.btnLogA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogA.Location = new System.Drawing.Point(110, 91);
            this.btnLogA.Name = "btnLogA";
            this.btnLogA.Size = new System.Drawing.Size(99, 68);
            this.btnLogA.TabIndex = 4;
            this.btnLogA.Text = "Log A";
            this.btnLogA.UseVisualStyleBackColor = false;
            this.btnLogA.Click += new System.EventHandler(this.btnLogA_Click);
            // 
            // btnLogB
            // 
            this.btnLogB.BackColor = System.Drawing.Color.Pink;
            this.btnLogB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogB.FlatAppearance.BorderSize = 0;
            this.btnLogB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogB.Location = new System.Drawing.Point(215, 91);
            this.btnLogB.Name = "btnLogB";
            this.btnLogB.Size = new System.Drawing.Size(99, 68);
            this.btnLogB.TabIndex = 5;
            this.btnLogB.Text = "Log B";
            this.btnLogB.UseVisualStyleBackColor = false;
            this.btnLogB.Click += new System.EventHandler(this.btnLogB_Click);
            // 
            // btnLogC
            // 
            this.btnLogC.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLogC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogC.FlatAppearance.BorderSize = 0;
            this.btnLogC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogC.Location = new System.Drawing.Point(110, 187);
            this.btnLogC.Name = "btnLogC";
            this.btnLogC.Size = new System.Drawing.Size(99, 68);
            this.btnLogC.TabIndex = 6;
            this.btnLogC.Text = "Log C";
            this.btnLogC.UseVisualStyleBackColor = false;
            this.btnLogC.Click += new System.EventHandler(this.btnLogC_Click);
            // 
            // btnLogD
            // 
            this.btnLogD.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLogD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogD.FlatAppearance.BorderSize = 0;
            this.btnLogD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogD.Location = new System.Drawing.Point(215, 187);
            this.btnLogD.Name = "btnLogD";
            this.btnLogD.Size = new System.Drawing.Size(99, 68);
            this.btnLogD.TabIndex = 7;
            this.btnLogD.Text = "Log D";
            this.btnLogD.UseVisualStyleBackColor = false;
            this.btnLogD.Click += new System.EventHandler(this.btnLogD_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogD);
            this.panel1.Controls.Add(this.btnPlanD);
            this.panel1.Controls.Add(this.btnLogC);
            this.panel1.Controls.Add(this.btnPlanA);
            this.panel1.Controls.Add(this.btnLogB);
            this.panel1.Controls.Add(this.btnPlanB);
            this.panel1.Controls.Add(this.btnLogA);
            this.panel1.Controls.Add(this.btnPlanC);
            this.panel1.Location = new System.Drawing.Point(23, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 361);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Cold Storage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(397, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "History of Temp";
            // 
            // btnMonitor
            // 
            this.btnMonitor.Font = new System.Drawing.Font("Tahoma", 11.5F);
            this.btnMonitor.Location = new System.Drawing.Point(737, 13);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(83, 29);
            this.btnMonitor.TabIndex = 5;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // picEmp
            // 
            this.picEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmp.Location = new System.Drawing.Point(871, 13);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(151, 138);
            this.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEmp.TabIndex = 6;
            this.picEmp.TabStop = false;
            // 
            // lblNmeEmp
            // 
            this.lblNmeEmp.AutoSize = true;
            this.lblNmeEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmeEmp.ForeColor = System.Drawing.Color.Blue;
            this.lblNmeEmp.Location = new System.Drawing.Point(893, 165);
            this.lblNmeEmp.Name = "lblNmeEmp";
            this.lblNmeEmp.Size = new System.Drawing.Size(59, 19);
            this.lblNmeEmp.TabIndex = 7;
            this.lblNmeEmp.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(835, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 2);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(878, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Server Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(829, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Database Name :";
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDBName.Location = new System.Drawing.Point(942, 239);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(20, 16);
            this.lblDBName.TabIndex = 11;
            this.lblDBName.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(829, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Source :";
            // 
            // lblDataSrc
            // 
            this.lblDataSrc.AutoSize = true;
            this.lblDataSrc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSrc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDataSrc.Location = new System.Drawing.Point(942, 264);
            this.lblDataSrc.Name = "lblDataSrc";
            this.lblDataSrc.Size = new System.Drawing.Size(20, 16);
            this.lblDataSrc.TabIndex = 13;
            this.lblDataSrc.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(829, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Your IP :";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIP.Location = new System.Drawing.Point(942, 288);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 16);
            this.lblIP.TabIndex = 15;
            this.lblIP.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(829, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Server Thread :";
            // 
            // lblServThread
            // 
            this.lblServThread.AutoSize = true;
            this.lblServThread.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServThread.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblServThread.Location = new System.Drawing.Point(942, 313);
            this.lblServThread.Name = "lblServThread";
            this.lblServThread.Size = new System.Drawing.Size(20, 16);
            this.lblServThread.TabIndex = 17;
            this.lblServThread.Text = "...";
            // 
            // lblServVersion
            // 
            this.lblServVersion.AutoSize = true;
            this.lblServVersion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblServVersion.Location = new System.Drawing.Point(942, 339);
            this.lblServVersion.Name = "lblServVersion";
            this.lblServVersion.Size = new System.Drawing.Size(20, 16);
            this.lblServVersion.TabIndex = 19;
            this.lblServVersion.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(829, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Server Version :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(829, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Server State :";
            // 
            // lblServState
            // 
            this.lblServState.AutoSize = true;
            this.lblServState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblServState.Location = new System.Drawing.Point(942, 366);
            this.lblServState.Name = "lblServState";
            this.lblServState.Size = new System.Drawing.Size(20, 16);
            this.lblServState.TabIndex = 21;
            this.lblServState.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(829, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Web Hosting :";
            // 
            // lblHosting
            // 
            this.lblHosting.AutoSize = true;
            this.lblHosting.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHosting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHosting.Location = new System.Drawing.Point(942, 390);
            this.lblHosting.Name = "lblHosting";
            this.lblHosting.Size = new System.Drawing.Size(20, 16);
            this.lblHosting.TabIndex = 23;
            this.lblHosting.Text = "...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 448);
            this.Controls.Add(this.lblHosting);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblServState);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblServVersion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblServThread);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDataSrc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDBName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNmeEmp);
            this.Controls.Add(this.picEmp);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.Button btnPlanA;
        private System.Windows.Forms.Button btnPlanB;
        private System.Windows.Forms.Button btnPlanC;
        private System.Windows.Forms.Button btnPlanD;
        private System.Windows.Forms.Button btnLogA;
        private System.Windows.Forms.Button btnLogB;
        private System.Windows.Forms.Button btnLogC;
        private System.Windows.Forms.Button btnLogD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.PictureBox picEmp;
        private System.Windows.Forms.Label lblNmeEmp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDataSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblServThread;
        private System.Windows.Forms.Label lblServVersion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblServState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHosting;
    }
}