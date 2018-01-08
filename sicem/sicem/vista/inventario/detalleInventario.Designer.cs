namespace sicem.vista.inventario
{
    partial class detalleInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detalleInventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.txtNombreProducto = new Telerik.WinControls.UI.RadTextBox();
            this.labelId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEstado = new Telerik.WinControls.UI.RadTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.vistaAlmacenaje = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.vistaHistorialEntrada = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bodegaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaEstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabEntrada = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPrecio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabCosto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.historialCostoPrecio = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAlmacenaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaHistorialEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialCostoPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AutoSize = false;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtID.Location = new System.Drawing.Point(35, 59);
            this.txtID.Name = "txtID";
            // 
            // 
            // 
            this.txtID.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtID.RootElement.CustomFont = "None";
            this.txtID.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtID.Size = new System.Drawing.Size(75, 30);
            this.txtID.TabIndex = 46;
            this.txtID.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtID.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtID.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtID.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AutoSize = false;
            this.txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtNombreProducto.Location = new System.Drawing.Point(35, 131);
            this.txtNombreProducto.Name = "txtNombreProducto";
            // 
            // 
            // 
            this.txtNombreProducto.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtNombreProducto.RootElement.CustomFont = "None";
            this.txtNombreProducto.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtNombreProducto.Size = new System.Drawing.Size(224, 30);
            this.txtNombreProducto.TabIndex = 45;
            this.txtNombreProducto.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombreProducto.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombreProducto.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNombreProducto.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelId.Location = new System.Drawing.Point(37, 41);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(64, 13);
            this.labelId.TabIndex = 44;
            this.labelId.Text = "ID Producto";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(37, 113);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(89, 13);
            this.bunifuCustomLabel2.TabIndex = 43;
            this.bunifuCustomLabel2.Text = "Nombre producto";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = false;
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtEstado.Location = new System.Drawing.Point(290, 131);
            this.txtEstado.Name = "txtEstado";
            // 
            // 
            // 
            this.txtEstado.RootElement.ControlDefaultSize = new System.Drawing.Size(235, 28);
            this.txtEstado.RootElement.CustomFont = "None";
            this.txtEstado.RootElement.FocusBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtEstado.Size = new System.Drawing.Size(119, 30);
            this.txtEstado.TabIndex = 52;
            this.txtEstado.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtEstado.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtEstado.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.RoyalBlue;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtEstado.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(292, 113);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel1.TabIndex = 51;
            this.bunifuCustomLabel1.Text = "Estado";
            // 
            // vistaAlmacenaje
            // 
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vistaAlmacenaje.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.vistaAlmacenaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vistaAlmacenaje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.vistaAlmacenaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vistaAlmacenaje.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vistaAlmacenaje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.vistaAlmacenaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaAlmacenaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bodegaID,
            this.bodegaNombre,
            this.bodegaEstante,
            this.bodegaCantidad});
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vistaAlmacenaje.DefaultCellStyle = dataGridViewCellStyle51;
            this.vistaAlmacenaje.DoubleBuffered = true;
            this.vistaAlmacenaje.EnableHeadersVisualStyles = false;
            this.vistaAlmacenaje.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.vistaAlmacenaje.HeaderForeColor = System.Drawing.Color.White;
            this.vistaAlmacenaje.Location = new System.Drawing.Point(35, 201);
            this.vistaAlmacenaje.MultiSelect = false;
            this.vistaAlmacenaje.Name = "vistaAlmacenaje";
            this.vistaAlmacenaje.ReadOnly = true;
            this.vistaAlmacenaje.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vistaAlmacenaje.RowHeadersVisible = false;
            this.vistaAlmacenaje.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.vistaAlmacenaje.RowsDefaultCellStyle = dataGridViewCellStyle52;
            this.vistaAlmacenaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vistaAlmacenaje.Size = new System.Drawing.Size(413, 130);
            this.vistaAlmacenaje.TabIndex = 53;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(37, 183);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(62, 13);
            this.bunifuCustomLabel3.TabIndex = 54;
            this.bunifuCustomLabel3.Text = "Almacenaje";
            // 
            // vistaHistorialEntrada
            // 
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vistaHistorialEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle53;
            this.vistaHistorialEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vistaHistorialEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.vistaHistorialEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vistaHistorialEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vistaHistorialEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.vistaHistorialEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaHistorialEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidadEntrada,
            this.costoEntrada,
            this.fechaEntrada});
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vistaHistorialEntrada.DefaultCellStyle = dataGridViewCellStyle55;
            this.vistaHistorialEntrada.DoubleBuffered = true;
            this.vistaHistorialEntrada.EnableHeadersVisualStyles = false;
            this.vistaHistorialEntrada.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.vistaHistorialEntrada.HeaderForeColor = System.Drawing.Color.White;
            this.vistaHistorialEntrada.Location = new System.Drawing.Point(35, 417);
            this.vistaHistorialEntrada.MultiSelect = false;
            this.vistaHistorialEntrada.Name = "vistaHistorialEntrada";
            this.vistaHistorialEntrada.ReadOnly = true;
            this.vistaHistorialEntrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vistaHistorialEntrada.RowHeadersVisible = false;
            this.vistaHistorialEntrada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.vistaHistorialEntrada.RowsDefaultCellStyle = dataGridViewCellStyle56;
            this.vistaHistorialEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vistaHistorialEntrada.Size = new System.Drawing.Size(413, 130);
            this.vistaHistorialEntrada.TabIndex = 55;
            // 
            // bodegaID
            // 
            this.bodegaID.FillWeight = 65.16669F;
            this.bodegaID.HeaderText = "ID";
            this.bodegaID.Name = "bodegaID";
            this.bodegaID.ReadOnly = true;
            // 
            // bodegaNombre
            // 
            this.bodegaNombre.FillWeight = 207.1066F;
            this.bodegaNombre.HeaderText = "Nombre";
            this.bodegaNombre.Name = "bodegaNombre";
            this.bodegaNombre.ReadOnly = true;
            // 
            // bodegaEstante
            // 
            this.bodegaEstante.FillWeight = 63.86336F;
            this.bodegaEstante.HeaderText = "Estante";
            this.bodegaEstante.Name = "bodegaEstante";
            this.bodegaEstante.ReadOnly = true;
            // 
            // bodegaCantidad
            // 
            this.bodegaCantidad.FillWeight = 63.86336F;
            this.bodegaCantidad.HeaderText = "Cantidad";
            this.bodegaCantidad.Name = "bodegaCantidad";
            this.bodegaCantidad.ReadOnly = true;
            // 
            // cantidadEntrada
            // 
            this.cantidadEntrada.FillWeight = 76.14214F;
            this.cantidadEntrada.HeaderText = "Cantidad";
            this.cantidadEntrada.Name = "cantidadEntrada";
            this.cantidadEntrada.ReadOnly = true;
            // 
            // costoEntrada
            // 
            this.costoEntrada.FillWeight = 111.9289F;
            this.costoEntrada.HeaderText = "Costo";
            this.costoEntrada.Name = "costoEntrada";
            this.costoEntrada.ReadOnly = true;
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.FillWeight = 111.9289F;
            this.fechaEntrada.HeaderText = "Fecha";
            this.fechaEntrada.Name = "fechaEntrada";
            this.fechaEntrada.ReadOnly = true;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(42, 362);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(55, 13);
            this.bunifuCustomLabel4.TabIndex = 56;
            this.bunifuCustomLabel4.Text = "Historiales";
            // 
            // tabEntrada
            // 
            this.tabEntrada.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(75)))), ((int)(((byte)(195)))));
            this.tabEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(205)))));
            this.tabEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEntrada.BorderRadius = 0;
            this.tabEntrada.ButtonText = "Entrada";
            this.tabEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabEntrada.DisabledColor = System.Drawing.Color.Gray;
            this.tabEntrada.Iconcolor = System.Drawing.Color.Transparent;
            this.tabEntrada.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabEntrada.Iconimage")));
            this.tabEntrada.Iconimage_right = null;
            this.tabEntrada.Iconimage_right_Selected = null;
            this.tabEntrada.Iconimage_Selected = null;
            this.tabEntrada.IconMarginLeft = 0;
            this.tabEntrada.IconMarginRight = 0;
            this.tabEntrada.IconRightVisible = false;
            this.tabEntrada.IconRightZoom = 0D;
            this.tabEntrada.IconVisible = false;
            this.tabEntrada.IconZoom = 90D;
            this.tabEntrada.IsTab = true;
            this.tabEntrada.Location = new System.Drawing.Point(35, 381);
            this.tabEntrada.Name = "tabEntrada";
            this.tabEntrada.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.tabEntrada.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.tabEntrada.OnHoverTextColor = System.Drawing.Color.White;
            this.tabEntrada.selected = true;
            this.tabEntrada.Size = new System.Drawing.Size(137, 30);
            this.tabEntrada.TabIndex = 57;
            this.tabEntrada.Text = "Entrada";
            this.tabEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabEntrada.Textcolor = System.Drawing.Color.White;
            this.tabEntrada.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEntrada.Click += new System.EventHandler(this.tabEntrada_Click);
            // 
            // tabPrecio
            // 
            this.tabPrecio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(75)))), ((int)(((byte)(195)))));
            this.tabPrecio.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPrecio.BorderRadius = 0;
            this.tabPrecio.ButtonText = "Precio";
            this.tabPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPrecio.DisabledColor = System.Drawing.Color.Gray;
            this.tabPrecio.Iconcolor = System.Drawing.Color.Transparent;
            this.tabPrecio.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabPrecio.Iconimage")));
            this.tabPrecio.Iconimage_right = null;
            this.tabPrecio.Iconimage_right_Selected = null;
            this.tabPrecio.Iconimage_Selected = null;
            this.tabPrecio.IconMarginLeft = 0;
            this.tabPrecio.IconMarginRight = 0;
            this.tabPrecio.IconRightVisible = false;
            this.tabPrecio.IconRightZoom = 0D;
            this.tabPrecio.IconVisible = false;
            this.tabPrecio.IconZoom = 90D;
            this.tabPrecio.IsTab = true;
            this.tabPrecio.Location = new System.Drawing.Point(311, 381);
            this.tabPrecio.Name = "tabPrecio";
            this.tabPrecio.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.tabPrecio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.tabPrecio.OnHoverTextColor = System.Drawing.Color.White;
            this.tabPrecio.selected = false;
            this.tabPrecio.Size = new System.Drawing.Size(137, 30);
            this.tabPrecio.TabIndex = 58;
            this.tabPrecio.Text = "Precio";
            this.tabPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabPrecio.Textcolor = System.Drawing.Color.White;
            this.tabPrecio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrecio.Click += new System.EventHandler(this.tabPrecio_Click);
            // 
            // tabCosto
            // 
            this.tabCosto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(75)))), ((int)(((byte)(195)))));
            this.tabCosto.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabCosto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCosto.BorderRadius = 0;
            this.tabCosto.ButtonText = "Costo";
            this.tabCosto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabCosto.DisabledColor = System.Drawing.Color.Gray;
            this.tabCosto.Iconcolor = System.Drawing.Color.Transparent;
            this.tabCosto.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabCosto.Iconimage")));
            this.tabCosto.Iconimage_right = null;
            this.tabCosto.Iconimage_right_Selected = null;
            this.tabCosto.Iconimage_Selected = null;
            this.tabCosto.IconMarginLeft = 0;
            this.tabCosto.IconMarginRight = 0;
            this.tabCosto.IconRightVisible = false;
            this.tabCosto.IconRightZoom = 0D;
            this.tabCosto.IconVisible = false;
            this.tabCosto.IconZoom = 90D;
            this.tabCosto.IsTab = true;
            this.tabCosto.Location = new System.Drawing.Point(168, 381);
            this.tabCosto.Name = "tabCosto";
            this.tabCosto.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.tabCosto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.tabCosto.OnHoverTextColor = System.Drawing.Color.White;
            this.tabCosto.selected = false;
            this.tabCosto.Size = new System.Drawing.Size(146, 30);
            this.tabCosto.TabIndex = 59;
            this.tabCosto.Text = "Costo";
            this.tabCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabCosto.Textcolor = System.Drawing.Color.White;
            this.tabCosto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCosto.Click += new System.EventHandler(this.tabCosto_Click);
            // 
            // historialCostoPrecio
            // 
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.historialCostoPrecio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle57;
            this.historialCostoPrecio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historialCostoPrecio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.historialCostoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historialCostoPrecio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historialCostoPrecio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.historialCostoPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialCostoPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtFechaInicio,
            this.txtFechaFinal,
            this.valueTipo});
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historialCostoPrecio.DefaultCellStyle = dataGridViewCellStyle59;
            this.historialCostoPrecio.DoubleBuffered = true;
            this.historialCostoPrecio.EnableHeadersVisualStyles = false;
            this.historialCostoPrecio.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.historialCostoPrecio.HeaderForeColor = System.Drawing.Color.White;
            this.historialCostoPrecio.Location = new System.Drawing.Point(35, 417);
            this.historialCostoPrecio.MultiSelect = false;
            this.historialCostoPrecio.Name = "historialCostoPrecio";
            this.historialCostoPrecio.ReadOnly = true;
            this.historialCostoPrecio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.historialCostoPrecio.RowHeadersVisible = false;
            this.historialCostoPrecio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.historialCostoPrecio.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.historialCostoPrecio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historialCostoPrecio.Size = new System.Drawing.Size(413, 130);
            this.historialCostoPrecio.TabIndex = 60;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.FillWeight = 76.14214F;
            this.txtFechaInicio.HeaderText = "Fecha inicio";
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = true;
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.FillWeight = 111.9289F;
            this.txtFechaFinal.HeaderText = "Fecha final";
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.ReadOnly = true;
            // 
            // valueTipo
            // 
            this.valueTipo.FillWeight = 111.9289F;
            this.valueTipo.HeaderText = "tipo";
            this.valueTipo.Name = "valueTipo";
            this.valueTipo.ReadOnly = true;
            // 
            // detalleInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.tabCosto);
            this.Controls.Add(this.tabPrecio);
            this.Controls.Add(this.tabEntrada);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.vistaAlmacenaje);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.vistaHistorialEntrada);
            this.Controls.Add(this.historialCostoPrecio);
            this.Name = "detalleInventario";
            this.Size = new System.Drawing.Size(483, 590);
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAlmacenaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaHistorialEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialCostoPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtID;
        private Telerik.WinControls.UI.RadTextBox txtNombreProducto;
        private Bunifu.Framework.UI.BunifuCustomLabel labelId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Telerik.WinControls.UI.RadTextBox txtEstado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid vistaAlmacenaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodegaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodegaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodegaEstante;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodegaCantidad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid vistaHistorialEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrada;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton tabEntrada;
        private Bunifu.Framework.UI.BunifuFlatButton tabPrecio;
        private Bunifu.Framework.UI.BunifuFlatButton tabCosto;
        private Bunifu.Framework.UI.BunifuCustomDataGrid historialCostoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTipo;
    }
}
