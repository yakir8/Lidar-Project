namespace LidarApplication {
    partial class ServerActionBar {
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
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnCheckNetwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStartServer.FlatAppearance.BorderSize = 0;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Location = new System.Drawing.Point(86, 7);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(171, 40);
            this.btnStartServer.TabIndex = 19;
            this.btnStartServer.Text = "הפעל שרת";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnCheckNetwork
            // 
            this.btnCheckNetwork.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckNetwork.FlatAppearance.BorderSize = 0;
            this.btnCheckNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckNetwork.Location = new System.Drawing.Point(410, 7);
            this.btnCheckNetwork.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.btnCheckNetwork.Name = "btnCheckNetwork";
            this.btnCheckNetwork.Size = new System.Drawing.Size(171, 40);
            this.btnCheckNetwork.TabIndex = 18;
            this.btnCheckNetwork.Text = "בדוק חיבור לרשת";
            this.btnCheckNetwork.UseVisualStyleBackColor = false;
            this.btnCheckNetwork.Click += new System.EventHandler(this.btnCheckNetwork_Click);
            // 
            // ServerActionBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(696, 51);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.btnCheckNetwork);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ServerActionBar";
            this.Text = "ServerActionBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnCheckNetwork;
    }
}