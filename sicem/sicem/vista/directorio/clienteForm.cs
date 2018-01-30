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
        DateTime fa = DateTime.Now;
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
        }

        private void inicia()
        {
            if (accionformulario == "crear") createID();
            guardar.ButtonText = (accionformulario == "crear" ? "Guarda" : "Actualizar");

            txtNombre.Region = new region().RoundBorder(txtNombre.Width, txtNombre.Height +1, 7);
            txtID.Region = new region().RoundBorder(txtID.Width, txtID.Height +1, 7);
            txtNombreContacto.Region = new region().RoundBorder(txtNombreContacto.Width, txtNombreContacto.Height+1, 7);
            txtTituloContacto.Region = new region().RoundBorder(txtTituloContacto.Width, txtTituloContacto.Height+1, 7);
            txtEmail.Region = new region().RoundBorder(txtEmail.Width, txtEmail.Height+1, 7);
            txtTel.Region = new region().RoundBorder(txtTel.Width, txtTel.Height+1, 7);
            txtDireccion.Region = new region().RoundBorder(txtDireccion.Width, txtDireccion.Height+1, 7);

            //foreach (string s in new listadoItems().ciudad())
            //    txtCiudad.AddItem(s);

            new drag().setDragable(toppanel);
        }

        private void setDataView(string id)
        {
            DataTable data = new Cliente().Detalle(id);

            if(data != null){
                DataRow row = data.Rows[0];

                txtID.Text = row["ID"].ToString();
                txtNombre.Text = row["NombreCliente"].ToString();
                txtNombreContacto.Text = row["NombreContacto"].ToString();
                txtTituloContacto.Text = row["TituloContacto"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtTel.Text = row["Telefono"].ToString();
                txtDireccion.Text = row["Domicilio"].ToString();
                txtCiudad.selectedIndex = new listadoItems().indexCiudad(row["Ciudad"].ToString());
                EstadoValue.Checked = (int.Parse(row["Estado"].ToString()) == 1) ? true : false;
            }else {
                new popup("Error al mostrar información", popup.AlertType.error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void createID()
        {
            string text = (txtNombre.Text.Length > 5) ? txtNombre.Text.Substring(0,5).ToLower() : txtNombre.Text.ToLower();
            text += "-"+fa.Day.ToString() + fa.Hour.ToString() + fa.Minute.ToString();
            txtID.Text = text;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (accionformulario == "crear") createID();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.ID = txtID.Text;
                c.Nombre = txtNombre.Text;
                c.NombreContacto = txtNombreContacto.Text;
                c.TituloContacto = txtTituloContacto.Text;
                c.Domicilio = txtDireccion.Text;
                c.Ciudad = txtCiudad.selectedValue;
                c.Email = txtEmail.Text;
                c.Telefono = txtTel.Text;
                c.Estado = (EstadoValue.Checked) ? 1 : 0;

                if (accionformulario == "crear")
                    c.Insertar();
                else
                    c.Editar();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) { new popup("Complete los campos", popup.AlertType.warning); }
        }

        private void tarjetaCredito_Click(object sender, EventArgs e)
        {
            new clienteTarjetaForm(txtID.Text).ShowDialog();
        }

        private void txtCiudad_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
