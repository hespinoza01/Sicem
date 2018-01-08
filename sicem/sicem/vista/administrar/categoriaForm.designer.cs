namespace sicem
{
    partial class categoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoriaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.estadoValor = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.aceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.txtId = new Telerik.WinControls.UI.RadTextBox();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.txtDescripcion = new Telerik.WinControls.UI.RadTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 40);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(17, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(175, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Información categoría";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelID.Location = new System.Drawing.Point(297, 57);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(67, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID categoría";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(24, 116);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(63, 13);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Descripción";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(24, 57);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(93, 13);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Nombre categoría";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(49, 226);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(45, 13);
            this.bunifuCustomLabel5.TabIndex = 10;
            this.bunifuCustomLabel5.Text = "Habilitar";
            // 
            // estadoValor
            // 
            this.estadoValor.BackColor = System.Drawing.Color.RoyalBlue;
            this.estadoValor.ChechedOffColor = System.Drawing.Color.Silver;
            this.estadoValor.Checked = true;
            this.estadoValor.CheckedOnColor = System.Drawing.Color.RoyalBlue;
            this.estadoValor.ForeColor = System.Drawing.Color.White;
            this.estadoValor.Location = new System.Drawing.Point(22, 222);
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.Size = new System.Drawing.Size(20, 20);
            this.estadoValor.TabIndex = 9;
            // 
            // cancelar
            // 
            this.cancelar.ActiveBorderThickness = 2;
            this.cancelar.ActiveCornerRadius = 10;
            this.cancelar.ActiveFillColor = System.Drawing.Color.White;
            this.cancelar.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.cancelar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
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
            this.cancelar.Location = new System.Drawing.Point(254, 256);
            this.cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 35);
            this.cancelar.TabIndex = 11;
            this.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.ActiveBorderThickness = 1;
            this.aceptar.ActiveCornerRadius = 10;
            this.aceptar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.aceptar.ActiveForecolor = System.Drawing.Color.White;
            this.aceptar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
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
            this.aceptar.Location = new System.Drawing.Point(374, 256);
            this.aceptar.Margin = new System.Windows.Forms.Padding(5);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 35);
            this.aceptar.TabIndex = 12;
            this.aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = false;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.Location = new System.Drawing.Point(22, 74);
            this.txtNombre.Name = "txtNombre";
            // 
            // 
            // 
            this.txtNombre.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtNombre.RootElement.CustomFont = "None";
            this.txtNombre.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.Size = new System.Drawing.Size(200, 30);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombre.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombre.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombre.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // txtId
            // 
            this.txtId.AutoSize = false;
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtId.Location = new System.Drawing.Point(295, 74);
            this.txtId.Name = "txtId";
            // 
            // 
            // 
            this.txtId.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtId.RootElement.CustomFont = "None";
            this.txtId.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtId.Size = new System.Drawing.Size(87, 30);
            this.txtId.TabIndex = 30;
            this.txtId.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtId.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtId.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtId.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = false;
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtDescripcion.Location = new System.Drawing.Point(22, 132);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            // 
            // 
            // 
            this.txtDescripcion.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtDescripcion.RootElement.CustomFont = "None";
            this.txtDescripcion.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtDescripcion.Size = new System.Drawing.Size(360, 74);
            this.txtDescripcion.TabIndex = 31;
            this.txtDescripcion.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtDescripcion.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtDescripcion.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtDescripcion.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // categoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 305);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.estadoValor);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoriaForm";
            this.Load += new System.EventHandler(this.categoriaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel labelID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox estadoValor;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 aceptar;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
        private Telerik.WinControls.UI.RadTextBox txtId;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadTextBox txtDescripcion;
    }
}