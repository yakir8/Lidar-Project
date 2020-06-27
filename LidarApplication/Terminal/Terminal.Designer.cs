namespace LidarApplication {
    partial class Terminal {
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
            this.btnGps = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnLidar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTerminal = new System.Windows.Forms.Panel();
            this.cursor = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.cursor);
            this.panel1.Controls.Add(this.btnGps);
            this.panel1.Controls.Add(this.btnServer);
            this.panel1.Controls.Add(this.btnLidar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 453);
            this.panel1.TabIndex = 0;
            // 
            // btnGps
            // 
            this.btnGps.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGps.FlatAppearance.BorderSize = 0;
            this.btnGps.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGps.Location = new System.Drawing.Point(0, 219);
            this.btnGps.Margin = new System.Windows.Forms.Padding(5);
            this.btnGps.Name = "btnGps";
            this.btnGps.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGps.Size = new System.Drawing.Size(222, 50);
            this.btnGps.TabIndex = 3;
            this.btnGps.Text = "GPS";
            this.btnGps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGps.UseVisualStyleBackColor = false;
            this.btnGps.Click += new System.EventHandler(this.btnGps_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServer.FlatAppearance.BorderSize = 0;
            this.btnServer.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Location = new System.Drawing.Point(0, 169);
            this.btnServer.Margin = new System.Windows.Forms.Padding(5);
            this.btnServer.Name = "btnServer";
            this.btnServer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnServer.Size = new System.Drawing.Size(222, 50);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Server";
            this.btnServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnLidar
            // 
            this.btnLidar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLidar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLidar.FlatAppearance.BorderSize = 0;
            this.btnLidar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLidar.Location = new System.Drawing.Point(0, 119);
            this.btnLidar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLidar.Name = "btnLidar";
            this.btnLidar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLidar.Size = new System.Drawing.Size(222, 50);
            this.btnLidar.TabIndex = 1;
            this.btnLidar.Text = "Lidar";
            this.btnLidar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLidar.UseVisualStyleBackColor = false;
            this.btnLidar.Click += new System.EventHandler(this.btnLidar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 119);
            this.panel2.TabIndex = 0;
            // 
            // panelTerminal
            // 
            this.panelTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminal.Location = new System.Drawing.Point(222, 0);
            this.panelTerminal.Name = "panelTerminal";
            this.panelTerminal.Size = new System.Drawing.Size(706, 453);
            this.panelTerminal.TabIndex = 1;
            // 
            // cursor
            // 
            this.cursor.BackColor = System.Drawing.Color.DodgerBlue;
            this.cursor.Location = new System.Drawing.Point(0, 119);
            this.cursor.Name = "cursor";
            this.cursor.Size = new System.Drawing.Size(10, 50);
            this.cursor.TabIndex = 14;
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 453);
            this.Controls.Add(this.panelTerminal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Terminal";
            this.Text = "Terminal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGps;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnLidar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTerminal;
        private System.Windows.Forms.FlowLayoutPanel cursor;
    }
}