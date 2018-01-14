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
    public partial class categoriaForm : Form
    {
        string accionformulario;
        public categoriaForm()
        {
            InitializeComponent();
            accionformulario = "crear";
            loadID();
        }

        public categoriaForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }

        private void categoriaForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            aceptar.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            txtId.Region = new region().RoundBorder(txtId.Width, txtId.Height+1, 7);
            txtNombre.Region = new region().RoundBorder(txtNombre.Width, txtNombre.Height+1, 7);
            txtDescripcion.Region = new region().RoundBorder(txtDescripcion.Width, txtDescripcion.Height+1, 7);

            new drag().setDragable(toppanel);
        }

        private void setDataView(int id)
        {
            DataTable data = new Categoria().Detalle(id);

            if(data != null){
                DataRow row = data.Rows[0];

                txtId.Text = row["ID"].ToString();
                txtNombre.Text = row["Nombre"].ToString();
                txtDescripcion.Text = row["Descripcion"].ToString();
                estadoValor.Checked = (int.Parse(row["Estado"].ToString()) == 1) ? true : false;
            }else{
                new popup("Error al mostrar información", popup.AlertType.error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }

        private void loadID()
        {
            int value = (int)new DBHelper().ReaderScalar("select count(*) + 1 from Categoria");
            txtId.Text = value.ToString();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria();
            c.Nombre = txtNombre.Text;
            c.Descripcion = txtDescripcion.Text;
            c.Estado = (estadoValor.Checked) ? 1 : 0;
        
            if (accionformulario == "crear")
            {
                c.Insertar();
            }
            else
            {
                c.ID = int.Parse(txtId.Text);
                c.Editar();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
