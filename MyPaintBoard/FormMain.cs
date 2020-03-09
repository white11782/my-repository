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
using System.Drawing.Imaging;

using WeifenLuo.WinFormsUI.Docking;

namespace MyPaintBoard
{
    public partial class FormMain : Form
    {

       

        public DashStyle CurrentDashStyle
        {
            get
            {
                DashStyle dashStyle = DashStyle.Solid;

                switch(this.tddlDashStyle.Text)
                {
                    case "实线":
                        dashStyle = DashStyle.Solid;
                        break;
                    case "点划线":
                        dashStyle = DashStyle.DashDot;
                        break;
                    case "虚线":
                        dashStyle = DashStyle.Dash;
                        break;
                    case "点线":
                        dashStyle = DashStyle.Dot;
                        break;
                    case "点点线":
                        dashStyle = DashStyle.DashDotDot;
                        break;
                }
                return dashStyle;
            }
        }

        public float CurrentWeight
        {
            get
            {
                return float.Parse(this.tcboWeight.Text);//将Parse括号中的类型转换为.之前的数据类型
            }
        }

        public Color CurrentColor
        {
            get
            {
                return this.tddlColor.BackColor;
            }
        }

        public ShapeCategory CurrentShape //枚举
        {
            get
            {
                ShapeCategory shapeCategory =  (ShapeCategory)Enum.Parse(typeof(ShapeCategory),this.lblShape.Text);
                return shapeCategory;
            }
            set
            {
                this.lblShape.Text = value.ToString();
            }
        }

        private FormToolbar frmToolbar = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void menuView_Toolbar_Click(object sender, EventArgs e)
        {

            if(frmToolbar!=null)
            {
                this.frmToolbar.Show();                
            }
            else
            {
                this.frmToolbar = FormToolbar.CreateInstance();
                this.frmToolbar.Show(this.dockMain, DockState.DockLeft);
                frmToolbar.FormMain = this;//什么意思？
                frmToolbar.FormMain = this;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.frmToolbar = FormToolbar.CreateInstance();
            this.frmToolbar.Show(this.dockMain, DockState.DockLeft);
            frmToolbar.FormMain = this;
        }

        private void menuFile_New_Click(object sender, EventArgs e)
        {
            FormDocument frmDocument = new FormDocument();
            frmDocument.Show(this.dockMain,DockState.Document);
            frmDocument.FormMain = this;
        }

        private void menuSolid_Click(object sender, EventArgs e)
        {
            this.tddlDashStyle.Text = "实线";
        }

        private void menuDash_Click(object sender, EventArgs e)
        {
            this.tddlDashStyle.Text = "点划线";
        }

        private void menuDotDash_Click(object sender, EventArgs e)
        {
            this.tddlDashStyle.Text = "虚线";
        }

        private void menuDot_Click(object sender, EventArgs e)
        {
            this.tddlDashStyle.Text = "点线";
        }

        private void menuDotDot_Click(object sender, EventArgs e)
        {
            this.tddlDashStyle.Text = "点点线";
        }

        private void menuRed_Click(object sender, EventArgs e)
        {
            this.tddlColor.Text = "Red";
            this.tddlColor.BackColor = Color.Red;
        }

        private void menuGreen_Click(object sender, EventArgs e)
        {
            this.tddlColor.Text = "Green";
            this.tddlColor.BackColor = Color.Green;
        }

        private void menuBlue_Click(object sender, EventArgs e)
        {
            this.tddlColor.Text = "Blue";
            this.tddlColor.BackColor = Color.Blue;
        }

        private void menuGray_Click(object sender, EventArgs e)
        {
            this.tddlColor.Text = "Gray";
            this.tddlColor.BackColor = Color.Gray;
        }

        private void menuColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if(colorDlg.ShowDialog()==DialogResult.OK)
            {
                Color color = colorDlg.Color;
                this.tddlColor.Text = string.Format("R:{0};G:{1};B:{2}"
                    , color.R, color.G, color.B);
                this.tddlColor.BackColor = color;
            }
        }

        private void menuFile_Save_Click(object sender, EventArgs e)
        {
            //As转换，如果转换失败，对象为空
            FormDocument activeDocument = this.ActiveMdiChild as FormDocument;
            if (activeDocument == null) return;


            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Net.10|*.net.10|XML文件|*.xml";

            if (saveDlg.ShowDialog() != DialogResult.OK) return;

            string fileName = saveDlg.FileName;
            activeDocument.SaveDocument(fileName);
        }

        private void menuFile_Export_Click(object sender, EventArgs e)
        {
            //As转换，如果转换失败，对象为空
            FormDocument activeDocument = this.ActiveMdiChild as FormDocument;
            if (activeDocument == null) return;


            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "位图|*.bmp|JPEG|*.jpg|PNG|*.png|GIF|*.gif";

            if (saveDlg.ShowDialog() != DialogResult.OK) return;

            string fileName = saveDlg.FileName;

            string extFileName = fileName.Substring(fileName.LastIndexOf(".") + 1);//这句话什么意思

            extFileName = extFileName.ToUpper();

            Bitmap bitmap = activeDocument.ExportToBitmap();


            switch (extFileName)
            {
                case "BMP":
                    bitmap.Save(fileName, ImageFormat.Bmp);
                    break;
                case "JPG":
                    bitmap.Save(fileName, ImageFormat.Jpeg);
                    break;
                case "PNG":
                    bitmap.Save(fileName, ImageFormat.Png);
                    break;
                case "GIF":
                    bitmap.Save(fileName, ImageFormat.Gif);
                    break;
            }
        }

        private void menuFile_Open_Click(object sender, EventArgs e)
        {
            FormDocument activeDocument = this.ActiveMdiChild as FormDocument;
            if (activeDocument == null)
            {
                activeDocument = new FormDocument();
                activeDocument.FormMain = this;
                activeDocument.Show(this.dockMain,DockState.Document);
                

            }

            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Net.10|*.net.10|XML文件|*.xml|所有文件|*.*";

            if (openDlg.ShowDialog() != DialogResult.OK) return;

            string fileName = openDlg.FileName;

            activeDocument.OpenDocument(fileName);
        }

        private void menuFile_Print_Click(object sender, EventArgs e)
        {
            FormDocument activeDocument = this.ActiveMdiChild as FormDocument;

            if (activeDocument == null) return;

            this.printPreview = new PrintPreviewDialog();
            this.printPreview.Document = this.printDoc;
            this.printPreview.ShowDialog();
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FormDocument activeDocument = this.ActiveMdiChild as FormDocument;

            if (activeDocument == null) return;
            activeDocument.PrintShapes(e.Graphics);
        }
    }
}
