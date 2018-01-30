using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace sicem
{
    public partial class compraForm : Form
    {
        int count, index, idproveedor = -1, idproducto = -1;
        string accionformulario;
        List<int> valuesidproducto = new List<int>();
        List<int> valuesidproveedor = new List<int>();
        bool cargainfo = false;
        public compraForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public compraForm(string id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }

        private void formulario_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            crearProducto.Left = 660;
            agregarProductoDetalle.Visible = false;
            addListasSugerencias();

            txtProveedor.Region = new region().RoundBorder(235, 28, 7);
            txtCodigoCompra.Region = new region().RoundBorder(170, 28, 7);
            txtProducto.Region = new region().RoundBorder(235, 28, 7);
            txtCantidadProducto.Region = new region().RoundBorder(115, 28, 7);
            txtCostoUnitario.Region = new region().RoundBorder(115, 28, 7);
            showCreate.Region = new region().RoundBorder(showCreate.Width + 10, showCreate.Height, 10);

            showCreate.MouseHover += show;
            showCreate.Click += show;
            crearProducto.MouseLeave += hide;

            guardarButton.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            if (accionformulario == "crear")
            {
                showCreate.Visible = true;
                txtCodigoCompra.Text = generaCodFactura();
                fechaCompra.Value = DateTime.Now;
            }
            else
                showCreate.Visible = false;
        }

        private void addListasSugerencias()
        {
            txtProveedor.TopLevelControl.Controls.Add(listaProveedores);
            Point controlLocation = txtProveedor.TopLevelControl.PointToClient(txtProveedor.Parent.PointToScreen(txtProveedor.Location));
            listaProveedores.Left = controlLocation.X + 5;
            listaProveedores.Top = controlLocation.Y + txtProveedor.Height;
            listaProveedores.Width = txtProveedor.Width-10;
            listaProveedores.Height = 0;
            listaProveedores.Visible = true;

            txtProducto.TopLevelControl.Controls.Add(listaProductos);
            controlLocation = txtProducto.TopLevelControl.PointToClient(txtProducto.Parent.PointToScreen(txtProducto.Location));
            listaProductos.Left = controlLocation.X + 5;
            listaProductos.Top = controlLocation.Y + txtProducto.Height;
            listaProductos.Width = txtProducto.Width-10;
            listaProductos.Height = 0;
            listaProductos.Visible = true;
        }

        private void setDataView(string id)
        {
            DataTable data = new compra().Detalle(id);

            if (data != null) {
                cargainfo = true;
                DataRow row = data.Rows[0];

                txtCodigoCompra.Text = row["ID"].ToString();
                obtenerProveedor(int.Parse(row["ProveedorID"].ToString()));
                tipoPago.selectedIndex = int.Parse(row["TipoPago"].ToString());
                fechaCompra.Value = DateTime.Parse(row["FechaCompra"].ToString());
                txtTotalCompra.Text = row["Monto"].ToString();
                getDetalleCompra(txtCodigoCompra.Text);

                cargainfo = false;
            }else{
                new popup("Error al mostrar información", popup.AlertType.error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }

        private void obtenerProveedor(int id)
        {
            DataTable data = new Proveedor().Detalle(id);
            if(data != null) { 
                    DataRow row = data.Rows[0];
                    idproveedor = int.Parse(row["ID"].ToString());
                    txtProveedor.Text = row["Nombre"].ToString();
             }
        }

        private void getDetalleCompra(string id)
        {
            DataTable data = new DetalleCompra().Mostrar(id);
            if(data != null) { 
                detalleCompra.Rows.Clear();

                foreach (DataRow row in data.Rows){
                    string pid, n, c, cu, t;
                    pid = row[0].ToString();
                    n = row[1].ToString();
                    c = row[2].ToString();
                    cu = row[3].ToString();
                    t = row[4].ToString();
                    detalleCompra.Rows.Add(pid, n, c, cu, t);
                }
            }
        }

        private void saveDetalle(int tipo)
        {
            DetalleCompra d = new DetalleCompra();
            foreach(DataGridViewRow r in detalleCompra.Rows) //(int i = 0; i < detalleCompra.Rows.Count; i++)
            {   //detalleCompra.Rows[i].Cells[0].Value.ToString()
                d.CompraID = txtCodigoCompra.Text;
                d.ProdID = int.Parse(r.Cells[0].Value.ToString());
                d.Cant = int.Parse(r.Cells[2].Value.ToString());
                d.UnitPrice = decimal.Parse(r.Cells[3].Value.ToString());
                d.Total = decimal.Parse(r.Cells[4].Value.ToString());
                historialCosto(d.ProdID, d.UnitPrice);
                if (tipo == 1)
                    d.Insertar();
                else
                    d.Editar();
            }
        }

        private void getSugerencias(int tabla)
        {
            int h, cont;
            DataTable data = (tabla == 1) ? new Proveedor().Buscar(txtProveedor.Text, 0) : new Producto().Buscar(txtProducto.Text, 0);

            if (data != null){
                valuesidproducto.Clear();
                valuesidproveedor.Clear();
                listaProductos.Items.Clear();
                listaProveedores.Items.Clear();

                foreach (DataRow r in data.Rows)
                {
                    if(tabla == 1){
                        valuesidproveedor.Add(int.Parse(r["ID"].ToString()));
                        listaProveedores.Items.Add(r["Nombre"].ToString());
                    }else{
                        valuesidproducto.Add(int.Parse(r["ID"].ToString()));
                        listaProductos.Items.Add(r["Nombre"].ToString());
                    }
                }

                if(tabla == 1){
                    cont = listaProveedores.Items.Count;
                    h = listaProveedores.ItemHeight;
                    listaProveedores.Height = (cont > 5) ? (h * 5) : (h * cont);
                    listaProveedores.BringToFront();
                }
                else{
                    cont = listaProductos.Items.Count;
                    h = listaProductos.ItemHeight;
                    listaProductos.Height = (cont > 5) ? (h * 5) : (h * cont);
                    listaProductos.BringToFront();
                }
            }
        }

        private string generaCodFactura()
        {
            string codigo;
            DateTime fa = DateTime.Now;

            codigo = "c" + fa.Day.ToString() + fa.Month.ToString() + fa.Year.ToString().Substring(2, 2);
            codigo += "-" + fa.ToShortTimeString().Replace(":", "");

            return codigo;
        }

        public void historialCosto(int id, decimal precio)
        {
            string cmd = "select Precio from HistorialCostoProducto where ProductoID = '" + id + "' and FechaFinal = null";
            object value = new DBHelper().ReaderScalar(cmd);
            if (value != null)
            {
                if (decimal.Parse(value.ToString().Replace(".", ",")) != precio)
                    new Producto().InsertarHistorialCosto(id, precio);
            }
        }

        private void clearTextboxDetalle()
        {
            txtProducto.Clear();
            txtCantidadProducto.Value = 0;
            txtCostoUnitario.Clear();
        }

        private decimal calculoTotalCompra()
        {
            decimal total = 0;
            foreach (DataGridViewRow r in detalleCompra.Rows)
                total += Convert.ToDecimal(r.Cells[4].Value.ToString());

            return total;
        }

        private void show(object sender, EventArgs e)
        {
            Transition.run(crearProducto, "Left", 500, new TransitionType_EaseInEaseOut(750));
            Transition.run(showCreate, "Left", 645, new TransitionType_EaseInEaseOut(750));
        }

        private void hide(object sender, EventArgs e)
        {
            //if (crearProducto.Left == 490)
            //{
                Transition.run(crearProducto, "Left", 660, new TransitionType_EaseInEaseOut(750));
                Transition.run(showCreate, "Left", 615, new TransitionType_EaseInEaseOut(750));
            //}
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if(!cargainfo){
                if (txtProveedor.Text.Length > 0)
                    getSugerencias(1);
                else
                    listaProveedores.Height = 0;

                idproveedor = -1;
            }
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((listaProveedores.Visible) && (listaProveedores.SelectedIndex < listaProveedores.Items.Count - 1))
                            listaProveedores.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (listaProveedores.Visible && listaProveedores.SelectedIndex >= 0)
                            listaProveedores.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (listaProveedores.Visible)
                        {
                            listaProveedores_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            if (!listaProveedores.ContainsFocus)
                listaProveedores.Visible = false;
        }

        private void listaProveedores_Leave(object sender, EventArgs e)
        {
            if (!txtProveedor.ContainsFocus)
                listaProveedores.Visible = false;
        }

        private void listaProveedores_Click(object sender, EventArgs e)
        {
            if (listaProveedores.SelectedIndex >= 0)
            {
                cargainfo = true;
                txtProveedor.Text = listaProveedores.SelectedItem.ToString();
                idproveedor = valuesidproveedor[listaProveedores.SelectedIndex];
                cargainfo = false;
            }

            txtProveedor.Focus();
            txtProveedor.Select(txtProveedor.Text.Length, 0);
            listaProveedores.Height = 0;
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if(!cargainfo){
                if (txtProducto.Text.Length > 0)
                {
                    agregarProductoDetalle.Visible = true;
                    getSugerencias(2);
                }
                else
                {
                    listaProductos.Height = 0;
                    agregarProductoDetalle.Visible = false;
                }

                idproducto = -1;
            }
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((listaProductos.Visible) && (listaProductos.SelectedIndex < listaProductos.Items.Count - 1))
                            listaProductos.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (listaProductos.Visible && listaProductos.SelectedIndex >= 0)
                            listaProductos.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (listaProductos.Visible)
                        {
                            listaProductos_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (!listaProductos.ContainsFocus)
                listaProductos.Visible = false;
        }

        private void listaProductos_Leave(object sender, EventArgs e)
        {
            if (!txtProducto.ContainsFocus)
                listaProductos.Visible = false;
        }

        private void listaProductos_Click(object sender, EventArgs e)
        {
            if (listaProductos.SelectedIndex >= 0)
            {
                cargainfo = true;
                txtProducto.Text = listaProductos.SelectedItem.ToString();
                idproducto = valuesidproducto[listaProductos.SelectedIndex];
                cargainfo = false;
            }

            txtProducto.Focus();
            txtProducto.Select(txtProducto.Text.Length, 0);
            listaProductos.Height = 0;
        }

        private void txtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == ',' && !txtCostoUnitario.Text.Contains(e.KeyChar.ToString()))
            {
                if (txtCostoUnitario.Text == "")
                {
                    txtCostoUnitario.Text += "0,";
                    txtCostoUnitario.Select(txtCostoUnitario.Text.Length, 0);
                    e.Handled = true;
                }
                else
                    e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Back))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void borrarDetalle_Click(object sender, EventArgs e)
        {
            detalleCompra.Rows.RemoveAt(index);
            txtTotalCompra.Text = calculoTotalCompra().ToString();
            borrarDetalle.Visible = false;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            try {
                if (idproveedor != -1)
                {
                    //string[] value = txtProveedor.Text.Split('-');
                    compra c = new compra();
                    c.ID = txtCodigoCompra.Text;
                    c.ProveedorID = idproveedor;
                    c.TipoPago = tipoPago.selectedIndex;
                    c.FechaCompra = fechaCompra.Value;
                    c.Monto = decimal.Parse(txtTotalCompra.Text);

                    if (accionformulario == "crear") {
                        c.Insertar();
                        saveDetalle(1);
                    }
                    else {
                        c.Editar();
                        saveDetalle(0);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    new popup("No se pudo realizar la acción", popup.AlertType.error);
            }catch(Exception ex) { }
        }

        private void crearProducto_Click(object sender, EventArgs e)
        {
            new productoForm().ShowDialog();
            hide(null, null);
        }

        private void agregarProductoDetalle_Click(object sender, EventArgs e)
        {
            if (idproducto != -1)
            {
                if (count == -1)
                {
                    count = detalleCompra.Rows.Count - 1;
                    detalleCompra.Rows.Add(1);
                }
                //string[] value = txtProducto.Text.Split('-');
                txtCostoUnitario.Text = txtCostoUnitario.Text.Replace('.', ',');

                detalleCompra.Rows[count].Cells[0].Value = idproducto;
                detalleCompra.Rows[count].Cells[1].Value = txtProducto.Text;
                detalleCompra.Rows[count].Cells[2].Value = txtCantidadProducto.Text;
                detalleCompra.Rows[count].Cells[3].Value = txtCostoUnitario.Text;
                detalleCompra.Rows[count].Cells[4].Value = int.Parse(txtCantidadProducto.Text) * Convert.ToDecimal(txtCostoUnitario.Text);

                count = -1;
                idproducto = -1;

                clearTextboxDetalle();
                txtTotalCompra.Text = calculoTotalCompra().ToString();
            }
            else
                new popup("Error al agregar", popup.AlertType.error);
        }

        private void detalleCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                count = e.RowIndex;

                idproducto = int.Parse(detalleCompra.Rows[count].Cells[0].Value.ToString());
                txtProducto.Text = detalleCompra.Rows[count].Cells[1].Value.ToString();
                txtCantidadProducto.Text = detalleCompra.Rows[count].Cells[2].Value.ToString();
                txtCostoUnitario.Text = detalleCompra.Rows[count].Cells[3].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void detalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accionformulario == "crear")
            {
                borrarDetalle.Visible = true;
                index = e.RowIndex;
            }
        }

        private void detalleCompra_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            borrarDetalle.Visible = false;
        }

        private void detalleCompra_Leave(object sender, EventArgs e)
        {
            borrarDetalle.Visible = false;
        }

    }
}
