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
    public partial class detalleInventario : UserControl
    {
        public detalleInventario()
        {
            InitializeComponent();
        }

        private void tabEntrada_Click(object sender, EventArgs e)
        {
            vistaHistorialEntrada.BringToFront();
        }

        private void tabCosto_Click(object sender, EventArgs e)
        {
            valueTipo.HeaderText = "Costo";
            historialCostoPrecio.BringToFront();
        }

        private void tabPrecio_Click(object sender, EventArgs e)
        {
            valueTipo.HeaderText = "Precio";
            historialCostoPrecio.BringToFront();
        }
    }
}
