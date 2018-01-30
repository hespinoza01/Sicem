using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace sicem
{
    public partial class ofertaForm : Form
    {
        string accionformulario;
        List<int> idvalues = new List<int>();
        int idproducto = -1;
        bool cargainfo = false;
        public ofertaForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public ofertaForm(int id)
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
            if (accionformulario == "crear")
            {
                loadID();
                fechaInicio.Value = DateTime.Now;
                fechaFin.Value = DateTime.Now;
            }

            txtID.Region = new region().RoundBorder(txtID.Width, txtID.Height+1, 7);
            txtTipoOferta.Region = new region().RoundBorder(txtTipoOferta.Width, txtTipoOferta.Height+1, 7);
            txtPorcentajeDescuento.Region = new region().RoundBorder(txtPorcentajeDescuento.Width, txtPorcentajeDescuento.Height+1, 7);
            txtCantidadMin.Region = new region().RoundBorder(txtCantidadMin.Width, txtCantidadMin.Height+1, 7);
            txtCantidadMax.Region = new region().RoundBorder(txtCantidadMax.Width, txtCantidadMax.Height+1, 7);
            txtDescripcion.Region = new region().RoundBorder(txtDescripcion.Width, txtDescripcion.Height+1, 7);
            txtProducto.Region = new region().RoundBorder(txtProducto.Width, txtProducto.Height+1, 7);
            listadoProductoOferta.Region = new region().RoundBorder(listadoProductoOferta.Width, listadoProductoOferta.Height, 7);

            cardFormProducto.Height = 25;
            expand.Height = 25;
            expand.Iconimage = sicem.Properties.Resources.expandir;

            txtProducto.TextChanged += txtProducto_TextChanged;
            txtProducto.KeyDown += txtProducto_KeyDown;
            txtProducto.Leave += txtProducto_Leave;

            new drag().setDragable(toppanel);

            listaSugerencia();
        }

        private void listaSugerencia()
        {
            sugerencia.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            sugerencia.ForeColor = Color.RoyalBlue;
            sugerencia.ItemHeight = 15;

            txtProducto.TopLevelControl.Controls.Add(sugerencia);
            sugerencia.Width = txtProducto.Width-10;
            sugerencia.Height = 0;
            sugerencia.Leave += sugerencia_Leave;
            sugerencia.Visible = true;
        }

        private void setDataView(int id)
        {
            DataTable data = new OfertaEspecial().Detalle(id);

            if(data != null){
                cargainfo = true;
                DataRow row = data.Rows[0];

                txtID.Text = row["ID"].ToString();
                txtDescripcion.Text = row["Descripcion"].ToString();
                txtPorcentajeDescuento.Value = Convert.ToDecimal(float.Parse(row["PorcentajeDescuento"].ToString()) * 100);
                txtTipoOferta.Text = row["tipoOferta"].ToString();
                fechaInicio.Value = (DateTime)row["FechaInicio"];
                fechaFin.Value = (DateTime)row["FechaFinal"];
                txtCantidadMin.Text = row["MinCantidad"].ToString();
                txtCantidadMax.Text = row["MaxCantidad"].ToString();
                listaProductos();

                cargainfo = false;
            }else{
                new popup("Error al mostrar información", popup.AlertType.error);
                this.Close();
            }

        }

        private void listaProductos(){
            DataTable data = new OfertaEspecial().listadoProductos(int.Parse(txtID.Text));

            if (data != null)
            {
                listadoProductoOferta.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    string id, n;
                    id = row[0].ToString();
                    n = row[1].ToString();
                    listadoProductoOferta.Rows.Add(id, n);
                }
            }
        }

        private void loadID()
        {
            object value = new DBHelper().ReaderScalar("select count(*) + 1 from OfertaEspecial");
            txtID.Text = (value != null) ? value.ToString() : "";
        }

        private void sugerencias()
        {
            DataTable data = new Producto().Buscar(txtProducto.Text, 0);
            idproducto = -1;
            if(data != null)
            {
                sugerencia.Items.Clear();
                idvalues.Clear();
                foreach(DataRow r in data.Rows)
                {
                    sugerencia.Items.Add(r["Nombre"].ToString());
                    idvalues.Add((int)r["ID"]);
                }

                sugerencia.Height = (sugerencia.Items.Count < 5) ? (sugerencia.ItemHeight * sugerencia.Items.Count) : (sugerencia.ItemHeight * 5);
                sugerencia.BringToFront();
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
                OfertaEspecial o = new OfertaEspecial();
                o.Descripcion = txtDescripcion.Text;
                o.PorcentajeDescuento = int.Parse(txtPorcentajeDescuento.Text) / 100;
                o.TipoOferta = txtTipoOferta.Text;
                o.FechaInicio = fechaInicio.Value;
                o.FechaFinal = fechaFin.Value;
                o.MinCantidad = (int)txtCantidadMin.Value;
                o.MaxCantidad = (int)txtCantidadMax.Value;

                if (accionformulario == "crear")
                {
                    o.Insertar();
                } else {
                    o.ID = int.Parse(txtID.Text);
                    o.Editar();
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

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (!cargainfo)
            {
                if (txtProducto.Text.Length > 0)
                {
                    Point controlLocation = txtTipoOferta.TopLevelControl.PointToClient(txtProducto.Parent.PointToScreen(txtProducto.Location));
                    sugerencia.Left = controlLocation.X + 5;
                    sugerencia.Top = controlLocation.Y + txtProducto.Height;
                    sugerencias();

                }
                else
                    sugerencia.Height = 0;
            }
        }

        private void sugerencia_Click(object sender, EventArgs e)
        {
            if (sugerencia.SelectedIndex >= 0)
            {
                cargainfo = true;
                txtProducto.Text = sugerencia.SelectedItem.ToString();
                idproducto = idvalues[sugerencia.SelectedIndex];
                cargainfo = false;
            }

            txtProducto.Focus();
            txtProducto.Select(txtProducto.Text.Length, 0);
            sugerencia.Height = 0;
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
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

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (!sugerencia.ContainsFocus)
                sugerencia.Height = 0;
        }

        private void sugerencia_Leave(object sender, EventArgs e)
        {
            if (!txtProducto.ContainsFocus)
                sugerencia.Height = 0;
        }

        bool expandActive = false;
        private void expand_Click(object sender, EventArgs e)
        {
            if (!expandActive)
            {
                Transition.run(cardFormProducto, "Height", 85, new TransitionType_EaseInEaseOut(500));
                expand.Iconimage = sicem.Properties.Resources.contraer;
                txtProducto.Visible = true;
                expandActive = true;
            }
            else
            {
                expandActive = false;
                expand.Iconimage = sicem.Properties.Resources.expandir;
                txtProducto.Visible = false;
                Transition.run(cardFormProducto, "Height", 25, new TransitionType_EaseInEaseOut(500));
                txtProducto.Clear();
            }

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (idproducto != -1)
            {
                if (new OfertaEspecial().InsertarOfertaProducto(int.Parse(txtID.Text), idproducto))
                {
                    listadoProductoOferta.Rows.Add(idproducto, txtProducto.Text);
                    txtProducto.Clear();
                    idproducto = -1;
                }
            }
            else
                new popup("Producto no valido", popup.AlertType.warning);
        }

        private void txtCantidadMin_ValueChanged(object sender, EventArgs e)
        {
            if (txtCantidadMax.Value < txtCantidadMin.Value)
                txtCantidadMax.Value = txtCantidadMin.Value;
        }

        private void fechaInicio_onValueChanged(object sender, EventArgs e)
        {
            if (fechaFin.Value.Subtract(fechaInicio.Value).TotalDays < 0)
                fechaFin.Value = fechaInicio.Value;
        }

        private void listadoProductoOferta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idproducto = (int)listadoProductoOferta.Rows[e.RowIndex].Cells[0].Value;
                if (new logoutDialog("¿ Remover producto ?").ShowDialog() == DialogResult.OK)
                {
                    if (new OfertaEspecial().RemoverOfertaProducto(int.Parse(txtID.Text), idproducto))
                    {
                        listadoProductoOferta.Rows.RemoveAt(e.RowIndex);
                    }
                }

                idproducto = -1;
            }
            catch (Exception ex) { }
        }
    }
}
