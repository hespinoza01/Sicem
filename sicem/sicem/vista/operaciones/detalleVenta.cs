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
    public partial class detalleVenta : UserControl
    {
        public detalleVenta()
        {
            InitializeComponent();
        }

        private void detalleVenta_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            editar.Visible = false;
            labelFechaModificacion.Text = "";
            editar.Click += editar_Click;
        }

        public void setInfo(string id)
        {
            DataTable data = new venta().Detalle(id);

            if (data != null){
                editar.Visible = true;
                DataRow r = data.Rows[0];

                txtCodigoVenta.Text = r["ID"].ToString();
                getCliente(r["ClienteID"].ToString());
                txtFechaVenta.Text = r["FechaVenta"].ToString();
                txtTipoPago.Text = new listadoItems().tipoPagoVenta()[int.Parse(r["TipoPago"].ToString())];
                ventaCredito.Checked = (int.Parse(r["TipoVenta"].ToString()) == 1) ? true : false;
                txtSubtotal.Text = r["SubTotal"].ToString();
                txtImpuesto.Text = r["Impuesto"].ToString();
                txtTotal.Text = r["Total"].ToString();
                labelFechaModificacion.Text = r["FechaModificacion"].ToString();
                listarDetalle();
            }
            else
                new popup("Error al mostrar detalle", popup.AlertType.error);
        }

        private void getCliente(string id)
        {
            object value = new DBHelper().ReaderScalar("select NombreCliente from Cliente where ID = '"+id+"'");
            if (value != null)
                txtCliente.Text = value.ToString();
        }

        private void listarDetalle()
        {
            DataTable data = new DetalleVenta().Mostrar(txtCodigoVenta.Text);
            if(data != null)
            {
                vistaDetalle.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    string pid, n, c, pu, d, i, t;
                    pid = Convert.ToString(row[0]);
                    n = Convert.ToString(row[1]);
                    c = Convert.ToString(row[2]);
                    pu = Convert.ToString(row[3]);
                    d = Convert.ToString(row[4]);
                    i = Convert.ToString(row[5]);
                    t = Convert.ToString(row[6]);
                    vistaDetalle.Rows.Add(pid, n, c, pu, d, i, t);
                }
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (new ventaForm(txtCodigoVenta.Text).ShowDialog() == DialogResult.OK)
                setInfo(txtCodigoVenta.Text);
        }
    }
}
