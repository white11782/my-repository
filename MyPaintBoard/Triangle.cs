using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml;

namespace MyPaintBoard
{
    public class Triangle:Shape
    {
        private PointF a = PointF.Empty;
        private PointF b = PointF.Empty;
        private PointF c = PointF.Empty;

        public PointF A { get => a; set => a = value; }
        public PointF B { get => b; set => b = value; }
        public PointF C { get => c; set => c = value; }

        public override RectangleF Frame
        {
            get
            {
                RectangleF frame = new RectangleF();

                float minX, minY, maxX, maxY;
                minX = minY = float.MaxValue;//什么意思？
                maxX = maxY = float.MinValue;

                PointF[] points = new PointF[] { this.a, this.b, this.c };


                foreach (PointF point in points)
                {
                    if (minX > point.X) minX = point.X;
                    if (minY > point.Y) minY = point.Y;
                    if (maxX < point.X) maxX = point.X;
                    if (maxY < point.Y) maxY = point.Y;
                }
                frame.X = minX;
                frame.Y = minY;
                frame.Width = maxX - minX;
                frame.Height = maxY - minY;
                return frame;
            }
        }

        public override void FromString(string value)
        {
            string[] values = value.Split(';');
            this.color = Color.FromArgb(int.Parse(values[1]));
            this.dashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), values[2]);
            this.weight = float.Parse(values[3]);

            string[] pointValues = values[4].Split(',');
            this.a = new PointF(float.Parse(pointValues[0]), float.Parse(pointValues[1]));
            pointValues = values[5].Split(',');
            this.b = new PointF(float.Parse(pointValues[0]), float.Parse(pointValues[1]));
            pointValues = values[6].Split(',');
            this.c = new PointF(float.Parse(pointValues[0]), float.Parse(pointValues[1]));
        }

        public override string ToString()
        {//形状；颜色；线形；粗细
            string value = string.Format("三角形;{0};{1};{2};",
                this.color.ToArgb(),
                this.dashStyle.ToString(),
                this.weight);

            PointF[] pointFs = new PointF[] {this.a,this.b,this.c };

            foreach(var item in pointFs)
            {
                string pointValue = string.Format("{0},{1};",
                    item.X,
                    item.Y);
                value += pointValue;
            }
            value = value.Substring(0, value.Length - 1);
            return value;
        }

        public override void Draw(Graphics grp)
        {
            Pen pen = new Pen(this.color, this.weight);
            pen.DashStyle = this.dashStyle;
            PointF[] points =
            {
                this.a,this.b,this.c,this.a
            };
            grp.DrawLines(pen, points);

        }

        public override void ToXML(XmlWriter writer)
        {

        }

        public override void FromXML(XmlNode node)
        {

        }
    }
}
