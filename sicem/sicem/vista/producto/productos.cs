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
            new listadoItems().llenar(metodoBusqueda, new listadoItems().producto());

            contentDetails.Controls.Add(detalleProducto);
            detalleProducto.ocultaCampos();

            Cargar(false);
        }

        public void Cargar(bool buscar)
        {
            try{
                DataTable data = (buscar) ? new Producto().Buscar(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new Producto().Mostrar();

                vista.Rows.Clear();
                foreach(DataRow row in vista.Rows){
                    string id, n, fm;
                    id = Convert.ToString(row["ID"]);
                    n = Convert.ToString(row["Nombre"]);
                    fm = Convert.ToString(row["FechaModificacion"]);
                    vista.Rows.Add(id, n, fm);
                }
            }
            catch (Exception ex) { }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            new productoForm().Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
                Cargar(false);
            else
                Cargar(true);
        }

    }
}
