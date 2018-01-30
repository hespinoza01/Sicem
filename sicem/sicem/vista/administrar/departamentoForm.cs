using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem
{
    public partial class departamentoForm : Form
    {
        string accionformulario;
        public departamentoForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public departamentoForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }

        private void departamentoForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia() {
            guardarButton.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";
            if (accionformulario == "crear") LoadID();

            txtID.Region = new region().RoundBorder(txtID.Width, txtID.Height+1, 7);
            txtNombre.Region = new region().RoundBorder(txtNombre.Width, txtNombre.Height+1, 7);
            txtNombreGrupo.Region = new region().RoundBorder(txtNombreGrupo.Width, txtNombreGrupo.Height+1, 7);

            cancelarButton.Click += cancelar_Click;
            guardarButton.Click += aceptar_Click;

            new drag().setDragable(toppanel);
        }

        private void setDataView(int id)
        {
            DataTable data = new Departamento().Detalle(id);

            if(data != null)
            {
                DataRow r = data.Rows[0];

                txtID.Text = r["ID"].ToString();
                txtNombre.Text = r["Nombre"].ToString();
                txtNombreGrupo.Text = r["NombreGrupo"].ToString();
            }
            else
            {
                new popup("Error al mostrar la información", popup.AlertType.error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void LoadID()
        {
            object value = new DBHelper().ReaderScalar("select count(*)+1 from RH_Departamentos");
            if (value != null)
                txtID.Text = value.ToString();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try {
                Departamento d = new Departamento();
                d.ID = int.Parse(txtID.Text);
                d.Nombre = txtNombre.Text;
                d.NombreGrupo = txtNombreGrupo.Text;

                if (accionformulario == "crear")
                    d.Insertar();
                else
                    d.Editar();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }catch(Exception ex) { }
        }
    }
}
