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
            loadID();
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
        }

        private void inicia()
        {
            guardar.ButtonText = (accionformulario == "crear" ? "Guarda" : "Actualizar");

            txtNombre.Region = new region().RoundBorder(txtNombre.Width, txtNombre.Height +1, 7);
            txtID.Region = new region().RoundBorder(txtID.Width, txtID.Height +1, 7);
            txtNombreContacto.Region = new region().RoundBorder(txtNombreContacto.Width, txtNombreContacto.Height+1, 7);
            txtTituloContacto.Region = new region().RoundBorder(txtTituloContacto.Width, txtTituloContacto.Height+1, 7);
            txtEmail.Region = new region().RoundBorder(txtEmail.Width, txtEmail.Height+1, 7);
            txtTel.Region = new region().RoundBorder(txtTel.Width, txtTel.Height+1, 7);
            txtDireccion.Region = new region().RoundBorder(txtDireccion.Width, txtDireccion.Height+1, 7);

            new drag().setDragable(paneltop);
        }

        private void setDataView(int id)
        {
            DataTable data = new Proveedor().Detalle(id);

            if (data != null) { 
                DataRow row = data.Rows[0];

                txtID.Text = row["ID"].ToString();
                txtNombre.Text = row["Nombre"].ToString();
                txtNombreContacto.Text = row["NombreContacto"].ToString();
                txtTituloContacto.Text = row["TituloContacto"].ToString();
                txtCiudad.selectedIndex = new listadoItems().indexCiudad(row["Ciudad"].ToString());
                txtEmail.Text = row["Email"].ToString();
                txtTel.Text = row["Telefono"].ToString();
                txtDireccion.Text = row["Domicilio"].ToString();
                estado.Checked = (int.Parse(row["Estado"].ToString()) == 1) ? true : false;
            }else
            {
                new popup("Error al mostrar información", popup.AlertType.error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void loadID()
        {
            int value = (int)new DBHelper().ReaderScalar("select count(*) + 1 from Proveedor");
            txtID.Text = value.ToString();
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
            p.P_NombreContacto = txtNombreContacto.Text;
            p.P_TituloContacto = txtTituloContacto.Text;
            p.P_Domicilio = txtDireccion.Text;
            p.P_Ciudad = txtCiudad.selectedValue;
            p.P_Email = txtEmail.Text;
            p.P_Telefono = txtTel.Text;
            p.P_Estado = (estado.Checked) ? 1 : 0;

            if (accionformulario == "crear")
                p.Insertar();
            else
            {
                p.P_Id = int.Parse(txtID.Text);
                p.Editar();
            }

            this.Close();

        }



    }
}
