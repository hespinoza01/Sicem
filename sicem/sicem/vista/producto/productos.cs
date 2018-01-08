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
    public partial class productos : UserControl
    {
        detalleProducto detalleProducto = new detalleProducto();
        public productos()
        {   
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            inicia();
        }

        public void inicia()
        {
            contentDetails.Controls.Add(detalleProducto);
            detalleProducto.ocultaCampos();
        }

        public void Cargar()
        {
            //try
            //{
            //    vistaClientes.DataSource = new Cliente().Mostrar();
            //}
            //catch (Exception ex) { }
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

    }
}
