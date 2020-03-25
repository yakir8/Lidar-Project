namespace LidarApplication
{
    partial class OperatorMode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.activeAlert = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frontViewBox = new System.Windows.Forms.GroupBox();
            this.topViewBox = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gpsStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverIP = new System.Windows.Forms.Label();
            this.serverIPLabel = new System.Windows.Forms.Label();
            this.serverStatus = new System.Windows.Forms.Label();
            this.lidarStatus = new System.Windows.Forms.Label();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.lidarStatusLabel = new System.Windows.Forms.Label();
            this.clearLog = new System.Windows.Forms.Button();
            this.saveLog = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReplaceIP = new System.Windows.Forms.Button();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.log);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 661);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1684, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "לוג התראות";
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader15});
            this.log.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.log.Location = new System.Drawing.Point(9, 34);
            this.log.MultiSelect = false;
            this.log.Name = "log";
            this.log.RightToLeftLayout = true;
            this.log.Size = new System.Drawing.Size(1663, 260);
            this.log.TabIndex = 1;
            this.log.UseCompatibleStateImageBehavior = false;
            this.log.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "תאריך";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "שעה";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "קורדינטות";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 250;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "זווית";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 250;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "צד";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 250;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "מרחק";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 250;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "גובה";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 250;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "רמת התראה";
            this.columnHeader15.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.activeAlert);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 361);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1684, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "התראות פעילות";
            // 
            // activeAlert
            // 
            this.activeAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeAlert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activeAlert.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader14});
            this.activeAlert.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.activeAlert.Location = new System.Drawing.Point(9, 36);
            this.activeAlert.MultiSelect = false;
            this.activeAlert.Name = "activeAlert";
            this.activeAlert.RightToLeftLayout = true;
            this.activeAlert.Size = new System.Drawing.Size(1663, 260);
            this.activeAlert.TabIndex = 0;
            this.activeAlert.UseCompatibleStateImageBehavior = false;
            this.activeAlert.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "מס\"ד";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "קורדינטות";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "זווית";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "צד";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "מרחק";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "גובה";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 250;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "רמת התראה";
            this.columnHeader14.Width = 150;
            // 
            // frontViewBox
            // 
            this.frontViewBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.frontViewBox.Location = new System.Drawing.Point(1054, 0);
            this.frontViewBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.frontViewBox.Name = "frontViewBox";
            this.frontViewBox.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.frontViewBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.frontViewBox.Size = new System.Drawing.Size(630, 361);
            this.frontViewBox.TabIndex = 2;
            this.frontViewBox.TabStop = false;
            this.frontViewBox.Text = "מבט חזיתי";
            this.frontViewBox.Paint += new System.Windows.Forms.PaintEventHandler(this.FrontViewBox_Paint);
            // 
            // topViewBox
            // 
            this.topViewBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.topViewBox.Location = new System.Drawing.Point(0, 0);
            this.topViewBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.topViewBox.Name = "topViewBox";
            this.topViewBox.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.topViewBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.topViewBox.Size = new System.Drawing.Size(630, 361);
            this.topViewBox.TabIndex = 3;
            this.topViewBox.TabStop = false;
            this.topViewBox.Text = "מבט עילי";
            this.topViewBox.Paint += new System.Windows.Forms.PaintEventHandler(this.TopViewBox_Paint);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.gpsStatus);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.serverIP);
            this.groupBox5.Controls.Add(this.serverIPLabel);
            this.groupBox5.Controls.Add(this.serverStatus);
            this.groupBox5.Controls.Add(this.lidarStatus);
            this.groupBox5.Controls.Add(this.serverStatusLabel);
            this.groupBox5.Controls.Add(this.lidarStatusLabel);
            this.groupBox5.Location = new System.Drawing.Point(642, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox5.MaximumSize = new System.Drawing.Size(0, 200);
            this.groupBox5.MinimumSize = new System.Drawing.Size(400, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(400, 200);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "סטאטוס תקשורת";
            // 
            // gpsStatus
            // 
            this.gpsStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpsStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gpsStatus.ForeColor = System.Drawing.Color.Black;
            this.gpsStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gpsStatus.Location = new System.Drawing.Point(138, 48);
            this.gpsStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gpsStatus.Name = "gpsStatus";
            this.gpsStatus.Size = new System.Drawing.Size(114, 20);
            this.gpsStatus.TabIndex = 10;
            this.gpsStatus.Text = "כבוי";
            this.gpsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "אות GPS:";
            // 
            // serverIP
            // 
            this.serverIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverIP.AutoSize = true;
            this.serverIP.Location = new System.Drawing.Point(133, 150);
            this.serverIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.serverIP.Name = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(119, 22);
            this.serverIP.TabIndex = 8;
            this.serverIP.Text = "000.000.000";
            // 
            // serverIPLabel
            // 
            this.serverIPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverIPLabel.AutoSize = true;
            this.serverIPLabel.Location = new System.Drawing.Point(258, 150);
            this.serverIPLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.serverIPLabel.Name = "serverIPLabel";
            this.serverIPLabel.Size = new System.Drawing.Size(102, 22);
            this.serverIPLabel.TabIndex = 7;
            this.serverIPLabel.Text = "כתובת שרת:";
            // 
            // serverStatus
            // 
            this.serverStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.serverStatus.ForeColor = System.Drawing.Color.Red;
            this.serverStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serverStatus.Location = new System.Drawing.Point(138, 118);
            this.serverStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(114, 20);
            this.serverStatus.TabIndex = 6;
            this.serverStatus.Text = "החיבור אבד";
            this.serverStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lidarStatus
            // 
            this.lidarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lidarStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lidarStatus.ForeColor = System.Drawing.Color.Red;
            this.lidarStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lidarStatus.Location = new System.Drawing.Point(138, 82);
            this.lidarStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lidarStatus.Name = "lidarStatus";
            this.lidarStatus.Size = new System.Drawing.Size(114, 20);
            this.lidarStatus.TabIndex = 5;
            this.lidarStatus.Text = "החיבור אבד";
            this.lidarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.Location = new System.Drawing.Point(275, 118);
            this.serverStatusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(85, 22);
            this.serverStatusLabel.TabIndex = 1;
            this.serverStatusLabel.Text = "מצב שרת:";
            // 
            // lidarStatusLabel
            // 
            this.lidarStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lidarStatusLabel.AutoSize = true;
            this.lidarStatusLabel.Location = new System.Drawing.Point(274, 82);
            this.lidarStatusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lidarStatusLabel.Name = "lidarStatusLabel";
            this.lidarStatusLabel.Size = new System.Drawing.Size(86, 22);
            this.lidarStatusLabel.TabIndex = 0;
            this.lidarStatusLabel.Text = "מצב חיישן:";
            // 
            // clearLog
            // 
            this.clearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearLog.Location = new System.Drawing.Point(642, 269);
            this.clearLog.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clearLog.MaximumSize = new System.Drawing.Size(0, 39);
            this.clearLog.MinimumSize = new System.Drawing.Size(400, 0);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(400, 39);
            this.clearLog.TabIndex = 5;
            this.clearLog.Text = "מחק לוג התראות";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // saveLog
            // 
            this.saveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLog.Location = new System.Drawing.Point(642, 318);
            this.saveLog.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.saveLog.MaximumSize = new System.Drawing.Size(0, 39);
            this.saveLog.MinimumSize = new System.Drawing.Size(400, 0);
            this.saveLog.Name = "saveLog";
            this.saveLog.Size = new System.Drawing.Size(400, 39);
            this.saveLog.TabIndex = 8;
            this.saveLog.Text = "שמור לוג התראות";
            this.saveLog.UseVisualStyleBackColor = true;
            this.saveLog.Click += new System.EventHandler(this.saveLog_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ReplaceIP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTerminal, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(636, 211);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 50);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(400, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 50);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // ReplaceIP
            // 
            this.ReplaceIP.AutoSize = true;
            this.ReplaceIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReplaceIP.Location = new System.Drawing.Point(212, 5);
            this.ReplaceIP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ReplaceIP.MaximumSize = new System.Drawing.Size(0, 39);
            this.ReplaceIP.MinimumSize = new System.Drawing.Size(200, 0);
            this.ReplaceIP.Name = "ReplaceIP";
            this.ReplaceIP.Size = new System.Drawing.Size(200, 39);
            this.ReplaceIP.TabIndex = 11;
            this.ReplaceIP.Text = "החלף כתובת שרת";
            this.ReplaceIP.UseVisualStyleBackColor = true;
            this.ReplaceIP.Click += new System.EventHandler(this.ReplaceIP_Click);
            // 
            // btnTerminal
            // 
            this.btnTerminal.AutoSize = true;
            this.btnTerminal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTerminal.Location = new System.Drawing.Point(6, 5);
            this.btnTerminal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTerminal.MaximumSize = new System.Drawing.Size(0, 39);
            this.btnTerminal.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(200, 39);
            this.btnTerminal.TabIndex = 10;
            this.btnTerminal.Text = "פתח מסוף נתונים";
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // OperatorMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1684, 961);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.saveLog);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.topViewBox);
            this.Controls.Add(this.frontViewBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(1700, 1000);
            this.Name = "OperatorMode";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "תצוגת מפעיל";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OperatorMode_FormClosed);
            this.Load += new System.EventHandler(this.OperatorMode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox frontViewBox;
        private System.Windows.Forms.GroupBox topViewBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label serverStatusLabel;
        private System.Windows.Forms.Label lidarStatusLabel;
        private System.Windows.Forms.Label serverStatus;
        private System.Windows.Forms.Label lidarStatus;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.Label serverIP;
        private System.Windows.Forms.Label serverIPLabel;
        private System.Windows.Forms.Button saveLog;
        private System.Windows.Forms.ListView activeAlert;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView log;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label gpsStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ReplaceIP;
        private System.Windows.Forms.Button btnTerminal;
    }
}