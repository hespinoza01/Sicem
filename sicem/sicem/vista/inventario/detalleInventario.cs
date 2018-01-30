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
        string active = "";
        List<int> valueid = new List<int>();
        public detalleInventario()
        {
            InitializeComponent();
        }

        private void detalleInventario_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia(){
            active = "entrada";
        }

        public void setInfo(int id)
        {
            DataTable data = new Producto().Detalle(id);
            if(data != null)
            {
                DataRow r = data.Rows[0];
                txtID.Text = r["ID"].ToString();
                txtNombreProducto.Text = r["Nombre"].ToString();
                txtEstado.Text = (int.Parse(r["Estado"].ToString()) == 1) ? "Habilitado" : "Deshabilitado";

                listarAlmacenaje();
                listarHistorial();
            }
        }

        private void listarAlmacenaje()
        {
            DataTable data = new Inventario().Mostrar(int.Parse(txtID.Text));
            if (data != null)
            {
                vistaAlmacenaje.Rows.Clear();
                valueid.Clear();
                foreach (DataRow row in data.Rows)
                {
                    string i, n, e, c;
                    valueid.Add(int.Parse(row[0].ToString()));
                    i = row[1].ToString();
                    n = row[2].ToString();
                    e = row[3].ToString();
                    c = row[4].ToString();
                    vistaAlmacenaje.Rows.Add(i, n, e, c);
                }
            }
        }

        private void listarHistorial()
        {
            DataTable data = null;

            if(txtID.Text != ""){
                switch (active)
                {
                    case "entrada":
                        data = new Inventario().EntradaProducto(int.Parse(txtID.Text));
                        vistaHistorialEntrada.BringToFront();
                        break;

                    case "precio":
                        data = new Producto().HistorialPrecio(int.Parse(txtID.Text));
                        valueTipo.HeaderText = "Precio";
                        historialCostoPrecio.BringToFront();
                        break;

                    case "costo":
                        data = new Producto().HistorialCosto(int.Parse(txtID.Text));
                        valueTipo.HeaderText = "Costo";
                        historialCostoPrecio.BringToFront();
                        break;
                }
            }

            if (data != null)
            {
                vistaHistorialEntrada.Rows.Clear();
                historialCostoPrecio.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    string i, n, e;
                    i = row[1].ToString();
                    n = row[2].ToString();
                    e = row[3].ToString();
                    if(active == "entrada") vistaAlmacenaje.Rows.Add(i, n, e);
                    else historialCostoPrecio.Rows.Add(i, n, e);
                }
            }
        }

        private void tabEntrada_Click(object sender, EventArgs e)
        {
            active = "entrada";
            listarHistorial();
        }

        private void tabCosto_Click(object sender, EventArgs e)
        {
            active = "costo";
            listarHistorial();
        }

        private void tabPrecio_Click(object sender, EventArgs e)
        {
            active = "precio";
            listarHistorial();
        }

        private void vistaAlmacenaje_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = valueid[e.RowIndex];
                if (new almacenProductoForm(index).ShowDialog() == DialogResult.OK)
                    setInfo(int.Parse(txtID.Text));
            }
            catch(Exception ex) { }
        }
    }
}
