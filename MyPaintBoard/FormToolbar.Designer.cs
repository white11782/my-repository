namespace MyPaintBoard
{
    partial class FormToolbar
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
            this.lblDot = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblCurve = new System.Windows.Forms.Label();
            this.lblCircle = new System.Windows.Forms.Label();
            this.lblRectangle = new System.Windows.Forms.Label();
            this.lblTriangle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDot
            // 
            this.lblDot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDot.Location = new System.Drawing.Point(0, 0);
            this.lblDot.Name = "lblDot";
            this.lblDot.Size = new System.Drawing.Size(222, 25);
            this.lblDot.TabIndex = 0;
            this.lblDot.Text = "点";
            this.lblDot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDot.Click += new System.EventHandler(this.lblShape_Click);
            this.lblDot.MouseEnter += new System.EventHandler(this.lblShape_MouseEnter);
            this.lblDot.MouseLeave += new System.EventHandler(this.lblShape_MouseLeave);
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLine.Location = new System.Drawing.Point(0, 25);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(222, 25);
            this.lblLine.TabIndex = 1;
            this.lblLine.Text = "直线";
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLine.Click += new System.EventHandler(this.lblShape_Click);
            this.lblLine.MouseEnter += new System.EventHandler(this.lblShape_MouseEnter);
            this.lblLine.MouseLeave += new System.EventHandler(this.lblShape_MouseLeave);
            // 
            // lblCurve
            // 
            this.lblCurve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCurve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurve.Location = new System.Drawing.Point(0, 50);
            this.lblCurve.Name = "lblCurve";
            this.lblCurve.Size = new System.Drawing.Size(222, 25);
            this.lblCurve.TabIndex = 2;
            this.lblCurve.Text = "曲线";
            this.lblCurve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurve.Click += new System.EventHandler(this.lblShape_Click);
            this.lblCurve.MouseEnter += new System.EventHandler(this.lblShape_MouseEnter);
            this.lblCurve.MouseLeave += new System.EventHandler(this.lblShape_MouseLeave);
            // 
            // lblCircle
            // 
            this.lblCircle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCircle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCircle.Location = new System.Drawing.Point(0, 75);
            this.lblCircle.Name = "lblCircle";
            this.lblCircle.Size = new System.Drawing.Size(222, 25);
            this.lblCircle.TabIndex = 3;
            this.lblCircle.Text = "圆";
            this.lblCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCircle.Click += new System.EventHandler(this.lblShape_Click);
            this.lblCircle.MouseEnter += new System.EventHandler(this.lblShape_MouseEnter);
            this.lblCircle.MouseLeave += new System.EventHandler(this.lblShape_MouseLeave);
            // 
            // lblRectangle
            // 
            this.lblRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRectangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRectangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRectangle.Location = new System.Drawing.Point(0, 100);
            this.lblRectangle.Name = "lblRectangle";
            this.lblRectangle.Size = new System.Drawing.Size(222, 25);
            this.lblRectangle.TabIndex = 4;
            this.lblRectangle.Text = "矩形";
            this.lblRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRectangle.Click += new System.EventHandler(this.lblShape_Click);
            this.lblRectangle.MouseEnter += new System.EventHandler(this.lblShape_MouseEnter);
            this.lblRectangle.MouseLeave += new System.EventHandler(this.lblShape_MouseLeave);
            // 
            // lblTriangle
            // 
            this.lblTriangle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTriangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTriangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTriangle.Location = new System.Drawing.Point(0, 125);
            this.lblTriangle.Name = "lblTriangle";
            this.lblTriangle.Size = new System.Drawing.Size(222, 25);
            this.lblTriangle.TabIndex = 5;
            this.lblTriangle.Text = "三角形";
            this.lblTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTriangle.Click += new System.EventHandler(this.lblShape_Click);
            this.lblTriangle.MouseEnter += new System.EventHandler(this.lblShape_MouseEnter);
            this.lblTriangle.MouseLeave += new System.EventHandler(this.lblShape_MouseLeave);
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblText.Location = new System.Drawing.Point(0, 150);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(222, 25);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "文字";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblText.Click += new System.EventHandler(this.lblShape_Click);
            this.lblText.MouseEnter += new System.EventHandler(this.lblShape_MouseEnter);
            this.lblText.MouseLeave += new System.EventHandler(this.lblShape_MouseLeave);
            // 
            // FormToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 450);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTriangle);
            this.Controls.Add(this.lblRectangle);
            this.Controls.Add(this.lblCircle);
            this.Controls.Add(this.lblCurve);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblDot);
            this.Name = "FormToolbar";
            this.TabText = "工具箱";
            this.Text = "工具箱";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormToolbar_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDot;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblCurve;
        private System.Windows.Forms.Label lblCircle;
        private System.Windows.Forms.Label lblRectangle;
        private System.Windows.Forms.Label lblTriangle;
        private System.Windows.Forms.Label lblText;
    }
}