namespace WarehouseManagementSystem1.PL
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.نسخهاحتياطيهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعادهالنسخهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعدادالاتصالبالسيرفرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهمنتجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارهمنتجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ادارهالاصنافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارهالعملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهبيعجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارهالمبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارهالموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارهالمشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المستخدمينToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهمستخدمToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارهالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsMenu,
            this.toolStripButton1,
            this.toolStripDropDownButton1,
            this.المبيعاتToolStripMenuItem,
            this.الموردينToolStripMenuItem,
            this.المشترياتToolStripMenuItem,
            this.المستخدمينToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(877, 38);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نسخهاحتياطيهToolStripMenuItem,
            this.استعادهالنسخهToolStripMenuItem,
            this.اعدادالاتصالبالسيرفرToolStripMenuItem,
            this.تسجيلخروجToolStripMenuItem});
            this.toolsMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(60, 34);
            this.toolsMenu.Text = "ملف";
            // 
            // نسخهاحتياطيهToolStripMenuItem
            // 
            this.نسخهاحتياطيهToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("نسخهاحتياطيهToolStripMenuItem.Image")));
            this.نسخهاحتياطيهToolStripMenuItem.Name = "نسخهاحتياطيهToolStripMenuItem";
            this.نسخهاحتياطيهToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.نسخهاحتياطيهToolStripMenuItem.Text = "عمل نسخه احتياطيه";
            this.نسخهاحتياطيهToolStripMenuItem.Click += new System.EventHandler(this.عملنسخهاحتياطيهToolStripMenuItem_Click);
            // 
            // استعادهالنسخهToolStripMenuItem
            // 
            this.استعادهالنسخهToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("استعادهالنسخهToolStripMenuItem.Image")));
            this.استعادهالنسخهToolStripMenuItem.Name = "استعادهالنسخهToolStripMenuItem";
            this.استعادهالنسخهToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.استعادهالنسخهToolStripMenuItem.Text = "استعاده النسخه الاحتياطيه";
            this.استعادهالنسخهToolStripMenuItem.Click += new System.EventHandler(this.استعادهالنسخهالاحتياطيهToolStripMenuItem_Click);
            // 
            // اعدادالاتصالبالسيرفرToolStripMenuItem
            // 
            this.اعدادالاتصالبالسيرفرToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("اعدادالاتصالبالسيرفرToolStripMenuItem.Image")));
            this.اعدادالاتصالبالسيرفرToolStripMenuItem.Name = "اعدادالاتصالبالسيرفرToolStripMenuItem";
            this.اعدادالاتصالبالسيرفرToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.اعدادالاتصالبالسيرفرToolStripMenuItem.Text = "اعداد الاتصال بالسيرفر";
            this.اعدادالاتصالبالسيرفرToolStripMenuItem.Click += new System.EventHandler(this.اعدادالاتصالبالسيرفرToolStripMenuItem_Click);
            // 
            // تسجيلخروجToolStripMenuItem
            // 
            this.تسجيلخروجToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تسجيلخروجToolStripMenuItem.Image")));
            this.تسجيلخروجToolStripMenuItem.Name = "تسجيلخروجToolStripMenuItem";
            this.تسجيلخروجToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.تسجيلخروجToolStripMenuItem.Text = "تسجيل خروج";
            this.تسجيلخروجToolStripMenuItem.Click += new System.EventHandler(this.تسجيلخروجToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهمنتجToolStripMenuItem,
            this.ادارهمنتجاتToolStripMenuItem,
            this.toolStripSeparator1,
            this.ادارهالاصنافToolStripMenuItem});
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 34);
            this.toolStripButton1.Text = "مخازن";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // اضافهمنتجToolStripMenuItem
            // 
            this.اضافهمنتجToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("اضافهمنتجToolStripMenuItem.Image")));
            this.اضافهمنتجToolStripMenuItem.Name = "اضافهمنتجToolStripMenuItem";
            this.اضافهمنتجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.اضافهمنتجToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.اضافهمنتجToolStripMenuItem.Text = "اضافه منتج";
            this.اضافهمنتجToolStripMenuItem.Click += new System.EventHandler(this.اضافهصنفToolStripMenuItem_Click);
            // 
            // ادارهمنتجاتToolStripMenuItem
            // 
            this.ادارهمنتجاتToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ادارهمنتجاتToolStripMenuItem.Image")));
            this.ادارهمنتجاتToolStripMenuItem.Name = "ادارهمنتجاتToolStripMenuItem";
            this.ادارهمنتجاتToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ادارهمنتجاتToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.ادارهمنتجاتToolStripMenuItem.Text = "اداره المنتجات";
            this.ادارهمنتجاتToolStripMenuItem.Click += new System.EventHandler(this.تعديلصنفToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // ادارهالاصنافToolStripMenuItem
            // 
            this.ادارهالاصنافToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ادارهالاصنافToolStripMenuItem.Image")));
            this.ادارهالاصنافToolStripMenuItem.Name = "ادارهالاصنافToolStripMenuItem";
            this.ادارهالاصنافToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.ادارهالاصنافToolStripMenuItem.Text = "اداره الاصناف";
            this.ادارهالاصنافToolStripMenuItem.Click += new System.EventHandler(this.ادارهالاصنافToolStripMenuItem_Click_1);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ادارهالعملاءToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(76, 34);
            this.toolStripDropDownButton1.Text = "العملاء";
            // 
            // ادارهالعملاءToolStripMenuItem
            // 
            this.ادارهالعملاءToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ادارهالعملاءToolStripMenuItem.Image")));
            this.ادارهالعملاءToolStripMenuItem.Name = "ادارهالعملاءToolStripMenuItem";
            this.ادارهالعملاءToolStripMenuItem.Size = new System.Drawing.Size(177, 30);
            this.ادارهالعملاءToolStripMenuItem.Text = "اداره العملاء";
            this.ادارهالعملاءToolStripMenuItem.Click += new System.EventHandler(this.ادارهالعملاءToolStripMenuItem_Click);
            // 
            // المبيعاتToolStripMenuItem
            // 
            this.المبيعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهبيعجديدToolStripMenuItem,
            this.ادارهالمبيعاتToolStripMenuItem});
            this.المبيعاتToolStripMenuItem.Name = "المبيعاتToolStripMenuItem";
            this.المبيعاتToolStripMenuItem.Size = new System.Drawing.Size(99, 34);
            this.المبيعاتToolStripMenuItem.Text = "المبيعات";
            // 
            // اضافهبيعجديدToolStripMenuItem
            // 
            this.اضافهبيعجديدToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("اضافهبيعجديدToolStripMenuItem.Image")));
            this.اضافهبيعجديدToolStripMenuItem.Name = "اضافهبيعجديدToolStripMenuItem";
            this.اضافهبيعجديدToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.اضافهبيعجديدToolStripMenuItem.Text = "اضافه بيع جديد";
            this.اضافهبيعجديدToolStripMenuItem.Click += new System.EventHandler(this.اضافهبيعجديدToolStripMenuItem_Click);
            // 
            // ادارهالمبيعاتToolStripMenuItem
            // 
            this.ادارهالمبيعاتToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ادارهالمبيعاتToolStripMenuItem.Image")));
            this.ادارهالمبيعاتToolStripMenuItem.Name = "ادارهالمبيعاتToolStripMenuItem";
            this.ادارهالمبيعاتToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.ادارهالمبيعاتToolStripMenuItem.Text = "اداره المبيعات";
            this.ادارهالمبيعاتToolStripMenuItem.Click += new System.EventHandler(this.ادارهالمبيعاتToolStripMenuItem_Click);
            // 
            // الموردينToolStripMenuItem
            // 
            this.الموردينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ادارهالموردينToolStripMenuItem});
            this.الموردينToolStripMenuItem.Name = "الموردينToolStripMenuItem";
            this.الموردينToolStripMenuItem.Size = new System.Drawing.Size(99, 34);
            this.الموردينToolStripMenuItem.Text = "الموردين";
            // 
            // ادارهالموردينToolStripMenuItem
            // 
            this.ادارهالموردينToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ادارهالموردينToolStripMenuItem.Image")));
            this.ادارهالموردينToolStripMenuItem.Name = "ادارهالموردينToolStripMenuItem";
            this.ادارهالموردينToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.ادارهالموردينToolStripMenuItem.Text = "اداره الموردين";
            this.ادارهالموردينToolStripMenuItem.Click += new System.EventHandler(this.ادارهالموردينToolStripMenuItem_Click);
            // 
            // المشترياتToolStripMenuItem
            // 
            this.المشترياتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اToolStripMenuItem,
            this.ادارهالمشترياتToolStripMenuItem});
            this.المشترياتToolStripMenuItem.Name = "المشترياتToolStripMenuItem";
            this.المشترياتToolStripMenuItem.Size = new System.Drawing.Size(116, 34);
            this.المشترياتToolStripMenuItem.Text = "المشتريات";
            // 
            // اToolStripMenuItem
            // 
            this.اToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("اToolStripMenuItem.Image")));
            this.اToolStripMenuItem.Name = "اToolStripMenuItem";
            this.اToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.اToolStripMenuItem.Text = "فاتوره شراء";
            this.اToolStripMenuItem.Click += new System.EventHandler(this.اToolStripMenuItem_Click);
            // 
            // ادارهالمشترياتToolStripMenuItem
            // 
            this.ادارهالمشترياتToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ادارهالمشترياتToolStripMenuItem.Image")));
            this.ادارهالمشترياتToolStripMenuItem.Name = "ادارهالمشترياتToolStripMenuItem";
            this.ادارهالمشترياتToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.ادارهالمشترياتToolStripMenuItem.Text = "اداره المشتريات";
            this.ادارهالمشترياتToolStripMenuItem.Click += new System.EventHandler(this.ادارهالمشترياتToolStripMenuItem_Click);
            // 
            // المستخدمينToolStripMenuItem1
            // 
            this.المستخدمينToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهمستخدمToolStripMenuItem1,
            this.ادارهالمستخدمينToolStripMenuItem});
            this.المستخدمينToolStripMenuItem1.Name = "المستخدمينToolStripMenuItem1";
            this.المستخدمينToolStripMenuItem1.Size = new System.Drawing.Size(130, 34);
            this.المستخدمينToolStripMenuItem1.Text = "المستخدمين";
            this.المستخدمينToolStripMenuItem1.Click += new System.EventHandler(this.المستخدمينToolStripMenuItem1_Click);
            // 
            // اضافهمستخدمToolStripMenuItem1
            // 
            this.اضافهمستخدمToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("اضافهمستخدمToolStripMenuItem1.Image")));
            this.اضافهمستخدمToolStripMenuItem1.Name = "اضافهمستخدمToolStripMenuItem1";
            this.اضافهمستخدمToolStripMenuItem1.Size = new System.Drawing.Size(236, 34);
            this.اضافهمستخدمToolStripMenuItem1.Text = "اضافه مستخدم";
            this.اضافهمستخدمToolStripMenuItem1.Click += new System.EventHandler(this.اضافهمستخدمToolStripMenuItem1_Click);
            // 
            // ادارهالمستخدمينToolStripMenuItem
            // 
            this.ادارهالمستخدمينToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ادارهالمستخدمينToolStripMenuItem.Image")));
            this.ادارهالمستخدمينToolStripMenuItem.Name = "ادارهالمستخدمينToolStripMenuItem";
            this.ادارهالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.ادارهالمستخدمينToolStripMenuItem.Text = "اداره المستخدمين";
            this.ادارهالمستخدمينToolStripMenuItem.Click += new System.EventHandler(this.ادارهالمستخدمينToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.reflectionLabel1);
            this.groupPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(0, 38);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPanel1.Size = new System.Drawing.Size(877, 361);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 23;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.Class = "";
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(487, 169);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reflectionLabel1.Size = new System.Drawing.Size(355, 70);
            this.reflectionLabel1.TabIndex = 25;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i></i><font color=\"#Bc2FFC\"> <u></u><u></u><font color=\"#000F" +
                "F00\"></font><font color=\"#1DDDDD\"></font>برنامج اداره المبيعات والمخازن</font></" +
                "font></b>";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 399);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اداره المخازن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem toolStripButton1;
        public System.Windows.Forms.ToolStripMenuItem toolStripDropDownButton1;
        public System.Windows.Forms.ToolStripMenuItem toolsMenu;
        public System.Windows.Forms.ToolStripMenuItem المبيعاتToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem نسخهاحتياطيهToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem استعادهالنسخهToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem اضافهمنتجToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ادارهمنتجاتToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem ادارهالعملاءToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem اضافهبيعجديدToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ادارهالمبيعاتToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem المستخدمينToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem تسجيلخروجToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem اضافهمستخدمToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem ادارهالمستخدمينToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.ToolStripMenuItem الموردينToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ادارهالموردينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem المشترياتToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ادارهالاصنافToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ادارهالمشترياتToolStripMenuItem;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.ToolStripMenuItem اعدادالاتصالبالسيرفرToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;


    }
}