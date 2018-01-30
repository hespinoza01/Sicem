namespace sicem
{
    partial class tarjetaCreditoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarjetaCreditoForm));
            this.toppanel = new System.Windows.Forms.Panel();
            this.txtTipoTarjeta = new Telerik.WinControls.UI.RadTextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.aceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtNumeroTarjeta = new Telerik.WinControls.UI.RadTextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtExpiraMes = new Telerik.WinControls.UI.RadSpinEditor();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtExpiraAño = new Telerik.WinControls.UI.RadSpinEditor();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.remover = new Bunifu.Framework.UI.BunifuImageButton();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpiraMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpiraAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remover)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.toppanel.Controls.Add(this.remover);
            this.toppanel.Controls.Add(this.bunifuCustomLabel1);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(345, 40);
            this.toppanel.TabIndex = 0;
            // 
            // txtTipoTarjeta
            // 
            this.txtTipoTarjeta.AutoSize = false;
            this.txtTipoTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTipoTarjeta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoTarjeta.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtTipoTarjeta.Location = new System.Drawing.Point(33, 86);
            this.txtTipoTarjeta.Name = "txtTipoTarjeta";
            // 
            // 
            // 
            this.txtTipoTarjeta.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtTipoTarjeta.RootElement.CustomFont = "None";
            this.txtTipoTarjeta.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTipoTarjeta.Size = new System.Drawing.Size(162, 28);
            this.txtTipoTarjeta.TabIndex = 34;
            this.txtTipoTarjeta.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtTipoTarjeta.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtTipoTarjeta.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtTipoTarjeta.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(36, 68);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(60, 13);
            this.bunifuCustomLabel4.TabIndex = 31;
            this.bunifuCustomLabel4.Text = "Tipo tarjeta";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(114, 20);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "Trajeta crédito";
            // 
            // aceptar
            // 
            this.aceptar.ActiveBorderThickness = 1;
            this.aceptar.ActiveCornerRadius = 10;
            this.aceptar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.aceptar.ActiveForecolor = System.Drawing.Color.White;
            this.aceptar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptar.BackColor = System.Drawing.Color.White;
            this.aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptar.BackgroundImage")));
            this.aceptar.ButtonText = "Guardar";
            this.aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.aceptar.IdleBorderThickness = 1;
            this.aceptar.IdleCornerRadius = 10;
            this.aceptar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.aceptar.IdleForecolor = System.Drawing.Color.White;
            this.aceptar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.aceptar.Location = new System.Drawing.Point(233, 306);
            this.aceptar.Margin = new System.Windows.Forms.Padding(5);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 35);
            this.aceptar.TabIndex = 33;
            this.aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelar
            // 
            this.cancelar.ActiveBorderThickness = 2;
            this.cancelar.ActiveCornerRadius = 10;
            this.cancelar.ActiveFillColor = System.Drawing.Color.White;
            this.cancelar.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.cancelar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar.BackColor = System.Drawing.Color.White;
            this.cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelar.BackgroundImage")));
            this.cancelar.ButtonText = "Cancelar";
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.cancelar.IdleBorderThickness = 1;
            this.cancelar.IdleCornerRadius = 10;
            this.cancelar.IdleFillColor = System.Drawing.Color.White;
            this.cancelar.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.cancelar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.cancelar.Location = new System.Drawing.Point(113, 306);
            this.cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 35);
            this.cancelar.TabIndex = 32;
            this.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.AutoSize = false;
            this.txtNumeroTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNumeroTarjeta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTarjeta.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(33, 151);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            // 
            // 
            // 
            this.txtNumeroTarjeta.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtNumeroTarjeta.RootElement.CustomFont = "None";
            this.txtNumeroTarjeta.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(175, 28);
            this.txtNumeroTarjeta.TabIndex = 36;
            this.txtNumeroTarjeta.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNumeroTarjeta.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNumeroTarjeta.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNumeroTarjeta.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(36, 133);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(91, 13);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Número de tarjeta";
            // 
            // txtExpiraMes
            // 
            this.txtExpiraMes.AutoSize = false;
            this.txtExpiraMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtExpiraMes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiraMes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtExpiraMes.Location = new System.Drawing.Point(33, 215);
            this.txtExpiraMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtExpiraMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtExpiraMes.Name = "txtExpiraMes";
            this.txtExpiraMes.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // 
            // 
            this.txtExpiraMes.RootElement.ControlDefaultSize = new System.Drawing.Size(75, 28);
            this.txtExpiraMes.RootElement.EnableFocusBorder = true;
            this.txtExpiraMes.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtExpiraMes.Size = new System.Drawing.Size(115, 28);
            this.txtExpiraMes.TabIndex = 38;
            this.txtExpiraMes.TabStop = false;
            this.txtExpiraMes.ThemeName = "Material";
            this.txtExpiraMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            ((Telerik.WinControls.UI.RadSpinElement)(this.txtExpiraMes.GetChildAt(0))).EnableRippleAnimation = true;
            ((Telerik.WinControls.UI.RadSpinElement)(this.txtExpiraMes.GetChildAt(0))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.RadSpinElement)(this.txtExpiraMes.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadSpinElement)(this.txtExpiraMes.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2))).HorizontalLineColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2))).BorderBottomColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2))).EnableRippleAnimation = true;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2))).Padding = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Text = "1";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).StretchVertically = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).EnableRippleAnimation = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).CustomFontSize = 11F;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).MinSize = new System.Drawing.Size(33, 15);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraMes.GetChildAt(0).GetChildAt(2).GetChildAt(0))).MaxSize = new System.Drawing.Size(33, 15);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(35, 199);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(58, 13);
            this.bunifuCustomLabel3.TabIndex = 37;
            this.bunifuCustomLabel3.Text = "Expira mes";
            // 
            // txtExpiraAño
            // 
            this.txtExpiraAño.AutoSize = false;
            this.txtExpiraAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtExpiraAño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiraAño.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtExpiraAño.Location = new System.Drawing.Point(195, 215);
            this.txtExpiraAño.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtExpiraAño.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.txtExpiraAño.Name = "txtExpiraAño";
            this.txtExpiraAño.NullableValue = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // 
            // 
            this.txtExpiraAño.RootElement.ControlDefaultSize = new System.Drawing.Size(75, 28);
            this.txtExpiraAño.RootElement.EnableFocusBorder = true;
            this.txtExpiraAño.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtExpiraAño.Size = new System.Drawing.Size(115, 28);
            this.txtExpiraAño.TabIndex = 40;
            this.txtExpiraAño.TabStop = false;
            this.txtExpiraAño.ThemeName = "Material";
            this.txtExpiraAño.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            ((Telerik.WinControls.UI.RadSpinElement)(this.txtExpiraAño.GetChildAt(0))).EnableRippleAnimation = true;
            ((Telerik.WinControls.UI.RadSpinElement)(this.txtExpiraAño.GetChildAt(0))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.RadSpinElement)(this.txtExpiraAño.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadSpinElement)(this.txtExpiraAño.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2))).HorizontalLineColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2))).BorderBottomColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2))).EnableRippleAnimation = true;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2))).Padding = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Text = "17";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).StretchVertically = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).EnableRippleAnimation = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).CustomFontSize = 11F;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).MinSize = new System.Drawing.Size(33, 15);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtExpiraAño.GetChildAt(0).GetChildAt(2).GetChildAt(0))).MaxSize = new System.Drawing.Size(33, 15);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(197, 199);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(57, 13);
            this.bunifuCustomLabel5.TabIndex = 39;
            this.bunifuCustomLabel5.Text = "Expira año";
            // 
            // remover
            // 
            this.remover.BackColor = System.Drawing.Color.Transparent;
            this.remover.Image = ((System.Drawing.Image)(resources.GetObject("remover.Image")));
            this.remover.ImageActive = ((System.Drawing.Image)(resources.GetObject("remover.ImageActive")));
            this.remover.Location = new System.Drawing.Point(308, 6);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(30, 30);
            this.remover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.remover.TabIndex = 61;
            this.remover.TabStop = false;
            this.remover.Visible = false;
            this.remover.Zoom = 5;
            // 
            // tarjetaCreditoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 351);
            this.Controls.Add(this.txtExpiraAño);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.txtExpiraMes);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtTipoTarjeta);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tarjetaCreditoForm";
            this.Text = "Tarjeta Credito";
            this.Load += new System.EventHandler(this.tarjetaCreditoForm_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpiraMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpiraAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private Telerik.WinControls.UI.RadTextBox txtTipoTarjeta;
        private Bunifu.Framework.UI.BunifuThinButton2 aceptar;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Telerik.WinControls.UI.RadTextBox txtNumeroTarjeta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Telerik.WinControls.UI.RadSpinEditor txtExpiraMes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Telerik.WinControls.UI.RadSpinEditor txtExpiraAño;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuImageButton remover;
    }
}