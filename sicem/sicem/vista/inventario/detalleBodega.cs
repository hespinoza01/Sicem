using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem.vista.inventario
{
    public partial class detalleBodega : UserControl
    {
        public detalleBodega()
        {
            InitializeComponent();
        }

        private void detalleBodega_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            labelFechaModificacion.Text = "";
            editar.Visible = false;
            editar.Click += editar_Click;
        }

        public void setInfo(int id)
        {
            DataTable data = new Bodega().Detalle(id);

            if (data != null)
            {
                editar.Visible = true;
                DataRow r = data.Rows[0];

                txtId.Text = r["ID"].ToString();
                txtNombre.Text = r["Nombre"].ToString();
                txtCapacidad.Text = r["Almacenaje"].ToString();
                txtComentarios.Text = r["Comentarios"].ToString();
                txtEstado.Text = (int.Parse(r["Estado"].ToString()) == 1) ? "Habilitado" : "Deshabilitado";
                labelFechaModificacion.Text = r["FechaModificacion"].ToString();
            }
            else
                new popup("Error al mostrar detalle", popup.AlertType.error);
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (new bodegaForm(int.Parse(txtId.Text)).ShowDialog() == DialogResult.OK)
                setInfo(int.Parse(txtId.Text));
        }

    }
}
