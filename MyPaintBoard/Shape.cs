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
   public abstract class Shape
    {
        protected Color color;
        public Color Color { get => color; set => color = value; }

        protected DashStyle dashStyle = DashStyle.Solid;
        public DashStyle DashStyle { get => dashStyle; set => dashStyle = value; }

        protected float weight = 1f;
        public float Weight
        {
            get => weight; set => weight = value;
        }

        public abstract RectangleF Frame
        {
            get;
        }
        public abstract void Draw(Graphics grp);
        public abstract void FromXML(XmlNode node);
        public abstract void ToXML(XmlWriter writer);
        public abstract void FromString(String value);
    }
}
