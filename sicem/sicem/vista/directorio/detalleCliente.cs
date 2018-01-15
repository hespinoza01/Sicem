using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem.vista.directorio
{
    public partial class detalleCliente : UserControl
    {
        public detalleCliente()
        {
            InitializeComponent();
        }

        private void detalleCliente_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            EstadoValue.Text = "";
            labelFechaModificacion.Text = "";
            editar.Visible = false;
            editar.Click += editar_Click;
        }

        public void setInfo(string id){
        	DataTable data = new Cliente().Detalle(id);

        	if(data != null){
                editar.Visible = true;
        		DataRow row = data.Rows[0];

        		txtID.Text = row["ID"].ToString();
        		txtNombre.Text = row["NombreCliente"].ToString();
        		txtNombreContacto.Text = row["NombreContacto"].ToString();
        		txtTituloContacto.Text = row["TituloContacto"].ToString();
        		txtDireccion.Text = row["Domicilio"].ToString();
        		txtCiudad.Text = row["Ciudad"].ToString();
        		txtTel.Text = row["Telefono"].ToString();
        		txtEmail.Text = row["Email"].ToString();
                EstadoValue.Text = (int.Parse(row["Estado"].ToString()) == 1) ? "Habilitado" : "Deshabilitado";
                labelFechaModificacion.Text = row["FechaModificacion"].ToString();

        	}else{
        		new popup("Error al mostrar detalle", popup.AlertType.error);
        	}
        }

        private void editar_Click(object sender, EventArgs e){
        	if(new clienteForm(txtID.Text).ShowDialog() == DialogResult.OK)
        		setInfo(txtID.Text);
        }

    }
}
