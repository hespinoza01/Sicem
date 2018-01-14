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
using sicem.vista.inventario;

namespace sicem
{
    public partial class inventario : UserControl
    {
        detalleInventario detalleInventario = new detalleInventario();
        detalleBodega detalleBodega = new detalleBodega();
        string active = "";
        public inventario()
        {   
            InitializeComponent();
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            inicia();
        }

        public void inicia()
        {
            clearForeColor();
            labelproducto.ForeColor = Color.RoyalBlue;

            new listadoItems().llenar(metodoBusqueda, new listadoItems().producto());
            active = "producto";

            contentDetails.Controls.Add(detalleInventario);
            contentDetails.Controls.Add(detalleBodega);

            detalleInventario.BringToFront();

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
            labelproducto.ForeColor = Color.Silver;
            labelbodega.ForeColor = Color.Silver;
        }


        private void agregarButton_Click(object sender, EventArgs e)
        {
            switch (active)
            {
                case "producto":
                    new almacenProductoForm().Show();
                    break;

                case "bodega":
                    new bodegaForm().Show();
                    break;
            }
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

        private void labelbodega_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelbodega.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelbodega.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelbodega.Width;
            detalleBodega.BringToFront(); new listadoItems().llenar(metodoBusqueda, new listadoItems().bodega());
            active = "bodega";
        }

        private void labelproducto_Click(object sender, EventArgs e)
        {
            clearForeColor();
            labelproducto.ForeColor = Color.RoyalBlue;
            Transition.run(indicadorlabel, "Left", labelproducto.Left, new TransitionType_EaseInEaseOut(500));
            indicadorlabel.Width = labelproducto.Width;
            detalleInventario.BringToFront();
            new listadoItems().llenar(metodoBusqueda, new listadoItems().producto());
            active = "producto";
        }
    }
}
