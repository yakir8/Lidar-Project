using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
    public abstract class GraphicLidar {

        protected Configuration config;

        //GroupBox Parameter
        public int height, width;

        public float center, radios, diameter;
        
        //Arc Padding From Top And Left
        public int LeftPadding;
        public int TopPadding;

        //Arc Offset From The Bottom
        public int heightOffset = 25;

        //Width & Height Factor -> 1 pix to mm
        public float widthFactor = 1;
        public float heightFactor = 1;

        public float Ratio = 1;

        public GraphicLidar(GroupBox viewBox, Configuration config) {
            this.config = config;
            this.width = viewBox.Width;
            this.height = viewBox.Height;
            diameter = getDiameter(viewBox);
            radios = diameter / 2;
            center = width / 2;
            LeftPadding = (int)(width - diameter) / 2;
            TopPadding = (int) (height - radios) - heightOffset;
            Ratio = GetRatioHeightWidth(config);
        }
        public static float GetRatioHeightWidth(Configuration config) {
            double alpha = (90 - config.getAngleSetup()) * (Math.PI / 180);
            return (float)Math.Tan(alpha);
        }
        public abstract void Draw(PaintEventArgs e, List<Obstacle> ScanResult);
        protected void PaintRectangle(PaintEventArgs e) {
            Graphics l = e.Graphics;
            l.FillRectangle(Brushes.SkyBlue, LeftPadding, TopPadding, (int)diameter, (int)radios);
            l.DrawRectangle(new Pen(Color.Gray, 1.5f), LeftPadding, TopPadding, (int)diameter, (int)radios);
            if (config.getActiveZoneEnable()) PaintActiveZone(e);
            if (config.getGridEnable()) PaintGridRectangle(e);
        }
        private void PaintGridRectangle(PaintEventArgs e) {
            float gridWidth = (center - LeftPadding) / 3;
            Pen pen = new Pen(Color.Gray, 1.5f);
            // Vertical Line Grid
            for (int i = 0; i < 3; i++) {
                float x = center + i * gridWidth;
                float y = height - radios - heightOffset;
                e.Graphics.DrawLine(pen, new PointF(x, y), new PointF(x, height - heightOffset));
                x = center - i * gridWidth;
                e.Graphics.DrawLine(pen, new PointF(x, y), new PointF(x, height - heightOffset));
            }
            // Horizontal Line Grid
            for (int i = 1; i < 3; i++) {
                float y = height - heightOffset - i * gridWidth;
                float x = width - LeftPadding;
                e.Graphics.DrawLine(pen, new PointF(LeftPadding, y), new PointF(x, y));
            }
        }
        private void PaintActiveZone(PaintEventArgs e) {
            Graphics l = e.Graphics;

            float side = 2 * (config.getSideLowAlert() * 10 * widthFactor);
            float h = config.getFrontLowAlert() * 10 * heightFactor;
            if (h > radios) h = radios;
            if (side > diameter) side = diameter;

            float side2 = 2 * (config.getSideHighAlert() * 10 * widthFactor);
            float h2 = config.getFrontHighAlert() * 10 * heightFactor;
            if (h2 > radios) h2 = radios;
            if (side2 > diameter) side2 = diameter;

            l.FillRectangle(Brushes.SeaGreen, LeftPadding + radios - (side / 2), 
                height - h - heightOffset, (int) side, (int) h);

            l.FillRectangle(Brushes.IndianRed, LeftPadding + radios - (side2 / 2),
                height - h2 - heightOffset, (int)side2, (int)h2);
        }
        public static float getDiameter(GroupBox viewBox) {
            float width = viewBox.Width;
            float height = viewBox.Height;
            float a = width - 20;
            return (width / 2) <= (height - 25) ? width - 20 : (height * 2) - 80;
        }
    }
}
