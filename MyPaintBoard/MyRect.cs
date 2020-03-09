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
    public class MyRect:Shape
    {
        private RectangleF rectF = RectangleF.Empty;
        public RectangleF RectF { get => rectF; set => rectF = value; }

        public override RectangleF Frame
        {
            get
            {
                return this.rectF;
            }
        }

        public override void FromString(string value)
        {
            string[] values = value.Split(';');
            this.color = Color.FromArgb(int.Parse(values[1]));
            this.dashStyle = (DashStyle)Enum.Parse(typeof(DashStyle),values[2]);
            this.weight = float.Parse(values[3]);

            this.rectF = new RectangleF();
            rectF.X = float.Parse(values[4]);
            rectF.Y = float.Parse(values[5]);
            rectF.Width = float.Parse(values[6]);
            rectF.Height = float.Parse(values[7]);
        }

        public override string ToString()
        {
            //矩形；颜色；线形；粗细
            string value = string.Format("矩形;{0};{1};{2};",
                this.color.ToArgb(),
                this.dashStyle.ToString(),
                this.weight);

            value += string.Format("{0};{1};", this.rectF.X, this.rectF.Y);
            value += string.Format("{0};{1}", this.rectF.Width, this.rectF.Height);
            return value;
        }

        public override void Draw(Graphics grp)
        {
            Pen pen = new Pen(this.color);
            pen.DashStyle = dashStyle;
            pen.Width = this.weight;
            grp.DrawRectangle(pen,this.rectF.X,this.rectF.Y,this.RectF.Width,this.RectF.Height);
        }

        public override void ToXML(XmlWriter writer)
        {

        }

        public override void FromXML(XmlNode node)
        {

        }



    }
}
