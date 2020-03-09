using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyPaintBoard
{
    class ShapeFactory
    {
        public static Shape CreateShape(XmlNode node)
        {
            Shape shape = null;

            switch (node.Name)
            {
                case "Circle":
                    shape = new Circle();              
                    break;
                case "Dot":
                    shape = new Dot();
                    break;
                case "Triangle":
                    shape = new Triangle();
                    break;
                case "Rectangle":
                    shape = new MyRect();
                    break;
                case "Curve":
                    shape = new Curve();
                    break;
                case "Text":
                    shape = new MyText();
                    break;
                case "Line":
                    shape = new Line();
                    break;
            }
            shape.FromXML(node);
            return shape;
        }

        public static Shape CreateShape(string value)
        {
            Shape shape = null;
            string shapeCategory = value.Substring(0, value.IndexOf(";"));
            switch (shapeCategory)
            {
                case "圆":
                    shape = new Circle();
                    break;
                case "点":
                    shape = new Dot();
                    break;
                case "矩形":
                    shape = new MyRect();
                    break;
                case "直线":
                    shape = new Line();
                    break;
                case "三角形":
                    shape = new Triangle();
                    break;
                case "文字":
                    shape = new MyText();
                    break;
                case "曲线":
                    shape = new Curve();
                    break;
            } 
            shape.FromString(value);
            return shape;
        }
    }
}
