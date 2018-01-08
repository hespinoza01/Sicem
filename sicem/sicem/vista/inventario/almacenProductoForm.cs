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
    public partial class almacenProductoForm : Form
    {
        string accionformulario;
        public almacenProductoForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public almacenProductoForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }

        private void almacenProductoForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            aceptar.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            txtProducto.Region = new region().RoundBorder(txtProducto.Width, txtProducto.Height+1, 7);
            txtBodega.Region = new region().RoundBorder(txtBodega.Width, txtBodega.Height+1, 7);
            txtEstante.Region = new region().RoundBorder(txtEstante.Width, txtEstante.Height+1, 7);
            txtCantidad.Region = new region().RoundBorder(txtCantidad.Width, txtCantidad.Height+1, 7);

            sugerenciaProducto.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            sugerenciaProducto.ItemHeight = 15;
            txtProducto.TopLevelControl.Controls.Add(sugerenciaProducto);
            Point controlLocation = txtProducto.TopLevelControl.PointToClient(txtProducto.Parent.PointToScreen(txtProducto.Location));
            sugerenciaProducto.Left = controlLocation.X + 5;
            sugerenciaProducto.Top = controlLocation.Y + txtProducto.Height;
            sugerenciaProducto.Width = txtProducto.Width - 10;
            sugerenciaProducto.Height = sugerenciaProducto.ItemHeight * 5;
            sugerenciaProducto.Visible = false;

            sugerenciaBodega.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            sugerenciaBodega.ItemHeight = 15;
            txtBodega.TopLevelControl.Controls.Add(sugerenciaBodega);
            controlLocation = txtBodega.TopLevelControl.PointToClient(txtBodega.Parent.PointToScreen(txtBodega.Location));
            sugerenciaBodega.Left = controlLocation.X + 5;
            sugerenciaBodega.Top = controlLocation.Y + txtBodega.Height;
            sugerenciaBodega.Width = txtBodega.Width - 10;
            sugerenciaBodega.Height = sugerenciaBodega.ItemHeight * 5;
            sugerenciaBodega.Visible = false;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
                
                this.Close();
        }


        private void setDataView(int id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Categoria");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Categoria where ID = " + id,
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    //DataRow row = data.Rows[0];
                    //txtId.Text = row["ID"].ToString();
                    //txtBodega.Text = row["Nombre"].ToString();
                    //txtComentarios.Text = row["Descripcion"].ToString();
                    //if (int.Parse(row["Estado"].ToString()) == 0)
                    //    estadoValor.Checked = false;
                    //else
                    //    estadoValor.Checked = true;
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text.Length > 0)
            {
                sugerenciaProducto.Visible = true;
                sugerenciaProducto.BringToFront();
            }
            else
                sugerenciaProducto.Visible = false;
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((sugerenciaProducto.Visible) && (sugerenciaProducto.SelectedIndex < sugerenciaProducto.Items.Count - 1))
                            sugerenciaProducto.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (sugerenciaProducto.Visible && sugerenciaProducto.SelectedIndex >= 0)
                            sugerenciaProducto.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (sugerenciaProducto.Visible)
                        {
                            sugerenciaProducto_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void sugerenciaProducto_Click(object sender, EventArgs e)
        {
            if (sugerenciaProducto.SelectedIndex >= 0)
                txtProducto.Text = sugerenciaProducto.SelectedItem.ToString();

            txtProducto.Focus();
            txtProducto.Select(txtProducto.Text.Length, 0);
            sugerenciaProducto.Visible = false;
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (!sugerenciaProducto.ContainsFocus)
                sugerenciaProducto.Visible = false;
        }

        private void sugerenciaProducto_Leave(object sender, EventArgs e)
        {
            if (!txtProducto.ContainsFocus)
                sugerenciaProducto.Visible = false;
        }

        private void txtBodega_TextChanged(object sender, EventArgs e)
        {
            if (txtBodega.Text.Length > 0)
            {
                sugerenciaBodega.Visible = true;
                sugerenciaBodega.BringToFront();
            }
            else
                sugerenciaBodega.Visible = false;
        }

        private void txtBodega_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((sugerenciaBodega.Visible) && (sugerenciaBodega.SelectedIndex < sugerenciaBodega.Items.Count - 1))
                            sugerenciaBodega.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (sugerenciaBodega.Visible && sugerenciaBodega.SelectedIndex >= 0)
                            sugerenciaBodega.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (sugerenciaBodega.Visible)
                        {
                            sugerenciaBodega_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void sugerenciaBodega_Click(object sender, EventArgs e)
        {
            if (sugerenciaBodega.SelectedIndex >= 0)
                txtBodega.Text = sugerenciaBodega.SelectedItem.ToString();

            txtBodega.Focus();
            txtBodega.Select(txtBodega.Text.Length, 0);
            sugerenciaBodega.Visible = false;
        }

        private void txtBodega_Leave(object sender, EventArgs e)
        {
            if (!sugerenciaBodega.ContainsFocus)
                sugerenciaBodega.Visible = false;
        }

        private void sugerenciaBodega_Leave(object sender, EventArgs e)
        {
            if (!txtBodega.ContainsFocus)
                sugerenciaBodega.Visible = false;
        }

        
    }
}
