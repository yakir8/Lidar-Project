namespace LidarApplication
{
    partial class Boot
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.comComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inputIpAddress = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lidarIp = new System.Windows.Forms.MaskedTextBox();
            this.checkLidar = new System.Windows.Forms.Button();
            this.interntAdapterComboBox = new System.Windows.Forms.ComboBox();
            this.lidarAdapterComboBox = new System.Windows.Forms.ComboBox();
            this.checkNetwork = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.highAlert = new System.Windows.Forms.NumericUpDown();
            this.lowAlert = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.serverIpAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowAlert)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 613);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.startButton);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "מצב מפעיל";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ParityComboBox);
            this.groupBox4.Controls.Add(this.BaudRateComboBox);
            this.groupBox4.Controls.Add(this.comComboBox);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Location = new System.Drawing.Point(165, 450);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 129);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "הגדרות תקשורת טורית";
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(73, 92);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ParityComboBox.Size = new System.Drawing.Size(151, 21);
            this.ParityComboBox.TabIndex = 10;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Location = new System.Drawing.Point(73, 58);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BaudRateComboBox.Size = new System.Drawing.Size(151, 21);
            this.BaudRateComboBox.TabIndex = 9;
            // 
            // comComboBox
            // 
            this.comComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comComboBox.FormattingEnabled = true;
            this.comComboBox.Location = new System.Drawing.Point(73, 23);
            this.comComboBox.Name = "comComboBox";
            this.comComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comComboBox.Size = new System.Drawing.Size(151, 21);
            this.comComboBox.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(265, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "יציאה טורית";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(263, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "סיבית זוגיות";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(265, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "קצב תקשורת";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(22, 194);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "ביטול שינויים";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(22, 250);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(22, 375);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "הפעל";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inputIpAddress);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lidarIp);
            this.groupBox3.Controls.Add(this.checkLidar);
            this.groupBox3.Controls.Add(this.interntAdapterComboBox);
            this.groupBox3.Controls.Add(this.lidarAdapterComboBox);
            this.groupBox3.Controls.Add(this.checkNetwork);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(165, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 204);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "הגדרות רשת";
            // 
            // inputIpAddress
            // 
            this.inputIpAddress.Location = new System.Drawing.Point(73, 122);
            this.inputIpAddress.Name = "inputIpAddress";
            this.inputIpAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputIpAddress.Size = new System.Drawing.Size(151, 20);
            this.inputIpAddress.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "כתובת IP שרת";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(250, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "כתובת IP חיישן";
            // 
            // lidarIp
            // 
            this.lidarIp.Location = new System.Drawing.Point(73, 53);
            this.lidarIp.Name = "lidarIp";
            this.lidarIp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lidarIp.Size = new System.Drawing.Size(148, 20);
            this.lidarIp.TabIndex = 13;
            // 
            // checkLidar
            // 
            this.checkLidar.Location = new System.Drawing.Point(201, 167);
            this.checkLidar.Name = "checkLidar";
            this.checkLidar.Size = new System.Drawing.Size(125, 23);
            this.checkLidar.TabIndex = 12;
            this.checkLidar.Text = "בדיקת חיבור לחיישן";
            this.checkLidar.UseVisualStyleBackColor = true;
            this.checkLidar.Click += new System.EventHandler(this.checkLidar_Click);
            // 
            // interntAdapterComboBox
            // 
            this.interntAdapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interntAdapterComboBox.FormattingEnabled = true;
            this.interntAdapterComboBox.Location = new System.Drawing.Point(73, 89);
            this.interntAdapterComboBox.Name = "interntAdapterComboBox";
            this.interntAdapterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.interntAdapterComboBox.Size = new System.Drawing.Size(151, 21);
            this.interntAdapterComboBox.TabIndex = 10;
            this.interntAdapterComboBox.SelectedIndexChanged += new System.EventHandler(this.interntAdapterComboBox_SelectedIndexChanged);
            // 
            // lidarAdapterComboBox
            // 
            this.lidarAdapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lidarAdapterComboBox.FormattingEnabled = true;
            this.lidarAdapterComboBox.Location = new System.Drawing.Point(73, 22);
            this.lidarAdapterComboBox.Name = "lidarAdapterComboBox";
            this.lidarAdapterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lidarAdapterComboBox.Size = new System.Drawing.Size(151, 21);
            this.lidarAdapterComboBox.TabIndex = 9;
            this.lidarAdapterComboBox.SelectedIndexChanged += new System.EventHandler(this.lidarAdapterComboBox_SelectedIndexChanged);
            // 
            // checkNetwork
            // 
            this.checkNetwork.Location = new System.Drawing.Point(25, 167);
            this.checkNetwork.Name = "checkNetwork";
            this.checkNetwork.Size = new System.Drawing.Size(125, 23);
            this.checkNetwork.TabIndex = 8;
            this.checkNetwork.Text = "בדיקת חיבור לשרת";
            this.checkNetwork.UseVisualStyleBackColor = true;
            this.checkNetwork.Click += new System.EventHandler(this.checkNetwork_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "מתאם רשת למחשב";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "מתאם רשת לחיישן";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resolutionComboBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.highAlert);
            this.groupBox2.Controls.Add(this.lowAlert);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(165, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "הגדרות חלון";
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Location = new System.Drawing.Point(161, 26);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resolutionComboBox.Size = new System.Drawing.Size(63, 21);
            this.resolutionComboBox.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "סנטימטרים";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "סנטימטרים";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "מעלות";
            // 
            // highAlert
            // 
            this.highAlert.Location = new System.Drawing.Point(161, 74);
            this.highAlert.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.highAlert.Name = "highAlert";
            this.highAlert.Size = new System.Drawing.Size(63, 20);
            this.highAlert.TabIndex = 17;
            this.highAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.highAlert.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lowAlert
            // 
            this.lowAlert.Location = new System.Drawing.Point(161, 50);
            this.lowAlert.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.lowAlert.Name = "lowAlert";
            this.lowAlert.Size = new System.Drawing.Size(63, 20);
            this.lowAlert.TabIndex = 16;
            this.lowAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lowAlert.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "התראה קריטית";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "התראה נמוכה";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "רזולוצית סריקה";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.angle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(165, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "נתוני חיישן";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "מעלות";
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(231, 67);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(63, 20);
            this.angle.TabIndex = 5;
            this.angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.angle.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "סנטימטרים";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(231, 39);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(63, 20);
            this.height.TabIndex = 3;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "זווית";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "גובה";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.serverIpAddress);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "מצב בקרה";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // serverIpAddress
            // 
            this.serverIpAddress.Location = new System.Drawing.Point(193, 199);
            this.serverIpAddress.Name = "serverIpAddress";
            this.serverIpAddress.ReadOnly = true;
            this.serverIpAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverIpAddress.Size = new System.Drawing.Size(110, 20);
            this.serverIpAddress.TabIndex = 13;
            this.serverIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "כתובת IP שרת";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(41, 267);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 20);
            this.button7.TabIndex = 3;
            this.button7.Text = "הפעל שרת";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(294, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 20);
            this.button6.TabIndex = 2;
            this.button6.Text = "בדוק חיבור לרשת";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.checkNetwork_Click);
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 613);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Boot";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowAlert)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.ComboBox interntAdapterComboBox;
        private System.Windows.Forms.ComboBox lidarAdapterComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown highAlert;
        private System.Windows.Forms.NumericUpDown lowAlert;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox lidarIp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.ComboBox comComboBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button checkLidar;
        private System.Windows.Forms.Button checkNetwork;
        private System.Windows.Forms.TextBox serverIpAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox inputIpAddress;
        private System.Windows.Forms.Label label15;
    }
}

