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
    public partial class detalleCategoria : UserControl
    {
        public detalleCategoria()
        {
            InitializeComponent();
        }

        private void detalleCategoria_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            labelFechaModificacion.Text = "";
            editar.Visible = false;
            editar.Click += editar_Click;
        }

        public void setInfo(int id){
        	DataTable data = new Categoria().Detalle(id);

        	if(data != null){
                editar.Visible = true;
        		DataRow row = data.Rows[0];

        		txtId.Text = row["ID"].ToString();
        		txtNombre.Text = row["Nombre"].ToString();
        		txtDescripcion.Text = row["Descripcion"].ToString();
        		txtEstado.Text = (int.Parse(row["Estado"].ToString()) == 1) ? "Habilitado" : "Deshabilitado";
        		txtFechaCreacion.Text = row["FechaCreacion"].ToString();
        		labelFechaModificacion.Text = row["FechaModificacion"].ToString();
                setProductosAlbergados();
    		}else
    			new popup("Error al mostrar detalle", popup.AlertType.error);
        }

        private void setProductosAlbergados()
        {
            string cmd = "select count(*) from Producto where CategoriaID = '"+int.Parse(txtId.Text)+"'";
            object value = new DBHelper().ReaderScalar(cmd);
            if(value != null)
                txtCantidadProductosAlbergados.Text = value.ToString();
        }

        private void editar_Click(object sender, EventArgs e){
        	if(new categoriaForm(int.Parse(txtId.Text)).ShowDialog() == DialogResult.OK)
        		setInfo(int.Parse(txtId.Text));
        }

    }
}
