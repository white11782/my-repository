namespace MyPaintBoard
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFile_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFile_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView_Toolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.btn_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tcboWeight = new System.Windows.Forms.ToolStripComboBox();
            this.tddlDashStyle = new System.Windows.Forms.ToolStripSplitButton();
            this.menuSolid = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDash = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDotDash = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDot = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDotDot = new System.Windows.Forms.ToolStripMenuItem();
            this.tddlColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblShape = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.编辑ToolStripMenuItem,
            this.menuView,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile_New,
            this.menuFile_Open,
            this.menuFile_Save,
            this.toolStripSeparator3,
            this.menuFile_Export,
            this.menuFile_Print,
            this.toolStripSeparator4,
            this.menuFile_SaveAs,
            this.menuFile_Exit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(53, 24);
            this.menuFile.Text = "文件";
            // 
            // menuFile_New
            // 
            this.menuFile_New.Name = "menuFile_New";
            this.menuFile_New.Size = new System.Drawing.Size(144, 26);
            this.menuFile_New.Text = "新建";
            this.menuFile_New.Click += new System.EventHandler(this.menuFile_New_Click);
            // 
            // menuFile_Open
            // 
            this.menuFile_Open.Name = "menuFile_Open";
            this.menuFile_Open.Size = new System.Drawing.Size(144, 26);
            this.menuFile_Open.Text = "打开";
            this.menuFile_Open.Click += new System.EventHandler(this.menuFile_Open_Click);
            // 
            // menuFile_Save
            // 
            this.menuFile_Save.Name = "menuFile_Save";
            this.menuFile_Save.Size = new System.Drawing.Size(144, 26);
            this.menuFile_Save.Text = "保存";
            this.menuFile_Save.Click += new System.EventHandler(this.menuFile_Save_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // menuFile_Export
            // 
            this.menuFile_Export.Name = "menuFile_Export";
            this.menuFile_Export.Size = new System.Drawing.Size(144, 26);
            this.menuFile_Export.Text = "导出(&O)";
            this.menuFile_Export.Click += new System.EventHandler(this.menuFile_Export_Click);
            // 
            // menuFile_Print
            // 
            this.menuFile_Print.Name = "menuFile_Print";
            this.menuFile_Print.Size = new System.Drawing.Size(144, 26);
            this.menuFile_Print.Text = "打印(&P)";
            this.menuFile_Print.Click += new System.EventHandler(this.menuFile_Print_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // menuFile_SaveAs
            // 
            this.menuFile_SaveAs.Name = "menuFile_SaveAs";
            this.menuFile_SaveAs.Size = new System.Drawing.Size(144, 26);
            this.menuFile_SaveAs.Text = "另存为";
            // 
            // menuFile_Exit
            // 
            this.menuFile_Exit.Name = "menuFile_Exit";
            this.menuFile_Exit.Size = new System.Drawing.Size(144, 26);
            this.menuFile_Exit.Text = "退出";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuView_Toolbar});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(53, 24);
            this.menuView.Text = "视图";
            // 
            // menuView_Toolbar
            // 
            this.menuView_Toolbar.Name = "menuView_Toolbar";
            this.menuView_Toolbar.Size = new System.Drawing.Size(137, 26);
            this.menuView_Toolbar.Text = "工具箱";
            this.menuView_Toolbar.Click += new System.EventHandler(this.menuView_Toolbar_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnNew,
            this.tbtnSave,
            this.btn_Print,
            this.btn_Open,
            this.toolStripSeparator1,
            this.tcboWeight,
            this.tddlDashStyle,
            this.tddlColor,
            this.toolStripSeparator2,
            this.lblShape});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnNew
            // 
            this.tbtnNew.AutoSize = false;
            this.tbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tbtnNew.Image")));
            this.tbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNew.Name = "tbtnNew";
            this.tbtnNew.Size = new System.Drawing.Size(25, 25);
            this.tbtnNew.Text = "新建";
            this.tbtnNew.Click += new System.EventHandler(this.menuFile_New_Click);
            // 
            // tbtnSave
            // 
            this.tbtnSave.AutoSize = false;
            this.tbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSave.Image")));
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(25, 25);
            this.tbtnSave.Text = "保存";
            this.tbtnSave.Click += new System.EventHandler(this.menuFile_Save_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(29, 29);
            this.btn_Print.Text = "打印";
            this.btn_Print.Click += new System.EventHandler(this.menuFile_Print_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Open.Image = ((System.Drawing.Image)(resources.GetObject("btn_Open.Image")));
            this.btn_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(29, 29);
            this.btn_Open.Text = "打开";
            this.btn_Open.Click += new System.EventHandler(this.menuFile_Open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // tcboWeight
            // 
            this.tcboWeight.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.tcboWeight.Name = "tcboWeight";
            this.tcboWeight.Size = new System.Drawing.Size(160, 32);
            this.tcboWeight.Text = "1";
            // 
            // tddlDashStyle
            // 
            this.tddlDashStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tddlDashStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSolid,
            this.menuDash,
            this.menuDotDash,
            this.menuDot,
            this.menuDotDot});
            this.tddlDashStyle.Image = ((System.Drawing.Image)(resources.GetObject("tddlDashStyle.Image")));
            this.tddlDashStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tddlDashStyle.Name = "tddlDashStyle";
            this.tddlDashStyle.Size = new System.Drawing.Size(58, 29);
            this.tddlDashStyle.Text = "实线";
            // 
            // menuSolid
            // 
            this.menuSolid.Name = "menuSolid";
            this.menuSolid.Size = new System.Drawing.Size(137, 26);
            this.menuSolid.Text = "实线";
            this.menuSolid.Click += new System.EventHandler(this.menuSolid_Click);
            // 
            // menuDash
            // 
            this.menuDash.Name = "menuDash";
            this.menuDash.Size = new System.Drawing.Size(137, 26);
            this.menuDash.Text = "点划线";
            this.menuDash.Click += new System.EventHandler(this.menuDash_Click);
            // 
            // menuDotDash
            // 
            this.menuDotDash.Name = "menuDotDash";
            this.menuDotDash.Size = new System.Drawing.Size(137, 26);
            this.menuDotDash.Text = "虚线";
            this.menuDotDash.Click += new System.EventHandler(this.menuDotDash_Click);
            // 
            // menuDot
            // 
            this.menuDot.Name = "menuDot";
            this.menuDot.Size = new System.Drawing.Size(137, 26);
            this.menuDot.Text = "点线";
            this.menuDot.Click += new System.EventHandler(this.menuDot_Click);
            // 
            // menuDotDot
            // 
            this.menuDotDot.Name = "menuDotDot";
            this.menuDotDot.Size = new System.Drawing.Size(137, 26);
            this.menuDotDot.Text = "点点线";
            this.menuDotDot.Click += new System.EventHandler(this.menuDotDot_Click);
            // 
            // tddlColor
            // 
            this.tddlColor.BackColor = System.Drawing.Color.Red;
            this.tddlColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tddlColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRed,
            this.menuGreen,
            this.menuBlue,
            this.menuGray,
            this.toolStripMenuItem1,
            this.menuColor});
            this.tddlColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tddlColor.Image = ((System.Drawing.Image)(resources.GetObject("tddlColor.Image")));
            this.tddlColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tddlColor.Name = "tddlColor";
            this.tddlColor.Size = new System.Drawing.Size(52, 29);
            this.tddlColor.Text = "Red";
            // 
            // menuRed
            // 
            this.menuRed.BackColor = System.Drawing.SystemColors.Control;
            this.menuRed.Name = "menuRed";
            this.menuRed.Size = new System.Drawing.Size(137, 26);
            this.menuRed.Text = "Red";
            this.menuRed.Click += new System.EventHandler(this.menuRed_Click);
            // 
            // menuGreen
            // 
            this.menuGreen.Name = "menuGreen";
            this.menuGreen.Size = new System.Drawing.Size(137, 26);
            this.menuGreen.Text = "Green";
            this.menuGreen.Click += new System.EventHandler(this.menuGreen_Click);
            // 
            // menuBlue
            // 
            this.menuBlue.Name = "menuBlue";
            this.menuBlue.Size = new System.Drawing.Size(137, 26);
            this.menuBlue.Text = "Blue";
            this.menuBlue.Click += new System.EventHandler(this.menuBlue_Click);
            // 
            // menuGray
            // 
            this.menuGray.Name = "menuGray";
            this.menuGray.Size = new System.Drawing.Size(137, 26);
            this.menuGray.Text = "Gray";
            this.menuGray.Click += new System.EventHandler(this.menuGray_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 6);
            // 
            // menuColor
            // 
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(137, 26);
            this.menuColor.Text = "自定义";
            this.menuColor.Click += new System.EventHandler(this.menuColor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // lblShape
            // 
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(24, 29);
            this.lblShape.Text = "点";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(144, 20);
            this.toolStripStatusLabel1.Text = "欢迎使用网络绘图板";
            // 
            // dockMain
            // 
            this.dockMain.ActiveAutoHideContent = null;
            this.dockMain.BackColor = System.Drawing.SystemColors.Control;
            this.dockMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockMain.Location = new System.Drawing.Point(0, 60);
            this.dockMain.Margin = new System.Windows.Forms.Padding(4);
            this.dockMain.Name = "dockMain";
            this.dockMain.Size = new System.Drawing.Size(1067, 476);
            this.dockMain.TabIndex = 4;
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Document = this.printDoc;
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dockMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "绘图板";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFile_New;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Open;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Save;
        private System.Windows.Forms.ToolStripMenuItem menuFile_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuView_Toolbar;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnNew;
        private System.Windows.Forms.ToolStripButton tbtnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tcboWeight;
        private System.Windows.Forms.ToolStripSplitButton tddlDashStyle;
        private System.Windows.Forms.ToolStripMenuItem menuSolid;
        private System.Windows.Forms.ToolStripMenuItem menuDash;
        private System.Windows.Forms.ToolStripMenuItem menuDotDash;
        private System.Windows.Forms.ToolStripMenuItem menuDot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblShape;
        private System.Windows.Forms.ToolStripDropDownButton tddlColor;
        private System.Windows.Forms.ToolStripMenuItem menuRed;
        private System.Windows.Forms.ToolStripMenuItem menuGreen;
        private System.Windows.Forms.ToolStripMenuItem menuBlue;
        private System.Windows.Forms.ToolStripMenuItem menuGray;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuColor;
        private System.Windows.Forms.ToolStripMenuItem menuDotDot;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Export;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_Open;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Print;
        private System.Windows.Forms.ToolStripButton btn_Print;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.Drawing.Printing.PrintDocument printDoc;
    }
}

