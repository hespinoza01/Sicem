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
            active = "producto";
            clearForeColor();
            labelproducto.ForeColor = Color.RoyalBlue;
            detalleInventario.BringToFront();
            new listadoItems().llenar(metodoBusqueda, new listadoItems().producto());
            metodoBusqueda.StartIndex = 0;

            contentDetails.Controls.Add(detalleInventario);
            contentDetails.Controls.Add(detalleBodega);

            Cargar(false);
        }

        public void Cargar(bool buscar)
        {
            DataTable data = null;

            if (buscar)
                data = (active == "producto") ? new Producto().Buscar(txtBuscar.Text, 0) : new Bodega().Buscar(txtBuscar.Text, 0);
            else
                data = (active == "producto") ? new Producto().MostrarHabilitados() : new Bodega().Mostrar(); 

            if (data != null)
            {
                vista.Rows.Clear();
                foreach(DataRow r in data.Rows)
                {
                    string i, n, f;
                    i = r["ID"].ToString();
                    n = r["Nombre"].ToString();
                    f = r["FechaModificacion"].ToString();
                    vista.Rows.Add(i, n, f);
                }
            }
        }

        private void clearForeColor()
        {
            labelproducto.ForeColor = Color.Silver;
            labelbodega.ForeColor = Color.Silver;
        }

        private void activa()
        {
            clearForeColor();
            Cargar(false);
            switch (active)
            {
                case "producto":
                    labelproducto.ForeColor = Color.RoyalBlue;
                    Transition.run(indicadorlabel, "Left", labelproducto.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelproducto.Width;
                    detalleInventario.BringToFront();
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().producto());
                    break;

                case "bodega":
                    labelbodega.ForeColor = Color.RoyalBlue;
                    Transition.run(indicadorlabel, "Left", labelbodega.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelbodega.Width;
                    detalleBodega.BringToFront();
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().bodega());
                    break;
            }

            metodoBusqueda.StartIndex = 0;
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
            try
            {
                string value = vista.Rows[e.RowIndex].Cells[0].Value.ToString();
                switch (active)
                {
                    case "producto":
                        detalleInventario.setInfo(int.Parse(value));
                        break;

                    case "bodega":
                        detalleBodega.setInfo(int.Parse(value));
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

        private void labelbodega_Click(object sender, EventArgs e)
        {
            active = "bodega";
            activa();
        }

        private void labelproducto_Click(object sender, EventArgs e)
        {
            active = "producto";
            activa();
        }

    }
}
