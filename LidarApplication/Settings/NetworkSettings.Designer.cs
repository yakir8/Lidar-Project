namespace LidarApplication {
    partial class NetworkSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lidarAdapterComboBox = new System.Windows.Forms.ComboBox();
            this.checkLidar = new System.Windows.Forms.Button();
            this.epServer = new IPAddressControlLib.IPAddressControl();
            this.label2 = new System.Windows.Forms.Label();
            this.interntAdapterComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkNetwork = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.epLidar = new IPAddressControlLib.IPAddressControl();
            this.label3 = new System.Windows.Forms.Label();
            this.lidarPort = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.358066F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.17882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.10505F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.358066F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lidarAdapterComboBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkLidar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.epServer, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.interntAdapterComboBox, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkNetwork, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.56823F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202537F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.56822F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202537F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202537F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.202537F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64833F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 551);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 4);
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(11, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(674, 74);
            this.label5.TabIndex = 31;
            this.label5.Text = "פרטי התחברות לחיישן";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 4);
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(11, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(674, 74);
            this.label4.TabIndex = 30;
            this.label4.Text = "פרטי התחברות לשרת";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(439, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 50);
            this.label1.TabIndex = 19;
            this.label1.Text = "מתאם רשת";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(439, 124);
            this.label16.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 50);
            this.label16.TabIndex = 25;
            this.label16.Text = "כתובת IP";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lidarAdapterComboBox
            // 
            this.lidarAdapterComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.lidarAdapterComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lidarAdapterComboBox.DropDownHeight = 200;
            this.lidarAdapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lidarAdapterComboBox.DropDownWidth = 300;
            this.lidarAdapterComboBox.FormattingEnabled = true;
            this.lidarAdapterComboBox.IntegralHeight = false;
            this.lidarAdapterComboBox.Location = new System.Drawing.Point(77, 82);
            this.lidarAdapterComboBox.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.lidarAdapterComboBox.Name = "lidarAdapterComboBox";
            this.lidarAdapterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lidarAdapterComboBox.Size = new System.Drawing.Size(340, 30);
            this.lidarAdapterComboBox.TabIndex = 22;
            // 
            // checkLidar
            // 
            this.checkLidar.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.checkLidar, 2);
            this.checkLidar.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkLidar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkLidar.FlatAppearance.BorderSize = 0;
            this.checkLidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkLidar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkLidar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkLidar.Location = new System.Drawing.Point(77, 182);
            this.checkLidar.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.checkLidar.Name = "checkLidar";
            this.checkLidar.Size = new System.Drawing.Size(543, 34);
            this.checkLidar.TabIndex = 24;
            this.checkLidar.Text = "בדיקת חיבור לחיישן";
            this.checkLidar.UseVisualStyleBackColor = false;
            this.checkLidar.Click += new System.EventHandler(this.checkLidar_Click);
            // 
            // epServer
            // 
            this.epServer.AllowInternalTab = false;
            this.epServer.AutoHeight = true;
            this.epServer.BackColor = System.Drawing.SystemColors.Window;
            this.epServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epServer.Cursor = System.Windows.Forms.Cursors.Default;
            this.epServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epServer.Location = new System.Drawing.Point(77, 356);
            this.epServer.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.epServer.MinimumSize = new System.Drawing.Size(153, 29);
            this.epServer.Name = "epServer";
            this.epServer.ReadOnly = false;
            this.epServer.Size = new System.Drawing.Size(340, 29);
            this.epServer.TabIndex = 28;
            this.epServer.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(439, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 50);
            this.label2.TabIndex = 20;
            this.label2.Text = "מתאם רשת";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // interntAdapterComboBox
            // 
            this.interntAdapterComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.interntAdapterComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interntAdapterComboBox.DropDownHeight = 200;
            this.interntAdapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interntAdapterComboBox.DropDownWidth = 300;
            this.interntAdapterComboBox.FormattingEnabled = true;
            this.interntAdapterComboBox.IntegralHeight = false;
            this.interntAdapterComboBox.Location = new System.Drawing.Point(77, 306);
            this.interntAdapterComboBox.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.interntAdapterComboBox.Name = "interntAdapterComboBox";
            this.interntAdapterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.interntAdapterComboBox.Size = new System.Drawing.Size(340, 30);
            this.interntAdapterComboBox.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(439, 348);
            this.label15.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 50);
            this.label15.TabIndex = 26;
            this.label15.Text = "כתובת IP";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkNetwork
            // 
            this.checkNetwork.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.checkNetwork, 2);
            this.checkNetwork.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkNetwork.FlatAppearance.BorderSize = 0;
            this.checkNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkNetwork.Location = new System.Drawing.Point(77, 406);
            this.checkNetwork.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.checkNetwork.Name = "checkNetwork";
            this.checkNetwork.Size = new System.Drawing.Size(543, 34);
            this.checkNetwork.TabIndex = 21;
            this.checkNetwork.Text = "בדיקת חיבור לרשת";
            this.checkNetwork.UseVisualStyleBackColor = false;
            this.checkNetwork.Click += new System.EventHandler(this.checkNetwork_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.08109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.708062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.21085F));
            this.tableLayoutPanel2.Controls.Add(this.epLidar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lidarPort, 0, 0);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(69, 127);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 44);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // epLidar
            // 
            this.epLidar.AllowInternalTab = false;
            this.epLidar.AutoHeight = true;
            this.epLidar.BackColor = System.Drawing.SystemColors.Window;
            this.epLidar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epLidar.Cursor = System.Windows.Forms.Cursors.Default;
            this.epLidar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epLidar.Location = new System.Drawing.Point(11, 8);
            this.epLidar.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.epLidar.MinimumSize = new System.Drawing.Size(153, 29);
            this.epLidar.Name = "epLidar";
            this.epLidar.ReadOnly = false;
            this.epLidar.Size = new System.Drawing.Size(211, 29);
            this.epLidar.TabIndex = 29;
            this.epLidar.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(244, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 44);
            this.label3.TabIndex = 30;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lidarPort
            // 
            this.lidarPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.lidarPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lidarPort.Location = new System.Drawing.Point(278, 8);
            this.lidarPort.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.lidarPort.Name = "lidarPort";
            this.lidarPort.Size = new System.Drawing.Size(67, 29);
            this.lidarPort.TabIndex = 27;
            this.lidarPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NetworkSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "NetworkSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "NetworkSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkSettings_FormClosing);
            this.Load += new System.EventHandler(this.NetworkSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox lidarPort;
        private System.Windows.Forms.Label label3;
        private IPAddressControlLib.IPAddressControl epLidar;
        private IPAddressControlLib.IPAddressControl epServer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button checkLidar;
        private System.Windows.Forms.ComboBox interntAdapterComboBox;
        private System.Windows.Forms.ComboBox lidarAdapterComboBox;
        private System.Windows.Forms.Button checkNetwork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}