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
        string active = "";
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
            active = "venta";
            clearForeColor();
            labelventas.ForeColor = Color.RoyalBlue;
            detalleVenta.BringToFront();
            new listadoItems().llenar(metodoBusqueda, new listadoItems().venta());
            columnFecha.HeaderText = "Fecha venta";

            contentDetails.Controls.Add(detalleVenta);
            contentDetails.Controls.Add(detalleCompra);

        }

        public void Cargar(bool busqueda)
        {
            DataTable data = null;
            string rowname = "";

            switch (active)
            {
                case "venta":
                    data = (busqueda) ? new venta().Buscar(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new venta().Mostrar();
                    rowname = "FechaVenta";
                    break;

                case "compra":
                    data = (busqueda) ? new compra().Buscar(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new compra().Mostrar();
                    rowname = "FechaCompra";
                    break;
            }

            if (data != null)
            {
                vista.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    string id, n, fm;
                    id = Convert.ToString(row["ID"]);
                    n = Convert.ToString(row[rowname]);
                    fm = Convert.ToString(row["FechaModificacion"]);
                    vista.Rows.Add(id, n, fm);
                }
            }
        }

        private void clearForeColor()
        {
            labelventas.ForeColor = Color.Silver;
            labelcompras.ForeColor = Color.Silver;
        }

        private void activa()
        {
            clearForeColor();
            Cargar(false);

            switch (active)
            {
                case "venta":
                    labelventas.ForeColor = Color.RoyalBlue;
                    Transition.run(indicadorlabel, "Left", labelventas.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelventas.Width;
                    detalleVenta.BringToFront();
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().venta());
                    columnFecha.HeaderText = "Fecha venta";
                    break;

                case "compra":
                    labelcompras.ForeColor = Color.RoyalBlue;
                    Transition.run(indicadorlabel, "Left", labelcompras.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelcompras.Width;
                    detalleCompra.BringToFront();
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().compra());
                    columnFecha.HeaderText = "Fecha compra";
                    break;
            }

            metodoBusqueda.StartIndex = 0;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            switch (active)
            {
                case "venta":
                    new ventaForm().Show();
                    break;

                case "compra":
                    new compraForm().Show();
                    break;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = vista.Rows[e.RowIndex].Cells[0].Value.ToString();

                switch (active)
                {
                    case "venta":
                        detalleVenta.setInfo(value);
                        break;

                    case "compra":
                        detalleCompra.setInfo(value);
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
                Cargar(true);
            else
                Cargar(false);
        }

        private void labelventas_Click(object sender, EventArgs e)
        {
            active = "venta";
            activa();
        }

        private void labelcompras_Click(object sender, EventArgs e)
        {
            active = "compra";
            activa();
        }
    }
}
