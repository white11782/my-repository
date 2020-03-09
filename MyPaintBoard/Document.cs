using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml;

namespace MyPaintBoard
{
    public class Document
    {

        private List<Shape> shapes = new List<Shape>();
        public List<Shape> Shapes { get => shapes; }

        public void AddShape(Shape shape)
        {
            this.shapes.Add(shape);
        }

        public RectangleF ShapeContainer
        {
            get 
            {           
                float left, top, right, bottom;
                left = top = float.MaxValue;
                right = bottom = float.MinValue;
                foreach (var shape in this.shapes)
                {
                    if (left > shape.Frame.Left) left = shape.Frame.Left;
                    if (top > shape.Frame.Top) top = shape.Frame.Top;
                    if (right < shape.Frame.Right) right = shape.Frame.Right;
                    if (bottom < shape.Frame.Bottom) bottom = shape.Frame.Bottom;
                }
                return new RectangleF(left, top, right - left, bottom - top);
            }
        }

        public void Draw(Graphics grp)
        {
            grp.SmoothingMode = SmoothingMode.HighQuality;

            foreach (Shape shape in this.shapes)
            {
                shape.Draw(grp);
            }
        }
        public void Save(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Create);

            StreamWriter writer = new StreamWriter(stream);


            foreach (Shape shape in this.shapes)
            {
                writer.WriteLine(shape.ToString());
            }
            writer.Close();

            stream.Close();
        }

        public void Open(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);

            
            StreamReader reader = new StreamReader(stream);

            while(!reader.EndOfStream)
            {
                this.shapes.Add(ShapeFactory.CreateShape(reader.ReadLine()));
            }
            reader.Close();

            stream.Close();
        }

        public void SaveToXML(string fileName)
        {
            XmlWriter writer = XmlWriter.Create(fileName);

            writer.WriteStartDocument();
            writer.WriteStartElement("Shapes");

            foreach (Shape shape in this.shapes)
            {
                shape.ToXML(writer);               
            }
            writer.WriteEndElement();
            writer.Close();
        }

        public void OpenFromXML(String fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            XmlElement rootElement = doc.DocumentElement;
            foreach(XmlNode node in rootElement.ChildNodes)
            {
                this.shapes.Add(ShapeFactory.CreateShape(node));
            }
        }
    }
}
