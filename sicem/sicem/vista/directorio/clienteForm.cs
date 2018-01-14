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
    public partial class clienteForm : Form
    {
        string accionformulario;
        DBHelper db = new DBHelper();
        public clienteForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public clienteForm(string id)
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

            new drag().setDragable(toppanel);
        }

        private void setDataView(string id)
        {
            DataTable data = db.DataReader("select * from Cliente where ID = '" + id+"'");

            if(data != null){
                DataRow row = data.Rows[0];

                txtID.Text = row["ID"].ToString();
                txtNombre.Text = row["NombreCliente"].ToString();
                txtNombreContacto.Text = row["NombreContacto"].ToString();
                txtTituloContacto.Text = row["TituloContacto"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtTel.Text = row["Telefono"].ToString();
                txtDireccion.Text = row["Domicilio"].ToString();
            }else {
                new popup("Error al mostrar información", popup.AlertType.error);
                this.Close();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.C_Nombre = txtNombre.Text;
            c.C_Domicilio = txtDireccion.Text;
            c.C_Email = txtEmail.Text;
            c.C_Telefono = txtTel.Text;

            if (accionformulario == "crear")
            {
                try { c.Insertar(); }
                catch (Exception ex) { new popup("Inserción fallida", popup.AlertType.error); }
                this.Close();
            }
            else
            {
                try
                {
                    c.C_Id = txtID.Text;
                    c.Editar();
                }
                catch (Exception ex) { new popup("Actualización fallida", popup.AlertType.error); }
            }

        }



    }
}
