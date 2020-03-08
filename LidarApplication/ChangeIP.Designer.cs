namespace LidarApplication
{
    partial class ChangeIP
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
            this.ipAddressControl = new IPAddressControlLib.IPAddressControl();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipAddressControl
            // 
            this.ipAddressControl.AllowInternalTab = false;
            this.ipAddressControl.AutoHeight = true;
            this.ipAddressControl.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl.Location = new System.Drawing.Point(158, 36);
            this.ipAddressControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ipAddressControl.MinimumSize = new System.Drawing.Size(153, 29);
            this.ipAddressControl.Name = "ipAddressControl";
            this.ipAddressControl.ReadOnly = false;
            this.ipAddressControl.Size = new System.Drawing.Size(160, 29);
            this.ipAddressControl.TabIndex = 0;
            this.ipAddressControl.Text = "...";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(156, 116);
            this.OK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(160, 39);
            this.OK.TabIndex = 1;
            this.OK.Text = "אישור";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ChangeIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 185);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.ipAddressControl);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeIP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "עדכון כתובת IP";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private IPAddressControlLib.IPAddressControl ipAddressControl;
        private System.Windows.Forms.Button OK;
    }
}