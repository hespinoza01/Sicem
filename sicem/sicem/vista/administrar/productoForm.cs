using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem
{
    public partial class productoForm : Form
    {
        string accionformulario;
        //ListBox sugerencia = new ListBox();
        public productoForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public productoForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }

        private void productoForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            guardarButton.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            txtID.Region = new region().RoundBorder(txtID.Width, txtID.Height+1, 7);
            txtNombreProducto.Region = new region().RoundBorder(txtNombreProducto.Width, txtNombreProducto.Height+1, 7);
            txtIDCategoria.Region = new region().RoundBorder(txtIDCategoria.Width, txtIDCategoria.Height+1, 7);
            txtPrecioVenta.Region = new region().RoundBorder(txtPrecioVenta.Width, txtPrecioVenta.Height+1, 7);
            txtCantidadPorUnidad.Region = new region().RoundBorder(txtCantidadPorUnidad.Width, txtCantidadPorUnidad.Height+1, 7);
            txtStock.Region = new region().RoundBorder(txtStock.Width, txtStock.Height+1, 7);
            txtDescripcion.Region = new region().RoundBorder(txtDescripcion.Width, txtDescripcion.Height+1, 7);

            listaSugerencia();
        }

        private void listaSugerencia()
        {
            sugerencia.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            sugerencia.ForeColor = Color.RoyalBlue;
            sugerencia.ItemHeight = 15;
            //sugerencia.DrawMode = DrawMode.OwnerDrawFixed;
            //sugerencia.DrawItem += sugerencia_DrawItem;

            txtIDCategoria.TopLevelControl.Controls.Add(sugerencia);
            Point controlLocation = txtIDCategoria.TopLevelControl.PointToClient(txtIDCategoria.Parent.PointToScreen(txtIDCategoria.Location));
            sugerencia.Left = controlLocation.X + 5;
            sugerencia.Top = controlLocation.Y + txtIDCategoria.Height;
            sugerencia.Width = txtIDCategoria.Width-10;
            sugerencia.Height = 0;//sugerencia.ItemHeight * 5;
            //sugerencia.Region = new region().RoundBorder(sugerencia.Width, sugerencia.Height, 5);
            sugerencia.Click += sugerencia_Click;
            sugerencia.Leave += sugerencia_Leave;
            sugerencia.Visible = true;
            //for(int i=0; i<10; i++)
            //sugerencia.Items.Add("ListBox Item "+i);
        }

        private void setDataView(int id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Producto where ID = '" + id + "'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtID.Text = row["ID"].ToString();
                    txtNombreProducto.Text = row["Nombre"].ToString();
                    txtPrecioVenta.Text = row["PrecioVenta"].ToString();
                    txtStock.Text = row["Stock"].ToString();
                    txtIDCategoria.Text = row["CategoriaID"].ToString();
                    txtDescripcion.Text = row["Descripcion"].ToString();
                    if (int.Parse(row["Estado"].ToString()) == 0)
                        estadoValor.Checked = false;
                    else
                        estadoValor.Checked = true;
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.CategoriaID = int.Parse( txtIDCategoria.Text);
            p.Nombre = txtNombreProducto.Text;
            p.Descripcion = txtDescripcion.Text;
            p.Stock = int.Parse(txtStock.Text );
            p.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
            p.Estado = (estadoValor.Checked) ? 1 : 0;

                if (accionformulario == "crear")
                {
                    try {
                        p.Insertar();
                    }
                    catch (Exception ex) { new popup("Inserción fallida", popup.AlertType.error); }
                }
                else
                {
                    try {
                        p.ID = int.Parse(txtID.Text);
                        p.Editar();
                    }
                    catch (Exception ex) { new popup("Actualización fallida", popup.AlertType.error); }
                }

            this.Close();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) ? false : true;
        }

        private void txtCantidadPorUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) ? false : true;
        }

        private void sugerencia_Paint(object sender, PaintEventArgs e)
        {
            //GraphicsPath GP = default(GraphicsPath);
            //GP = new region().RoundRect(0, 0, sugerencia.Width-1, sugerencia.Height-1, 5);
            //e.Graphics.DrawPath(new Pen(Color.RoyalBlue), GP);
        }

        //private void sugerencia_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        //    {
        //        e.Graphics.FillRectangle(new SolidBrush(Color.RoyalBlue), e.Bounds);
        //    }
        //    else
        //    {
        //        e.Graphics.FillRectangle(Brushes.White, e.Bounds);
        //    }

        //    if (!(e.Index == -1))
        //    {
        //        e.Graphics.DrawString(sugerencia.GetItemText(sugerencia.Items[e.Index]), e.Font, Brushes.DimGray, e.Bounds);
        //    }
        //}

        private void txtIDCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtIDCategoria.Text.Length > 0)
            {
                sugerencia.Height = sugerencia.ItemHeight * 5;
                sugerencia.BringToFront();
            }
            else
                sugerencia.Height = 0;
        }

        private void sugerencia_Click(object sender, EventArgs e)
        {
            if(sugerencia.SelectedIndex >= 0)
                txtIDCategoria.Text = sugerencia.SelectedItem.ToString();

            txtIDCategoria.Focus();
            txtIDCategoria.Select(txtIDCategoria.Text.Length, 0);
            sugerencia.Height = 0;
        }

        private void txtIDCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((sugerencia.Visible) && (sugerencia.SelectedIndex < sugerencia.Items.Count - 1))
                            sugerencia.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (sugerencia.Visible && sugerencia.SelectedIndex >= 0)
                            sugerencia.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (sugerencia.Visible)
                        {
                            sugerencia_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void txtIDCategoria_Leave(object sender, EventArgs e)
        {
            if (!sugerencia.ContainsFocus)
                sugerencia.Height = 0;
        }

        private void sugerencia_Leave(object sender, EventArgs e)
        {
            if (!txtIDCategoria.ContainsFocus)
                sugerencia.Height = 0;
        }

        
    }
}
