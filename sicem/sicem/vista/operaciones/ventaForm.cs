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
        int count, index, idcliente, idproducto;
        string accionformulario;

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
            addListasSugerencias();
        }

        private void inicia()
        {
            txtCliente.Region = new region().RoundBorder(235, 28, 7);
            txtCodigoVenta.Region = new region().RoundBorder(170, 28, 7);
            txtProducto.Region = new region().RoundBorder(235, 28, 7);
            cantidadVentaProducto.Region = new region().RoundBorder(75, 28, 7);
            txtStock.Region = new region().RoundBorder(75, 28, 7);
            txtPrecioVenta.Region = new region().RoundBorder(75, 28, 7);
            descuentoProducto.Region = new region().RoundBorder(84, 28, 7);

            if (accionformulario == "crear")
            {
                txtCodigoVenta.Text = generaCodFactura();
                guardarButton.ButtonText = "Guardar";
                fechaVenta.Value = DateTime.Now;
                labelSubtotal.Text = "00,00";
                labelImpuesto.Text = "00,00";
                labelTotal.Text = "00,00";
            }
            else
            {
                guardarButton.ButtonText = "Actualizar";
            }
        }

        private void addListasSugerencias()
        {
            txtCliente.TopLevelControl.Controls.Add(listaClientes);
            Point controlLocation = txtCliente.TopLevelControl.PointToClient(txtCliente.Parent.PointToScreen(txtCliente.Location));
            listaClientes.Left = controlLocation.X + 3;
            listaClientes.Top = controlLocation.Y + txtCliente.Height;
            listaClientes.Width = txtCliente.Width;
            listaClientes.Height = listaClientes.ItemHeight * 6;

            txtProducto.TopLevelControl.Controls.Add(listaProductos);
            controlLocation = txtProducto.TopLevelControl.PointToClient(txtProducto.Parent.PointToScreen(txtProducto.Location));
            listaProductos.Left = controlLocation.X + 3;
            listaProductos.Top = controlLocation.Y + txtProducto.Height;
            listaProductos.Width = txtProducto.Width;
            listaProductos.Height = listaProductos.ItemHeight * 6;
        }

        private string generaCodFactura()
        {
            string codigo;
            DateTime fa = DateTime.Now;

            codigo = "V" + fa.Day + fa.Month + fa.Year.ToString().Substring(2, 2);
            codigo += "-" + fa.ToShortTimeString().Replace(":", "-");

            return codigo;
        }

        private void clearTextboxDetalle()
        {
            txtProducto.Text = "";
            cantidadVentaProducto.Text = "";
            txtStock.Text = "";
            txtPrecioVenta.Text = "";
            descuentoProducto.Text = "";
            impuestoValue.Checked = true;
        }

        private void calculoTotales()
        {
            decimal subtotal = 0, impuesto = 0;
            for (int i = 0; i < detalleVenta.Rows.Count; i++)
            {
                subtotal += (int.Parse(detalleVenta.Rows[i].Cells[2].Value.ToString()) * Convert.ToDecimal(detalleVenta.Rows[i].Cells[3].Value.ToString()) - Convert.ToDecimal(detalleVenta.Rows[i].Cells[4].Value.ToString()));
                impuesto += Convert.ToDecimal(detalleVenta.Rows[i].Cells[5].Value.ToString());
            }

            labelSubtotal.Text = subtotal.ToString();
            labelImpuesto.Text = impuesto.ToString();
            labelTotal.Text = Convert.ToString(subtotal + impuesto);
        }

        private DataTable getSugerencias(string value, string tabla)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Usuario");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select ID, Nombre from " + tabla + " where ID like '%" + value + "%' or Nombre like '%" + value + "%'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);
                }
                catch (Exception ex)
                {
                    //new popup("Error al mostrar información", popup.AlertType.error);
                    data = null;
                }

                return data;
            }
        }

        private void setPrecioStock(int id)
        {
            DataTable data = new DataTable("Data");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select PrecioVenta, Stock from Producto where ID = '" + id + "'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtPrecioVenta.Text = row["PrecioVenta"].ToString();
                    txtStock.Text = row["Stock"].ToString();

                }
                catch (Exception ex)
                {
                }
                finally { cn.Close(); }
            }
        }

        private string setStock(int id)
        {
            Conexión conexion = new Conexión();
            int contador;

            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand("select Stock from Producto where ID = '" + id + "'", cn);

                    contador = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex) { contador = 0; }
                finally { cn.Close(); }
            }

            return contador.ToString();
        }

        private void setDataView(string id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Venta where ID = '" + id + "'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtCodigoVenta.Text = row["ID"].ToString();
                    txtCliente.Text = obtenerCliente(row["ClienteID"].ToString());
                    tipoPago.selectedIndex = int.Parse(row["TipoPago"].ToString());
                    fechaVenta.Value = DateTime.Parse(row["FechaVenta"].ToString());
                    if (int.Parse(row["TipoVenta"].ToString()) == 0)
                        ventaCredito.Checked = false;
                    else
                        ventaCredito.Checked = true;

                    getDetalleVenta(txtCodigoVenta.Text);
                }
                catch (Exception ex)
                {
                    //new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

        }

        private string obtenerCliente(string id)
        {
            DataTable data = new DataTable("Cliente");
            string value;
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select ID, Nombre from Cliente where ID = '" + id + "'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    idcliente = int.Parse(row["ID"].ToString());
                    value = row["Nombre"].ToString();
                }
                catch (Exception ex)
                {
                    value = "";
                }

                return value;
            }
        }

        private void getDetalleVenta(string id)
        {
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "Mostrar_Detalle_Venta";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ID = new SqlParameter();
                    ID.ParameterName = "@id";
                    ID.SqlDbType = SqlDbType.VarChar;
                    ID.Size = 15;
                    ID.Value = id;
                    cmd.Parameters.Add(ID);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    detalleVenta.Rows.Clear();

                    foreach (DataRow row in data.Rows)
                    {
                        string pid, n, c, pu, d, i, t;
                        pid = Convert.ToString(row[0]);
                        n = Convert.ToString(row[1]);
                        c = Convert.ToString(row[2]);
                        pu = Convert.ToString(row[3]);
                        d = Convert.ToString(row[4]);
                        i = Convert.ToString(row[5]);
                        t = Convert.ToString(row[6]);
                        detalleVenta.Rows.Add(pid, n, c, pu, d, i, t);
                    }

                }
                catch (Exception ex)
                {
                    data = null;
                }
            }

        }

        private void saveDetalle(int tipo)
        {
            DetalleVenta d = new DetalleVenta();
            for (int i = 0; i < detalleVenta.Rows.Count; i++)
            {
                d.ProductoID = int.Parse(detalleVenta.Rows[i].Cells[0].Value.ToString());
                d.VentaID = txtCodigoVenta.Text;
                d.Cantidad = int.Parse(detalleVenta.Rows[i].Cells[2].Value.ToString());
                d.PrecioUnitario = decimal.Parse(detalleVenta.Rows[i].Cells[3].Value.ToString());
                d.Descuento = decimal.Parse(detalleVenta.Rows[i].Cells[4].Value.ToString());
                d.Impuesto = decimal.Parse(detalleVenta.Rows[i].Cells[5].Value.ToString());
                d.Total = decimal.Parse(detalleVenta.Rows[i].Cells[6].Value.ToString());

                if (tipo == 1)
                    d.Insertar();
                else
                    d.Editar();
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text.Length > 0)
            {
                //listaClientes.DataSource = getSugerencias(txtCliente.Text, "Cliente");
                listaClientes.Visible = true;
                listaClientes.BringToFront();
            }
            else
                listaClientes.Visible = false;

            idcliente = -1;
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
            if(listaClientes.SelectedIndex >= 0)
                txtCliente.Text = listaClientes.SelectedItem.ToString();

            txtCliente.Focus();
            txtCliente.Select(txtCliente.Text.Length, 0);
            listaClientes.Visible = false;
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text.Length > 0)
            {
                //listaProductos.DataSource = getSugerencias(txtProducto.Text, "Producto");
                listaProductos.Visible = true;
                listaProductos.BringToFront();
            }
            else
                listaProductos.Visible = false;

            idproducto = -1;
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
            if(listaProductos.SelectedIndex >= 0)
                txtProducto.Text = listaProductos.SelectedItem.ToString();

            txtProducto.Focus();
            txtProducto.Select(txtProducto.Text.Length, 0);
            listaProductos.Visible = false;
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

                detalleVenta.Rows[count].Cells[0].Value = idproducto;
                detalleVenta.Rows[count].Cells[1].Value = txtProducto.Text;
                detalleVenta.Rows[count].Cells[2].Value = cantidadVentaProducto.Text;
                detalleVenta.Rows[count].Cells[3].Value = txtPrecioVenta.Text;
                detalleVenta.Rows[count].Cells[4].Value = descuentovalue;
                if (impuestoValue.Checked)
                    detalleVenta.Rows[count].Cells[5].Value = (totalvalue - descuentovalue) * decimal.Parse("0,15");
                else
                    detalleVenta.Rows[count].Cells[5].Value = 0;
                detalleVenta.Rows[count].Cells[6].Value = totalvalue - descuentovalue + decimal.Parse(detalleVenta.Rows[count].Cells[5].Value.ToString());

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
                count = e.RowIndex;

                idproducto = int.Parse(detalleVenta.Rows[count].Cells[0].Value.ToString());
                txtProducto.Text = detalleVenta.Rows[count].Cells[1].Value.ToString();
                cantidadVentaProducto.Text = detalleVenta.Rows[count].Cells[2].Value.ToString();
                txtPrecioVenta.Text = detalleVenta.Rows[count].Cells[3].Value.ToString();
                descuentoProducto.Text = detalleVenta.Rows[count].Cells[4].Value.ToString();
                txtStock.Text = setStock(int.Parse(detalleVenta.Rows[count].Cells[0].Value.ToString()));
                if (Convert.ToDecimal(detalleVenta.Rows[count].Cells[5].Value.ToString()) != 0)
                    impuestoValue.Checked = true;
                else
                    impuestoValue.Checked = false;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear" || accionformulario == "editar")
            {
                if (idcliente != -1)
                {
                    //string[] valueid = txtCliente.Text.Split('-');
                    venta v = new venta();
                    v.Id = txtCodigoVenta.Text;
                    v.ClientId = idcliente;
                    v.TipoPago = tipoPago.selectedIndex;
                    v.FechaVenta = fechaVenta.Value;
                    if (ventaCredito.Checked)
                        v.TipoVenta = 1;
                    else
                        v.TipoVenta = 0;
                    v.SubTotal = decimal.Parse(labelSubtotal.Text);
                    v.Tax = decimal.Parse(labelImpuesto.Text);
                    v.MontoTotal = decimal.Parse(labelTotal.Text);

                    if (accionformulario == "crear")
                    {
                        try{

                            v.Insertar();
                            saveDetalle(1);
                        }catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                        this.Close();
                    }
                    else
                    {
                        try{
                            v.Editar();
                            saveDetalle(0);
                        }catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                    new popup("No se puede guardar la venta", popup.AlertType.error);

            }
            else
                this.Close();
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
