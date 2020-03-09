using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Xml;

namespace MyPaintBoard
{
    public class Dot:Shape
    {
        private PointF position;
        public PointF Position
        {
            get { return position; }
            set { position = value; }
        } 
       
        public override RectangleF Frame
        {
            get
            {
                return new RectangleF(
                    this.position.X,
                    this.position.Y,
                    2 * this.weight,
                    2*this.weight
                    );
            }
        }

        public override void FromString(string value)
        {
            string[] values = value.Split(';');

            this.color = Color.FromArgb(int.Parse(values[1]));
            this.weight = float.Parse(values[2]);

            string[] pointValues = values[3].Split(',');

            this.position = new PointF(float.Parse(pointValues[0]), float.Parse(pointValues[1]));
        }

        public override string ToString()
        {
            //Circle：图形类型;颜色;线宽;圆心X,圆心Y
            string value = string.Format("点;{0};{1};{2},{3}",
                this.color.ToArgb(),
                this.weight,
                this.position.X,
                this.position.Y
                );
            return value;

        }

        public override void Draw(Graphics grp)
        {
            Brush brush = new SolidBrush(this.color);

            RectangleF rectF = new RectangleF();

            rectF.X = position.X - this.weight;
            rectF.Y = position.Y - this.weight;

            rectF.Width = 2 * this.weight;
            rectF.Height = 2 * this.weight;


            grp.FillEllipse(brush,rectF);

        }

        public override void ToXML(XmlWriter writer)
        {

        }

        public override void FromXML(XmlNode node)
        {

        }
    }
}
