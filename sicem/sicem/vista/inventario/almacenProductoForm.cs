using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem
{
    public partial class almacenProductoForm : Form
    {
        string accionformulario;
        int idinventario, idproducto = -1, idbodega = -1;
        List<int> valuesidproducto = new List<int>();
        List<int> valuesidbodega = new List<int>();
        bool cargainfo = false;
        public almacenProductoForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public almacenProductoForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }

        private void almacenProductoForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            if (accionformulario == "crear")
            {
                labelDisponible.Text = "";
                labelSinAlmacenar.Text = "";
                remover.Visible = false;
            }
            aceptar.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            txtProducto.Region = new region().RoundBorder(txtProducto.Width, txtProducto.Height+1, 7);
            txtBodega.Region = new region().RoundBorder(txtBodega.Width, txtBodega.Height+1, 7);
            txtEstante.Region = new region().RoundBorder(txtEstante.Width, txtEstante.Height+1, 7);
            txtCantidad.Region = new region().RoundBorder(txtCantidad.Width, txtCantidad.Height+1, 7);

            sugerenciaProducto.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            sugerenciaProducto.ItemHeight = 15;
            txtProducto.TopLevelControl.Controls.Add(sugerenciaProducto);
            Point controlLocation = txtProducto.TopLevelControl.PointToClient(txtProducto.Parent.PointToScreen(txtProducto.Location));
            sugerenciaProducto.Left = controlLocation.X + 5;
            sugerenciaProducto.Top = controlLocation.Y + txtProducto.Height;
            sugerenciaProducto.Width = txtProducto.Width - 10;
            sugerenciaProducto.Height = sugerenciaProducto.ItemHeight * 5;
            sugerenciaProducto.Visible = false;

            sugerenciaBodega.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            sugerenciaBodega.ItemHeight = 15;
            txtBodega.TopLevelControl.Controls.Add(sugerenciaBodega);
            controlLocation = txtBodega.TopLevelControl.PointToClient(txtBodega.Parent.PointToScreen(txtBodega.Location));
            sugerenciaBodega.Left = controlLocation.X + 5;
            sugerenciaBodega.Top = controlLocation.Y + txtBodega.Height;
            sugerenciaBodega.Width = txtBodega.Width - 10;
            sugerenciaBodega.Height = sugerenciaBodega.ItemHeight * 5;
            sugerenciaBodega.Visible = false;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try {
                if (idproducto != -1 && idbodega != -1)
                {
                    Inventario i = new Inventario();
                    i.ProductoID = idproducto;
                    i.BodegaID = idbodega;
                    i.Estante = txtEstante.Text;
                    i.Cantidad = (int)txtCantidad.Value;

                    if (accionformulario == "crear")
                        i.Insertar();
                    else
                    {
                        i.ID = idinventario;
                        i.Editar();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    new popup("No se pudo realizar la acción", popup.AlertType.error);
            }catch(Exception ex) { }
        }


        private void setDataView(int id)
        {
            DataTable data = new Inventario().Detalle(id);

            if (data != null) {
                cargainfo = true;
                DataRow r = data.Rows[0];

                idinventario = int.Parse(r["ID"].ToString());
                obtenerProducto(int.Parse(r["ProductoID"].ToString()));
                obtenerBodega(int.Parse(r["BodegaID"].ToString()));
                txtEstante.Text = r["Estante"].ToString();
                txtCantidad.Value = decimal.Parse(r["Cantidad"].ToString());

                cargainfo = false;
            } else {
                new popup("Error al mostrar información", popup.AlertType.error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void obtenerProducto(int id)
        {
            DataTable data = new Producto().Detalle(id);
            if(data != null){
                DataRow r = data.Rows[0];
                txtProducto.Text = r["Nombre"].ToString();
                idproducto = int.Parse(r["ID"].ToString());
                productoSinAlmacenar();
            }
        }

        private void obtenerBodega(int id)
        {
            DataTable data = new Bodega().Detalle(id);
            if (data != null)
            {
                DataRow r = data.Rows[0];
                txtBodega.Text = r["Nombre"].ToString();
                idbodega = int.Parse(r["ID"].ToString());
                almacenajeDisponible();
            }
        }

        private void productoSinAlmacenar()
        {
            object value = new DBHelper().ReaderScalar("select Stock from Producto where ID = '"+idproducto+"'");
            DataTable data = new Inventario().Mostrar(idinventario);
            int suma = 0;

            if(data != null)
            {
                foreach(DataRow r in data.Rows)
                    suma += int.Parse(r["Cantidad"].ToString());
            }
            labelSinAlmacenar.Text = (value != null) ? (int.Parse(value.ToString()) - suma).ToString() : "";
        }

        private void almacenajeDisponible()
        {
            object value = new DBHelper().ReaderScalar("select Almacenaje from Bodega where ID = '" + idbodega + "'");
            DataTable data = new DBHelper().Reader("select * from Inventario where BodegaID = '" + idbodega + "'");
            int suma = 0;

            if (data != null)
            {
                foreach (DataRow r in data.Rows)
                    suma += int.Parse(r["Cantidad"].ToString());
            }
            labelDisponible.Text = (value != null) ? (int.Parse(value.ToString()) - suma).ToString() : "";
        }

        private void sugerencias(int tipo)
        {
            DataTable data = (tipo == 1) ? new Producto().Buscar(txtProducto.Text, 0) : new Bodega().Buscar(txtBodega.Text, 0);

            if(data != null){
                valuesidproducto.Clear();
                valuesidbodega.Clear();
                sugerenciaProducto.Items.Clear();
                sugerenciaBodega.Items.Clear();
                foreach(DataRow r in data.Rows){
                    if(tipo == 1){
                        valuesidproducto.Add(int.Parse(r["ID"].ToString()));
                        sugerenciaProducto.Items.Add(r["Nombre"].ToString());
                    }else{
                        valuesidbodega.Add(int.Parse(r["ID"].ToString()));
                        sugerenciaBodega.Items.Add(r["Nombre"].ToString());
                    }
                }
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if(!cargainfo){
                if (txtProducto.Text.Length > 0)
                {
                    sugerencias(1);
                    sugerenciaProducto.Visible = true;
                    sugerenciaProducto.BringToFront();
                }
                else
                    sugerenciaProducto.Visible = false;

                idproducto = -1;
            }
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((sugerenciaProducto.Visible) && (sugerenciaProducto.SelectedIndex < sugerenciaProducto.Items.Count - 1))
                            sugerenciaProducto.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (sugerenciaProducto.Visible && sugerenciaProducto.SelectedIndex >= 0)
                            sugerenciaProducto.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (sugerenciaProducto.Visible)
                        {
                            sugerenciaProducto_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void sugerenciaProducto_Click(object sender, EventArgs e)
        {
            if (sugerenciaProducto.SelectedIndex >= 0)
            {
                cargainfo = true;
                txtProducto.Text = sugerenciaProducto.SelectedItem.ToString();
                idproducto = valuesidproducto[sugerenciaProducto.SelectedIndex];
                cargainfo = false;
            }

            txtProducto.Focus();
            txtProducto.Select(txtProducto.Text.Length, 0);
            sugerenciaProducto.Visible = false;
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (!sugerenciaProducto.ContainsFocus)
                sugerenciaProducto.Visible = false;
        }

        private void sugerenciaProducto_Leave(object sender, EventArgs e)
        {
            if (!txtProducto.ContainsFocus)
                sugerenciaProducto.Visible = false;
        }

        private void txtBodega_TextChanged(object sender, EventArgs e)
        {
            if(!cargainfo){
                if (txtBodega.Text.Length > 0)
                {
                    sugerencias(2);
                    sugerenciaBodega.Visible = true;
                    sugerenciaBodega.BringToFront();
                }
                else
                    sugerenciaBodega.Visible = false;

                idbodega = -1;
            }
        }

        private void txtBodega_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((sugerenciaBodega.Visible) && (sugerenciaBodega.SelectedIndex < sugerenciaBodega.Items.Count - 1))
                            sugerenciaBodega.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (sugerenciaBodega.Visible && sugerenciaBodega.SelectedIndex >= 0)
                            sugerenciaBodega.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (sugerenciaBodega.Visible)
                        {
                            sugerenciaBodega_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void sugerenciaBodega_Click(object sender, EventArgs e)
        {
            if (sugerenciaBodega.SelectedIndex >= 0)
            {
                cargainfo = true;
                txtBodega.Text = sugerenciaBodega.SelectedItem.ToString();
                idbodega = valuesidbodega[sugerenciaBodega.SelectedIndex];
                cargainfo = false;
            }

            txtBodega.Focus();
            txtBodega.Select(txtBodega.Text.Length, 0);
            sugerenciaBodega.Visible = false;
        }

        private void txtBodega_Leave(object sender, EventArgs e)
        {
            if (!sugerenciaBodega.ContainsFocus)
                sugerenciaBodega.Visible = false;
        }

        private void sugerenciaBodega_Leave(object sender, EventArgs e)
        {
            if (!txtBodega.ContainsFocus)
                sugerenciaBodega.Visible = false;
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(txtCantidad.Value.ToString());
            if(!(valor <= int.Parse(labelSinAlmacenar.Text)) && !(valor >= int.Parse(labelDisponible.Text)))
            {
                txtCantidad.Value = 0;
                new popup("Cantidad no valida", popup.AlertType.warning);
            }
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (new logoutDialog("¿ Remover del registro ? \nEsta acción no puede deshacerse.").ShowDialog() == DialogResult.OK)
            {
                new Inventario().Remover(idinventario);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}
