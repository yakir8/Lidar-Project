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
            this.SuspendLayout();
            // 
            // lidarPort
            // 
            this.lidarPort.Location = new System.Drawing.Point(451, 94);
            this.lidarPort.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.lidarPort.Name = "lidarPort";
            this.lidarPort.Size = new System.Drawing.Size(62, 29);
            this.lidarPort.TabIndex = 27;
            this.lidarPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = ":";
            // 
            // epLidar
            // 
            this.epLidar.AllowInternalTab = false;
            this.epLidar.AutoHeight = true;
            this.epLidar.BackColor = System.Drawing.SystemColors.Window;
            this.epLidar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epLidar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epLidar.Location = new System.Drawing.Point(225, 93);
            this.epLidar.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.epLidar.MinimumSize = new System.Drawing.Size(153, 29);
            this.epLidar.Name = "epLidar";
            this.epLidar.ReadOnly = false;
            this.epLidar.Size = new System.Drawing.Size(205, 29);
            this.epLidar.TabIndex = 29;
            this.epLidar.Text = "...";
            // 
            // epServer
            // 
            this.epServer.AllowInternalTab = false;
            this.epServer.AutoHeight = true;
            this.epServer.BackColor = System.Drawing.SystemColors.Window;
            this.epServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.epServer.Location = new System.Drawing.Point(225, 214);
            this.epServer.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.epServer.MinimumSize = new System.Drawing.Size(153, 29);
            this.epServer.Name = "epServer";
            this.epServer.ReadOnly = false;
            this.epServer.Size = new System.Drawing.Size(288, 29);
            this.epServer.TabIndex = 28;
            this.epServer.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(566, 217);
            this.label15.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 22);
            this.label15.TabIndex = 26;
            this.label15.Text = "כתובת IP שרת";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(565, 99);
            this.label16.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 22);
            this.label16.TabIndex = 25;
            this.label16.Text = "כתובת IP חיישן";
            // 
            // checkLidar
            // 
            this.checkLidar.BackColor = System.Drawing.Color.SteelBlue;
            this.checkLidar.FlatAppearance.BorderSize = 0;
            this.checkLidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkLidar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkLidar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkLidar.Location = new System.Drawing.Point(6, 67);
            this.checkLidar.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.checkLidar.Name = "checkLidar";
            this.checkLidar.Size = new System.Drawing.Size(200, 50);
            this.checkLidar.TabIndex = 24;
            this.checkLidar.Text = "בדיקת חיבור לחיישן";
            this.checkLidar.UseVisualStyleBackColor = false;
            this.checkLidar.Click += new System.EventHandler(this.checkLidar_Click);
            // 
            // interntAdapterComboBox
            // 
            this.interntAdapterComboBox.DropDownHeight = 200;
            this.interntAdapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interntAdapterComboBox.DropDownWidth = 300;
            this.interntAdapterComboBox.FormattingEnabled = true;
            this.interntAdapterComboBox.IntegralHeight = false;
            this.interntAdapterComboBox.Location = new System.Drawing.Point(225, 147);
            this.interntAdapterComboBox.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.interntAdapterComboBox.Name = "interntAdapterComboBox";
            this.interntAdapterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.interntAdapterComboBox.Size = new System.Drawing.Size(288, 30);
            this.interntAdapterComboBox.TabIndex = 23;
            // 
            // lidarAdapterComboBox
            // 
            this.lidarAdapterComboBox.DropDownHeight = 200;
            this.lidarAdapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lidarAdapterComboBox.DropDownWidth = 300;
            this.lidarAdapterComboBox.FormattingEnabled = true;
            this.lidarAdapterComboBox.IntegralHeight = false;
            this.lidarAdapterComboBox.Location = new System.Drawing.Point(225, 35);
            this.lidarAdapterComboBox.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.lidarAdapterComboBox.Name = "lidarAdapterComboBox";
            this.lidarAdapterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lidarAdapterComboBox.Size = new System.Drawing.Size(288, 30);
            this.lidarAdapterComboBox.TabIndex = 22;
            // 
            // checkNetwork
            // 
            this.checkNetwork.BackColor = System.Drawing.Color.SteelBlue;
            this.checkNetwork.FlatAppearance.BorderSize = 0;
            this.checkNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkNetwork.Location = new System.Drawing.Point(6, 147);
            this.checkNetwork.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.checkNetwork.Name = "checkNetwork";
            this.checkNetwork.Size = new System.Drawing.Size(200, 50);
            this.checkNetwork.TabIndex = 21;
            this.checkNetwork.Text = "בדיקת חיבור לרשת";
            this.checkNetwork.UseVisualStyleBackColor = false;
            this.checkNetwork.Click += new System.EventHandler(this.checkNetwork_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "מתאם רשת לאינטרנט";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "מתאם רשת לחיישן";
            // 
            // NetworkSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 462);
            this.Controls.Add(this.lidarPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.epLidar);
            this.Controls.Add(this.epServer);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.checkLidar);
            this.Controls.Add(this.interntAdapterComboBox);
            this.Controls.Add(this.lidarAdapterComboBox);
            this.Controls.Add(this.checkNetwork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "NetworkSettings";
            this.Text = "NetworkSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkSettings_FormClosing);
            this.Load += new System.EventHandler(this.NetworkSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}