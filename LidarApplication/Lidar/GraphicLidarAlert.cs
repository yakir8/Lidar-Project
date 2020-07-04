using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidarApplication {
    public class GraphicLidarAlert : GraphicLidar {

        private const float dotRadios = 15;

        public static float Zoom = 1.0f;

        public GraphicLidarAlert(GroupBox viewBox, Configuration config) : base(viewBox, config) {
            float maxDisSide = (config.getSideLowAlert() * 10) / Zoom;
            float maxDisFront = (config.getFrontLowAlert() * 10) / Zoom;
            widthFactor = diameter / (maxDisSide * 2);
            heightFactor = radios / maxDisFront;
            // Rescaling the max distance 
            if (maxDisSide / maxDisFront < Ratio) {
                float RatioFactor = (maxDisFront * Ratio) / maxDisSide;
                widthFactor = diameter / (maxDisSide * 2 * RatioFactor);
            }
            else if (maxDisSide / maxDisFront > Ratio) {
                float RatioFactor = maxDisSide / (maxDisFront * Ratio);
                heightFactor = radios / (maxDisFront * RatioFactor);
            }
        }

        public override void Draw(PaintEventArgs e, List<Obstacle> ScanResult) {
            Graphics l = e.Graphics;
            Pen pen = new Pen(Color.Gray, 1.5f);
            PaintRectangle(e);
            l.FillEllipse(new SolidBrush(Color.Navy), (width - dotRadios) / 2,
                height - 20 - heightOffset / 2, dotRadios, dotRadios);
            foreach (Obstacle obstacle in ScanResult) {
                if (obstacle.InActiveZone()) {
                    for (int i = 0; i < obstacle.GetAngles().Count; i++) {
                        Obstacle o = new Obstacle(config, obstacle.GetAngles()[i], obstacle.GetRadius()[i]);
                        SolidBrush brush = o.GetAleatState() == 2 ?
                       new SolidBrush(Color.DarkRed) : new SolidBrush(Color.Red);
                        float y = radios - (o.GetY(0) * heightFactor) - heightOffset / 2 + 5;
                        float x = center + (o.GetX(0) * widthFactor);
                        PaintObstacle(e, brush, (int)x, (int)(y + TopPadding));
                    }
                }
            }
            l.Dispose();
        }
        private void PaintObstacle(PaintEventArgs e, SolidBrush solidBrush, int x, int y) {
            Graphics l = e.Graphics;
            const float ObstacleSize = 5;
            l.FillEllipse(solidBrush, x, y, ObstacleSize, ObstacleSize);
        }
    }
}
