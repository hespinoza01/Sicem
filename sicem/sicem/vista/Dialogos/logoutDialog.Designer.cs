namespace sicem
{
    partial class logoutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logoutDialog));
            this.content = new System.Windows.Forms.Panel();
            this.cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.aceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.content.Controls.Add(this.mensaje);
            this.content.Controls.Add(this.aceptar);
            this.content.Controls.Add(this.cancelar);
            this.content.Location = new System.Drawing.Point(1, 1);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(298, 123);
            this.content.TabIndex = 0;
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
            // logoutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(300, 125);
            this.Controls.Add(this.content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logoutDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logoutDialog";
            this.Load += new System.EventHandler(this.logoutDialog_Load);
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private Bunifu.Framework.UI.BunifuThinButton2 aceptar;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelar;
        private Bunifu.Framework.UI.BunifuCustomLabel mensaje;
    }
}