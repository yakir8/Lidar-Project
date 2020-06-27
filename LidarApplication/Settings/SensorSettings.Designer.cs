namespace LidarApplication {
    partial class SensorSettings {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(85, 171);
            this.label25.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(161, 40);
            this.label25.TabIndex = 53;
            this.label25.Text = "סנטימטרים";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(85, 342);
            this.label23.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(161, 40);
            this.label23.TabIndex = 62;
            this.label23.Text = "מעלות";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vehicleWidth
            // 
            this.vehicleWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleWidth.Location = new System.Drawing.Point(268, 179);
            this.vehicleWidth.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.vehicleWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vehicleWidth.Name = "vehicleWidth";
            this.vehicleWidth.Size = new System.Drawing.Size(161, 29);
            this.vehicleWidth.TabIndex = 52;
            this.vehicleWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vehicleWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // stopAngle
            // 
            this.stopAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopAngle.Location = new System.Drawing.Point(268, 350);
            this.stopAngle.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
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
            this.stopAngle.Size = new System.Drawing.Size(161, 29);
            this.stopAngle.TabIndex = 61;
            this.stopAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopAngle.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(451, 171);
            this.label24.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(161, 40);
            this.label24.TabIndex = 51;
            this.label24.Text = "רוחב הרכב";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(85, 302);
            this.label22.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(161, 40);
            this.label22.TabIndex = 60;
            this.label22.Text = "מעלות";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 40);
            this.label7.TabIndex = 50;
            this.label7.Text = "מעלות";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startAngle
            // 
            this.startAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startAngle.Location = new System.Drawing.Point(268, 310);
            this.startAngle.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
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
            this.startAngle.Size = new System.Drawing.Size(161, 29);
            this.startAngle.TabIndex = 59;
            this.startAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // angle
            // 
            this.angle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.angle.Location = new System.Drawing.Point(268, 139);
            this.angle.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.angle.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(161, 29);
            this.angle.TabIndex = 49;
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
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(451, 342);
            this.label18.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 40);
            this.label18.TabIndex = 58;
            this.label18.Text = "זווית סיום";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 40);
            this.label6.TabIndex = 48;
            this.label6.Text = "סנטימטרים";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(451, 302);
            this.label17.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 40);
            this.label17.TabIndex = 57;
            this.label17.Text = "זווית התחלה";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // height
            // 
            this.height.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.height.Location = new System.Drawing.Point(268, 99);
            this.height.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.height.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(161, 29);
            this.height.TabIndex = 47;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Location = new System.Drawing.Point(268, 390);
            this.resolutionComboBox.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resolutionComboBox.Size = new System.Drawing.Size(161, 30);
            this.resolutionComboBox.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 382);
            this.label12.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 40);
            this.label12.TabIndex = 56;
            this.label12.Text = "מעלות";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(451, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 40);
            this.label5.TabIndex = 46;
            this.label5.Text = "זווית החיישן";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(451, 382);
            this.label9.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 40);
            this.label9.TabIndex = 54;
            this.label9.Text = "רזולוצית סריקה";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(451, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 40);
            this.label4.TabIndex = 45;
            this.label4.Text = "גובה החיישן";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.resolutionComboBox, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label23, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label25, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.stopAngle, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.height, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label22, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.startAngle, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.vehicleWidth, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.angle, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label24, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.52547F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.360353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.360353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.360353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.52547F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.360353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.360353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.360353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.78695F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 551);
            this.tableLayoutPanel1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 5);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(11, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(674, 91);
            this.label2.TabIndex = 64;
            this.label2.Text = "הגדרות סריקה של החיישן";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 91);
            this.label1.TabIndex = 63;
            this.label1.Text = "נתונים פיזים של המערכת";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SensorSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SensorSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "SensorSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SensorSettings_FormClosing);
            this.Load += new System.EventHandler(this.SensorSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown vehicleWidth;
        private System.Windows.Forms.NumericUpDown stopAngle;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown startAngle;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}