namespace sicem
{
    partial class departamentoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(departamentoForm));
            this.toppanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.labelId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombreGrupo = new Telerik.WinControls.UI.RadTextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cancelarButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guardarButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.toppanel.Controls.Add(this.bunifuCustomLabel1);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(321, 40);
            this.toppanel.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(227, 21);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Información Departamento";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = false;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.Location = new System.Drawing.Point(30, 149);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            // 
            // 
            // 
            this.txtNombre.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtNombre.RootElement.CustomFont = "None";
            this.txtNombre.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.Size = new System.Drawing.Size(210, 28);
            this.txtNombre.TabIndex = 34;
            this.txtNombre.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombre.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombre.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombre.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(32, 131);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(44, 13);
            this.bunifuCustomLabel6.TabIndex = 33;
            this.bunifuCustomLabel6.Text = "Nombre";
            // 
            // txtID
            // 
            this.txtID.AutoSize = false;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtID.Location = new System.Drawing.Point(30, 70);
            this.txtID.Name = "txtID";
            // 
            // 
            // 
            this.txtID.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtID.RootElement.CustomFont = "None";
            this.txtID.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtID.Size = new System.Drawing.Size(50, 28);
            this.txtID.TabIndex = 36;
            this.txtID.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtID.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtID.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtID.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelId.Location = new System.Drawing.Point(32, 54);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 35;
            this.labelId.Text = "ID";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.AutoSize = false;
            this.txtNombreGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNombreGrupo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreGrupo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtNombreGrupo.Location = new System.Drawing.Point(30, 232);
            this.txtNombreGrupo.Multiline = true;
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            // 
            // 
            // 
            this.txtNombreGrupo.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtNombreGrupo.RootElement.CustomFont = "None";
            this.txtNombreGrupo.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtNombreGrupo.Size = new System.Drawing.Size(210, 28);
            this.txtNombreGrupo.TabIndex = 38;
            this.txtNombreGrupo.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombreGrupo.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombreGrupo.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombreGrupo.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 214);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(74, 13);
            this.bunifuCustomLabel2.TabIndex = 37;
            this.bunifuCustomLabel2.Text = "Nombre grupo";
            // 
            // cancelarButton
            // 
            this.cancelarButton.ActiveBorderThickness = 2;
            this.cancelarButton.ActiveCornerRadius = 10;
            this.cancelarButton.ActiveFillColor = System.Drawing.Color.White;
            this.cancelarButton.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.cancelarButton.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.cancelarButton.BackColor = System.Drawing.Color.White;
            this.cancelarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelarButton.BackgroundImage")));
            this.cancelarButton.ButtonText = "Cancelar";
            this.cancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelarButton.IdleBorderThickness = 1;
            this.cancelarButton.IdleCornerRadius = 10;
            this.cancelarButton.IdleFillColor = System.Drawing.Color.White;
            this.cancelarButton.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.cancelarButton.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.cancelarButton.Location = new System.Drawing.Point(47, 338);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(120, 40);
            this.cancelarButton.TabIndex = 40;
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guardarButton
            // 
            this.guardarButton.ActiveBorderThickness = 1;
            this.guardarButton.ActiveCornerRadius = 10;
            this.guardarButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.guardarButton.ActiveForecolor = System.Drawing.Color.White;
            this.guardarButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.guardarButton.BackColor = System.Drawing.Color.White;
            this.guardarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarButton.BackgroundImage")));
            this.guardarButton.ButtonText = "Guardar";
            this.guardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.guardarButton.IdleBorderThickness = 1;
            this.guardarButton.IdleCornerRadius = 10;
            this.guardarButton.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.guardarButton.IdleForecolor = System.Drawing.Color.White;
            this.guardarButton.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.guardarButton.Location = new System.Drawing.Point(192, 338);
            this.guardarButton.Margin = new System.Windows.Forms.Padding(5);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(120, 40);
            this.guardarButton.TabIndex = 39;
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 387);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "departamentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.departamentoForm_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Telerik.WinControls.UI.RadTextBox txtID;
        private Bunifu.Framework.UI.BunifuCustomLabel labelId;
        private Telerik.WinControls.UI.RadTextBox txtNombreGrupo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelarButton;
        private Bunifu.Framework.UI.BunifuThinButton2 guardarButton;
    }
}