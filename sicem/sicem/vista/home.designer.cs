namespace sicem
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.navbar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inicioTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inventarioTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.productosTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reportesTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.administrarTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.directorioTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.OperacionesTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topNavbar = new System.Windows.Forms.Panel();
            this.closemenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logout = new Bunifu.Framework.UI.BunifuImageButton();
            this.userPictureNavbar = new System.Windows.Forms.PictureBox();
            this.nameUser = new System.Windows.Forms.Label();
            this.idUsuario = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.contenedor = new System.Windows.Forms.Panel();
            this.contentMenuMore = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Label();
            this.cerrarsesion = new System.Windows.Forms.Label();
            this.configuraperfil = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.moreMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.viewTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.navbar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.topNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closemenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureNavbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.contenedor.SuspendLayout();
            this.contentMenuMore.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moreMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.navbar.Controls.Add(this.panel3);
            this.navbar.Controls.Add(this.topNavbar);
            this.viewTransition.SetDecoration(this.navbar, BunifuAnimatorNS.DecorationType.None);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(232, 590);
            this.navbar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.inicioTab);
            this.panel3.Controls.Add(this.inventarioTab);
            this.panel3.Controls.Add(this.productosTab);
            this.panel3.Controls.Add(this.reportesTab);
            this.panel3.Controls.Add(this.administrarTab);
            this.panel3.Controls.Add(this.directorioTab);
            this.panel3.Controls.Add(this.OperacionesTab);
            this.viewTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 435);
            this.panel3.TabIndex = 1;
            // 
            // inicioTab
            // 
            this.inicioTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.inicioTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.inicioTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inicioTab.BorderRadius = 0;
            this.inicioTab.ButtonText = "  Inicio";
            this.inicioTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.inicioTab, BunifuAnimatorNS.DecorationType.None);
            this.inicioTab.DisabledColor = System.Drawing.Color.Gray;
            this.inicioTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioTab.Iconcolor = System.Drawing.Color.Transparent;
            this.inicioTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("inicioTab.Iconimage")));
            this.inicioTab.Iconimage_right = null;
            this.inicioTab.Iconimage_right_Selected = null;
            this.inicioTab.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("inicioTab.Iconimage_Selected")));
            this.inicioTab.IconMarginLeft = 0;
            this.inicioTab.IconMarginRight = 0;
            this.inicioTab.IconRightVisible = true;
            this.inicioTab.IconRightZoom = 0D;
            this.inicioTab.IconVisible = true;
            this.inicioTab.IconZoom = 57D;
            this.inicioTab.IsTab = true;
            this.inicioTab.Location = new System.Drawing.Point(0, 7);
            this.inicioTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inicioTab.Name = "inicioTab";
            this.inicioTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inicioTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.inicioTab.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.inicioTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inicioTab.selected = true;
            this.inicioTab.Size = new System.Drawing.Size(230, 40);
            this.inicioTab.TabIndex = 8;
            this.inicioTab.Text = "  Inicio";
            this.inicioTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicioTab.Textcolor = System.Drawing.Color.RoyalBlue;
            this.inicioTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioTab.Click += new System.EventHandler(this.inicioTab_Click);
            // 
            // inventarioTab
            // 
            this.inventarioTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.inventarioTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inventarioTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventarioTab.BorderRadius = 0;
            this.inventarioTab.ButtonText = "  Inventario";
            this.inventarioTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.inventarioTab, BunifuAnimatorNS.DecorationType.None);
            this.inventarioTab.DisabledColor = System.Drawing.Color.Gray;
            this.inventarioTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioTab.Iconcolor = System.Drawing.Color.Transparent;
            this.inventarioTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("inventarioTab.Iconimage")));
            this.inventarioTab.Iconimage_right = null;
            this.inventarioTab.Iconimage_right_Selected = null;
            this.inventarioTab.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("inventarioTab.Iconimage_Selected")));
            this.inventarioTab.IconMarginLeft = 0;
            this.inventarioTab.IconMarginRight = 0;
            this.inventarioTab.IconRightVisible = true;
            this.inventarioTab.IconRightZoom = 0D;
            this.inventarioTab.IconVisible = true;
            this.inventarioTab.IconZoom = 57D;
            this.inventarioTab.IsTab = true;
            this.inventarioTab.Location = new System.Drawing.Point(0, 175);
            this.inventarioTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inventarioTab.Name = "inventarioTab";
            this.inventarioTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.inventarioTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.inventarioTab.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.inventarioTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inventarioTab.selected = false;
            this.inventarioTab.Size = new System.Drawing.Size(230, 40);
            this.inventarioTab.TabIndex = 3;
            this.inventarioTab.Text = "  Inventario";
            this.inventarioTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventarioTab.Textcolor = System.Drawing.Color.RoyalBlue;
            this.inventarioTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioTab.Click += new System.EventHandler(this.inventarioTab_Click);
            // 
            // productosTab
            // 
            this.productosTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.productosTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.productosTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productosTab.BorderRadius = 0;
            this.productosTab.ButtonText = "  Productos";
            this.productosTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.productosTab, BunifuAnimatorNS.DecorationType.None);
            this.productosTab.DisabledColor = System.Drawing.Color.Gray;
            this.productosTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosTab.Iconcolor = System.Drawing.Color.Transparent;
            this.productosTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("productosTab.Iconimage")));
            this.productosTab.Iconimage_right = null;
            this.productosTab.Iconimage_right_Selected = null;
            this.productosTab.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("productosTab.Iconimage_Selected")));
            this.productosTab.IconMarginLeft = 0;
            this.productosTab.IconMarginRight = 0;
            this.productosTab.IconRightVisible = true;
            this.productosTab.IconRightZoom = 0D;
            this.productosTab.IconVisible = true;
            this.productosTab.IconZoom = 57D;
            this.productosTab.IsTab = true;
            this.productosTab.Location = new System.Drawing.Point(0, 133);
            this.productosTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productosTab.Name = "productosTab";
            this.productosTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.productosTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.productosTab.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.productosTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productosTab.selected = false;
            this.productosTab.Size = new System.Drawing.Size(230, 40);
            this.productosTab.TabIndex = 2;
            this.productosTab.Text = "  Productos";
            this.productosTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productosTab.Textcolor = System.Drawing.Color.RoyalBlue;
            this.productosTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosTab.Click += new System.EventHandler(this.productosTab_Click);
            // 
            // reportesTab
            // 
            this.reportesTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.reportesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.reportesTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportesTab.BorderRadius = 0;
            this.reportesTab.ButtonText = "  Reportes";
            this.reportesTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.reportesTab, BunifuAnimatorNS.DecorationType.None);
            this.reportesTab.DisabledColor = System.Drawing.Color.Gray;
            this.reportesTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesTab.Iconcolor = System.Drawing.Color.Transparent;
            this.reportesTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("reportesTab.Iconimage")));
            this.reportesTab.Iconimage_right = null;
            this.reportesTab.Iconimage_right_Selected = null;
            this.reportesTab.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("reportesTab.Iconimage_Selected")));
            this.reportesTab.IconMarginLeft = 0;
            this.reportesTab.IconMarginRight = 0;
            this.reportesTab.IconRightVisible = true;
            this.reportesTab.IconRightZoom = 0D;
            this.reportesTab.IconVisible = true;
            this.reportesTab.IconZoom = 57D;
            this.reportesTab.IsTab = true;
            this.reportesTab.Location = new System.Drawing.Point(0, 217);
            this.reportesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportesTab.Name = "reportesTab";
            this.reportesTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.reportesTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.reportesTab.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.reportesTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportesTab.selected = false;
            this.reportesTab.Size = new System.Drawing.Size(230, 40);
            this.reportesTab.TabIndex = 7;
            this.reportesTab.Text = "  Reportes";
            this.reportesTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportesTab.Textcolor = System.Drawing.Color.RoyalBlue;
            this.reportesTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesTab.Click += new System.EventHandler(this.proveedorTab_Click);
            // 
            // administrarTab
            // 
            this.administrarTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.administrarTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.administrarTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.administrarTab.BorderRadius = 0;
            this.administrarTab.ButtonText = "  Administración";
            this.administrarTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.administrarTab, BunifuAnimatorNS.DecorationType.None);
            this.administrarTab.DisabledColor = System.Drawing.Color.Gray;
            this.administrarTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarTab.Iconcolor = System.Drawing.Color.Transparent;
            this.administrarTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("administrarTab.Iconimage")));
            this.administrarTab.Iconimage_right = null;
            this.administrarTab.Iconimage_right_Selected = null;
            this.administrarTab.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("administrarTab.Iconimage_Selected")));
            this.administrarTab.IconMarginLeft = 0;
            this.administrarTab.IconMarginRight = 0;
            this.administrarTab.IconRightVisible = true;
            this.administrarTab.IconRightZoom = 0D;
            this.administrarTab.IconVisible = true;
            this.administrarTab.IconZoom = 57D;
            this.administrarTab.IsTab = true;
            this.administrarTab.Location = new System.Drawing.Point(0, 259);
            this.administrarTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.administrarTab.Name = "administrarTab";
            this.administrarTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.administrarTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.administrarTab.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.administrarTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.administrarTab.selected = false;
            this.administrarTab.Size = new System.Drawing.Size(230, 40);
            this.administrarTab.TabIndex = 6;
            this.administrarTab.Text = "  Administración";
            this.administrarTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.administrarTab.Textcolor = System.Drawing.Color.RoyalBlue;
            this.administrarTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarTab.Click += new System.EventHandler(this.administrarTab_Click);
            // 
            // directorioTab
            // 
            this.directorioTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.directorioTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.directorioTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.directorioTab.BorderRadius = 0;
            this.directorioTab.ButtonText = "  Directorio";
            this.directorioTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.directorioTab, BunifuAnimatorNS.DecorationType.None);
            this.directorioTab.DisabledColor = System.Drawing.Color.Gray;
            this.directorioTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorioTab.Iconcolor = System.Drawing.Color.Transparent;
            this.directorioTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("directorioTab.Iconimage")));
            this.directorioTab.Iconimage_right = null;
            this.directorioTab.Iconimage_right_Selected = null;
            this.directorioTab.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("directorioTab.Iconimage_Selected")));
            this.directorioTab.IconMarginLeft = 0;
            this.directorioTab.IconMarginRight = 0;
            this.directorioTab.IconRightVisible = true;
            this.directorioTab.IconRightZoom = 0D;
            this.directorioTab.IconVisible = true;
            this.directorioTab.IconZoom = 57D;
            this.directorioTab.IsTab = true;
            this.directorioTab.Location = new System.Drawing.Point(-2, 49);
            this.directorioTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.directorioTab.Name = "directorioTab";
            this.directorioTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.directorioTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.directorioTab.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.directorioTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.directorioTab.selected = false;
            this.directorioTab.Size = new System.Drawing.Size(230, 40);
            this.directorioTab.TabIndex = 4;
            this.directorioTab.Text = "  Directorio";
            this.directorioTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.directorioTab.Textcolor = System.Drawing.Color.RoyalBlue;
            this.directorioTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorioTab.Click += new System.EventHandler(this.directorioTab_Click);
            // 
            // OperacionesTab
            // 
            this.OperacionesTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.OperacionesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.OperacionesTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OperacionesTab.BorderRadius = 0;
            this.OperacionesTab.ButtonText = " Operaciones";
            this.OperacionesTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.OperacionesTab, BunifuAnimatorNS.DecorationType.None);
            this.OperacionesTab.DisabledColor = System.Drawing.Color.Gray;
            this.OperacionesTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperacionesTab.Iconcolor = System.Drawing.Color.Transparent;
            this.OperacionesTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("OperacionesTab.Iconimage")));
            this.OperacionesTab.Iconimage_right = null;
            this.OperacionesTab.Iconimage_right_Selected = null;
            this.OperacionesTab.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("OperacionesTab.Iconimage_Selected")));
            this.OperacionesTab.IconMarginLeft = 0;
            this.OperacionesTab.IconMarginRight = 0;
            this.OperacionesTab.IconRightVisible = true;
            this.OperacionesTab.IconRightZoom = 0D;
            this.OperacionesTab.IconVisible = true;
            this.OperacionesTab.IconZoom = 57D;
            this.OperacionesTab.IsTab = true;
            this.OperacionesTab.Location = new System.Drawing.Point(0, 91);
            this.OperacionesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OperacionesTab.Name = "OperacionesTab";
            this.OperacionesTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.OperacionesTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.OperacionesTab.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.OperacionesTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OperacionesTab.selected = false;
            this.OperacionesTab.Size = new System.Drawing.Size(230, 40);
            this.OperacionesTab.TabIndex = 2;
            this.OperacionesTab.Text = " Operaciones";
            this.OperacionesTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OperacionesTab.Textcolor = System.Drawing.Color.RoyalBlue;
            this.OperacionesTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperacionesTab.Click += new System.EventHandler(this.OperacionesTab_Click);
            // 
            // topNavbar
            // 
            this.topNavbar.Controls.Add(this.closemenu);
            this.topNavbar.Controls.Add(this.logout);
            this.topNavbar.Controls.Add(this.userPictureNavbar);
            this.topNavbar.Controls.Add(this.nameUser);
            this.topNavbar.Controls.Add(this.idUsuario);
            this.viewTransition.SetDecoration(this.topNavbar, BunifuAnimatorNS.DecorationType.None);
            this.topNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topNavbar.Location = new System.Drawing.Point(0, 0);
            this.topNavbar.Name = "topNavbar";
            this.topNavbar.Size = new System.Drawing.Size(232, 155);
            this.topNavbar.TabIndex = 0;
            // 
            // closemenu
            // 
            this.closemenu.BackColor = System.Drawing.Color.Transparent;
            this.closemenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.closemenu, BunifuAnimatorNS.DecorationType.None);
            this.closemenu.Image = ((System.Drawing.Image)(resources.GetObject("closemenu.Image")));
            this.closemenu.ImageActive = ((System.Drawing.Image)(resources.GetObject("closemenu.ImageActive")));
            this.closemenu.Location = new System.Drawing.Point(203, 6);
            this.closemenu.Name = "closemenu";
            this.closemenu.Size = new System.Drawing.Size(25, 25);
            this.closemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closemenu.TabIndex = 3;
            this.closemenu.TabStop = false;
            this.closemenu.Zoom = 7;
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.viewTransition.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageActive = ((System.Drawing.Image)(resources.GetObject("logout.ImageActive")));
            this.logout.Location = new System.Drawing.Point(206, 37);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(22, 22);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 5;
            this.logout.TabStop = false;
            this.logout.Zoom = 6;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // userPictureNavbar
            // 
            this.userPictureNavbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.userPictureNavbar, BunifuAnimatorNS.DecorationType.None);
            this.userPictureNavbar.Image = ((System.Drawing.Image)(resources.GetObject("userPictureNavbar.Image")));
            this.userPictureNavbar.Location = new System.Drawing.Point(77, 20);
            this.userPictureNavbar.Name = "userPictureNavbar";
            this.userPictureNavbar.Size = new System.Drawing.Size(75, 75);
            this.userPictureNavbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureNavbar.TabIndex = 3;
            this.userPictureNavbar.TabStop = false;
            // 
            // nameUser
            // 
            this.nameUser.BackColor = System.Drawing.Color.Transparent;
            this.viewTransition.SetDecoration(this.nameUser, BunifuAnimatorNS.DecorationType.None);
            this.nameUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.nameUser.Location = new System.Drawing.Point(1, 98);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(230, 25);
            this.nameUser.TabIndex = 6;
            this.nameUser.Text = "Nombre Usuario";
            this.nameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idUsuario
            // 
            this.viewTransition.SetDecoration(this.idUsuario, BunifuAnimatorNS.DecorationType.None);
            this.idUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuario.ForeColor = System.Drawing.Color.RoyalBlue;
            this.idUsuario.Location = new System.Drawing.Point(1, 123);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(230, 20);
            this.idUsuario.TabIndex = 4;
            this.idUsuario.Text = "ID Usuario";
            this.idUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPicture
            // 
            this.userPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewTransition.SetDecoration(this.userPicture, BunifuAnimatorNS.DecorationType.None);
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(911, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(50, 50);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 2;
            this.userPicture.TabStop = false;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.contenedor.Controls.Add(this.contentMenuMore);
            this.viewTransition.SetDecoration(this.contenedor, BunifuAnimatorNS.DecorationType.None);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.contenedor.Location = new System.Drawing.Point(40, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(950, 590);
            this.contenedor.TabIndex = 2;
            // 
            // contentMenuMore
            // 
            this.contentMenuMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.contentMenuMore.Controls.Add(this.salir);
            this.contentMenuMore.Controls.Add(this.cerrarsesion);
            this.contentMenuMore.Controls.Add(this.configuraperfil);
            this.viewTransition.SetDecoration(this.contentMenuMore, BunifuAnimatorNS.DecorationType.None);
            this.contentMenuMore.Location = new System.Drawing.Point(732, 37);
            this.contentMenuMore.Name = "contentMenuMore";
            this.contentMenuMore.Size = new System.Drawing.Size(130, 85);
            this.contentMenuMore.TabIndex = 0;
            // 
            // salir
            // 
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.salir, BunifuAnimatorNS.DecorationType.None);
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.salir.Location = new System.Drawing.Point(0, 54);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(130, 25);
            this.salir.TabIndex = 2;
            this.salir.Text = "Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cerrarsesion
            // 
            this.cerrarsesion.BackColor = System.Drawing.Color.Transparent;
            this.cerrarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.cerrarsesion, BunifuAnimatorNS.DecorationType.None);
            this.cerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cerrarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarsesion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cerrarsesion.Location = new System.Drawing.Point(0, 27);
            this.cerrarsesion.Name = "cerrarsesion";
            this.cerrarsesion.Size = new System.Drawing.Size(130, 25);
            this.cerrarsesion.TabIndex = 1;
            this.cerrarsesion.Text = "Cerrar sesión";
            this.cerrarsesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // configuraperfil
            // 
            this.configuraperfil.BackColor = System.Drawing.Color.Transparent;
            this.configuraperfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.configuraperfil, BunifuAnimatorNS.DecorationType.None);
            this.configuraperfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configuraperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraperfil.ForeColor = System.Drawing.Color.RoyalBlue;
            this.configuraperfil.Location = new System.Drawing.Point(0, 0);
            this.configuraperfil.Name = "configuraperfil";
            this.configuraperfil.Size = new System.Drawing.Size(130, 25);
            this.configuraperfil.TabIndex = 0;
            this.configuraperfil.Text = "Configurar perfil";
            this.configuraperfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(185)))));
            this.toppanel.Controls.Add(this.userPicture);
            this.toppanel.Controls.Add(this.moreMenu);
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Controls.Add(this.menu);
            this.viewTransition.SetDecoration(this.toppanel, BunifuAnimatorNS.DecorationType.None);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(990, 56);
            this.toppanel.TabIndex = 3;
            // 
            // moreMenu
            // 
            this.moreMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moreMenu.BackColor = System.Drawing.Color.Transparent;
            this.moreMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.moreMenu, BunifuAnimatorNS.DecorationType.None);
            this.moreMenu.Image = ((System.Drawing.Image)(resources.GetObject("moreMenu.Image")));
            this.moreMenu.ImageActive = ((System.Drawing.Image)(resources.GetObject("moreMenu.ImageActive")));
            this.moreMenu.Location = new System.Drawing.Point(962, 3);
            this.moreMenu.Name = "moreMenu";
            this.moreMenu.Size = new System.Drawing.Size(25, 48);
            this.moreMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moreMenu.TabIndex = 4;
            this.moreMenu.TabStop = false;
            this.moreMenu.Zoom = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.viewTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(57, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "SICEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageActive = ((System.Drawing.Image)(resources.GetObject("menu.ImageActive")));
            this.menu.Location = new System.Drawing.Point(6, 6);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(45, 45);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 2;
            this.menu.TabStop = false;
            this.menu.Zoom = 5;
            // 
            // viewTransition
            // 
            this.viewTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.viewTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.viewTransition.DefaultAnimation = animation1;
            this.viewTransition.MaxAnimationTime = 750;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.navbar);
            this.panel1.Controls.Add(this.contenedor);
            this.viewTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 590);
            this.panel1.TabIndex = 4;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toppanel);
            this.viewTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.navbar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.topNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closemenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureNavbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.contenedor.ResumeLayout(false);
            this.contentMenuMore.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moreMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private Bunifu.Framework.UI.BunifuFlatButton OperacionesTab;
        private Bunifu.Framework.UI.BunifuFlatButton productosTab;
        private System.Windows.Forms.PictureBox userPicture;
        private Bunifu.Framework.UI.BunifuFlatButton inventarioTab;
        private Bunifu.Framework.UI.BunifuFlatButton directorioTab;
        private Bunifu.Framework.UI.BunifuFlatButton administrarTab;
        private System.Windows.Forms.Label idUsuario;
        private Bunifu.Framework.UI.BunifuImageButton menu;
        private Bunifu.Framework.UI.BunifuFlatButton reportesTab;
        private Bunifu.Framework.UI.BunifuFlatButton inicioTab;
        private System.Windows.Forms.Panel contenedor;
        private Bunifu.Framework.UI.BunifuImageButton logout;
        private Bunifu.Framework.UI.BunifuImageButton closemenu;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label nameUser;
        private BunifuAnimatorNS.BunifuTransition viewTransition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel topNavbar;
        private System.Windows.Forms.PictureBox userPictureNavbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contentMenuMore;
        private Bunifu.Framework.UI.BunifuImageButton moreMenu;
        private System.Windows.Forms.Label configuraperfil;
        private System.Windows.Forms.Label salir;
        private System.Windows.Forms.Label cerrarsesion;
    }
}