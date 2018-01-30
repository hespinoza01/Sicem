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
        detalleDepartamento detalleDepartamento = new detalleDepartamento();
        string active = "";
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
            active = "usuario";
            clearForeColor();
            labelusuarios.ForeColor = Color.RoyalBlue;
            detalleUsuario.BringToFront();
            new listadoItems().llenar(metodoBusqueda, new listadoItems().usuario());
            metodoBusqueda.StartIndex = 0;

            contentDetails.Controls.Add(detalleUsuario);
            contentDetails.Controls.Add(detalleProducto);
            contentDetails.Controls.Add(detalleCategoria);
            contentDetails.Controls.Add(detalleOferta);
            contentDetails.Controls.Add(detalleDepartamento);
        }

        private void clearForeColor()
        {
            labelusuarios.ForeColor = Color.Silver;
            labelproductos.ForeColor = Color.Silver;
            labelcategorias.ForeColor = Color.Silver;
            labelofertas.ForeColor = Color.Silver;
            labelDepartamentos.ForeColor = Color.Silver;
        }

        public void Cargar(bool buscar)
        {
            DataTable data = null;
            string rowname = "";

            switch(active){
                case "usuario":
                    data = (buscar)? new usuario().Buscar(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new usuario().Mostrar();
                    rowname = "Nombre";
                    break;

                case "producto":
                    data = (buscar)? new Producto().BuscarTodo(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new Producto().Mostrar();
                    rowname = "Nombre";
                    break;

                case "categoria":
                    data = (buscar)? new Categoria().Buscar(txtBuscar.Text) : new Categoria().Mostrar();
                    rowname = "Nombre";
                    break;

                case "oferta":
                    data = (buscar)? new OfertaEspecial().Buscar(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new OfertaEspecial().Mostrar();
                    rowname = "tipoOferta";
                    break;

                case "departamento":
                    data = (buscar) ? new Departamento().Buscar(txtBuscar.Text, metodoBusqueda.SelectedIndex) : new Departamento().Mostrar();
                    rowname = "Nombre";
                    break;
            }

            if (data != null)
            {
                vistaListado.Rows.Clear();
                columnName.HeaderText = (active == "oferta") ? "Tipo Oferta" : "Nombre";
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

        public void activa(){
            clearForeColor();
            Cargar(false);

            switch (active)
            {
                case "usuario":
                    labelusuarios.ForeColor = Color.RoyalBlue;
                    Transition.run(indicadorlabel, "Left", labelusuarios.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelusuarios.Width;
                    detalleUsuario.BringToFront();
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().usuario());
                    metodoBusqueda.StartIndex = 0;
                    break;

                case "producto":
                    labelproductos.ForeColor = Color.RoyalBlue;
                    Transition.run(indicadorlabel, "Left", labelproductos.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelproductos.Width;
                    detalleProducto.BringToFront();
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().producto());
                    metodoBusqueda.StartIndex = 0;
                    break;

                case "categoria":
                    labelcategorias.ForeColor = Color.RoyalBlue;
                    Transition.run(indicadorlabel, "Left", labelcategorias.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelcategorias.Width;
                    detalleCategoria.BringToFront();
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().categoria());
            
                    break;

                case "oferta":
                    labelofertas.ForeColor = Color.RoyalBlue;
                    Transition.run(indicadorlabel, "Left", labelofertas.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelofertas.Width;
                    detalleOferta.BringToFront();
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().oferta());
                    metodoBusqueda.StartIndex = 0;
                    break;

                case "departamento":
                    labelDepartamentos.ForeColor = Color.RoyalBlue;
                    Transition.run(indicadorlabel, "Left", labelDepartamentos.Left, new TransitionType_EaseInEaseOut(500));
                    indicadorlabel.Width = labelDepartamentos.Width;
                    detalleDepartamento.BringToFront();
                    new listadoItems().llenar(metodoBusqueda, new listadoItems().departamento());
                    metodoBusqueda.StartIndex = 0;
                    break;
            }

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            switch (active)
            {
                case "usuario":
                    new usuarioForm().Show();
                    break;

                case "producto":
                    new productoForm().Show();
                    break;

                case "categoria":
                    new categoriaForm().Show();
                    break;

                case "oferta":
                    new ofertaForm().Show();
                    break;

                case "departamento":
                    new departamentoForm().Show();
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
                    case "usuario":
                        detalleUsuario.setInfo(value);
                        break;

                    case "producto":
                        detalleProducto.setInfo(int.Parse(value));
                        break;

                    case "categoria":
                        detalleCategoria.setInfo(int.Parse(value));
                        break;

                    case "oferta":
                        detalleOferta.setInfo(int.Parse(value));
                        break;

                    case "departamento":
                        detalleDepartamento.setInfo(int.Parse(value));
                        break;
                }
            }
            catch (Exception es) { }
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
                Cargar(true);
            else
                Cargar(false);
        }

        private void labelusuarios_Click(object sender, EventArgs e)
        {
            active = "usuario";
            activa();
        }

        private void labelproductos_Click(object sender, EventArgs e)
        {
            active = "producto";
            activa();
        }

        private void labelcategorias_Click(object sender, EventArgs e)
        {
            active = "categoria";
            activa();
        }

        private void labelofertas_Click(object sender, EventArgs e)
        {
            active = "oferta";
            activa();
        }

        private void labelDepartamentos_Click(object sender, EventArgs e)
        {
            active = "departamento";
            activa();
        }
    }
}
