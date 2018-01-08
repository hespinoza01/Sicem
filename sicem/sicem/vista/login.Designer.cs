namespace sicem
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.content = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.password = new Telerik.WinControls.UI.RadTextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.username = new Telerik.WinControls.UI.RadTextBox();
            this.listaSugetencias = new Telerik.WinControls.UI.RadListControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ingresar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.picture = new System.Windows.Forms.PictureBox();
            this.viewpass = new Bunifu.Framework.UI.BunifuImageButton();
            this.borderForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bglogo = new System.Windows.Forms.Panel();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSugetencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewpass)).BeginInit();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.content.Controls.Add(this.bunifuSeparator2);
            this.content.Controls.Add(this.password);
            this.content.Controls.Add(this.bunifuSeparator1);
            this.content.Controls.Add(this.username);
            this.content.Controls.Add(this.listaSugetencias);
            this.content.Controls.Add(this.pictureBox2);
            this.content.Controls.Add(this.pictureBox4);
            this.content.Controls.Add(this.ingresar);
            this.content.Controls.Add(this.exitButton);
            this.content.Controls.Add(this.picture);
            this.content.Controls.Add(this.viewpass);
            this.content.Location = new System.Drawing.Point(20, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(680, 530);
            this.content.TabIndex = 0;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(365, 362);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(280, 5);
            this.bunifuSeparator2.TabIndex = 22;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // password
            // 
            this.password.AutoSize = false;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.RoyalBlue;
            this.password.Location = new System.Drawing.Point(401, 334);
            this.password.Name = "password";
            this.password.NullText = "Contraseña";
            // 
            // 
            // 
            this.password.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.password.RootElement.CustomFont = "None";
            this.password.RootElement.EnableFocusBorderAnimation = false;
            this.password.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.password.Size = new System.Drawing.Size(210, 30);
            this.password.TabIndex = 50;
            this.password.ThemeName = "Material";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.password.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.password.GetChildAt(0))).EnableFocusBorder = false;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.password.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.password.GetChildAt(0))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.password.GetChildAt(0))).CustomFont = "Roboto Medium";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.password.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.password.GetChildAt(0).GetChildAt(0))).NullText = "Contraseña";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.password.GetChildAt(0).GetChildAt(0))).NullTextColor = System.Drawing.Color.DarkGray;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.password.GetChildAt(0).GetChildAt(0))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.password.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(365, 290);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(280, 5);
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // username
            // 
            this.username.AutoSize = false;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.RoyalBlue;
            this.username.Location = new System.Drawing.Point(401, 262);
            this.username.Name = "username";
            this.username.NullText = "Usuario";
            // 
            // 
            // 
            this.username.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.username.RootElement.CustomFont = "None";
            this.username.RootElement.EnableFocusBorderAnimation = false;
            this.username.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.username.Size = new System.Drawing.Size(240, 30);
            this.username.TabIndex = 49;
            this.username.ThemeName = "Material";
            this.username.TextChanged += new System.EventHandler(this.username_OnValueChanged);
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.username.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.username.GetChildAt(0))).EnableFocusBorder = false;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.username.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.username.GetChildAt(0))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.username.GetChildAt(0))).CustomFont = "Roboto Medium";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.username.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.username.GetChildAt(0).GetChildAt(0))).NullText = "Usuario";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.username.GetChildAt(0).GetChildAt(0))).NullTextColor = System.Drawing.Color.DarkGray;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.username.GetChildAt(0).GetChildAt(0))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.username.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // listaSugetencias
            // 
            this.listaSugetencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaSugetencias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaSugetencias.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listaSugetencias.ItemHeight = 20;
            radListDataItem1.Text = "ListItem 1";
            radListDataItem2.Text = "ListItem 2";
            radListDataItem3.Text = "ListItem 3";
            radListDataItem4.Text = "ListItem 4";
            radListDataItem5.Text = "ListItem 5";
            radListDataItem6.Text = "ListItem 6";
            radListDataItem7.Text = "ListItem 7";
            this.listaSugetencias.Items.Add(radListDataItem1);
            this.listaSugetencias.Items.Add(radListDataItem2);
            this.listaSugetencias.Items.Add(radListDataItem3);
            this.listaSugetencias.Items.Add(radListDataItem4);
            this.listaSugetencias.Items.Add(radListDataItem5);
            this.listaSugetencias.Items.Add(radListDataItem6);
            this.listaSugetencias.Items.Add(radListDataItem7);
            this.listaSugetencias.Location = new System.Drawing.Point(400, 299);
            this.listaSugetencias.Name = "listaSugetencias";
            // 
            // 
            // 
            this.listaSugetencias.RootElement.FocusBorderColor = System.Drawing.Color.CornflowerBlue;
            this.listaSugetencias.Size = new System.Drawing.Size(136, 17);
            this.listaSugetencias.TabIndex = 48;
            this.listaSugetencias.Text = "radListControl1";
            this.listaSugetencias.ThemeName = "Material";
            this.listaSugetencias.Visible = false;
            this.listaSugetencias.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.listaSugetencias_SelectedIndexChanged);
            this.listaSugetencias.Leave += new System.EventHandler(this.listaSugetencias_Leave);
            ((Telerik.WinControls.UI.RadListElement)(this.listaSugetencias.GetChildAt(0))).ItemHeight = 20;
            ((Telerik.WinControls.UI.RadListElement)(this.listaSugetencias.GetChildAt(0))).DrawBorder = true;
            ((Telerik.WinControls.UI.RadListElement)(this.listaSugetencias.GetChildAt(0))).HorizontalLineColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadListElement)(this.listaSugetencias.GetChildAt(0))).BorderLeftColor = System.Drawing.Color.CornflowerBlue;
            ((Telerik.WinControls.UI.RadListElement)(this.listaSugetencias.GetChildAt(0))).BorderTopColor = System.Drawing.Color.CornflowerBlue;
            ((Telerik.WinControls.UI.RadListElement)(this.listaSugetencias.GetChildAt(0))).BorderRightColor = System.Drawing.Color.CornflowerBlue;
            ((Telerik.WinControls.UI.RadListElement)(this.listaSugetencias.GetChildAt(0))).BorderBottomColor = System.Drawing.Color.CornflowerBlue;
            ((Telerik.WinControls.UI.RadListElement)(this.listaSugetencias.GetChildAt(0))).EnableElementShadow = true;
            ((Telerik.WinControls.UI.RadScrollBarElement)(this.listaSugetencias.GetChildAt(0).GetChildAt(2))).MinSize = new System.Drawing.Size(12, 112);
            ((Telerik.WinControls.UI.RadScrollBarElement)(this.listaSugetencias.GetChildAt(0).GetChildAt(2))).MaxSize = new System.Drawing.Size(12, 112);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(365, 333);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(365, 262);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // ingresar
            // 
            this.ingresar.ActiveBorderThickness = 1;
            this.ingresar.ActiveCornerRadius = 35;
            this.ingresar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(235)))));
            this.ingresar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.ingresar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(235)))));
            this.ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingresar.BackgroundImage")));
            this.ingresar.ButtonText = "Ingresar";
            this.ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.SeaGreen;
            this.ingresar.IdleBorderThickness = 1;
            this.ingresar.IdleCornerRadius = 35;
            this.ingresar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.ingresar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.ingresar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.ingresar.Location = new System.Drawing.Point(365, 440);
            this.ingresar.Margin = new System.Windows.Forms.Padding(5);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(280, 48);
            this.ingresar.TabIndex = 17;
            this.ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("exitButton.ImageActive")));
            this.exitButton.Location = new System.Drawing.Point(640, 15);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 16;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 7;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(445, 70);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(120, 120);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 15;
            this.picture.TabStop = false;
            // 
            // viewpass
            // 
            this.viewpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.viewpass.Image = ((System.Drawing.Image)(resources.GetObject("viewpass.Image")));
            this.viewpass.ImageActive = ((System.Drawing.Image)(resources.GetObject("viewpass.ImageActive")));
            this.viewpass.Location = new System.Drawing.Point(615, 334);
            this.viewpass.Name = "viewpass";
            this.viewpass.Size = new System.Drawing.Size(30, 30);
            this.viewpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewpass.TabIndex = 24;
            this.viewpass.TabStop = false;
            this.viewpass.Zoom = 5;
            this.viewpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewpass_MouseDown);
            this.viewpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewpass_MouseUp);
            // 
            // borderForm
            // 
            this.borderForm.ElipseRadius = 8;
            this.borderForm.TargetControl = this;
            // 
            // bglogo
            // 
            this.bglogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bglogo.BackgroundImage")));
            this.bglogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bglogo.Location = new System.Drawing.Point(0, 15);
            this.bglogo.Name = "bglogo";
            this.bglogo.Size = new System.Drawing.Size(350, 500);
            this.bglogo.TabIndex = 26;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 530);
            this.Controls.Add(this.bglogo);
            this.Controls.Add(this.content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.log_Load);
            this.content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSugetencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewpass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.PictureBox picture;
        public Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuThinButton2 ingresar;
        private Bunifu.Framework.UI.BunifuImageButton viewpass;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuElipse borderForm;
        private System.Windows.Forms.Panel bglogo;
        private Telerik.WinControls.UI.RadListControl listaSugetencias;
        private Telerik.WinControls.UI.RadTextBox username;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadTextBox password;
    }
}

