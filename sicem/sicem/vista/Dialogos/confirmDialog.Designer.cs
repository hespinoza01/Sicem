namespace sicem.vista.Dialogos
{
    partial class confirmDialog
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmDialog));
            this.content = new System.Windows.Forms.Panel();
            this.contentConfirm = new System.Windows.Forms.Panel();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.confirmar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new Telerik.WinControls.UI.RadTextBox();
            this.mensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.aceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.content.SuspendLayout();
            this.contentConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.content.Controls.Add(this.contentConfirm);
            this.content.Controls.Add(this.mensaje);
            this.content.Controls.Add(this.aceptar);
            this.content.Controls.Add(this.cancelar);
            this.bunifuTransition1.SetDecoration(this.content, BunifuAnimatorNS.DecorationType.None);
            this.content.Location = new System.Drawing.Point(1, 1);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(298, 123);
            this.content.TabIndex = 0;
            // 
            // contentConfirm
            // 
            this.contentConfirm.Controls.Add(this.close);
            this.contentConfirm.Controls.Add(this.confirmar);
            this.contentConfirm.Controls.Add(this.label1);
            this.contentConfirm.Controls.Add(this.txtContraseña);
            this.bunifuTransition1.SetDecoration(this.contentConfirm, BunifuAnimatorNS.DecorationType.None);
            this.contentConfirm.Location = new System.Drawing.Point(13, 11);
            this.contentConfirm.Name = "contentConfirm";
            this.contentConfirm.Size = new System.Drawing.Size(272, 109);
            this.contentConfirm.TabIndex = 3;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.bunifuTransition1.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = ((System.Drawing.Image)(resources.GetObject("close.ImageActive")));
            this.close.Location = new System.Drawing.Point(249, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 33;
            this.close.TabStop = false;
            this.close.Zoom = 0;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // confirmar
            // 
            this.confirmar.ActiveBorderThickness = 1;
            this.confirmar.ActiveCornerRadius = 10;
            this.confirmar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.confirmar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.confirmar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.confirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmar.BackgroundImage")));
            this.confirmar.ButtonText = "Confirmar";
            this.confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmar.ForeColor = System.Drawing.Color.SeaGreen;
            this.confirmar.IdleBorderThickness = 1;
            this.confirmar.IdleCornerRadius = 10;
            this.confirmar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.confirmar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.confirmar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.confirmar.Location = new System.Drawing.Point(86, 69);
            this.confirmar.Margin = new System.Windows.Forms.Padding(5);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(100, 35);
            this.confirmar.TabIndex = 32;
            this.confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmar.Visible = false;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Introduzca su contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.AutoSize = false;
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bunifuTransition1.SetDecoration(this.txtContraseña, BunifuAnimatorNS.DecorationType.None);
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtContraseña.Location = new System.Drawing.Point(26, 38);
            this.txtContraseña.Name = "txtContraseña";
            // 
            // 
            // 
            this.txtContraseña.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtContraseña.RootElement.CustomFont = "None";
            this.txtContraseña.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtContraseña.Size = new System.Drawing.Size(220, 30);
            this.txtContraseña.TabIndex = 30;
            this.txtContraseña.ThemeName = "Material";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtContraseña.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtContraseña.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtContraseña.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // mensaje
            // 
            this.mensaje.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mensaje.Location = new System.Drawing.Point(13, 26);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(272, 52);
            this.mensaje.TabIndex = 2;
            this.mensaje.Text = "bunifuCustomLabel1";
            this.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aceptar
            // 
            this.aceptar.ActiveBorderThickness = 1;
            this.aceptar.ActiveCornerRadius = 10;
            this.aceptar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.aceptar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.aceptar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptar.BackgroundImage")));
            this.aceptar.ButtonText = "Aceptar";
            this.aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ForeColor = System.Drawing.Color.SeaGreen;
            this.aceptar.IdleBorderThickness = 1;
            this.aceptar.IdleCornerRadius = 10;
            this.aceptar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.aceptar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.aceptar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.aceptar.Location = new System.Drawing.Point(185, 83);
            this.aceptar.Margin = new System.Windows.Forms.Padding(5);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 35);
            this.aceptar.TabIndex = 1;
            this.aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.ActiveBorderThickness = 2;
            this.cancelar.ActiveCornerRadius = 10;
            this.cancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.cancelar.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.cancelar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelar.BackgroundImage")));
            this.cancelar.ButtonText = "Cancelar";
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelar.IdleBorderThickness = 1;
            this.cancelar.IdleCornerRadius = 10;
            this.cancelar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.cancelar.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.cancelar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.cancelar.Location = new System.Drawing.Point(13, 83);
            this.cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 35);
            this.cancelar.TabIndex = 0;
            this.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // confirmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(300, 125);
            this.Controls.Add(this.content);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "confirmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logoutDialog";
            this.Load += new System.EventHandler(this.confirmDialog_Load);
            this.content.ResumeLayout(false);
            this.contentConfirm.ResumeLayout(false);
            this.contentConfirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private Bunifu.Framework.UI.BunifuThinButton2 aceptar;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelar;
        private Bunifu.Framework.UI.BunifuCustomLabel mensaje;
        private System.Windows.Forms.Panel contentConfirm;
        private Bunifu.Framework.UI.BunifuThinButton2 confirmar;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtContraseña;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}