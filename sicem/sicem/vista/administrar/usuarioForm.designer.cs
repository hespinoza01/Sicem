namespace sicem
{
    partial class usuarioForm
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarioForm));
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lateral = new System.Windows.Forms.Panel();
            this.contraseñaVisible = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.confirPass = new Telerik.WinControls.UI.RadTextBox();
            this.pass = new Telerik.WinControls.UI.RadTextBox();
            this.nomUser = new Telerik.WinControls.UI.RadTextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.finalizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bac = new Bunifu.Framework.UI.BunifuImageButton();
            this.perfil = new System.Windows.Forms.PictureBox();
            this.next = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nombreTxt = new Telerik.WinControls.UI.RadTextBox();
            this.apellidoTxt = new Telerik.WinControls.UI.RadTextBox();
            this.editPerfilPicture = new Bunifu.Framework.UI.BunifuImageButton();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apellidoTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPerfilPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(76, 283);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(51, 16);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "Apellido";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(73, 188);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(51, 16);
            this.bunifuCustomLabel6.TabIndex = 26;
            this.bunifuCustomLabel6.Text = "Nombre";
            // 
            // lateral
            // 
            this.lateral.Controls.Add(this.contraseñaVisible);
            this.lateral.Controls.Add(this.bunifuCustomLabel4);
            this.lateral.Controls.Add(this.confirPass);
            this.lateral.Controls.Add(this.pass);
            this.lateral.Controls.Add(this.nomUser);
            this.lateral.Controls.Add(this.bunifuCustomLabel3);
            this.lateral.Controls.Add(this.bunifuCustomLabel1);
            this.lateral.Controls.Add(this.bunifuCustomLabel2);
            this.lateral.Controls.Add(this.finalizar);
            this.bunifuTransition1.SetDecoration(this.lateral, BunifuAnimatorNS.DecorationType.None);
            this.lateral.Location = new System.Drawing.Point(12, 171);
            this.lateral.Name = "lateral";
            this.lateral.Size = new System.Drawing.Size(370, 284);
            this.lateral.TabIndex = 30;
            // 
            // contraseñaVisible
            // 
            this.contraseñaVisible.BackColor = System.Drawing.Color.Transparent;
            this.contraseñaVisible.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contraseñaVisible.BackgroundImage")));
            this.contraseñaVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contraseñaVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.contraseñaVisible, BunifuAnimatorNS.DecorationType.None);
            this.contraseñaVisible.Location = new System.Drawing.Point(64, 209);
            this.contraseñaVisible.Name = "contraseñaVisible";
            this.contraseñaVisible.OffColor = System.Drawing.Color.Silver;
            this.contraseñaVisible.OnColor = System.Drawing.Color.RoyalBlue;
            this.contraseñaVisible.Size = new System.Drawing.Size(35, 20);
            this.contraseñaVisible.TabIndex = 42;
            this.contraseñaVisible.Value = true;
            this.contraseñaVisible.OnValueChange += new System.EventHandler(this.contraseñaVisible_OnValueChange);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(105, 211);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(113, 16);
            this.bunifuCustomLabel4.TabIndex = 41;
            this.bunifuCustomLabel4.Text = "Mostrar contraseña";
            // 
            // confirPass
            // 
            this.confirPass.AutoSize = false;
            this.confirPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuTransition1.SetDecoration(this.confirPass, BunifuAnimatorNS.DecorationType.None);
            this.confirPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirPass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.confirPass.Location = new System.Drawing.Point(64, 164);
            this.confirPass.Name = "confirPass";
            // 
            // 
            // 
            this.confirPass.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.confirPass.RootElement.CustomFont = "None";
            this.confirPass.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.confirPass.Size = new System.Drawing.Size(205, 30);
            this.confirPass.TabIndex = 39;
            this.confirPass.ThemeName = "Material";
            this.confirPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirPass_KeyPress);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.confirPass.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.confirPass.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.confirPass.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // pass
            // 
            this.pass.AutoSize = false;
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuTransition1.SetDecoration(this.pass, BunifuAnimatorNS.DecorationType.None);
            this.pass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pass.Location = new System.Drawing.Point(64, 102);
            this.pass.Name = "pass";
            // 
            // 
            // 
            this.pass.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.pass.RootElement.CustomFont = "None";
            this.pass.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.pass.Size = new System.Drawing.Size(205, 30);
            this.pass.TabIndex = 38;
            this.pass.ThemeName = "Material";
            this.pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_KeyPress);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.pass.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.pass.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.pass.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // nomUser
            // 
            this.nomUser.AutoSize = false;
            this.nomUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuTransition1.SetDecoration(this.nomUser, BunifuAnimatorNS.DecorationType.None);
            this.nomUser.Enabled = false;
            this.nomUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nomUser.Location = new System.Drawing.Point(65, 26);
            this.nomUser.Name = "nomUser";
            // 
            // 
            // 
            this.nomUser.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.nomUser.RootElement.CustomFont = "None";
            this.nomUser.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.nomUser.Size = new System.Drawing.Size(205, 30);
            this.nomUser.TabIndex = 37;
            this.nomUser.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.nomUser.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.nomUser.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.nomUser.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(64, 145);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(127, 16);
            this.bunifuCustomLabel3.TabIndex = 36;
            this.bunifuCustomLabel3.Text = "Confirmar Contraseña";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(65, 83);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 16);
            this.bunifuCustomLabel1.TabIndex = 34;
            this.bunifuCustomLabel1.Text = "Contraseña";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(64, 7);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(110, 16);
            this.bunifuCustomLabel2.TabIndex = 31;
            this.bunifuCustomLabel2.Text = "Nombre de usuario";
            // 
            // finalizar
            // 
            this.finalizar.ActiveBorderThickness = 1;
            this.finalizar.ActiveCornerRadius = 10;
            this.finalizar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.finalizar.ActiveForecolor = System.Drawing.Color.White;
            this.finalizar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.finalizar.BackColor = System.Drawing.Color.White;
            this.finalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalizar.BackgroundImage")));
            this.finalizar.ButtonText = "Finalizar";
            this.finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.finalizar, BunifuAnimatorNS.DecorationType.None);
            this.finalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.finalizar.IdleBorderThickness = 1;
            this.finalizar.IdleCornerRadius = 10;
            this.finalizar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.finalizar.IdleForecolor = System.Drawing.Color.White;
            this.finalizar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.finalizar.Location = new System.Drawing.Point(241, 244);
            this.finalizar.Margin = new System.Windows.Forms.Padding(5);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(124, 40);
            this.finalizar.TabIndex = 32;
            this.finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finalizar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.bac);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 40);
            this.panel1.TabIndex = 38;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = ((System.Drawing.Image)(resources.GetObject("close.ImageActive")));
            this.close.Location = new System.Drawing.Point(361, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 24;
            this.close.TabStop = false;
            this.close.Zoom = 7;
            this.close.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bac
            // 
            this.bac.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bac, BunifuAnimatorNS.DecorationType.None);
            this.bac.Image = ((System.Drawing.Image)(resources.GetObject("bac.Image")));
            this.bac.ImageActive = ((System.Drawing.Image)(resources.GetObject("bac.ImageActive")));
            this.bac.Location = new System.Drawing.Point(7, 5);
            this.bac.Name = "bac";
            this.bac.Size = new System.Drawing.Size(30, 30);
            this.bac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bac.TabIndex = 37;
            this.bac.TabStop = false;
            this.bac.Zoom = 6;
            this.bac.Click += new System.EventHandler(this.bac_Click);
            // 
            // perfil
            // 
            this.perfil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perfil.BackColor = System.Drawing.Color.Transparent;
            this.perfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.perfil, BunifuAnimatorNS.DecorationType.None);
            this.perfil.Image = global::sicem.Properties.Resources.picture_user;
            this.perfil.Location = new System.Drawing.Point(147, 65);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(100, 100);
            this.perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.perfil.TabIndex = 22;
            this.perfil.TabStop = false;
            this.perfil.Click += new System.EventHandler(this.perfil_Click);
            // 
            // next
            // 
            this.next.ActiveBorderThickness = 2;
            this.next.ActiveCornerRadius = 10;
            this.next.ActiveFillColor = System.Drawing.Color.White;
            this.next.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.next.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.next.BackColor = System.Drawing.Color.White;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.ButtonText = "Siguiente";
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.next, BunifuAnimatorNS.DecorationType.None);
            this.next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.next.IdleBorderThickness = 1;
            this.next.IdleCornerRadius = 10;
            this.next.IdleFillColor = System.Drawing.Color.White;
            this.next.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.next.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.next.Location = new System.Drawing.Point(218, 415);
            this.next.Margin = new System.Windows.Forms.Padding(5);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(124, 40);
            this.next.TabIndex = 27;
            this.next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.AutoSize = false;
            this.nombreTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuTransition1.SetDecoration(this.nombreTxt, BunifuAnimatorNS.DecorationType.None);
            this.nombreTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nombreTxt.Location = new System.Drawing.Point(76, 207);
            this.nombreTxt.Name = "nombreTxt";
            // 
            // 
            // 
            this.nombreTxt.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.nombreTxt.RootElement.CustomFont = "None";
            this.nombreTxt.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.nombreTxt.Size = new System.Drawing.Size(205, 30);
            this.nombreTxt.TabIndex = 39;
            this.nombreTxt.ThemeName = "Material";
            this.nombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTxt_KeyPress);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.nombreTxt.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.nombreTxt.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.nombreTxt.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.AutoSize = false;
            this.apellidoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuTransition1.SetDecoration(this.apellidoTxt, BunifuAnimatorNS.DecorationType.None);
            this.apellidoTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTxt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.apellidoTxt.Location = new System.Drawing.Point(76, 302);
            this.apellidoTxt.Name = "apellidoTxt";
            // 
            // 
            // 
            this.apellidoTxt.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.apellidoTxt.RootElement.CustomFont = "None";
            this.apellidoTxt.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.apellidoTxt.Size = new System.Drawing.Size(205, 30);
            this.apellidoTxt.TabIndex = 40;
            this.apellidoTxt.ThemeName = "Material";
            this.apellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidoTxt_KeyPress);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.apellidoTxt.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.apellidoTxt.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.apellidoTxt.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // editPerfilPicture
            // 
            this.editPerfilPicture.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.editPerfilPicture, BunifuAnimatorNS.DecorationType.None);
            this.editPerfilPicture.Image = ((System.Drawing.Image)(resources.GetObject("editPerfilPicture.Image")));
            this.editPerfilPicture.ImageActive = ((System.Drawing.Image)(resources.GetObject("editPerfilPicture.ImageActive")));
            this.editPerfilPicture.Location = new System.Drawing.Point(222, 140);
            this.editPerfilPicture.Name = "editPerfilPicture";
            this.editPerfilPicture.Size = new System.Drawing.Size(22, 22);
            this.editPerfilPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editPerfilPicture.TabIndex = 41;
            this.editPerfilPicture.TabStop = false;
            this.editPerfilPicture.Zoom = 6;
            this.editPerfilPicture.Click += new System.EventHandler(this.perfil_Click);
            // 
            // usuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 467);
            this.Controls.Add(this.editPerfilPicture);
            this.Controls.Add(this.lateral);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.next);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            this.lateral.ResumeLayout(false);
            this.lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomUser)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apellidoTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPerfilPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog open;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.PictureBox perfil;
        private Bunifu.Framework.UI.BunifuThinButton2 next;
        private System.Windows.Forms.Panel lateral;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 finalizar;
        private Bunifu.Framework.UI.BunifuImageButton bac;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadTextBox nomUser;
        private Telerik.WinControls.UI.RadTextBox confirPass;
        private Telerik.WinControls.UI.RadTextBox pass;
        private Telerik.WinControls.UI.RadTextBox nombreTxt;
        private Telerik.WinControls.UI.RadTextBox apellidoTxt;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuImageButton editPerfilPicture;
        private Bunifu.Framework.UI.BunifuiOSSwitch contraseñaVisible;
    }
}