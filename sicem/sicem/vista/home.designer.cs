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
            this.inventarioTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inicioTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logout = new Bunifu.Framework.UI.BunifuImageButton();
            this.directorioTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.idUsuario = new System.Windows.Forms.Label();
            this.OperacionesTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nameUser = new System.Windows.Forms.Label();
            this.administrarTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.proveedorTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closemenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.productosTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.contenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.viewTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closemenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.navbar.Controls.Add(this.inventarioTab);
            this.navbar.Controls.Add(this.inicioTab);
            this.navbar.Controls.Add(this.logout);
            this.navbar.Controls.Add(this.directorioTab);
            this.navbar.Controls.Add(this.idUsuario);
            this.navbar.Controls.Add(this.OperacionesTab);
            this.navbar.Controls.Add(this.nameUser);
            this.navbar.Controls.Add(this.administrarTab);
            this.navbar.Controls.Add(this.proveedorTab);
            this.navbar.Controls.Add(this.closemenu);
            this.navbar.Controls.Add(this.productosTab);
            this.navbar.Controls.Add(this.userPicture);
            this.viewTransition.SetDecoration(this.navbar, BunifuAnimatorNS.DecorationType.None);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(193, 630);
            this.navbar.TabIndex = 0;
            // 
            // inventarioTab
            // 
            this.inventarioTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.inventarioTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
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
            this.inventarioTab.Iconimage_Selected = null;
            this.inventarioTab.IconMarginLeft = 0;
            this.inventarioTab.IconMarginRight = 0;
            this.inventarioTab.IconRightVisible = true;
            this.inventarioTab.IconRightZoom = 0D;
            this.inventarioTab.IconVisible = true;
            this.inventarioTab.IconZoom = 65D;
            this.inventarioTab.IsTab = true;
            this.inventarioTab.Location = new System.Drawing.Point(0, 379);
            this.inventarioTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inventarioTab.Name = "inventarioTab";
            this.inventarioTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.inventarioTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.inventarioTab.OnHoverTextColor = System.Drawing.Color.White;
            this.inventarioTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inventarioTab.selected = false;
            this.inventarioTab.Size = new System.Drawing.Size(230, 50);
            this.inventarioTab.TabIndex = 3;
            this.inventarioTab.Text = "  Inventario";
            this.inventarioTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventarioTab.Textcolor = System.Drawing.Color.White;
            this.inventarioTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioTab.Click += new System.EventHandler(this.inventarioTab_Click);
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
            this.inicioTab.Iconimage_Selected = null;
            this.inicioTab.IconMarginLeft = 0;
            this.inicioTab.IconMarginRight = 0;
            this.inicioTab.IconRightVisible = true;
            this.inicioTab.IconRightZoom = 0D;
            this.inicioTab.IconVisible = true;
            this.inicioTab.IconZoom = 60D;
            this.inicioTab.IsTab = true;
            this.inicioTab.Location = new System.Drawing.Point(0, 147);
            this.inicioTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inicioTab.Name = "inicioTab";
            this.inicioTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.inicioTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.inicioTab.OnHoverTextColor = System.Drawing.Color.White;
            this.inicioTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inicioTab.selected = true;
            this.inicioTab.Size = new System.Drawing.Size(230, 50);
            this.inicioTab.TabIndex = 8;
            this.inicioTab.Text = "  Inicio";
            this.inicioTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicioTab.Textcolor = System.Drawing.Color.White;
            this.inicioTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioTab.Click += new System.EventHandler(this.inicioTab_Click);
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.viewTransition.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageActive = null;
            this.logout.Location = new System.Drawing.Point(170, 34);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(20, 20);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout.TabIndex = 5;
            this.logout.TabStop = false;
            this.logout.Zoom = 8;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // directorioTab
            // 
            this.directorioTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.directorioTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
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
            this.directorioTab.Iconimage_Selected = null;
            this.directorioTab.IconMarginLeft = 0;
            this.directorioTab.IconMarginRight = 0;
            this.directorioTab.IconRightVisible = true;
            this.directorioTab.IconRightZoom = 0D;
            this.directorioTab.IconVisible = true;
            this.directorioTab.IconZoom = 60D;
            this.directorioTab.IsTab = true;
            this.directorioTab.Location = new System.Drawing.Point(0, 205);
            this.directorioTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.directorioTab.Name = "directorioTab";
            this.directorioTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.directorioTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.directorioTab.OnHoverTextColor = System.Drawing.Color.White;
            this.directorioTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.directorioTab.selected = false;
            this.directorioTab.Size = new System.Drawing.Size(230, 50);
            this.directorioTab.TabIndex = 4;
            this.directorioTab.Text = "  Directorio";
            this.directorioTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.directorioTab.Textcolor = System.Drawing.Color.White;
            this.directorioTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorioTab.Click += new System.EventHandler(this.directorioTab_Click);
            // 
            // idUsuario
            // 
            this.viewTransition.SetDecoration(this.idUsuario, BunifuAnimatorNS.DecorationType.None);
            this.idUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.idUsuario.Location = new System.Drawing.Point(30, 110);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(170, 20);
            this.idUsuario.TabIndex = 4;
            this.idUsuario.Text = "ID Usuario";
            this.idUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OperacionesTab
            // 
            this.OperacionesTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.OperacionesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
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
            this.OperacionesTab.Iconimage_Selected = null;
            this.OperacionesTab.IconMarginLeft = 0;
            this.OperacionesTab.IconMarginRight = 0;
            this.OperacionesTab.IconRightVisible = true;
            this.OperacionesTab.IconRightZoom = 0D;
            this.OperacionesTab.IconVisible = true;
            this.OperacionesTab.IconZoom = 65D;
            this.OperacionesTab.IsTab = true;
            this.OperacionesTab.Location = new System.Drawing.Point(0, 263);
            this.OperacionesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OperacionesTab.Name = "OperacionesTab";
            this.OperacionesTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.OperacionesTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.OperacionesTab.OnHoverTextColor = System.Drawing.Color.White;
            this.OperacionesTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OperacionesTab.selected = false;
            this.OperacionesTab.Size = new System.Drawing.Size(230, 50);
            this.OperacionesTab.TabIndex = 2;
            this.OperacionesTab.Text = " Operaciones";
            this.OperacionesTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OperacionesTab.Textcolor = System.Drawing.Color.White;
            this.OperacionesTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperacionesTab.Click += new System.EventHandler(this.OperacionesTab_Click);
            // 
            // nameUser
            // 
            this.nameUser.BackColor = System.Drawing.Color.Transparent;
            this.viewTransition.SetDecoration(this.nameUser, BunifuAnimatorNS.DecorationType.None);
            this.nameUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameUser.ForeColor = System.Drawing.Color.White;
            this.nameUser.Location = new System.Drawing.Point(30, 85);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(170, 25);
            this.nameUser.TabIndex = 6;
            this.nameUser.Text = "Nombre Usuario";
            this.nameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // administrarTab
            // 
            this.administrarTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.administrarTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
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
            this.administrarTab.Iconimage_Selected = null;
            this.administrarTab.IconMarginLeft = 0;
            this.administrarTab.IconMarginRight = 0;
            this.administrarTab.IconRightVisible = true;
            this.administrarTab.IconRightZoom = 0D;
            this.administrarTab.IconVisible = true;
            this.administrarTab.IconZoom = 60D;
            this.administrarTab.IsTab = true;
            this.administrarTab.Location = new System.Drawing.Point(0, 495);
            this.administrarTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.administrarTab.Name = "administrarTab";
            this.administrarTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.administrarTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.administrarTab.OnHoverTextColor = System.Drawing.Color.White;
            this.administrarTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.administrarTab.selected = false;
            this.administrarTab.Size = new System.Drawing.Size(230, 50);
            this.administrarTab.TabIndex = 6;
            this.administrarTab.Text = "  Administración";
            this.administrarTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.administrarTab.Textcolor = System.Drawing.Color.White;
            this.administrarTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarTab.Click += new System.EventHandler(this.administrarTab_Click);
            // 
            // proveedorTab
            // 
            this.proveedorTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.proveedorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.proveedorTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proveedorTab.BorderRadius = 0;
            this.proveedorTab.ButtonText = "  Proveedores";
            this.proveedorTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.proveedorTab, BunifuAnimatorNS.DecorationType.None);
            this.proveedorTab.DisabledColor = System.Drawing.Color.Gray;
            this.proveedorTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedorTab.Iconcolor = System.Drawing.Color.Transparent;
            this.proveedorTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("proveedorTab.Iconimage")));
            this.proveedorTab.Iconimage_right = null;
            this.proveedorTab.Iconimage_right_Selected = null;
            this.proveedorTab.Iconimage_Selected = null;
            this.proveedorTab.IconMarginLeft = 0;
            this.proveedorTab.IconMarginRight = 0;
            this.proveedorTab.IconRightVisible = true;
            this.proveedorTab.IconRightZoom = 0D;
            this.proveedorTab.IconVisible = true;
            this.proveedorTab.IconZoom = 65D;
            this.proveedorTab.IsTab = true;
            this.proveedorTab.Location = new System.Drawing.Point(0, 437);
            this.proveedorTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.proveedorTab.Name = "proveedorTab";
            this.proveedorTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.proveedorTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.proveedorTab.OnHoverTextColor = System.Drawing.Color.White;
            this.proveedorTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.proveedorTab.selected = false;
            this.proveedorTab.Size = new System.Drawing.Size(230, 50);
            this.proveedorTab.TabIndex = 7;
            this.proveedorTab.Text = "  Proveedores";
            this.proveedorTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedorTab.Textcolor = System.Drawing.Color.White;
            this.proveedorTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedorTab.Click += new System.EventHandler(this.proveedorTab_Click);
            // 
            // closemenu
            // 
            this.closemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.closemenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.closemenu, BunifuAnimatorNS.DecorationType.None);
            this.closemenu.Image = ((System.Drawing.Image)(resources.GetObject("closemenu.Image")));
            this.closemenu.ImageActive = ((System.Drawing.Image)(resources.GetObject("closemenu.ImageActive")));
            this.closemenu.Location = new System.Drawing.Point(202, 3);
            this.closemenu.Name = "closemenu";
            this.closemenu.Size = new System.Drawing.Size(25, 25);
            this.closemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closemenu.TabIndex = 3;
            this.closemenu.TabStop = false;
            this.closemenu.Zoom = 7;
            this.closemenu.Click += new System.EventHandler(this.closemenu_Click);
            // 
            // productosTab
            // 
            this.productosTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.productosTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
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
            this.productosTab.Iconimage_Selected = null;
            this.productosTab.IconMarginLeft = 0;
            this.productosTab.IconMarginRight = 0;
            this.productosTab.IconRightVisible = true;
            this.productosTab.IconRightZoom = 0D;
            this.productosTab.IconVisible = true;
            this.productosTab.IconZoom = 60D;
            this.productosTab.IsTab = true;
            this.productosTab.Location = new System.Drawing.Point(0, 321);
            this.productosTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productosTab.Name = "productosTab";
            this.productosTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.productosTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.productosTab.OnHoverTextColor = System.Drawing.Color.White;
            this.productosTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productosTab.selected = false;
            this.productosTab.Size = new System.Drawing.Size(230, 50);
            this.productosTab.TabIndex = 2;
            this.productosTab.Text = "  Productos";
            this.productosTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productosTab.Textcolor = System.Drawing.Color.White;
            this.productosTab.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosTab.Click += new System.EventHandler(this.productosTab_Click);
            // 
            // userPicture
            // 
            this.userPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.userPicture, BunifuAnimatorNS.DecorationType.None);
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(80, 12);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(70, 70);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 2;
            this.userPicture.TabStop = false;
            this.userPicture.Click += new System.EventHandler(this.userPicture_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.viewTransition.SetDecoration(this.contenedor, BunifuAnimatorNS.DecorationType.None);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 40);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(950, 590);
            this.contenedor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contenedor);
            this.panel1.Controls.Add(this.panel2);
            this.viewTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 630);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.minButton);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.menu);
            this.viewTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 40);
            this.panel2.TabIndex = 3;
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.viewTransition.SetDecoration(this.minButton, BunifuAnimatorNS.DecorationType.None);
            this.minButton.Image = ((System.Drawing.Image)(resources.GetObject("minButton.Image")));
            this.minButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("minButton.ImageActive")));
            this.minButton.Location = new System.Drawing.Point(872, 7);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minButton.TabIndex = 4;
            this.minButton.TabStop = false;
            this.minButton.Zoom = 10;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.viewTransition.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("closeButton.ImageActive")));
            this.closeButton.Location = new System.Drawing.Point(908, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 7;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTransition.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageActive = ((System.Drawing.Image)(resources.GetObject("menu.ImageActive")));
            this.menu.Location = new System.Drawing.Point(5, 5);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(30, 30);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 2;
            this.menu.TabStop = false;
            this.menu.Zoom = 6;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            this.menu.MouseHover += new System.EventHandler(this.menu_MouseHover);
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
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.viewTransition.DefaultAnimation = animation1;
            this.viewTransition.MaxAnimationTime = 500;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 630);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.panel1);
            this.viewTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closemenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
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
        private Bunifu.Framework.UI.BunifuImageButton minButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuImageButton menu;
        private Bunifu.Framework.UI.BunifuFlatButton proveedorTab;
        private Bunifu.Framework.UI.BunifuFlatButton inicioTab;
        private System.Windows.Forms.Panel contenedor;
        private Bunifu.Framework.UI.BunifuImageButton logout;
        private Bunifu.Framework.UI.BunifuImageButton closemenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nameUser;
        private BunifuAnimatorNS.BunifuTransition viewTransition;
    }
}