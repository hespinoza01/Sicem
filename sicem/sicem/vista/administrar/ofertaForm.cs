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
            fechaInicio.Value = DateTime.Now;
            fechaFin.Value = DateTime.Now;

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
                    txtCantidadMax.Text = row["Stock"].ToString();
                    txtTipoOferta.Text = row["CategoriaID"].ToString();
                    txtDescripcion.Text = row["Descripcion"].ToString();
                    
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
            p.CategoriaID = int.Parse( txtTipoOferta.Text);
            p.Descripcion = txtDescripcion.Text;
            p.Stock = int.Parse(txtCantidadMax.Text );

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

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text.Length > 0)
            {
                Point controlLocation = txtTipoOferta.TopLevelControl.PointToClient(txtProducto.Parent.PointToScreen(txtProducto.Location));
                sugerencia.Left = controlLocation.X + 5;
                sugerencia.Top = controlLocation.Y + txtProducto.Height;
                sugerencia.Height = sugerencia.ItemHeight * 5;
                sugerencia.BringToFront();
            }
            else
                sugerencia.Height = 0;
        }

        private void sugerencia_Click(object sender, EventArgs e)
        {
            if (sugerencia.SelectedIndex >= 0)
                txtProducto.Text = sugerencia.SelectedItem.ToString();

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
                Transition.run(cardFormProducto, "Height", 80, new TransitionType_EaseInEaseOut(500));
                //expand.Height = 0;
                //Transition.run(contentEditor, "Height", 45, new TransitionType_EaseInEaseOut(500));
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
                //Transition.run(expand, "Height", 25, new TransitionType_EaseInEaseOut(500));
                //Transition.run(contentEditor, "Height", 0, new TransitionType_EaseInEaseOut(500));
            }

        }

        private void txtCantidadMin_ValueChanged(object sender, EventArgs e)
        {
            if (txtCantidadMax.Value < txtCantidadMin.Value)
                txtCantidadMax.Value = txtCantidadMin.Value;
        }
    }
}
