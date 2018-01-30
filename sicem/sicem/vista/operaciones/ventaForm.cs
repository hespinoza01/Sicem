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

namespace sicem
{
    public partial class ventaForm : Form
    {
        int count = -1, index, idproducto = -1, min=0, max=0;
        float desc = 0;
        string accionformulario, idcliente = "";
        List<string> valuesidcliente = new List<string>();
        List<int> valuesidproducto = new List<int>();
        bool cargainfo = false;

        public ventaForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public ventaForm(string id)
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
            agregarProductoDetalle.Visible = false;
            guardarButton.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            txtCliente.Region = new region().RoundBorder(235, 28, 7);
            txtCodigoVenta.Region = new region().RoundBorder(170, 28, 7);
            txtProducto.Region = new region().RoundBorder(235, 28, 7);
            cantidadVentaProducto.Region = new region().RoundBorder(75, 28, 7);
            txtStock.Region = new region().RoundBorder(75, 28, 7);
            txtPrecioVenta.Region = new region().RoundBorder(75, 28, 7);
            descuentoProducto.Region = new region().RoundBorder(84, 28, 7);

            addListasSugerencias();

            if (accionformulario == "crear")
            {
                txtCodigoVenta.Text = generaCodFactura();
                fechaVenta.Value = DateTime.Now;
                labelSubtotal.Text = "00,00";
                labelImpuesto.Text = "00,00";
                labelTotal.Text = "00,00";
            }
        }

        private void addListasSugerencias()
        {
            txtCliente.TopLevelControl.Controls.Add(listaClientes);
            Point controlLocation = txtCliente.TopLevelControl.PointToClient(txtCliente.Parent.PointToScreen(txtCliente.Location));
            listaClientes.Left = controlLocation.X + 3;
            listaClientes.Top = controlLocation.Y + txtCliente.Height;
            listaClientes.Width = txtCliente.Width;
            listaClientes.Height = 0;
            listaClientes.Visible = true;

            txtProducto.TopLevelControl.Controls.Add(listaProductos);
            controlLocation = txtProducto.TopLevelControl.PointToClient(txtProducto.Parent.PointToScreen(txtProducto.Location));
            listaProductos.Left = controlLocation.X + 3;
            listaProductos.Top = controlLocation.Y + txtProducto.Height;
            listaProductos.Width = txtProducto.Width;
            listaProductos.Height = 0;
            listaProductos.Visible = true;
        }

        private void setDataView(string id)
        {
            DataTable data = new venta().Detalle(id);

            if (data != null)
            {
                cargainfo = true;
                DataRow row = data.Rows[0];

                txtCodigoVenta.Text = row["ID"].ToString();
                obtenerCliente(row["ClienteID"].ToString());
                tipoPago.selectedIndex = int.Parse(row["TipoPago"].ToString());
                fechaVenta.Value = DateTime.Parse(row["FechaVenta"].ToString());
                ventaCredito.Checked = (int.Parse(row["TipoVenta"].ToString()) == 0) ? false : true;
                getDetalleVenta(txtCodigoVenta.Text);

                cargainfo = false;
            }
            else
            {
                new popup("Error al cargar la información", popup.AlertType.error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }

        private void getDetalleVenta(string id)
        {
            DataTable data = new DetalleVenta().Mostrar(id);
            if(data != null) { 
                detalleVenta.Rows.Clear();

                foreach (DataRow row in data.Rows)
                {
                    string pid, n, c, pu, d, i, t;
                    pid = row[0].ToString();
                    n = row[1].ToString();
                    c = row[2].ToString();
                    pu = row[3].ToString();
                    d = row[4].ToString();
                    i = row[5].ToString();
                    t = row[6].ToString();
                    detalleVenta.Rows.Add(pid, n, c, pu, d, i, t);
                }
            }
        }

        private void sugerencias(int tabla)
        {
            int h, cont;
            DataTable data = (tabla == 1) ? new Cliente().Buscar(txtCliente.Text, 0) : new Producto().Buscar(txtProducto.Text, 0);

            if (data != null)
            {
                //valuesidproducto.Clear();
                //valuesidcliente.Clear();
                listaProductos.Items.Clear();
                listaClientes.Items.Clear();

                foreach (DataRow r in data.Rows)
                {
                    if (tabla == 1)
                    {
                        listaClientes.Items.Add(r["NombreCliente"].ToString()+", "+ r["ID"].ToString());
                    }
                    else
                    {
                        listaProductos.Items.Add(r["Nombre"].ToString()+", "+ r["ID"].ToString());
                    }
                }

                if (tabla == 1)
                {
                    cont = listaClientes.Items.Count;
                    h = listaClientes.ItemHeight;
                    listaClientes.Height = (cont > 5) ? (h * 5) : (h * cont);
                    listaClientes.BringToFront();
                }
                else
                {
                    cont = listaProductos.Items.Count;
                    h = listaProductos.ItemHeight;
                    listaProductos.Height = (cont > 5) ? (h * 5) : (h * cont);
                    listaProductos.BringToFront();
                }
            }
        }

        private void setPrecioStock(int id)
        {
            DataTable data = new Producto().Detalle(id);
            if (data != null)
            {
                DataRow r = data.Rows[0];
                txtStock.Text = r["Stock"].ToString().Replace(".", ",");
                txtPrecioVenta.Text = r["PrecioVenta"].ToString();
                descuentoProducto.Text = "0";

                //DataTable dt = new Producto().detalleProductoOferta(id);
                //if (dt != null)
                //{
                //    DataRow rw = dt.Rows[0];
                //    min = int.Parse(rw[0].ToString());
                //    max = int.Parse(rw[1].ToString());
                //    desc = float.Parse(rw[2].ToString());
                //}
                //else
                //    desc = 0;
            }
            else
            {
                txtStock.Text = "0";
                txtPrecioVenta.Text = "00,00";
                descuentoProducto.Text = "00,00";
            }
        }

        private void obtenerCliente(string id)
        {
            DataTable data = new Cliente().Detalle(id);

            if (data != null){
                DataRow row = data.Rows[0];
                idcliente = row["ID"].ToString();
                txtCliente.Text = row["NombreCliente"].ToString();
            }
        }

        private void obtenerTarjetas()
        {
            //DataTable data = new TarjetaCredito().Listar(idcliente);
            //if(data != null)
            //{
            //    Data
            //}
        }

        private string generaCodFactura()
        {
            string codigo;
            DateTime fa = DateTime.Now;

            codigo = "v" + fa.Day.ToString() + fa.Month.ToString() + fa.Year.ToString().Substring(2, 2);
            codigo += "-" + fa.ToShortTimeString().Replace(":", "");

            return codigo;
        }

        private void clearTextboxDetalle()
        {
            txtProducto.Text = "";
            cantidadVentaProducto.Value = 0;
            txtStock.Text = "";
            txtPrecioVenta.Text = "";
            descuentoProducto.Text = "";
            impuestoValue.Checked = true;
            agregarProductoDetalle.Visible = false;
        }

        private void calculoTotales()
        {
            decimal subtotal = 0, impuesto = 0;
            try {
                foreach (DataGridViewRow r in detalleVenta.Rows) {
                    subtotal += (Convert.ToDecimal(r.Cells[2].Value.ToString()) * Convert.ToDecimal(r.Cells[3].Value.ToString()) - Convert.ToDecimal(r.Cells[4].Value.ToString()));
                    impuesto += Convert.ToDecimal(r.Cells[5].Value.ToString());
                }
            }catch(Exception ex) { }

            labelSubtotal.Text = subtotal.ToString();
            labelImpuesto.Text = impuesto.ToString();
            labelTotal.Text = Convert.ToString(subtotal + impuesto);
        }

        private void saveDetalle(int tipo)
        {
            DetalleVenta d = new DetalleVenta();
            foreach (DataGridViewRow r in detalleVenta.Rows)
            {
                d.ProductoID = int.Parse(r.Cells[0].Value.ToString());
                d.VentaID = txtCodigoVenta.Text;
                d.Cantidad = int.Parse(r.Cells[2].Value.ToString());
                d.PrecioUnitario = decimal.Parse(r.Cells[3].Value.ToString());
                d.Descuento = decimal.Parse(r.Cells[4].Value.ToString());
                d.Impuesto = decimal.Parse(r.Cells[5].Value.ToString());
                d.Total = decimal.Parse(r.Cells[6].Value.ToString());

                if (tipo == 1)
                    d.Insertar();
                else
                    d.Editar();
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if(!cargainfo){
                if (txtCliente.Text.Length > 0)
                    sugerencias(1);
                else
                    listaClientes.Height = 0;

                idcliente = "";
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((listaClientes.Visible) && (listaClientes.SelectedIndex < listaClientes.Items.Count - 1))
                            listaClientes.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (listaClientes.Visible && listaClientes.SelectedIndex >= 0)
                            listaClientes.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (listaClientes.Visible)
                        {
                            listaClientes_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (!listaClientes.ContainsFocus)
                listaClientes.Visible = false;
        }

        private void listaClientes_Leave(object sender, EventArgs e)
        {
            if (!txtCliente.ContainsFocus)
                listaClientes.Visible = false;
        }

        private void listaClientes_Click(object sender, EventArgs e)
        {
            if (listaClientes.SelectedIndex >= 0)
            {
                string[] value = listaClientes.SelectedItem.ToString().Split(',');
                cargainfo = true;
                txtCliente.Text = value[0].Trim();
                idcliente = value[1].Trim();
                cargainfo = false;
            }

            txtCliente.Focus();
            txtCliente.Select(txtCliente.Text.Length, 0);
            listaClientes.Height = 0;
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if(!cargainfo){
                if (txtProducto.Text.Length > 0)
                {
                    sugerencias(2);
                    agregarProductoDetalle.Visible = true;
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
                string[] value = listaProductos.SelectedItem.ToString().Split(',');
                cargainfo = true;
                txtProducto.Text = value[0].Trim();
                idproducto = int.Parse(value[1].Trim());
                setPrecioStock(idproducto);
                cargainfo = false;
            }

            txtProducto.Focus();
            txtProducto.Select(txtProducto.Text.Length, 0);
            listaProductos.Height = 0;
        }

        private void descuentoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == ',' && !descuentoProducto.Text.Contains(e.KeyChar.ToString()))
            {
                if (descuentoProducto.Text == "")
                {
                    descuentoProducto.Text += "0,";
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

        private void agregarProductoDetalle_Click(object sender, EventArgs e)
        {
            if (idproducto != -1)
            {
                if (count == -1)
                {
                    count = detalleVenta.Rows.Count - 1;
                    detalleVenta.Rows.Add(1);
                }
                //string[] value = txtProducto.Text.Split('-');
                txtPrecioVenta.Text = txtPrecioVenta.Text.Replace('.', ',');
                descuentoProducto.Text = descuentoProducto.Text.Replace('.', ',');
                decimal totalvalue = Convert.ToDecimal(int.Parse(cantidadVentaProducto.Text) * decimal.Parse(txtPrecioVenta.Text));
                decimal descuentovalue = Convert.ToDecimal(descuentoProducto.Text);

                string i, n, c, p, d, im, t;
                i = idproducto.ToString();
                n = txtProducto.Text;
                c = cantidadVentaProducto.Value.ToString();
                p = txtPrecioVenta.Text;
                d = descuentovalue.ToString();
                im = (impuestoValue.Checked) ? (((totalvalue - descuentovalue) * decimal.Parse("0,15"))).ToString() : "0";
                t = ( totalvalue - descuentovalue + decimal.Parse(im) ).ToString();

                detalleVenta.Rows[count].Cells[0].Value = i;
                detalleVenta.Rows[count].Cells[1].Value = n;
                detalleVenta.Rows[count].Cells[2].Value = c;
                detalleVenta.Rows[count].Cells[3].Value = p;
                detalleVenta.Rows[count].Cells[4].Value = d;
                detalleVenta.Rows[count].Cells[5].Value = im;
                detalleVenta.Rows[count].Cells[6].Value = t;

                count = -1;
                idproducto = -1;

                clearTextboxDetalle();
                calculoTotales();
            }
            else
                new popup("Error al agregar", popup.AlertType.error);
        }

        private void detalleVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                count = e.RowIndex;

                idproducto = int.Parse(detalleVenta.Rows[count].Cells[0].Value.ToString());
                txtProducto.Text = detalleVenta.Rows[count].Cells[1].Value.ToString();
                cantidadVentaProducto.Text = detalleVenta.Rows[count].Cells[2].Value.ToString();
                txtPrecioVenta.Text = detalleVenta.Rows[count].Cells[3].Value.ToString();
                descuentoProducto.Text = detalleVenta.Rows[count].Cells[4].Value.ToString();
                setPrecioStock(int.Parse(detalleVenta.Rows[count].Cells[0].Value.ToString()));
                impuestoValue.Checked = (Convert.ToDecimal(detalleVenta.Rows[count].Cells[5].Value.ToString()) != 0) ? true : false;
            }
            catch (Exception ex) { }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cantidadVentaProducto_ValueChanged(object sender, EventArgs e)
        {
            if(desc != 0 && (cantidadVentaProducto.Value >= min && cantidadVentaProducto.Value <= max))
            {
                decimal value = (cantidadVentaProducto.Value * decimal.Parse(txtPrecioVenta.Text)) * Convert.ToDecimal(desc);
                descuentoProducto.Text = value.ToString();
            }
        }

        private void tipoPago_onItemSelected(object sender, EventArgs e)
        {

        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            try {
                if (idcliente != "")
                {
                    venta v = new venta();
                    v.Id = txtCodigoVenta.Text;
                    v.ClientId = idcliente;
                    v.TipoPago = tipoPago.selectedIndex;
                    v.FechaVenta = fechaVenta.Value;
                    v.TipoVenta = (ventaCredito.Checked) ? 1 : 0;
                    v.SubTotal = decimal.Parse(labelSubtotal.Text);
                    v.Tax = decimal.Parse(labelImpuesto.Text);
                    v.MontoTotal = decimal.Parse(labelTotal.Text);

                    if (accionformulario == "crear") {
                        v.Insertar();
                        saveDetalle(1);
                    } else {
                        v.Editar();
                        saveDetalle(0);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    new popup("No se pudo realizar la acción", popup.AlertType.error);
            }catch(Exception ex) { }
        }

        private void borrarDetalle_Click(object sender, EventArgs e)
        {
            if (detalleVenta.Rows.Count > 0)
            {
                detalleVenta.Rows.RemoveAt(index);
                calculoTotales();
            }

            borrarDetalle.Visible = false;
        }

        private void detalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accionformulario == "crear")
            {
                borrarDetalle.Visible = true;
                index = e.RowIndex;
            }
        }

        private void detalleVenta_Leave(object sender, EventArgs e)
        {
            borrarDetalle.Visible = false;
        }

        private void detalleVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            borrarDetalle.Visible = false;
        }

    }
}
