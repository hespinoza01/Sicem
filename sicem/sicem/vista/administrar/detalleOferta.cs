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
    public partial class detalleOferta : UserControl
    {
        public detalleOferta()
        {
            InitializeComponent();
        }

        private void detalleOferta_Load(object sender, EventArgs e)
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

        		txtID.Text = row["ID"].ToString();
        		txtDescripcion.Text = row["Descripcion"].ToString();
        		txtPorcentajeDescuento.Text = row["PorcentajeDescuento"].ToString();
        		txtTipoOferta.Text = row["tipoOferta"].ToString();
        		txtFechaInicio.Text = row["FechaInicio"].ToString();
        		txtFechaFin.Text = row["FechaFinal"].ToString();
        		txtCantidadMin.Text = row["MinCantidad"].ToString();
        		txtCantidadMax.Text = row["MaxCantidad"].ToString();
        		labelFechaModificacion.Text = row["FechaModificacion"].ToString();
        		listaProductos();
        	}else
        		new popup("Error al mostrar detalle", popup.AlertType.error);
        }

        private void listaProductos(){
        	DataTable data = new OfertaEspecial().listadoProductos(int.Parse(txtID.Text));

            if (data != null)
            {
                listadoProductoOferta.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    string id, n;
                    id = row[0].ToString();
                    n = row[1].ToString();
                    listadoProductoOferta.Rows.Add(id, n);
                }
            }
        }

        private void editar_Click(object sender, EventArgs e){
        	if(new categoriaForm(int.Parse(txtID.Text)).ShowDialog() == DialogResult.OK)
        		setInfo(int.Parse(txtID.Text));
        }
    }
}
