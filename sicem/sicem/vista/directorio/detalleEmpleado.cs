using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using System.IO;
using sicem.datos;

namespace sicem.vista.directorio
{
    public partial class detalleEmpleado : UserControl
    {
        bool expand = true;
        public detalleEmpleado()
        {
            InitializeComponent();
        }

        private void detalleEmpleado_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            editar.Visible = false;
            labelFechaModificacion.Text = "";
            EstadoValue.Text = "";

            collapsiveInfoPersonal.Height = 300;
            collapsiveInfoLaboral.Height = 35;
            collapsiveInfoLaboral.Top = 460;

            expandInfoPersonal.Click += expandCollapsive_Click;
            expandInfoLaboral.Click += expandInfoLaboral_Click;
            editar.Click += editar_Click;
        }

        public void setInfo(int id){
            DataTable data = new Empleado().Detalle(id);

            if(data != null){
                editar.Visible = true;
                DataRow row = data.Rows[0];

                txtID.Text = row["ID"].ToString();
                txtNombre.Text = row["Nombres"].ToString();
                txtApellido.Text = row["Apellidos"].ToString();
                setDepartamento(int.Parse(row["DepartamentoID"].ToString()));
                txtTituloLaboral.Text = row["TituloLaboral"].ToString();
                fechaNacimiento.Text = row["FechaDeNacimiento"].ToString();
                fechaContratacion.Text = row["FechaDeContratacion"].ToString();
                txtEstadoCivil.Text = row["EstadoCivil"].ToString();
                txtGenero.Text = (int.Parse(row[""].ToString()) == 1) ? "Masculino" : "Femenino";
                txtDireccion.Text = row["Domicilio"].ToString();
                txtCiudad.Text = row["Ciudad"].ToString();
                txtTel.Text = row["Telefono"].ToString();
                txtCedula.Text = row["Cedula"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtObservaciones.Text = row["Observaciones"].ToString();
                setReportarA(int.Parse(row["ReportarA"].ToString()));
                    byte[] img = (byte[])row["Foto"];
                    MemoryStream ms = new MemoryStream(img);
                foto.Image = Image.FromStream(ms);
                labelFechaModificacion.Text = row["FechaModificacion"].ToString();
                EstadoValue.Text = (int.Parse(row["Estado"].ToString()) == 1) ? "Habilitado" : "Deshabilitado";
            }else
                new popup("Error al mostrar detalle", popup.AlertType.error);
        }

        private void setDepartamento(int id)
        {
            object value = new DBHelper().ReaderScalar("select Nombre from RH_Departamentos where ID = '"+id+"'");
            if (value != null)
                txtDepartamento.Text = value.ToString();
        }

        private void setReportarA(int id)
        {
            object value = new DBHelper().ReaderScalar("select Nombres from RH_Empleado where ID = '" + id + "'");
            if (value != null)
                txtReportarA.Text = value.ToString();
        }

        private bool showCollapsiveInfoPersonal()
        {
            Transition.run(collapsiveInfoPersonal, "Height", 300, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Top", 460, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Height", 35, new TransitionType_EaseInEaseOut(500));
            expandInfoPersonal.Iconimage = sicem.Properties.Resources.hide_collapse;
            expandInfoLaboral.Iconimage = sicem.Properties.Resources.expand_collapse;
            collapsiveInfoPersonal.color = Color.RoyalBlue;
            collapsiveInfoLaboral.color = Color.White;
            return true;
        }

        private bool showCollapsiveInfoLaboral()
        {
            expandInfoPersonal.Iconimage = sicem.Properties.Resources.expand_collapse;
            expandInfoLaboral.Iconimage = sicem.Properties.Resources.hide_collapse;
            collapsiveInfoPersonal.color = Color.White;
            collapsiveInfoLaboral.color = Color.RoyalBlue;
            Transition.run(collapsiveInfoPersonal, "Height", 35, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Top", 195, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Height", 270, new TransitionType_EaseInEaseOut(500));
            return false;
        }

        private void expandCollapsive_Click(object sender, EventArgs e)
        {
            expand = (expand) ? showCollapsiveInfoLaboral() : showCollapsiveInfoPersonal();
        }

        private void expandInfoLaboral_Click(object sender, EventArgs e)
        {
            expand = (!expand) ? showCollapsiveInfoPersonal() : showCollapsiveInfoLaboral();
        }

        private void editar_Click(object sender, EventArgs e){
            if(new empleadoForm(int.Parse(txtID.Text)).ShowDialog() == DialogResult.OK)
                setInfo(int.Parse(txtID.Text));
        }
    }
}
