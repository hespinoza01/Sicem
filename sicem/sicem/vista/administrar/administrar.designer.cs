namespace sicem
{
    partial class administrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administrar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelcategorias = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelproductos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.indicadorlabel = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelusuarios = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.erraseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.contentSearch = new System.Windows.Forms.Panel();
            this.metodoBusqueda = new iTalk.iTalk_ComboBox();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radScrollablePanel1 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.labelDepartamentos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelofertas = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.agregarButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.vistaListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contentDetails = new System.Windows.Forms.Panel();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.erraseButton)).BeginInit();
            this.contentSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel1)).BeginInit();
            this.radScrollablePanel1.PanelContainer.SuspendLayout();
            this.radScrollablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaListado)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelcategorias
            // 
            this.labelcategorias.AutoSize = true;
            this.labelcategorias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategorias.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelcategorias.Location = new System.Drawing.Point(220, 15);
            this.labelcategorias.Name = "labelcategorias";
            this.labelcategorias.Size = new System.Drawing.Size(97, 21);
            this.labelcategorias.TabIndex = 17;
            this.labelcategorias.Text = "Categorías";
            this.labelcategorias.Click += new System.EventHandler(this.labelcategorias_Click);
            // 
            // labelproductos
            // 
            this.labelproductos.AutoSize = true;
            this.labelproductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelproductos.Location = new System.Drawing.Point(112, 15);
            this.labelproductos.Name = "labelproductos";
            this.labelproductos.Size = new System.Drawing.Size(88, 21);
            this.labelproductos.TabIndex = 16;
            this.labelproductos.Text = "Productos";
            this.labelproductos.Click += new System.EventHandler(this.labelproductos_Click);
            // 
            // indicadorlabel
            // 
            this.indicadorlabel.BackColor = System.Drawing.Color.Transparent;
            this.indicadorlabel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.indicadorlabel.LineThickness = 3;
            this.indicadorlabel.Location = new System.Drawing.Point(20, 32);
            this.indicadorlabel.Name = "indicadorlabel";
            this.indicadorlabel.Size = new System.Drawing.Size(72, 10);
            this.indicadorlabel.TabIndex = 15;
            this.indicadorlabel.Transparency = 255;
            this.indicadorlabel.Vertical = false;
            // 
            // labelusuarios
            // 
            this.labelusuarios.AutoSize = true;
            this.labelusuarios.BackColor = System.Drawing.Color.White;
            this.labelusuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuarios.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelusuarios.Location = new System.Drawing.Point(20, 15);
            this.labelusuarios.Name = "labelusuarios";
            this.labelusuarios.Size = new System.Drawing.Size(72, 21);
            this.labelusuarios.TabIndex = 14;
            this.labelusuarios.Text = "Usuarios";
            this.labelusuarios.Click += new System.EventHandler(this.labelusuarios_Click);
            // 
            // erraseButton
            // 
            this.erraseButton.BackColor = System.Drawing.Color.White;
            this.erraseButton.Image = ((System.Drawing.Image)(resources.GetObject("erraseButton.Image")));
            this.erraseButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("erraseButton.ImageActive")));
            this.erraseButton.Location = new System.Drawing.Point(414, 80);
            this.erraseButton.Name = "erraseButton";
            this.erraseButton.Size = new System.Drawing.Size(37, 37);
            this.erraseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erraseButton.TabIndex = 10;
            this.erraseButton.TabStop = false;
            this.erraseButton.Visible = false;
            this.erraseButton.Zoom = 6;
            // 
            // contentSearch
            // 
            this.contentSearch.BackColor = System.Drawing.Color.White;
            this.contentSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentSearch.BackgroundImage")));
            this.contentSearch.Controls.Add(this.metodoBusqueda);
            this.contentSearch.Controls.Add(this.txtBuscar);
            this.contentSearch.Location = new System.Drawing.Point(15, 80);
            this.contentSearch.Name = "contentSearch";
            this.contentSearch.Size = new System.Drawing.Size(350, 37);
            this.contentSearch.TabIndex = 12;
            // 
            // metodoBusqueda
            // 
            this.metodoBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.metodoBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metodoBusqueda.DropDownHeight = 100;
            this.metodoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metodoBusqueda.Font = new System.Drawing.Font("Century Gothic", 8.15F);
            this.metodoBusqueda.ForeColor = System.Drawing.Color.RoyalBlue;
            this.metodoBusqueda.FormattingEnabled = true;
            this.metodoBusqueda.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.metodoBusqueda.IntegralHeight = false;
            this.metodoBusqueda.ItemHeight = 20;
            this.metodoBusqueda.Items.AddRange(new object[] {
            "Nombre/ID",
            "Correo",
            "Dirección",
            "Teléfono"});
            this.metodoBusqueda.Location = new System.Drawing.Point(244, 6);
            this.metodoBusqueda.Name = "metodoBusqueda";
            this.metodoBusqueda.Size = new System.Drawing.Size(95, 26);
            this.metodoBusqueda.StartIndex = 0;
            this.metodoBusqueda.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColorFocused = System.Drawing.Color.White;
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.White;
            this.txtBuscar.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtBuscar.BorderThickness = 1;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBuscar.isPassword = false;
            this.txtBuscar.Location = new System.Drawing.Point(32, 3);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(198, 30);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.OnValueChanged += new System.EventHandler(this.txtBuscar_OnTextChange);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.radScrollablePanel1);
            this.panel2.Controls.Add(this.agregarButton);
            this.panel2.Controls.Add(this.erraseButton);
            this.panel2.Controls.Add(this.vistaListado);
            this.panel2.Controls.Add(this.contentSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 590);
            this.panel2.TabIndex = 13;
            // 
            // radScrollablePanel1
            // 
            this.radScrollablePanel1.BackColor = System.Drawing.Color.White;
            this.radScrollablePanel1.Location = new System.Drawing.Point(0, 0);
            this.radScrollablePanel1.Name = "radScrollablePanel1";
            this.radScrollablePanel1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radScrollablePanel1.PanelContainer
            // 
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.labelDepartamentos);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.labelofertas);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.labelusuarios);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.labelcategorias);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.indicadorlabel);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.labelproductos);
            this.radScrollablePanel1.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.radScrollablePanel1.PanelContainer.Size = new System.Drawing.Size(467, 48);
            this.radScrollablePanel1.Size = new System.Drawing.Size(467, 65);
            this.radScrollablePanel1.TabIndex = 0;
            this.radScrollablePanel1.Text = "radScrollablePanel1";
            this.radScrollablePanel1.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radScrollablePanel1.GetChildAt(0).GetChildAt(1))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radScrollablePanel1.GetChildAt(0).GetChildAt(1))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radScrollablePanel1.GetChildAt(0).GetChildAt(1))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radScrollablePanel1.GetChildAt(0).GetChildAt(1))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radScrollablePanel1.GetChildAt(0).GetChildAt(1))).BottomWidth = 0F;
            // 
            // labelDepartamentos
            // 
            this.labelDepartamentos.AutoSize = true;
            this.labelDepartamentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartamentos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDepartamentos.Location = new System.Drawing.Point(425, 15);
            this.labelDepartamentos.Name = "labelDepartamentos";
            this.labelDepartamentos.Size = new System.Drawing.Size(135, 21);
            this.labelDepartamentos.TabIndex = 19;
            this.labelDepartamentos.Text = "Departamentos";
            this.labelDepartamentos.Click += new System.EventHandler(this.labelDepartamentos_Click);
            // 
            // labelofertas
            // 
            this.labelofertas.AutoSize = true;
            this.labelofertas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelofertas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelofertas.Location = new System.Drawing.Point(337, 15);
            this.labelofertas.Name = "labelofertas";
            this.labelofertas.Size = new System.Drawing.Size(68, 21);
            this.labelofertas.TabIndex = 18;
            this.labelofertas.Text = "Ofertas";
            this.labelofertas.Click += new System.EventHandler(this.labelofertas_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.White;
            this.agregarButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarButton.Image")));
            this.agregarButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("agregarButton.ImageActive")));
            this.agregarButton.Location = new System.Drawing.Point(371, 80);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(37, 37);
            this.agregarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.agregarButton.TabIndex = 14;
            this.agregarButton.TabStop = false;
            this.agregarButton.Zoom = 6;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // vistaListado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vistaListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vistaListado.BackgroundColor = System.Drawing.Color.White;
            this.vistaListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.vistaListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vistaListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.vistaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnName,
            this.columnFechaModificacion});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vistaListado.DefaultCellStyle = dataGridViewCellStyle5;
            this.vistaListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vistaListado.DoubleBuffered = false;
            this.vistaListado.EnableHeadersVisualStyles = false;
            this.vistaListado.HeaderBgColor = System.Drawing.Color.White;
            this.vistaListado.HeaderForeColor = System.Drawing.Color.RoyalBlue;
            this.vistaListado.Location = new System.Drawing.Point(0, 141);
            this.vistaListado.MultiSelect = false;
            this.vistaListado.Name = "vistaListado";
            this.vistaListado.ReadOnly = true;
            this.vistaListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vistaListado.RowHeadersVisible = false;
            this.vistaListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vistaListado.Size = new System.Drawing.Size(467, 449);
            this.vistaListado.TabIndex = 14;
            this.vistaListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // columnID
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.columnID.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnID.FillWeight = 80F;
            this.columnID.Frozen = true;
            this.columnID.HeaderText = "ID";
            this.columnID.MinimumWidth = 80;
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            this.columnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnID.Width = 80;
            // 
            // columnName
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.columnName.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnName.FillWeight = 230F;
            this.columnName.Frozen = true;
            this.columnName.HeaderText = "Nombre";
            this.columnName.MinimumWidth = 230;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnName.Width = 230;
            // 
            // columnFechaModificacion
            // 
            this.columnFechaModificacion.FillWeight = 167F;
            this.columnFechaModificacion.HeaderText = "Fecha Modificacion";
            this.columnFechaModificacion.MinimumWidth = 167;
            this.columnFechaModificacion.Name = "columnFechaModificacion";
            this.columnFechaModificacion.ReadOnly = true;
            this.columnFechaModificacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnFechaModificacion.Width = 167;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contentDetails);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 590);
            this.panel3.TabIndex = 14;
            // 
            // contentDetails
            // 
            this.contentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentDetails.Location = new System.Drawing.Point(467, 0);
            this.contentDetails.Name = "contentDetails";
            this.contentDetails.Size = new System.Drawing.Size(483, 590);
            this.contentDetails.TabIndex = 14;
            // 
            // administrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.panel3);
            this.Name = "administrar";
            this.Size = new System.Drawing.Size(950, 590);
            this.Load += new System.EventHandler(this.clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erraseButton)).EndInit();
            this.contentSearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.radScrollablePanel1.PanelContainer.ResumeLayout(false);
            this.radScrollablePanel1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel1)).EndInit();
            this.radScrollablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agregarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaListado)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton erraseButton;
        private System.Windows.Forms.Panel contentSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuSeparator indicadorlabel;
        private Bunifu.Framework.UI.BunifuCustomLabel labelusuarios;
        private Bunifu.Framework.UI.BunifuCustomLabel labelproductos;
        private Bunifu.Framework.UI.BunifuCustomLabel labelcategorias;
        private Bunifu.Framework.UI.BunifuImageButton agregarButton;
        private Bunifu.Framework.UI.BunifuCustomDataGrid vistaListado;
        private System.Windows.Forms.Panel contentDetails;
        private iTalk.iTalk_ComboBox metodoBusqueda;
        private Bunifu.Framework.UI.BunifuCustomLabel labelofertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaModificacion;
        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel labelDepartamentos;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
