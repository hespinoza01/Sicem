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
        //ExtrasContadores c = new ExtrasContadores();
        public inicio()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            //DataRow row = new ExtrasContadores().Contadores().Rows[0];
            //try { 
            //    label3.Text = row["Cliente"].ToString();
            //    label6.Text = row["Proveedor"].ToString();
            //    label4.Text = row["Producto"].ToString();
            //    label8.Text = row["Venta"].ToString();

            //    ultimasVentas.DataSource = new ExtrasContadores().ultimasVentas();
            //    productosMasVendidos.DataSource = new ExtrasContadores().productosMasVendidos();
            //    mejoresClientes.DataSource = new ExtrasContadores().topClientes();
            //}
            //catch (Exception ex) { }
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            cargar();
            inicia();
        }

        private void inicia()
        {
            contentBadget.Region = new region().Circle(contentBadget.Width, contentBadget.Height);
            hideBadget.Region = new region().Circle(hideBadget.Width, hideBadget.Height);
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
    }
}
