namespace MyPaintBoard
{
    partial class FormDocument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 562);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDocument";
            this.TabText = "绘图";
            this.Text = "绘图";
            this.Load += new System.EventHandler(this.FormDocument_Load);
            this.SizeChanged += new System.EventHandler(this.FormDocument_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormDocument_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDocument_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDocument_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDocument_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}