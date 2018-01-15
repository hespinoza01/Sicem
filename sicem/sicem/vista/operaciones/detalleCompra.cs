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
    public partial class detalleCompra : UserControl
    {
        public detalleCompra()
        {
            InitializeComponent();
        }

        private void detalleCompra_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            labelFechaModificacion.Text = "";
            editar.Visible = false;
            editar.Click += editar_Click;
        }

        public void setInfo(string id)
        {
            DataTable data = new compra().Detalle(id);
            if (data != null){
                editar.Visible = true;
                DataRow r = data.Rows[0];

                txtCodigoCompra.Text = r["ID"].ToString();
                getProveedor(int.Parse(r["ProveedorID"].ToString()));
                txtFechaCompra.Text = r["FechaCompra"].ToString();
                txtTipoPago.Text = new listadoItems().tipoPagoVenta()[int.Parse(r["TipoPago"].ToString())];
                txtMonto.Text = r["Monto"].ToString();
                labelFechaModificacion.Text = r["FechaModificacion"].ToString();
                listarDetalle();
            }
            else
                new popup("Error al mostrar detalle", popup.AlertType.error);
        }

        private void getProveedor(int id)
        {
            object value = new DBHelper().ReaderScalar("select Nombre from Proveedor where ID = '"+id+"'");
            if (value != null)
                txtProveedor.Text = value.ToString();
        }

        private void listarDetalle()
        {
            DataTable data = new DetalleCompra().Mostrar(txtCodigoCompra.Text);

            if(data != null)
            {
                vistaDetalle.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    string pid, n, c, cu, t;
                    pid = Convert.ToString(row[0]);
                    n = Convert.ToString(row[1]);
                    c = Convert.ToString(row[2]);
                    cu = Convert.ToString(row[3]);
                    t = Convert.ToString(row[4]);
                    vistaDetalle.Rows.Add(pid, n, c, cu, t);
                }
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (new compraForm(txtCodigoCompra.Text).ShowDialog() == DialogResult.OK)
                setInfo(txtCodigoCompra.Text);
        }
    }
}
