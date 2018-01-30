using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem
{
    public partial class detalleDepartamento : UserControl
    {
        public detalleDepartamento()
        {
            InitializeComponent();
        }

        private void detalleDepartamento_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia() {
            labelFechaModificacion.Text = "";
            editar.Visible = false;
            editar.Click += editar_Click;
        }

        public void setInfo(int id)
        {
            DataTable data = new Departamento().Detalle(id);
            if (data != null)
            {
                editar.Visible = true;
                DataRow r = data.Rows[0];

                txtID.Text = r["ID"].ToString();
                txtNombre.Text = r["Nombre"].ToString();
                txtNombreGrupo.Text = r["NombreGrupo"].ToString();
                labelFechaModificacion.Text = r["FechaModificacion"].ToString();
            }
            else
                new popup("Error al mostrar detalle", popup.AlertType.warning);
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (new departamentoForm(int.Parse(txtID.Text)).ShowDialog() == DialogResult.OK)
                setInfo(int.Parse(txtID.Text));
        }
    }
}
