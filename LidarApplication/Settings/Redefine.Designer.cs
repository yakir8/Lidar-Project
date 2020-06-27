namespace LidarApplication {
    partial class Redefine {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cursor = new System.Windows.Forms.FlowLayoutPanel();
            this.driverSubMenu = new System.Windows.Forms.Panel();
            this.btnSerialSettings = new System.Windows.Forms.Button();
            this.btnNetworkSettings = new System.Windows.Forms.Button();
            this.btnWindowSettings = new System.Windows.Forms.Button();
            this.btnSensorSettings = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelActionBar = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.driverSubMenu.SuspendLayout();
            this.panelActionBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.cursor);
            this.panel1.Controls.Add(this.driverSubMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 761);
            this.panel1.TabIndex = 1;
            // 
            // cursor
            // 
            this.cursor.BackColor = System.Drawing.Color.DodgerBlue;
            this.cursor.Location = new System.Drawing.Point(212, 100);
            this.cursor.Name = "cursor";
            this.cursor.Size = new System.Drawing.Size(10, 50);
            this.cursor.TabIndex = 12;
            // 
            // driverSubMenu
            // 
            this.driverSubMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.driverSubMenu.Controls.Add(this.btnSerialSettings);
            this.driverSubMenu.Controls.Add(this.btnNetworkSettings);
            this.driverSubMenu.Controls.Add(this.btnWindowSettings);
            this.driverSubMenu.Controls.Add(this.btnSensorSettings);
            this.driverSubMenu.Controls.Add(this.btnOverview);
            this.driverSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.driverSubMenu.Location = new System.Drawing.Point(0, 100);
            this.driverSubMenu.Name = "driverSubMenu";
            this.driverSubMenu.Size = new System.Drawing.Size(222, 250);
            this.driverSubMenu.TabIndex = 3;
            // 
            // btnSerialSettings
            // 
            this.btnSerialSettings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSerialSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSerialSettings.FlatAppearance.BorderSize = 0;
            this.btnSerialSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSerialSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSerialSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialSettings.Location = new System.Drawing.Point(0, 200);
            this.btnSerialSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSerialSettings.Name = "btnSerialSettings";
            this.btnSerialSettings.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnSerialSettings.Size = new System.Drawing.Size(222, 50);
            this.btnSerialSettings.TabIndex = 11;
            this.btnSerialSettings.Text = "תקשורת טורית";
            this.btnSerialSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerialSettings.UseVisualStyleBackColor = false;
            this.btnSerialSettings.Click += new System.EventHandler(this.btnSerialSettings_Click);
            // 
            // btnNetworkSettings
            // 
            this.btnNetworkSettings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNetworkSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNetworkSettings.FlatAppearance.BorderSize = 0;
            this.btnNetworkSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNetworkSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNetworkSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetworkSettings.Location = new System.Drawing.Point(0, 150);
            this.btnNetworkSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnNetworkSettings.Name = "btnNetworkSettings";
            this.btnNetworkSettings.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnNetworkSettings.Size = new System.Drawing.Size(222, 50);
            this.btnNetworkSettings.TabIndex = 10;
            this.btnNetworkSettings.Text = "פרטי רשת";
            this.btnNetworkSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNetworkSettings.UseVisualStyleBackColor = false;
            this.btnNetworkSettings.Click += new System.EventHandler(this.btnNetworkSettings_Click);
            // 
            // btnWindowSettings
            // 
            this.btnWindowSettings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWindowSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWindowSettings.FlatAppearance.BorderSize = 0;
            this.btnWindowSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWindowSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWindowSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowSettings.Location = new System.Drawing.Point(0, 100);
            this.btnWindowSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnWindowSettings.Name = "btnWindowSettings";
            this.btnWindowSettings.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnWindowSettings.Size = new System.Drawing.Size(222, 50);
            this.btnWindowSettings.TabIndex = 9;
            this.btnWindowSettings.Text = "תצוגת התראות";
            this.btnWindowSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWindowSettings.UseVisualStyleBackColor = false;
            this.btnWindowSettings.Click += new System.EventHandler(this.btnWindowSettings_Click);
            // 
            // btnSensorSettings
            // 
            this.btnSensorSettings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSensorSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSensorSettings.FlatAppearance.BorderSize = 0;
            this.btnSensorSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSensorSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSensorSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensorSettings.Location = new System.Drawing.Point(0, 50);
            this.btnSensorSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSensorSettings.Name = "btnSensorSettings";
            this.btnSensorSettings.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnSensorSettings.Size = new System.Drawing.Size(222, 50);
            this.btnSensorSettings.TabIndex = 6;
            this.btnSensorSettings.Text = "נתוני חיישן";
            this.btnSensorSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSensorSettings.UseVisualStyleBackColor = false;
            this.btnSensorSettings.Click += new System.EventHandler(this.btnSensorSettings_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Location = new System.Drawing.Point(0, 0);
            this.btnOverview.Margin = new System.Windows.Forms.Padding(0);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnOverview.Size = new System.Drawing.Size(222, 50);
            this.btnOverview.TabIndex = 4;
            this.btnOverview.Text = "סקירה כללית";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 100);
            this.panel2.TabIndex = 1;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(222, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(712, 701);
            this.panelSettings.TabIndex = 10;
            // 
            // panelActionBar
            // 
            this.panelActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelActionBar.Controls.Add(this.btnSave);
            this.panelActionBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionBar.Location = new System.Drawing.Point(222, 701);
            this.panelActionBar.Name = "panelActionBar";
            this.panelActionBar.Size = new System.Drawing.Size(712, 60);
            this.panelActionBar.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(8, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Redefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(934, 761);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelActionBar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 800);
            this.MinimumSize = new System.Drawing.Size(950, 800);
            this.Name = "Redefine";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "איתחול המערכת";
            this.panel1.ResumeLayout(false);
            this.driverSubMenu.ResumeLayout(false);
            this.panelActionBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel driverSubMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button btnSensorSettings;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Panel panelActionBar;
        private System.Windows.Forms.Button btnSerialSettings;
        private System.Windows.Forms.Button btnNetworkSettings;
        private System.Windows.Forms.Button btnWindowSettings;
        private System.Windows.Forms.FlowLayoutPanel cursor;
        private System.Windows.Forms.Button btnSave;
    }
}