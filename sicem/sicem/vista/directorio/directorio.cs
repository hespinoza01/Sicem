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
using sicem.datos;

namespace sicem
{
    public partial class directorio : UserControl
    {
        detalleCliente detalleCliente = new detalleCliente();
        detalleProveedor detalleProveedor = new detalleProveedor();
        detalleEmpleado detalleEmpleado = new detalleEmpleado();
        string active = "";

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

            contentDetails.Controls.Add(detalleCliente);
            contentDetails.Controls.Add(detalleProveedor);
            contentDetails.Controls.Add(detalleEmpleado);

            active = "cliente";
            clearForeColor();
            labelcliente.ForeColor = Color.RoyalBlue;
            new listadoItems().llenar(metodoBusqueda, new listadoItems().cliente());
            metodoBusqueda.StartIndex = 0;
            detalleCliente.BringToFront();
        }

        public void Cargar(bool busqueda)
        {
                DataTable data = null;
                string rowname = "";

                switch(active){
                    case "cliente":
                        data = (busqueda)? new Cliente().Buscar(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new Cliente().Mostrar();
                        rowname = "NombreCliente";
                        break;

                    case "proveedor":
                        data = (busqueda)? new Proveedor().Buscar(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new Proveedor().Mostrar();
                        rowname = "Nombre";
                        break;

                    case "empleado":
                        data = (busqueda)? new Empleado().Buscar(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new Empleado().Mostrar();
                        rowname = "Nombres";
                        break;
                }

            if (data != null)
            {
                vistaListado.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    string id, n, fm;
                    id = Convert.ToString(row["ID"]);
                    n = Convert.ToString(row[rowname]);
                    fm = Convert.ToString(row["FechaModificacion"]);
                    vistaListado.Rows.Add(id, n, fm);
                }
            }

        }

        private void clearForeColor()
        { 
            labelcliente.ForeColor = Color.Silver;
            labelproveedor.ForeColor = Color.Silver;
            labelempleado.ForeColor = Color.Silver;
        }

        private void activa()
        {
            clearForeColor();
            Cargar(false);

            switch (active)
            {
                case "cliente":
                    labelcliente.ForeColor = Color.RoyalBlue;
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().cliente());
                    Transition.run(indicadorlabel, "Left", labelcliente.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelcliente.Width;
                    detalleCliente.BringToFront();
                    break;

                case "proveedor":
                    labelproveedor.ForeColor = Color.RoyalBlue;
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().proveedor());
                    Transition.run(indicadorlabel, "Left", labelproveedor.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelproveedor.Width;
                    detalleProveedor.BringToFront();
                    break;

                case "empleado":
                    labelempleado.ForeColor = Color.RoyalBlue;
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().empleado());
                    Transition.run(indicadorlabel, "Left", labelempleado.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelempleado.Width;
                    detalleEmpleado.BringToFront();
                    break;
            }

            metodoBusqueda.StartIndex = 0;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            switch (active)
            {
                case "cliente":
                    new clienteForm().Show();
                    break;

                case "proveedor":
                    new proveedorForm().Show();
                    break;

                case "empleado":
                    new empleadoForm().Show();
                    break;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = vistaListado.Rows[e.RowIndex].Cells[0].Value.ToString();

                switch (active)
                {
                    case "cliente":
                        detalleCliente.setInfo(value);
                        break;

                    case "proveedor":
                        detalleProveedor.setInfo(int.Parse(value));
                        break;

                    case "empleado":
                        detalleEmpleado.setInfo(int.Parse(value));
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

        private void labelcliente_Click(object sender, EventArgs e)
        {
            active = "cliente";
            activa();
        }

        private void labelproveedor_Click(object sender, EventArgs e)
        {
            active = "proveedor";
            activa();
        }

        private void labelempleado_Click(object sender, EventArgs e)
        {
            active = "empleado";
            activa();
        }
    }
}
