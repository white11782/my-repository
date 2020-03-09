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
    public class Line:Shape
    {
        private PointF startPoint = Point.Empty;

        private PointF endPoint = PointF.Empty;
    
        public PointF StartPoint { get => startPoint; set => startPoint = value; }
        public PointF EndPoint { get => endPoint; set => endPoint = value; }

        public override RectangleF Frame
        {
            get
            {
                RectangleF frame = new RectangleF();

                float minX, minY, maxX, maxY;
                minX = minY = float.MaxValue;
                maxX = maxY = float.MinValue;

                PointF[]points= new PointF[] { this.startPoint, this.endPoint };

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
            //下面的代码段是什么意思
            string[] pointValues = values[4].Split(',');
            this.startPoint = new PointF(float.Parse(pointValues[0]), float.Parse(pointValues[1]));
            pointValues = values[5].Split(',');
            this.endPoint = new PointF(float.Parse(pointValues[0]), float.Parse(pointValues[1]));
        }

        public override string ToString()
        {
            string value = string.Format("直线;{0};{1};{2};",
                this.color.ToArgb(),
                this.dashStyle.ToString(),
                this.weight
                );

            PointF[] pointFs = new PointF[] { this.startPoint, this.endPoint };

            foreach(var item in pointFs)
            {
                string pointValue = string.Format("{0},{1};",
                    item.X,
                    item.Y);
                value += pointValue;
            }

            value = value.Substring(0, value.Length-1);
            return value;
        }

        public override void Draw(Graphics grp)
        {
            Pen pen = new Pen(Color);

            pen.Width = this.Weight;
                
            pen.DashStyle = DashStyle;

            grp.DrawLine(pen, StartPoint, EndPoint);
        }

        public override void ToXML(XmlWriter writer)
        {

        }

        public override void FromXML(XmlNode node)
        {

        }
    }
}
