using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sicem.vista.directorio
{
    public partial class detalleUsuario : UserControl
    {
        public detalleUsuario()
        {
            InitializeComponent();
        }

        private void detalleUsuario_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            valueEstado.Enabled = false;
        }

        public void setInfo(string id){
        	DataTable data = new usuario().Detalle(id);

        	if(data != null){
                valueEstado.Enabled = true;
        		DataRow row = data.Rows[0];

        		txtID.Text = row["ID"].ToString();
        		txtNombre.Text = row["Nombre"].ToString();
        		txtApellido.Text = row["Apellido"].ToString();
        		txtFechaCreacion.Text = row["FechaCreacion"].ToString();
        		labelFechaModificacion.Text = row["FechaModificacion"].ToString();
        		valueEstado.Value = (int.Parse(row["Estado"].ToString()) == 1) ? true : false;
	        		byte[] img = (byte[])row["FotoPerfil"];
	        		MemoryStream ms = new MemoryStream(img);
        		foto.Image = Image.FromStream(ms);

        		ms.Dispose();
    		}else
    			new popup("Error al mostrar detalle", popup.AlertType.error);
        }

        private void valueEstado_OnValueChange(object sender, EventArgs e)
        {
            string msj = (valueEstado.Value) ? "¿ Deshabilitar usuario ?" : "¿ Habilitar usuario ?";
            bool estadoaccion = false;
            confirmDialog cd = new confirmDialog(msj);
            cd.ShowDialog();
            if (valueEstado.Value)
            {
                if (cd.DialogResult == DialogResult.OK)
                    estadoaccion = new DBHelper().ExecuteQuery("update Usuario set Estado = 0 where ID = '" + txtID.Text + "'");
                else if(cd.DialogResult == DialogResult.No)
                {
                    estadoaccion = true;
                    new popup("No tiene permisos para esta acción", popup.AlertType.warning);
                }
            }
            else
            {
                if (cd.DialogResult == DialogResult.OK)
                    estadoaccion = new DBHelper().ExecuteQuery("update Usuario set Estado = 1 where ID = '" + txtID.Text + "'");
                else if (cd.DialogResult == DialogResult.No)
                {
                    estadoaccion = true;
                    new popup("No tiene permisos para esta acción", popup.AlertType.warning);
                }
            }

            setInfo(txtID.Text);
            if (!estadoaccion)
                new popup("No se pudo realizar la acción", popup.AlertType.info);
        }
    }
}
