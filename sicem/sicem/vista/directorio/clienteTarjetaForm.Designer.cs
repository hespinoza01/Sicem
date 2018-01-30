namespace sicem
{
    partial class clienteTarjetaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clienteTarjetaForm));
            this.toppanel = new System.Windows.Forms.Panel();
            this.listado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExpiraMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExpiraAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFormulario = new System.Windows.Forms.Label();
            this.agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.toppanel.Controls.Add(this.close);
            this.toppanel.Controls.Add(this.tipoFormulario);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(560, 40);
            this.toppanel.TabIndex = 0;
            // 
            // listado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listado.BackgroundColor = System.Drawing.Color.White;
            this.listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtTipo,
            this.txtNumero,
            this.txtExpiraMes,
            this.txtExpiraAño,
            this.txtFM});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listado.DefaultCellStyle = dataGridViewCellStyle3;
            this.listado.DoubleBuffered = true;
            this.listado.EnableHeadersVisualStyles = false;
            this.listado.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.listado.HeaderForeColor = System.Drawing.Color.White;
            this.listado.Location = new System.Drawing.Point(0, 40);
            this.listado.MultiSelect = false;
            this.listado.Name = "listado";
            this.listado.ReadOnly = true;
            this.listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listado.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.listado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listado.Size = new System.Drawing.Size(560, 150);
            this.listado.TabIndex = 1;
            this.listado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listado_CellDoubleClick);
            // 
            // txtTipo
            // 
            this.txtTipo.HeaderText = "Tipo";
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.ToolTipText = "Doble click para editar";
            this.txtTipo.Width = 112;
            // 
            // txtNumero
            // 
            this.txtNumero.HeaderText = "Número";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.ToolTipText = "Doble click para editar";
            this.txtNumero.Width = 112;
            // 
            // txtExpiraMes
            // 
            this.txtExpiraMes.HeaderText = "Expira Mes";
            this.txtExpiraMes.Name = "txtExpiraMes";
            this.txtExpiraMes.ReadOnly = true;
            this.txtExpiraMes.ToolTipText = "Doble click para editar";
            this.txtExpiraMes.Width = 112;
            // 
            // txtExpiraAño
            // 
            this.txtExpiraAño.HeaderText = "Expira Año";
            this.txtExpiraAño.Name = "txtExpiraAño";
            this.txtExpiraAño.ReadOnly = true;
            this.txtExpiraAño.ToolTipText = "Doble click para editar";
            this.txtExpiraAño.Width = 112;
            // 
            // txtFM
            // 
            this.txtFM.HeaderText = "Fecha Modificación";
            this.txtFM.Name = "txtFM";
            this.txtFM.ReadOnly = true;
            this.txtFM.ToolTipText = "Doble click para editar";
            this.txtFM.Width = 112;
            // 
            // tipoFormulario
            // 
            this.tipoFormulario.AutoSize = true;
            this.tipoFormulario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoFormulario.ForeColor = System.Drawing.Color.White;
            this.tipoFormulario.Location = new System.Drawing.Point(16, 9);
            this.tipoFormulario.Name = "tipoFormulario";
            this.tipoFormulario.Size = new System.Drawing.Size(263, 22);
            this.tipoFormulario.TabIndex = 1;
            this.tipoFormulario.Text = "Información tarjetas crédito";
            // 
            // agregar
            // 
            this.agregar.ActiveBorderThickness = 1;
            this.agregar.ActiveCornerRadius = 10;
            this.agregar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.agregar.ActiveForecolor = System.Drawing.Color.White;
            this.agregar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.agregar.BackColor = System.Drawing.Color.White;
            this.agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agregar.BackgroundImage")));
            this.agregar.ButtonText = "Guardar";
            this.agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.agregar.IdleBorderThickness = 1;
            this.agregar.IdleCornerRadius = 10;
            this.agregar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.agregar.IdleForecolor = System.Drawing.Color.White;
            this.agregar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.agregar.Location = new System.Drawing.Point(432, 198);
            this.agregar.Margin = new System.Windows.Forms.Padding(5);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(120, 40);
            this.agregar.TabIndex = 12;
            this.agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = ((System.Drawing.Image)(resources.GetObject("close.ImageActive")));
            this.close.Location = new System.Drawing.Point(527, 7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 25;
            this.close.TabStop = false;
            this.close.Zoom = 7;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // clienteTarjetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 242);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clienteTarjetaForm";
            this.Text = "Cliente Tarjeta";
            this.Load += new System.EventHandler(this.clienteTarjetaForm_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid listado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtExpiraMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtExpiraAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFM;
        private System.Windows.Forms.Label tipoFormulario;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuThinButton2 agregar;
    }
}