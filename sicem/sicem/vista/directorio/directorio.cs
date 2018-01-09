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
    public partial class directorio : UserControl
    {
        detalleCliente detalleCliente = new detalleCliente();
        detalleProveedor detalleProveedor = new detalleProveedor();
        detalleEmpleado detalleEmpleado = new detalleEmpleado();
        public directorio()
        {   
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            clearForeColor();
            labelcliente.ForeColor = Color.RoyalBlue;

            contentDetails.Controls.Add(detalleCliente);
            contentDetails.Controls.Add(detalleProveedor);
            contentDetails.Controls.Add(detalleEmpleado);

            detalleCliente.BringToFront();

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
            labelcliente.ForeColor = Color.Silver;
            labelproveedor.ForeColor = Color.Silver;
            labelempleado.ForeColor = Color.Silver;
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

        private void labelcliente_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelcliente.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelcliente.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelcliente.Width;
            detalleCliente.BringToFront();
        }

        private void labelproveedor_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelproveedor.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelproveedor.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelproveedor.Width;
            detalleProveedor.BringToFront();
        }

        private void labelempleado_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelempleado.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelempleado.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelempleado.Width;
            detalleEmpleado.BringToFront();
        }
    }
}
