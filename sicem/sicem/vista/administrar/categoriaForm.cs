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
    public partial class categoriaForm : Form
    {
        string accionformulario;
        public categoriaForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public categoriaForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }

        private void categoriaForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            aceptar.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            txtId.Region = new region().RoundBorder(txtId.Width, txtId.Height+1, 7);
            txtNombre.Region = new region().RoundBorder(txtNombre.Width, txtNombre.Height+1, 7);
            txtDescripcion.Region = new region().RoundBorder(txtDescripcion.Width, txtDescripcion.Height+1, 7);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
                Categoria c = new Categoria();
                c.Nombre = txtNombre.Text;
                c.Descripcion = txtDescripcion.Text;
                c.Estado = (estadoValor.Checked) ? 1 : 0;
            
                if (accionformulario == "crear")
                {
                    try {
                        new DataCategory().AddCategory(c);
                    }
                    catch (Exception ex) { new popup("Inserción fallida", popup.AlertType.error); }
                    this.Close();
                }
                else
                {
                    try {
                        c.ID = int.Parse(txtId.Text);
                        new DataCategory().UpdateCategory(c);
                    }
                    catch (Exception ex) { new popup("Actualización fallida", popup.AlertType.error); }
                }

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

                    DataRow row = data.Rows[0];
                    txtId.Text = row["ID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString();
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

    }
}
