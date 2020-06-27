namespace LidarApplication {
    partial class ServerSettings {
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
            this.serverIpAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverIpAddress
            // 
            this.serverIpAddress.Location = new System.Drawing.Point(180, 209);
            this.serverIpAddress.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.serverIpAddress.Name = "serverIpAddress";
            this.serverIpAddress.ReadOnly = true;
            this.serverIpAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverIpAddress.Size = new System.Drawing.Size(190, 29);
            this.serverIpAddress.TabIndex = 15;
            this.serverIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(373, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "כתובת IP שרת";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 551);
            this.Controls.Add(this.serverIpAddress);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ServerSettings";
            this.Text = "ServerSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverIpAddress;
        private System.Windows.Forms.Label label8;
    }
}