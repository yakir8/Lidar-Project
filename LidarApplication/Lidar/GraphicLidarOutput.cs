using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
    public class GraphicLidarOutput : GraphicLidar {

        //Vehicle Width [mm]
        private float vehicleWidth;

        //Max Lidar Scan Distance 
        public float MaxDistance = 1;

        public static float Zoom = 0.5f;

        public GraphicLidarOutput(GroupBox viewBox, Configuration config) : base(viewBox, config) {
            MaxDistance = config.getSideLowAlert() / Zoom;
            widthFactor = diameter / (MaxDistance * 20);
            heightFactor = (radios * Ratio) / (MaxDistance * 10);
            vehicleWidth = config.getVehicleWidth() * 10 * widthFactor;
        }
        public override void Draw(PaintEventArgs e, List<Obstacle> ScanResult) {
            Graphics l = e.Graphics;
            PaintRectangle(e);
            PaintFrontViewLine(e, ScanResult);
            // draw "vehicle" on the screen
            l.FillRectangle(Brushes.Navy, radios + LeftPadding - (vehicleWidth / 2),
                height - heightOffset, vehicleWidth, heightOffset);
            l.Dispose();
        }
        private void PaintFrontViewLine(PaintEventArgs e, List<Obstacle> ScanResult) {
            if (ScanResult.Any()) {
                List<PointF> points = new List<PointF>();
                Graphics l = e.Graphics;
                Pen pen = new Pen(Color.Black, 2f);
                // Create array of point for dispaly on the screen
                foreach (Obstacle o in ScanResult) {
                    float y = radios - (o.GetY(0) * heightFactor);
                    float x = center + (o.GetX(0) * widthFactor);
                    points.Add(new PointF(x, y + TopPadding));
                }
                // Connect all the point in the array
                e.Graphics.DrawLines(pen, points.ToArray());
            }
        }
    }
}
