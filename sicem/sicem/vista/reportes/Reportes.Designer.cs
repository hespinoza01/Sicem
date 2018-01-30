namespace sicem
{
    partial class Reportes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.top = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mes = new Bunifu.Framework.UI.BunifuDropdown();
            this.año = new Telerik.WinControls.UI.RadSpinEditor();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tipo = new Bunifu.Framework.UI.BunifuDropdown();
            this.report = new System.Windows.Forms.DataGridView();
            this.generar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.año)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.top.Controls.Add(this.generar);
            this.top.Controls.Add(this.bunifuCustomLabel1);
            this.top.Controls.Add(this.mes);
            this.top.Controls.Add(this.año);
            this.top.Controls.Add(this.bunifuCustomLabel9);
            this.top.Controls.Add(this.tipo);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(950, 77);
            this.top.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(303, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(27, 13);
            this.bunifuCustomLabel1.TabIndex = 35;
            this.bunifuCustomLabel1.Text = "Mes";
            // 
            // mes
            // 
            this.mes.BackColor = System.Drawing.Color.Transparent;
            this.mes.BorderRadius = 7;
            this.mes.DisabledColor = System.Drawing.Color.Gray;
            this.mes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mes.Items = new string[] {
        "Enero",
        "Febrero",
        "Marzo",
        "Abril",
        "Mayo",
        "Junio",
        "Julio",
        "Agosto",
        "Septiembre",
        "Octubre",
        "Noviembre",
        "Diciembre"};
            this.mes.Location = new System.Drawing.Point(295, 36);
            this.mes.Name = "mes";
            this.mes.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mes.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.mes.selectedIndex = 0;
            this.mes.Size = new System.Drawing.Size(140, 35);
            this.mes.TabIndex = 34;
            // 
            // año
            // 
            this.año.AutoSize = false;
            this.año.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.año.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.año.ForeColor = System.Drawing.Color.RoyalBlue;
            this.año.Location = new System.Drawing.Point(472, 36);
            this.año.Name = "año";
            // 
            // 
            // 
            this.año.RootElement.ControlDefaultSize = new System.Drawing.Size(75, 28);
            this.año.RootElement.EnableFocusBorder = true;
            this.año.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.año.Size = new System.Drawing.Size(112, 35);
            this.año.TabIndex = 33;
            this.año.TabStop = false;
            this.año.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadSpinElement)(this.año.GetChildAt(0))).EnableRippleAnimation = true;
            ((Telerik.WinControls.UI.RadSpinElement)(this.año.GetChildAt(0))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.RadSpinElement)(this.año.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadSpinElement)(this.año.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            ((Telerik.WinControls.UI.StackLayoutElement)(this.año.GetChildAt(0).GetChildAt(2))).HorizontalLineColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.año.GetChildAt(0).GetChildAt(2))).BorderBottomColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.año.GetChildAt(0).GetChildAt(2))).EnableRippleAnimation = true;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.año.GetChildAt(0).GetChildAt(2))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.año.GetChildAt(0).GetChildAt(2))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.año.GetChildAt(0).GetChildAt(2))).Padding = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.año.GetChildAt(0).GetChildAt(2).GetChildAt(0))).StretchVertically = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.año.GetChildAt(0).GetChildAt(2).GetChildAt(0))).EnableRippleAnimation = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.año.GetChildAt(0).GetChildAt(2).GetChildAt(0))).EnableFocusBorder = true;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.año.GetChildAt(0).GetChildAt(2).GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.año.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.año.GetChildAt(0).GetChildAt(2).GetChildAt(0))).CustomFontSize = 11F;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.año.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.año.GetChildAt(0).GetChildAt(2).GetChildAt(0))).MinSize = new System.Drawing.Size(33, 15);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.año.GetChildAt(0).GetChildAt(2).GetChildAt(0))).MaxSize = new System.Drawing.Size(33, 15);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(479, 19);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(26, 13);
            this.bunifuCustomLabel9.TabIndex = 32;
            this.bunifuCustomLabel9.Text = "Año";
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.Color.Transparent;
            this.tipo.BorderRadius = 7;
            this.tipo.DisabledColor = System.Drawing.Color.Gray;
            this.tipo.ForeColor = System.Drawing.Color.White;
            this.tipo.Items = new string[] {
        "Ventas",
        "Compras",
        "Estado Financiero"};
            this.tipo.Location = new System.Drawing.Point(30, 36);
            this.tipo.Name = "tipo";
            this.tipo.NomalColor = System.Drawing.Color.RoyalBlue;
            this.tipo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.tipo.selectedIndex = 0;
            this.tipo.Size = new System.Drawing.Size(140, 35);
            this.tipo.TabIndex = 0;
            // 
            // report
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.report.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.report.BackgroundColor = System.Drawing.Color.White;
            this.report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.report.DefaultCellStyle = dataGridViewCellStyle3;
            this.report.Dock = System.Windows.Forms.DockStyle.Right;
            this.report.Enabled = false;
            this.report.Location = new System.Drawing.Point(55, 77);
            this.report.MultiSelect = false;
            this.report.Name = "report";
            this.report.ReadOnly = true;
            this.report.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.report.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.report.Size = new System.Drawing.Size(895, 513);
            this.report.TabIndex = 1;
            // 
            // generar
            // 
            this.generar.ActiveBorderThickness = 1;
            this.generar.ActiveCornerRadius = 10;
            this.generar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.generar.ActiveForecolor = System.Drawing.Color.White;
            this.generar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.generar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generar.BackgroundImage")));
            this.generar.ButtonText = "Generar";
            this.generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generar.ForeColor = System.Drawing.Color.SeaGreen;
            this.generar.IdleBorderThickness = 1;
            this.generar.IdleCornerRadius = 10;
            this.generar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.generar.IdleForecolor = System.Drawing.Color.White;
            this.generar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.generar.Location = new System.Drawing.Point(764, 31);
            this.generar.Margin = new System.Windows.Forms.Padding(5);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(181, 41);
            this.generar.TabIndex = 36;
            this.generar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.report);
            this.Controls.Add(this.top);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(950, 590);
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.año)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.DataGridView report;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown mes;
        private Telerik.WinControls.UI.RadSpinEditor año;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuDropdown tipo;
        private Bunifu.Framework.UI.BunifuThinButton2 generar;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}
