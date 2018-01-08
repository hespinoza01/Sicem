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
    public partial class compraForm : Form
    {
        int count, index, idproveedor = 0, idproducto;
        string accionformulario;

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
            addListasSugerencias();

            txtProveedor.Region = new region().RoundBorder(235, 28, 7);
            txtCodigoCompra.Region = new region().RoundBorder(170, 28, 7);
            txtProducto.Region = new region().RoundBorder(235, 28, 7);
            txtCantidadProducto.Region = new region().RoundBorder(115, 28, 7);
            txtCostoUnitario.Region = new region().RoundBorder(115, 28, 7);

            guardarButton.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            if (accionformulario == "crear")
            {
                txtCodigoCompra.Text = generaCodFactura();
                fechaCompra.Value = DateTime.Now;
            }
            else
                crearProducto.Visible = false;
        }

        private void addListasSugerencias()
        {
            txtProveedor.TopLevelControl.Controls.Add(listaProveedores);
            Point controlLocation = txtProveedor.TopLevelControl.PointToClient(txtProveedor.Parent.PointToScreen(txtProveedor.Location));
            listaProveedores.Left = controlLocation.X + 5;
            listaProveedores.Top = controlLocation.Y + txtProveedor.Height;
            listaProveedores.Width = txtProveedor.Width-10;
            listaProveedores.Height = listaProveedores.ItemHeight * 5;

            txtProducto.TopLevelControl.Controls.Add(listaProductos);
            controlLocation = txtProducto.TopLevelControl.PointToClient(txtProducto.Parent.PointToScreen(txtProducto.Location));
            listaProductos.Left = controlLocation.X + 5;
            listaProductos.Top = controlLocation.Y + txtProducto.Height;
            listaProductos.Width = txtProducto.Width-10;
            listaProductos.Height = listaProductos.ItemHeight * 5;
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
                        "select * from Compra where ID = '" + id + "'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtCodigoCompra.Text = row["ID"].ToString();
                    txtProveedor.Text = obtenerProveedor(row["ProveedorID"].ToString());
                    tipoPago.selectedIndex = int.Parse(row["TipoPago"].ToString());
                    fechaCompra.Value = DateTime.Parse(row["FechaCompra"].ToString());
                    txtTotalCompra.Text = row["Monto"].ToString();

                    getDetalleCompra(txtCodigoCompra.Text);
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

        }

        private string obtenerProveedor(string id)
        {
            DataTable data = new DataTable("Cliente");
            string value;
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select ID, Nombre from Proveedor where ID = " + id,
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    idproveedor = int.Parse(row["ID"].ToString());
                    value = row["Nombre"].ToString();
                }
                catch (Exception ex)
                {
                    value = "";
                }

                return value;
            }
        }

        private string getSugerencias(int id, string tabla)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Data");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select ID, Nombre from " + tabla + " where ID = '" + id + "'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    if (tabla == "Proveedor")
                        idproveedor = int.Parse(row["ID"].ToString());
                    else
                        idproducto = int.Parse(row["ID"].ToString());

                    return row["Nombre"].ToString();
                }
                catch (Exception ex)
                {
                    return "";
                }
                finally { cn.Close(); }
            }
        }

        private void getDetalleCompra(string id)
        {
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "Mostrar_Detalle_Compra";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ID = new SqlParameter();
                    ID.ParameterName = "@id";
                    ID.SqlDbType = SqlDbType.VarChar;
                    ID.Size = 15;
                    ID.Value = id;
                    cmd.Parameters.Add(ID);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    detalleCompra.Rows.Clear();

                    foreach (DataRow row in data.Rows)
                    {
                        string pid, n, c, cu, t;
                        pid = Convert.ToString(row[0]);
                        n = Convert.ToString(row[1]);
                        c = Convert.ToString(row[2]);
                        cu = Convert.ToString(row[3]);
                        t = Convert.ToString(row[4]);
                        detalleCompra.Rows.Add(pid, n, c, cu, t);
                    }

                }
                catch (Exception ex){ }
                finally { cn.Close(); }
            }

        }

        private void saveDetalle(int tipo)
        {
            DetalleCompra d = new DetalleCompra();
            for (int i = 0; i < detalleCompra.Rows.Count; i++)
            {
                d.ProdID = int.Parse(detalleCompra.Rows[i].Cells[0].Value.ToString());
                d.CompraID = int.Parse(txtCodigoCompra.Text);
                d.Cant = int.Parse(detalleCompra.Rows[i].Cells[2].Value.ToString());
                d.UnitPrice = decimal.Parse(detalleCompra.Rows[i].Cells[3].Value.ToString());
                d.Total = decimal.Parse(detalleCompra.Rows[i].Cells[4].Value.ToString());

                if (tipo == 1)
                    d.Insertar();
                else
                    d.Editar();
            }
        }

        private string generaCodFactura()
        {
            string codigo;
            DateTime fa = DateTime.Now;

            codigo = "C" + fa.Day + fa.Month + fa.Year.ToString().Substring(2, 2);
            codigo += "-" + fa.ToShortTimeString().Replace(":", "-");

            return codigo;
        }

        private void clearTextboxDetalle()
        {
            txtProducto.Text = "";
            txtCantidadProducto.Text = "";
            txtCostoUnitario.Text = "";
        }

        private decimal calculoTotalCompra()
        {
            decimal total = 0;
            for (int i = 0; i < detalleCompra.Rows.Count; i++)
                total += Convert.ToDecimal(detalleCompra.Rows[0].Cells[4].Value.ToString());

            return total;
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtProveedor.Text.Length > 0)
            {
                listaProveedores.Visible = true;
                listaProveedores.BringToFront();
                //vistaProducto.DataSource = new Producto().Buscar(txtProducto.Text, 0);
            }
            else
                listaProveedores.Visible = false;

            idproveedor = -1;
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
            if(listaProveedores.SelectedIndex >= 0)
                txtProveedor.Text = listaProveedores.SelectedItem.ToString();

            txtProveedor.Focus();
            txtProveedor.Select(txtProveedor.Text.Length, 0);
            listaProveedores.Visible = false;
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text.Length > 0)
            {
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
            if (idproveedor != -1)
            {
                //string[] value = txtProveedor.Text.Split('-');
                compra c = new compra();
                c.ID = txtCodigoCompra.Text;
                c.ProveedorID = idproveedor;
                c.TipoPago = tipoPago.selectedIndex;
                c.FechaCompra = fechaCompra.Value;
                c.Monto = decimal.Parse(txtTotalCompra.Text);

                if (accionformulario == "crear")
                {
                    try{
                        c.Insertar();
                        saveDetalle(1);
                    }catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                    this.Close();
                }
                else
                {
                    try{
                        c.Editar();
                        saveDetalle(0);
                    }catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                }
            }
            else
                new popup("No se pudo guardar la compra", popup.AlertType.error);


            this.Close();
        }

        private void crearProducto_Click(object sender, EventArgs e)
        {
            //new productoForm().ShowDialog();
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
                detalleCompra.Rows[count].Cells[1].Value = txtProducto;
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
            count = e.RowIndex;

            idproducto = int.Parse(detalleCompra.Rows[count].Cells[0].Value.ToString());
            txtProducto.Text = detalleCompra.Rows[count].Cells[1].Value.ToString();
            txtCantidadProducto.Text = detalleCompra.Rows[count].Cells[2].Value.ToString();
            txtCostoUnitario.Text = detalleCompra.Rows[count].Cells[3].Value.ToString();
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
