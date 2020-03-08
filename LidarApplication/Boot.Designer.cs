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
            this.lidarPort = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epLidar = new IPAddressControlLib.IPAddressControl();
            this.epServer = new IPAddressControlLib.IPAddressControl();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkLidar = new System.Windows.Forms.Button();
            this.interntAdapterComboBox = new System.Windows.Forms.ComboBox();
            this.lidarAdapterComboBox = new System.Windows.Forms.ComboBox();
            this.checkNetwork = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.vehicleWidth = new System.Windows.Forms.NumericUpDown();
            this.stopAngle = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startAngle = new System.Windows.Forms.NumericUpDown();
            this.angle = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.highAlert = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.lowAlert = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.serverIpAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.startServer = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowAlert)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1384, 691);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(1376, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "מצב נהג";
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
            this.groupBox4.Location = new System.Drawing.Point(12, 319);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox4.Size = new System.Drawing.Size(650, 222);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "הגדרות תקשורת טורית";
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(359, 169);
            this.ParityComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ParityComboBox.Size = new System.Drawing.Size(131, 30);
            this.ParityComboBox.TabIndex = 10;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Location = new System.Drawing.Point(359, 110);
            this.BaudRateComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BaudRateComboBox.Size = new System.Drawing.Size(131, 30);
            this.BaudRateComboBox.TabIndex = 9;
            // 
            // comComboBox
            // 
            this.comComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comComboBox.FormattingEnabled = true;
            this.comComboBox.Location = new System.Drawing.Point(359, 52);
            this.comComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comComboBox.Name = "comComboBox";
            this.comComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comComboBox.Size = new System.Drawing.Size(131, 30);
            this.comComboBox.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(517, 50);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 22);
            this.label19.TabIndex = 2;
            this.label19.Text = "יציאה טורית";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(517, 172);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 22);
            this.label20.TabIndex = 1;
            this.label20.Text = "סיבית זוגיות";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(507, 113);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 22);
            this.label21.TabIndex = 0;
            this.label21.Text = "קצב תקשורת";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1193, 582);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(171, 39);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "ביטול שינויים";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(615, 582);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(171, 39);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(21, 582);
            this.startButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(171, 39);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "הפעל";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lidarPort);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.epLidar);
            this.groupBox3.Controls.Add(this.epServer);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.checkLidar);
            this.groupBox3.Controls.Add(this.interntAdapterComboBox);
            this.groupBox3.Controls.Add(this.lidarAdapterComboBox);
            this.groupBox3.Controls.Add(this.checkNetwork);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(714, 167);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Size = new System.Drawing.Size(650, 374);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "הגדרות רשת";
            // 
            // lidarPort
            // 
            this.lidarPort.Location = new System.Drawing.Point(388, 99);
            this.lidarPort.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lidarPort.Name = "lidarPort";
            this.lidarPort.Size = new System.Drawing.Size(55, 29);
            this.lidarPort.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = ":";
            // 
            // epLidar
            // 
            this.epLidar.AllowInternalTab = false;
            this.epLidar.AutoHeight = true;
            this.epLidar.BackColor = System.Drawing.SystemColors.Window;
            this.epLidar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epLidar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epLidar.Location = new System.Drawing.Point(170, 99);
            this.epLidar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.epLidar.MinimumSize = new System.Drawing.Size(153, 29);
            this.epLidar.Name = "epLidar";
            this.epLidar.ReadOnly = false;
            this.epLidar.Size = new System.Drawing.Size(194, 29);
            this.epLidar.TabIndex = 17;
            this.epLidar.Text = "...";
            // 
            // epServer
            // 
            this.epServer.AllowInternalTab = false;
            this.epServer.AutoHeight = true;
            this.epServer.BackColor = System.Drawing.SystemColors.Window;
            this.epServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epServer.Location = new System.Drawing.Point(170, 215);
            this.epServer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.epServer.MinimumSize = new System.Drawing.Size(153, 29);
            this.epServer.Name = "epServer";
            this.epServer.ReadOnly = false;
            this.epServer.Size = new System.Drawing.Size(273, 29);
            this.epServer.TabIndex = 16;
            this.epServer.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(491, 226);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 22);
            this.label15.TabIndex = 15;
            this.label15.Text = "כתובת IP שרת";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(490, 103);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 22);
            this.label16.TabIndex = 14;
            this.label16.Text = "כתובת IP חיישן";
            // 
            // checkLidar
            // 
            this.checkLidar.Location = new System.Drawing.Point(383, 304);
            this.checkLidar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkLidar.Name = "checkLidar";
            this.checkLidar.Size = new System.Drawing.Size(229, 39);
            this.checkLidar.TabIndex = 12;
            this.checkLidar.Text = "בדיקת חיבור לחיישן";
            this.checkLidar.UseVisualStyleBackColor = true;
            this.checkLidar.Click += new System.EventHandler(this.checkLidar_Click);
            // 
            // interntAdapterComboBox
            // 
            this.interntAdapterComboBox.DropDownHeight = 200;
            this.interntAdapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interntAdapterComboBox.DropDownWidth = 300;
            this.interntAdapterComboBox.FormattingEnabled = true;
            this.interntAdapterComboBox.IntegralHeight = false;
            this.interntAdapterComboBox.Location = new System.Drawing.Point(170, 160);
            this.interntAdapterComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.interntAdapterComboBox.Name = "interntAdapterComboBox";
            this.interntAdapterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.interntAdapterComboBox.Size = new System.Drawing.Size(274, 30);
            this.interntAdapterComboBox.TabIndex = 10;
            this.interntAdapterComboBox.SelectedIndexChanged += new System.EventHandler(this.interntAdapterComboBox_SelectedIndexChanged);
            // 
            // lidarAdapterComboBox
            // 
            this.lidarAdapterComboBox.DropDownHeight = 200;
            this.lidarAdapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lidarAdapterComboBox.DropDownWidth = 300;
            this.lidarAdapterComboBox.FormattingEnabled = true;
            this.lidarAdapterComboBox.IntegralHeight = false;
            this.lidarAdapterComboBox.Location = new System.Drawing.Point(170, 47);
            this.lidarAdapterComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lidarAdapterComboBox.Name = "lidarAdapterComboBox";
            this.lidarAdapterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lidarAdapterComboBox.Size = new System.Drawing.Size(274, 30);
            this.lidarAdapterComboBox.TabIndex = 9;
            this.lidarAdapterComboBox.SelectedIndexChanged += new System.EventHandler(this.lidarAdapterComboBox_SelectedIndexChanged);
            // 
            // checkNetwork
            // 
            this.checkNetwork.Location = new System.Drawing.Point(40, 304);
            this.checkNetwork.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkNetwork.Name = "checkNetwork";
            this.checkNetwork.Size = new System.Drawing.Size(229, 39);
            this.checkNetwork.TabIndex = 8;
            this.checkNetwork.Text = "בדיקת חיבור לרשת";
            this.checkNetwork.UseVisualStyleBackColor = true;
            this.checkNetwork.Click += new System.EventHandler(this.checkNetwork_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "מתאם רשת למחשב";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "מתאם רשת לחיישן";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.vehicleWidth);
            this.groupBox2.Controls.Add(this.stopAngle);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.startAngle);
            this.groupBox2.Controls.Add(this.angle);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.height);
            this.groupBox2.Controls.Add(this.resolutionComboBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(650, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "הגדרות חיישן";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(281, 132);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 22);
            this.label25.TabIndex = 9;
            this.label25.Text = "סנטימטרים";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(315, 212);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 22);
            this.label23.TabIndex = 26;
            this.label23.Text = "מעלות";
            // 
            // vehicleWidth
            // 
            this.vehicleWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleWidth.Location = new System.Drawing.Point(384, 130);
            this.vehicleWidth.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.vehicleWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vehicleWidth.Name = "vehicleWidth";
            this.vehicleWidth.Size = new System.Drawing.Size(93, 29);
            this.vehicleWidth.TabIndex = 8;
            this.vehicleWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vehicleWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // stopAngle
            // 
            this.stopAngle.Location = new System.Drawing.Point(384, 210);
            this.stopAngle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.stopAngle.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.stopAngle.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            -2147483648});
            this.stopAngle.Name = "stopAngle";
            this.stopAngle.Size = new System.Drawing.Size(93, 29);
            this.stopAngle.TabIndex = 25;
            this.stopAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopAngle.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(527, 132);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 22);
            this.label24.TabIndex = 7;
            this.label24.Text = "רוחב הרכב";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(315, 174);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 22);
            this.label22.TabIndex = 24;
            this.label22.Text = "מעלות";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "מעלות";
            // 
            // startAngle
            // 
            this.startAngle.Location = new System.Drawing.Point(384, 172);
            this.startAngle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.startAngle.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.startAngle.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            -2147483648});
            this.startAngle.Name = "startAngle";
            this.startAngle.Size = new System.Drawing.Size(93, 29);
            this.startAngle.TabIndex = 23;
            this.startAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // angle
            // 
            this.angle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.angle.Location = new System.Drawing.Point(384, 88);
            this.angle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(93, 29);
            this.angle.TabIndex = 5;
            this.angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.angle.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(536, 212);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 22);
            this.label18.TabIndex = 22;
            this.label18.Text = "זווית סיום";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "סנטימטרים";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(512, 174);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 22);
            this.label17.TabIndex = 21;
            this.label17.Text = "זווית התחלה";
            // 
            // height
            // 
            this.height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.height.Location = new System.Drawing.Point(384, 42);
            this.height.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.height.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(93, 29);
            this.height.TabIndex = 3;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Location = new System.Drawing.Point(384, 253);
            this.resolutionComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resolutionComboBox.Size = new System.Drawing.Size(93, 30);
            this.resolutionComboBox.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(315, 258);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "מעלות";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "זווית החיישן";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "רזולוצית סריקה";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "גובה החיישן";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.highAlert);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lowAlert);
            this.groupBox1.Location = new System.Drawing.Point(714, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(650, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "הגדרות חלון";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 22);
            this.label14.TabIndex = 20;
            this.label14.Text = "סנטימטרים";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 45);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 22);
            this.label13.TabIndex = 19;
            this.label13.Text = "סנטימטרים";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "התראה נמוכה";
            // 
            // highAlert
            // 
            this.highAlert.Location = new System.Drawing.Point(361, 86);
            this.highAlert.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.highAlert.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.highAlert.Name = "highAlert";
            this.highAlert.Size = new System.Drawing.Size(116, 29);
            this.highAlert.TabIndex = 17;
            this.highAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.highAlert.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 22);
            this.label11.TabIndex = 14;
            this.label11.Text = "התראה קריטית";
            // 
            // lowAlert
            // 
            this.lowAlert.Location = new System.Drawing.Point(361, 45);
            this.lowAlert.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lowAlert.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.lowAlert.Name = "lowAlert";
            this.lowAlert.Size = new System.Drawing.Size(116, 29);
            this.lowAlert.TabIndex = 16;
            this.lowAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lowAlert.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.serverIpAddress);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.startServer);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Size = new System.Drawing.Size(1376, 656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "מצב שרת";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // serverIpAddress
            // 
            this.serverIpAddress.Location = new System.Drawing.Point(496, 239);
            this.serverIpAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.serverIpAddress.Name = "serverIpAddress";
            this.serverIpAddress.ReadOnly = true;
            this.serverIpAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverIpAddress.Size = new System.Drawing.Size(198, 29);
            this.serverIpAddress.TabIndex = 13;
            this.serverIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(716, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "כתובת IP שרת";
            // 
            // startServer
            // 
            this.startServer.Location = new System.Drawing.Point(75, 453);
            this.startServer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(277, 35);
            this.startServer.TabIndex = 3;
            this.startServer.Text = "הפעל שרת";
            this.startServer.UseVisualStyleBackColor = true;
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(930, 453);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(277, 35);
            this.button6.TabIndex = 2;
            this.button6.Text = "בדוק חיבור לרשת";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.checkNetwork_Click);
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1384, 691);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 730);
            this.MinimumSize = new System.Drawing.Size(1400, 730);
            this.Name = "Boot";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "איתחול המערכת";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowAlert)).EndInit();
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
        private System.Windows.Forms.Button startServer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.Label label15;
        private IPAddressControlLib.IPAddressControl epServer;
        private IPAddressControlLib.IPAddressControl epLidar;
        private System.Windows.Forms.MaskedTextBox lidarPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown stopAngle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown startAngle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown vehicleWidth;
        private System.Windows.Forms.Label label24;
    }
}

