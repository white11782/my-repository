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
    public class Curve:Shape
    {
        private List<PointF> points = new List<PointF>();

        public List<PointF> Points { get => points; set => points = value; }

     public override RectangleF Frame
        {
            get
            {
                RectangleF frame = new RectangleF();

                float minX, minY, maxX, maxY;
                minX = minY = float.MaxValue;
                maxX = maxY = float.MinValue;
                foreach (PointF point in this.points)
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
            string[] values = value.Split(';');//这个是把value的字符串按分隔符拆分后然后赋给values数组吗？
            this.color = Color.FromArgb(int.Parse(values[1]));
            this.dashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), values[2]);
            this.weight = float.Parse(values[3]);

           
            for(int index = 4;index<values.Length;index++)
            {
                string[] pointValues = values[index].Split(',');
                PointF point = new PointF(float.Parse(pointValues[0]), float.Parse(pointValues[1]));
                this.points.Add(point);
            }
        }

        public override string ToString()
        {
            //形状；颜色；线形；粗细；点X，点Y；点X，点Y
            string value = string.Format("曲线;{0};{1};{2};",
                this.color.ToArgb(),
                this.dashStyle.ToString(),
                this.weight);
            foreach(var item in this.points)
            {
                string pointValue = string.Format("{0},{1};", item.X, item.Y);
                value += pointValue;
            }

            value = value.Substring(0, value.Length - 1);
            return value;

        }
        public override void Draw(Graphics grp)
        {
            Pen pen = new Pen(this.color);
            pen.Width = this.weight;
            pen.DashStyle = this.DashStyle;

            if (this.points.Count<2) return;

            PointF[] pointArray = this.points.ToArray();

            grp.DrawLines(pen, pointArray);
        }

        public override void ToXML(XmlWriter writer)
        {

        }

        public override void FromXML(XmlNode node)
        {

        }
    }
}
