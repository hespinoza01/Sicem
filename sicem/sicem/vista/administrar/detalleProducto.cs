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
    public partial class detalleProducto : UserControl
    {
        bool admin = true;
        public detalleProducto()
        {
            InitializeComponent();
        }

        private void detalleProducto_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            editar.Visible = false;
            editar.Click += editar_Click;
        }

        public void setInfo(int id){
            DataTable data = new Producto().Detalle(id);

            if(data != null){
                if (admin) editar.Visible = true;
                DataRow row = data.Rows[0];

                txtID.Text = row["ID"].ToString();
                txtIDCategoria.Text = row["CategoriaID"].ToString();
                txtNombreProducto.Text = row["Nombre"].ToString();
                txtCantidadPorUnidad.Text = row["CantidadPorUnidad"].ToString();
                txtPrecioVenta.Text = row["PrecioVenta"].ToString();
                txtStock.Text = row["Stock"].ToString();
                txtDescripcion.Text = row["Descripcion"].ToString();
                txtEstado.Text = (int.Parse(row["Estado"].ToString()) == 1) ? "Habilitado" : "Deshabilitado";
                labelFechaModificacion.Text = row["FechaModificacion"].ToString();
            }else
                new popup("Error al mostrar detalle", popup.AlertType.error);
        }

        public void ocultaCampos() {
            admin = false;
            txtEstado.Visible = false;
            labelestado.Visible = false;
            labelmsj.Visible = false;
            labelFechaModificacion.Visible = false;

            this.Left += 21;
            this.Top += 20;
        }

        private void editar_Click(object sender, EventArgs e){
            if(new productoForm(int.Parse(txtID.Text)).ShowDialog() == DialogResult.OK)
                setInfo(int.Parse(txtID.Text));
        }
    }
}
