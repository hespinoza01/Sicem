using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Transitions;
using sicem.vista.directorio;

namespace sicem
{
    public partial class operaciones : UserControl
    {
        detalleCompra detalleCompra = new detalleCompra();
        detalleVenta detalleVenta = new detalleVenta();
        public operaciones()
        {   
            InitializeComponent();
        }

        private void operaciones_Load(object sender, EventArgs e)
        {
            inicia();
        }

        public void inicia()
        {
            clearForeColor();
            labelventas.ForeColor = Color.RoyalBlue;

            contentDetails.Controls.Add(detalleVenta);
            contentDetails.Controls.Add(detalleCompra);

            detalleVenta.BringToFront();

            Cargar();
        }

        public void Cargar()
        {
            //try
            //{
            //    vistaClientes.DataSource = new Cliente().Mostrar();
            //}
            //catch (Exception ex) { }
        }

        private void clearForeColor()
        {
            labelventas.ForeColor = Color.Silver;
            labelcompras.ForeColor = Color.Silver;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            //new clienteForm().ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //new clienteForm(int.Parse(vistaClientes.Rows[e.RowIndex].Cells[0].Value.ToString())).ShowDialog();
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            //if (txtBuscar.text == "")
            //    Cargar();
            //else
            //    vistaClientes.DataSource = new Cliente().Buscar(txtBuscar.text, metodoBusqueda.SelectedIndex);
        }

        private void labelventas_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelventas.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelventas.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelventas.Width;
            detalleVenta.BringToFront();
        }

        private void labelcompras_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelcompras.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelcompras.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelcompras.Width;
            detalleCompra.BringToFront();
        }
    }
}
