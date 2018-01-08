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
    public partial class proveedorForm : Form
    {
        string accionformulario;
        public proveedorForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public proveedorForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }
        
        private void clienteForm_Load(object sender, EventArgs e)
        {
            inicia();
            guardar.ButtonText = (accionformulario == "crear" ? "Guarda" : "Actualizar");
        }

        private void inicia()
        {
            txtNombre.Region = new region().RoundBorder(txtNombre.Width, txtNombre.Height +1, 7);
            txtID.Region = new region().RoundBorder(txtID.Width, txtID.Height +1, 7);
            txtNombreContacto.Region = new region().RoundBorder(txtNombreContacto.Width, txtNombreContacto.Height+1, 7);
            txtTituloContacto.Region = new region().RoundBorder(txtTituloContacto.Width, txtTituloContacto.Height+1, 7);
            txtEmail.Region = new region().RoundBorder(txtEmail.Width, txtEmail.Height+1, 7);
            txtTel.Region = new region().RoundBorder(txtTel.Width, txtTel.Height+1, 7);
            txtDireccion.Region = new region().RoundBorder(txtDireccion.Width, txtDireccion.Height+1, 7);
        }

        private void setDataView(int id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    //cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Proveedor where ID = '" + id + "'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtID.Text = row["ID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtTel.Text = row["Telefono"].ToString();
                    txtDireccion.Text = row["Domicilio"].ToString();
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            p.P_Nombre = txtNombre.Text;
            p.P_Domicilio = txtDireccion.Text;
            p.P_Email = txtEmail.Text;
            p.P_Telefono = txtTel.Text;

            if (accionformulario == "crear")
            {
                try { p.Insertar(); }
                catch (Exception ex) { new popup("Inserción fallida", popup.AlertType.error); }
                this.Close();
            }
            else
            {
                try
                {
                    p.P_Id = int.Parse(txtID.Text);
                    p.Editar();
                }
                catch (Exception ex) { new popup("Actualización fallida", popup.AlertType.error); }
            }

        }



    }
}
