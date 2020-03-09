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
    public class Circle:Shape
    {
        private ShapeStatus status = ShapeStatus.正常;

        private PointF centerPoint = PointF.Empty;

        private float radius = 0f;

        private PointF mouseLocation = PointF.Empty;

        public PointF CenterPoint { get => centerPoint; set => centerPoint = value; }
        public float Radius { get => radius; set => radius = value; }
        
        public ShapeStatus Status { get => status; set => status = value; }
        public PointF MouseLocation { get => mouseLocation; set => mouseLocation = value; }

        public override RectangleF Frame
        {
            get
            {
                return new RectangleF(
                    this.centerPoint.X-this.radius,
                    this.centerPoint.Y-this.radius,
                    2*this.radius,
                    2*this.radius);
            }
        }

        public override void FromString(string value)
        {
            string[] values = value.Split(';');//什么意思,用分割符初始化数组吗？

            this.color = Color.FromArgb(int.Parse(values[1]));//什么意思？
            this.dashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), values[2]);
            this.weight = float.Parse(values[3]);
            this.radius = float.Parse(values[4]);

            string[] pointValues = values[5].Split(',');
            this.centerPoint = new PointF(float.Parse(pointValues[0]), float.Parse(pointValues[1]));

        }

        public override string ToString()
        {
            //Circle：图形类型;颜色;线型;线宽;半径;圆心X,圆心Y
            string value = string.Format("圆;{0};{1};{2};{3};{4},{5}",
                this.color.ToArgb(),
                this.dashStyle.ToString(),
                this.weight,
                this.radius,
                this.centerPoint.X,
                this.centerPoint.Y);
            

            return value;
        }


        public override void Draw(Graphics grp)
        {
            Pen pen = new Pen(this.color, this.weight);
            pen.DashStyle = this.dashStyle;

            RectangleF rectF = new RectangleF();
            rectF.X = this.CenterPoint.X - this.radius;
            rectF.Y = this.CenterPoint.Y - this.radius;
            rectF.Width = rectF.Height = 2 * this.radius;

            switch(this.status)
            {
                case ShapeStatus.正常:
                    grp.DrawEllipse(pen, rectF);
                    break;
                case ShapeStatus.预览:
                    //绘制半径效果线
                    Pen previewPen = new Pen(Color.Blue, 0.5f);
                    previewPen.DashStyle = DashStyle.Dot;



                    //旋转

                    grp.TranslateTransform(centerPoint.X, centerPoint.Y);
                    float angle = (float)Math.Atan2(mouseLocation.Y - centerPoint.Y,
                        mouseLocation.X - centerPoint.X);


                    grp.RotateTransform((float)(angle * 180f / Math.PI));

                    PointF pointTemp = PointF.Empty;
                    //pointTemp.X = centerPoint.X + radius / 2;
                    //pointTemp.Y = centerPoint.Y + radius / 2;

                    //pointTemp.X = radius / 2;
                    //pointTemp.Y = radius / 2;

                    pointTemp.X = radius/2f;
                    pointTemp.Y = 0f;

                    grp.DrawString(radius.ToString(), new Font("宋体", 10f), Brushes.Red,
                        pointTemp);

                    //恢复
                    grp.RotateTransform(-(float)(angle * 180f / Math.PI));
                    grp.TranslateTransform(-centerPoint.X, -centerPoint.Y);


                    grp.DrawLine(previewPen, this.centerPoint, this.mouseLocation);
                    grp.DrawEllipse(pen, rectF);
                    break;
            }

            
        }

        public override void ToXML(XmlWriter writer)
        {
            writer.WriteStartElement("Circle");

            writer.WriteStartElement("CenterPoint");
            writer.WriteAttributeString("X", this.centerPoint.X.ToString());
            writer.WriteAttributeString("Y", this.centerPoint.Y.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Color");
            writer.WriteString(this.color.ToArgb().ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Radius");
            writer.WriteString(this.radius.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("DashStyle");
            writer.WriteString(this.dashStyle.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Weight");
            writer.WriteString(this.weight.ToString());
            writer.WriteEndElement();

            writer.WriteEndElement();


        }

        public override void FromXML(XmlNode node)
        {
            foreach (XmlNode nodeTemp in node.ChildNodes)
            {
                switch (nodeTemp.Name)
                {
                    case "CenterPoint":
                        this.centerPoint = new PointF();
                        this.centerPoint.X = float.Parse(nodeTemp.Attributes["X"].Value);
                        this.centerPoint.Y = float.Parse(nodeTemp.Attributes["Y"].Value);
                        break;
                    case "Color":
                        this.color = Color.FromArgb(int.Parse(nodeTemp.InnerText));
                        break;
                    case "Radius":
                        this.radius = float.Parse(nodeTemp.InnerText);
                        break;
                    case "DashStyle":
                        this.dashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), nodeTemp.InnerText);
                        break;
                    case "Weight":
                        this.weight = float.Parse(nodeTemp.InnerText);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
