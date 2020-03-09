using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

namespace MyPaintBoard
{
    public partial class FormToolbar : DockContent
    {

        public FormMain FormMain = null;//创建一个新的主窗口吗？类和对象名字一样？

        private static FormToolbar instance = null;

        public static FormToolbar CreateInstance()
        {
            if (instance == null)
            {
                instance = new FormToolbar();
            }

            return instance;
        }

        private FormToolbar()
        {
            InitializeComponent();
        }

        private void FormToolbar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


        private void lblShape_Click(object sender, EventArgs e)
        {
            if (this.FormMain != null)
            {
                Label lblCurrent = (Label)sender;
                this.FormMain.CurrentShape = 
                    (ShapeCategory)Enum.Parse(typeof(ShapeCategory)
                    , lblCurrent.Text);//什么意思
            }
        }

        private void lblShape_MouseEnter(object sender,EventArgs e)
        {
            Label lblCurrent = (Label)sender;

            lblCurrent.BackColor = Color.Black;
            lblCurrent.ForeColor = Color.White;

        }

        private void lblShape_MouseLeave(object sender, EventArgs e)
        {
            Label lblCurrent = (Label)sender;

            lblCurrent.BackColor = SystemColors.Control;
            lblCurrent.ForeColor = Color.Black;
        }
    }
}
