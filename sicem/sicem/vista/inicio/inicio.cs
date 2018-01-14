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
    public partial class inicio : UserControl
    {
        public inicio()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            DataTable data = new DBHelper().Reader("contadores_tab_inicio");
            if(data != null)
            {
                DataRow row = data.Rows[0];

                clientesCont.Text = row["Cliente"].ToString();
                proveedoresCont.Text = row["Proveedor"].ToString();
                productosCont.Text = row["Producto"].ToString();
                ventasCont.Text = row["Venta"].ToString();

                ultimasVentas.DataSource = new DBHelper().Reader("ultimas_ventas");
                productosMasVendidos.DataSource = new DBHelper().Reader("productos_mas_vendidos");
                mejoresClientes.DataSource = new DBHelper().Reader("top_clientes");
            }
            else
            {
                clientesCont.Text = "0";
                proveedoresCont.Text = "0";
                productosCont.Text = "0";
                ventasCont.Text = "0";
            }
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            contentBadget.Region = new region().Circle(contentBadget.Width, contentBadget.Height);
            hideBadget.Region = new region().Circle(hideBadget.Width, hideBadget.Height);

            inicia();
        }

        private void seeBadget_Click(object sender, EventArgs e)
        {
            addCliente.Visible = false;
            addProveedor.Visible = false;
            addCompra.Visible = false;
            addVenta.Visible = false;

            transitionBadget.ShowSync(contentBadget);
            transitionBadget.MaxAnimationTime = 100;
            transitionBadget.ShowSync(addVenta);
            transitionBadget.ShowSync(addCompra);
            transitionBadget.ShowSync(addProveedor);
            transitionBadget.ShowSync(addCliente);
            transitionBadget.MaxAnimationTime = 750;
        }

        private void hideBadget_Click(object sender, EventArgs e)
        {
            contentBadget.Visible = false;
            seeBadget.Visible = false;
            transitionBadget.ShowSync(seeBadget);
        }

        private void addCliente_Click(object sender, EventArgs e)
        {
            new clienteForm().Show();
        }

        private void addProveedor_Click(object sender, EventArgs e)
        {
            new proveedorForm().Show();
        }

        private void addCompra_Click(object sender, EventArgs e)
        {
            new compraForm().Show();
        }

        private void addVenta_Click(object sender, EventArgs e)
        {
            new ventaForm().Show();
        }
    }
}
