using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem//.vista.administrar
{
    public partial class productoForm : Form
    {
        string accionformulario;
        int idc = 0;
        List<int> idcategoria = new List<int>();
        bool cargainfo = false;
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
            if(accionformulario == "crear") loadID();
            guardarButton.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            txtID.Region = new region().RoundBorder(txtID.Width, txtID.Height + 1, 7);
            txtNombreProducto.Region = new region().RoundBorder(txtNombreProducto.Width, txtNombreProducto.Height + 1, 7);
            txtIDCategoria.Region = new region().RoundBorder(txtIDCategoria.Width, txtIDCategoria.Height + 1, 7);
            txtPrecioVenta.Region = new region().RoundBorder(txtPrecioVenta.Width, txtPrecioVenta.Height + 1, 7);
            txtCantidadPorUnidad.Region = new region().RoundBorder(txtCantidadPorUnidad.Width, txtCantidadPorUnidad.Height + 1, 7);
            txtStock.Region = new region().RoundBorder(txtStock.Width, txtStock.Height + 1, 7);
            txtDescripcion.Region = new region().RoundBorder(txtDescripcion.Width, txtDescripcion.Height + 1, 7);

            new drag().setDragable(toppanel);

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
            sugerencia.Width = txtIDCategoria.Width - 10;
            sugerencia.Height = 0;//sugerencia.ItemHeight * 5;
            //sugerencia.Region = new region().RoundBorder(sugerencia.Width, sugerencia.Height, 5);
            sugerencia.Click += sugerencia_Click;
            sugerencia.Leave += sugerencia_Leave;
            sugerencia.Visible = true;
            //for(int i=0; i<10; i++)
            //sugerencia.Items.Add("ListBox Item "+i);
        }

        private void sugerenciaCategoria()
        {
            DataTable data = new Categoria().Buscar(txtIDCategoria.Text);
            idc = 0;

            if (data != null)
            {
                sugerencia.Items.Clear();
                idcategoria.Clear();
                foreach (DataRow row in data.Rows)
                {
                    idcategoria.Add((int)row["ID"]);
                    sugerencia.Items.Add(row["Nombre"].ToString());
                }

                sugerencia.Height = (sugerencia.Items.Count < 5) ? (sugerencia.ItemHeight * sugerencia.Items.Count) : (sugerencia.ItemHeight * 5);
                sugerencia.BringToFront();
            }
        }

        private void setDataView(int id)
        {
            DataTable data = new Producto().Detalle(id);

            if (data != null)
            {
                cargainfo = true;
                DataRow row = data.Rows[0];

                txtID.Text = row["ID"].ToString();
                txtNombreProducto.Text = row["Nombre"].ToString();
                txtPrecioVenta.Text = row["PrecioVenta"].ToString();
                txtStock.Value = decimal.Parse(row["Stock"].ToString());
                txtCantidadPorUnidad.Value = decimal.Parse(row["CantidadPorUnidad"].ToString());
                setValorCategoria(int.Parse(row["CategoriaID"].ToString()));
                txtDescripcion.Text = row["Descripcion"].ToString();
                estadoValor.Checked = (int.Parse(row["Estado"].ToString()) == 0) ? false : true;

                cargainfo = false;
            }
            else
            {
                new popup("Error al mostrar información", popup.AlertType.error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void setValorCategoria(int id)
        {
            DataRow r = new Categoria().Detalle(id).Rows[0];
            idc = int.Parse(r["ID"].ToString());
            txtIDCategoria.Text = r["Nombre"].ToString();
        }

        private void loadID()
        {
            object value = new DBHelper().ReaderScalar("select count(*) + 1 from Producto");
            if(value != null)
                txtID.Text = value.ToString();
        }

        public void historialPrecio() {
            string cmd = "select Precio from HistorialPrecioProducto where ProductoID = '" + txtID.Text + "' and FechaFinal = null";
            object value = new DBHelper().ReaderScalar(cmd);
            if(value != null)
            {
                if (decimal.Parse(value.ToString().Replace(".", ",")) != decimal.Parse(txtPrecioVenta.Text.Replace(".", ",")))
                    new Producto().InsertarHistorialPrecio(int.Parse(txtID.Text), decimal.Parse(txtPrecioVenta.Text.Replace(".", ",")));
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            try {
                Producto p = new Producto();
                p.CategoriaID = idc;
                p.Nombre = txtNombreProducto.Text;
                p.Descripcion = txtDescripcion.Text;
                p.CantidadPorUnidad = (int)txtCantidadPorUnidad.Value;
                p.Stock = int.Parse(txtStock.Text);
                p.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
                p.Estado = (estadoValor.Checked) ? 1 : 0;

                if (accionformulario == "crear")
                {
                    p.Insertar();
                }
                else
                {
                    historialPrecio();
                    p.ID = int.Parse(txtID.Text);
                    p.Editar();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }catch(Exception ex) { }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) ? false : true;
        }

        private void txtCantidadPorUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) ? false : true;
        }

        private void txtIDCategoria_TextChanged(object sender, EventArgs e)
        {
            if (!cargainfo)
            {
                if (txtIDCategoria.Text.Length > 0)
                    sugerenciaCategoria();
                else
                    sugerencia.Height = 0;
            }
        }

        private void sugerencia_Click(object sender, EventArgs e)
        {
            if (sugerencia.SelectedIndex >= 0)
            {
                cargainfo = true;
                txtIDCategoria.Text = sugerencia.SelectedItem.ToString();
                idc = idcategoria[sugerencia.SelectedIndex];
                cargainfo = false;
            }

            txtIDCategoria.Focus();
            txtIDCategoria.Select(txtIDCategoria.Text.Length, 0);
            sugerencia.Height = 0;
        }

        private void sugerencia_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            sugerencia_Click(null, null);
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
