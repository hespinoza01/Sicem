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
    public partial class administrar : UserControl
    {
        detalleUsuario detalleUsuario = new detalleUsuario();
        detalleProducto detalleProducto = new detalleProducto();
        detalleCategoria detalleCategoria = new detalleCategoria();
        detalleOferta detalleOferta = new detalleOferta();
        public administrar()
        {   
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void inicio()
        {
            clearForeColor();
            labelusuarios.ForeColor = Color.RoyalBlue;

            contentDetails.Controls.Add(detalleUsuario);
            contentDetails.Controls.Add(detalleProducto);
            contentDetails.Controls.Add(detalleCategoria);
            contentDetails.Controls.Add(detalleOferta);

            detalleUsuario.BringToFront();

            Cargar();
        }

        private void clearForeColor()
        {
            labelusuarios.ForeColor = Color.Silver;
            labelproductos.ForeColor = Color.Silver;
            labelcategorias.ForeColor = Color.Silver;
            labelofertas.ForeColor = Color.Silver;
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

        private void labelusuarios_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelusuarios.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelusuarios.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelusuarios.Width;
            detalleUsuario.BringToFront();
        }

        private void labelproductos_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelproductos.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelproductos.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelproductos.Width;
            detalleProducto.BringToFront();
        }

        private void labelcategorias_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelcategorias.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelcategorias.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelcategorias.Width;
            detalleCategoria.BringToFront();
        }

        private void labelofertas_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelofertas.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelofertas.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelofertas.Width;
            detalleOferta.BringToFront();
        }
    }
}
