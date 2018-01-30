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
    public partial class bodegaForm : Form
    {
        string accionformulario;
        public bodegaForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public bodegaForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }

        private void bodegaForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            if (accionformulario == "crear") loadID();
            aceptar.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            txtId.Region = new region().RoundBorder(txtId.Width, txtId.Height+1, 7);
            txtNombre.Region = new region().RoundBorder(txtNombre.Width, txtNombre.Height+1, 7);
            txtComentarios.Region = new region().RoundBorder(txtComentarios.Width, txtComentarios.Height+1, 7);
            txtCapacidad.Region = new region().RoundBorder(txtCapacidad.Width, txtCapacidad.Height+1, 7);
        }

        private void setDataView(int id)
        {
            DataTable data = new Bodega().Detalle(id);

            if(data != null)
            {
                DataRow r = data.Rows[0];

                txtId.Text = r["ID"].ToString();
                txtNombre.Text = r["Nombre"].ToString();
                txtCapacidad.Value = decimal.Parse(r["Almacenaje"].ToString());
                txtComentarios.Text = r["Comentarios"].ToString();
                estadoValor.Checked = (int.Parse(r["Estado"].ToString()) == 1) ? true : false;
            }
            else
            {
                new popup("Error al mostrar la información", popup.AlertType.error);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void loadID()
        {
            object value = new DBHelper().ReaderScalar("select count(*) + 1 from Bodega");
            if (value != null)
                txtId.Text = value.ToString();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try {
                Bodega b = new Bodega();
                b.Nombre = txtNombre.Text;
                b.Almacenaje = (int)txtCapacidad.Value;
                b.Comentarios = txtComentarios.Text;
                b.Estado = (estadoValor.Checked) ? 1 : 0;

                if (accionformulario == "crear")
                    b.Insertar();
                else
                {
                    b.ID = int.Parse(txtId.Text);
                    b.Editar();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }catch(Exception ex) { }
        }

    }
}
