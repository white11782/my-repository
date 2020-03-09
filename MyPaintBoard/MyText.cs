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
    public class MyText:Shape
    {
        private PointF position;

        private string text = "";
   
        public PointF Position { get => position; set => position = value; }
        public string Text { get => text; set => text = value; }

        public override RectangleF Frame
        {
            get
            {
                RectangleF frame = new RectangleF();
                frame.X = this.position.X;
                frame.Y = this.position.Y;
                frame.Width = this.Text.Length * this.weight;
                frame.Height = this.weight;
                return frame;
            }
        }

        public override void FromString(string value)
        {
            string[] values = value.Split(';');
            this.color = Color.FromArgb(int.Parse(values[1]));
            this.weight = float.Parse(values[2]);
            string[] pointValue = values[3].Split(',');

            this.position = new PointF(float.Parse(pointValue[0]), float.Parse(pointValue[1]));
            this.text = values[4];
        }

        public override string ToString()
        {
            string value = string.Format("文字;{0};{1};{2},{3};{4}",
                this.color.ToArgb(),
                this.weight,
                this.position.X,
                this.position.Y,
                this.text);

            return value;
        }

        public override void Draw(Graphics grp)
        {
            Font font = new Font("宋体", this.weight);

            grp.DrawString(this.text, font, new SolidBrush(this.color), position);
        }

        public override void ToXML(XmlWriter writer)
        {

        }

        public override void FromXML(XmlNode node)
        {

        }
    }
}
