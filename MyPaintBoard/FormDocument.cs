using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

using WeifenLuo.WinFormsUI.Docking;

namespace MyPaintBoard
{
    public partial class FormDocument : DockContent
    {
        private int mouseClientCount = 0;

        private PointF startPoint = PointF.Empty;

        public FormMain FormMain = null;

        private Document document = new Document();

        private BufferedGraphics bGrp = null;

        public FormDocument()
        {
            InitializeComponent();
        }

        private void DrawShapes()
        {
            this.bGrp.Graphics.Clear(this.BackColor);

            this.document.Draw(this.bGrp.Graphics);
            this.bGrp.Render();
        }

        public void PrintShapes(Graphics grp)
        {
            this.document.Draw(grp);
        }

        public void SaveDocument(string fileName)
        {
            string fileExtName = fileName.Substring(fileName.LastIndexOf(".")+1).ToUpper();
            if(fileExtName == "XML")
            {
                this.document.SaveToXML(fileName);
            }
            else
                this.document.Save(fileName);

        }

        public void OpenDocument(string fileName)
        {
            string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToUpper();
            if (fileExtName == "XML")
            {
                this.document.OpenFromXML(fileName);
            }
            else
            {
                this.document.Open(fileName);
            }               
            this.DrawShapes();
        }

        public Bitmap ExportToBitmap()
        {
            RectangleF frame = this.document.ShapeContainer;

            Bitmap bitmap = new Bitmap((int)frame.Width, (int)frame.Height);
            Graphics grp = Graphics.FromImage(bitmap);
            grp.Clear(Color.White);
            grp.TranslateTransform(-frame.Left, -frame.Top);
            this.document.Draw(grp);
            grp.TranslateTransform(frame.Left, frame.Top);
            grp.Dispose();
            return bitmap;

        }

        private void FormDocument_Load(object sender, EventArgs e)
        { 
            this.bGrp = BufferedGraphicsManager.Current.Allocate(this.CreateGraphics(),
                this.ClientRectangle);
        }

        private void FormDocument_Paint(object sender, PaintEventArgs e)
        {
            this.DrawShapes();
        }

        

        private void FormDocument_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (this.FormMain == null) return;

            ShapeCategory shapeCategory = this.FormMain.CurrentShape;

            switch (shapeCategory)
            {
                case ShapeCategory.点:
                    Dot dot = new Dot();
                    dot.Position = e.Location;
                    dot.Color = this.FormMain.CurrentColor;
                    dot.Weight = this.FormMain.CurrentWeight;
                    this.document.AddShape(dot);

                    break;
                case ShapeCategory.直线:
                    Line line = new Line();
                    line.StartPoint = e.Location;
                    line.EndPoint = e.Location;
                    line.Color = this.FormMain.CurrentColor;
                    line.Weight = this.FormMain.CurrentWeight;
                    line.DashStyle = this.FormMain.CurrentDashStyle;
                    this.document.AddShape(line);

                    break;
                case ShapeCategory.曲线:
                    Curve curve = new Curve();
                    curve.Color = this.FormMain.CurrentColor;
                    curve.DashStyle = this.FormMain.CurrentDashStyle;
                    curve.Weight = this.FormMain.CurrentWeight;
                    curve.Points.Add(e.Location);

                    this.document.AddShape(curve);
                    break;
                case ShapeCategory.圆:
                    Circle circle = new Circle();
                    circle.Color = this.FormMain.CurrentColor;
                    circle.DashStyle = this.FormMain.CurrentDashStyle;
                    circle.Weight = this.FormMain.CurrentWeight;
                    circle.CenterPoint = e.Location;
                    circle.MouseLocation = e.Location;
                    circle.Status = ShapeStatus.预览;

                    this.document.AddShape(circle);
                   
                    break;
                case ShapeCategory.矩形:
                    this.startPoint = e.Location;

                    MyRect myRect = new MyRect();//new一个Myrect（自定义的类）对象
                    myRect.Color = this.FormMain.CurrentColor;
                    myRect.DashStyle = this.FormMain.CurrentDashStyle;
                    myRect.Weight = this.FormMain.CurrentWeight;

                    RectangleF rectangleF = new RectangleF();//new一个RectangleF（系统定义的结构？）对象
                    rectangleF.X = e.Location.X;
                    rectangleF.Y = e.Location.Y;
                    rectangleF.Width = 0f;
                    rectangleF.Height = 0f;

                    myRect.RectF = rectangleF;//把
                    this.document.AddShape(myRect);
                    break;
                case ShapeCategory.三角形:
                    //int triangleCount = this.document.Triangles.Count;

                    int shapeCount = this.document.Shapes.Count;
                    switch (this.mouseClientCount)
                    {
                        case 0:
                            Triangle triangle = new Triangle();

                            triangle.Color = this.FormMain.CurrentColor;
                            triangle.DashStyle = this.FormMain.CurrentDashStyle;
                            triangle.Weight = this.FormMain.CurrentWeight;
                            triangle.A = triangle.B = triangle.C = e.Location;
                            this.document.AddShape(triangle);
                            break;
                        case 1:
                            if(shapeCount > 0)
                            {
                                Triangle lastTriangle = (Triangle)this.document.Shapes[shapeCount - 1];
                                lastTriangle.B = lastTriangle.C = e.Location;
                            }
                            break;
                        case 2:
                            if(shapeCount > 0)
                            {
                                Triangle lastTriangle = (Triangle)this.document.Shapes[shapeCount - 1];
                                lastTriangle.C = e.Location;
                            }
                            break;
                    }                                                                                                                   
                    break;
                case ShapeCategory.文字:
                    
                    MyText myText = new MyText();
                    myText.Color = this.FormMain.CurrentColor;
                    myText.Weight = this.FormMain.CurrentWeight * 10f;
                    myText.Position = e.Location;
                    this.document.AddShape(myText);

                    this.Controls.Clear();

                    TextBox textBox = new TextBox();
                    textBox.Multiline = true;
                    textBox.Location = e.Location;
                    textBox.Height = (int)(this.FormMain.CurrentWeight * 10 * 4f);
                    textBox.Width = 60 * textBox.Height;
                    textBox.Font = new Font("微软雅黑", myText.Weight);
                    textBox.TextChanged += textBox_TextChanged;//委托与事件

                    this.Controls.Add(textBox);
                    
                    break;
            }
            this.DrawShapes();
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            //int textCount = this.document.MyTexts.Count;
            int shapeCount = this.document.Shapes.Count;
            if (shapeCount > 0)
            {
                MyText lastText = (MyText)this.document.Shapes[shapeCount - 1];
                lastText.Text = ((TextBox)sender).Text;
            }
        }

        private void FormDocument_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            int shapeCount = this.document.Shapes.Count;
            switch (this.FormMain.CurrentShape)
            {
                case ShapeCategory.点:
                    break;
                case ShapeCategory.直线:
                    //int lineCount = this.document.Lines.Count;
                    
                    if (shapeCount > 0)
                    {
                        Line lastline = (Line)this.document.Shapes[shapeCount - 1];
                        lastline.EndPoint = e.Location;
                    }
                    break;
                case ShapeCategory.曲线:
      
                    if (shapeCount > 0)
                    {
                        Curve lastCurve = (Curve)this.document.Shapes[shapeCount - 1];
                        lastCurve.Points.Add(e.Location);
                    }
                    break;
                case ShapeCategory.圆:
         
                    if (shapeCount > 0)
                    {
                        Circle lastCircle = (Circle)this.document.Shapes[shapeCount - 1];
                        lastCircle.MouseLocation = e.Location;
                        lastCircle.Status = ShapeStatus.预览;
                        lastCircle.Radius = (float)Math.Sqrt(
                            Math.Pow(e.Location.X - lastCircle.CenterPoint.X, 2) +
                            Math.Pow(e.Location.Y - lastCircle.CenterPoint.Y, 2)
                            );
                    }
                    break;
                case ShapeCategory.矩形:
        
                    if (shapeCount > 0)
                    {
                        MyRect lastRectF = (MyRect)this.document.Shapes[shapeCount - 1];
                        RectangleF rectangleF = RectangleF.Empty;//赋值给rectangleF



                        rectangleF.X = (e.Location.X < startPoint.X) ? e.Location.X : startPoint.X;
                        rectangleF.Y = (e.Location.Y < startPoint.Y) ? e.Location.Y : startPoint.Y;

                        rectangleF.Width = Math.Abs(e.Location.X - startPoint.X);
                        rectangleF.Height = Math.Abs(e.Location.Y - startPoint.Y);

                        lastRectF.RectF = rectangleF;//这是什么意思？ 为什么又赋值回去
                    }
                    break;
                case ShapeCategory.三角形:
             
                    switch (this.mouseClientCount)
                    {
                        case 0:                           
                            break;
                        case 1:
                            if (shapeCount > 0)
                            {
                                Triangle lastTriangle = (Triangle)this.document.Shapes[shapeCount - 1];
                                lastTriangle.B = lastTriangle.C = e.Location;
                            }
                            break;
                        case 2:
                            if (shapeCount > 0)
                            {
                                Triangle lastTriangle = (Triangle)this.document.Shapes[shapeCount - 1];
                                lastTriangle.C = e.Location;
                            }
                            break;
                    }
                    break;
                case ShapeCategory.文字:
                    break;
            }
            this.DrawShapes();
        }

        private void FormDocument_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            int shapeCount = this.document.Shapes.Count;
            switch (this.FormMain.CurrentShape)
            {
                case ShapeCategory.点:
                    break;
                case ShapeCategory.直线:
                    //int lineCount = this.document.Lines.Count;

                    if (shapeCount > 0)
                    {
                        //Line lastline = this.document.Lines[lineCount - 1];
                        Line lastline = (Line)this.document.Shapes[shapeCount - 1];
                        lastline.EndPoint = e.Location;
                    }
                    break;
                case ShapeCategory.曲线:
                    break;
                case ShapeCategory.圆:
                    //int circleCount = this.document.Circles.Count;
                    if (shapeCount > 0)
                    {
                        Circle lastCircle = (Circle)this.document.Shapes[shapeCount - 1];
                        lastCircle.Status = ShapeStatus.正常;
                    }
                    break;
                case ShapeCategory.矩形:
                    
                    break;
                case ShapeCategory.三角形:
                    switch (this.mouseClientCount)
                    {
                        case 0:
                            this.mouseClientCount = 1;
                            break;
                        case 1:
                            this.mouseClientCount = 2;
                            break;
                        case 2:
                            //int triangleCount = this.document.Triangles.Count;
                            if (shapeCount > 0)
                            {
                                Triangle lastTriangle = (Triangle)this.document.Shapes[shapeCount - 1];
                                lastTriangle.C = e.Location;
                            }
                            this.mouseClientCount = 0;
                            break;
                    }
                    break;
                case ShapeCategory.文字:
                    break;
            }
            this.DrawShapes();
        }

        

        private void FormDocument_SizeChanged(object sender, EventArgs e)
        {
            if (this.ClientRectangle.Width == 0 || this.ClientRectangle.Height == 0) return;
            this.bGrp = BufferedGraphicsManager.Current.Allocate(this.CreateGraphics(),this.ClientRectangle);
        }
    }
}
