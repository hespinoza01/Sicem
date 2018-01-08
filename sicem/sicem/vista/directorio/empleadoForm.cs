﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace sicem
{
    public partial class empleadoForm : Form
    {
        string accionformulario;
        bool expand = true;
        public empleadoForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public empleadoForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }
        
        private void clienteForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            guardar.ButtonText = (accionformulario == "crear" ? "Guardar" : "Actualizar");
            if (accionformulario == "crear")
            {
                fechaNacimiento.Value = DateTime.Now;
                fechaContratacion.Value = DateTime.Now;
            }

            foto.Region = new region().Circle(foto.Width, foto.Height);
            txtNombre.Region = new region().RoundBorder(txtNombre.Width, txtNombre.Height +1, 7);
            txtApellido.Region = new region().RoundBorder(txtApellido.Width, txtApellido.Height+1, 7);
            txtID.Region = new region().RoundBorder(txtID.Width, txtID.Height +1, 7);
            txtEmail.Region = new region().RoundBorder(txtEmail.Width, txtEmail.Height+1, 7);
            txtTel.Region = new region().RoundBorder(txtTel.Width, txtTel.Height+1, 7);
            txtCedula.Region = new region().RoundBorder(txtCedula.Width, txtCedula.Height+1, 7);
            txtDireccion.Region = new region().RoundBorder(txtDireccion.Width, txtDireccion.Height+1, 7);
            txtDepartamento.Region = new region().RoundBorder(txtDepartamento.Width, txtDepartamento.Height+1, 7);
            txtTituloLaboral.Region = new region().RoundBorder(txtTituloLaboral.Width, txtTituloLaboral.Height+1, 7);
            txtReportarA.Region = new region().RoundBorder(txtReportarA.Width, txtReportarA.Height+1, 7);
            txtObservaciones.Region = new region().RoundBorder(txtObservaciones.Width, txtObservaciones.Height+1, 7);

            collapsiveInfoPersonal.Height = 300;
            collapsiveInfoLaboral.Height = 35;
            collapsiveInfoLaboral.Top = 510;
        }

        private bool showCollapsiveInfoPersonal()
        {
            //expand = true;
            Transition.run(collapsiveInfoPersonal, "Height", 300, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Top", 510, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Height", 35, new TransitionType_EaseInEaseOut(500));
            expandInfoPersonal.Iconimage = sicem.Properties.Resources.hide_collapse;
            expandInfoLaboral.Iconimage = sicem.Properties.Resources.expand_collapse;
            collapsiveInfoPersonal.color = Color.RoyalBlue;
            collapsiveInfoLaboral.color = Color.White;
            return true;
        }

        private bool showCollapsiveInfoLaboral()
        {
            //expand = false;
            expandInfoPersonal.Iconimage = sicem.Properties.Resources.expand_collapse;
            expandInfoLaboral.Iconimage = sicem.Properties.Resources.hide_collapse;
            collapsiveInfoPersonal.color = Color.White;
            collapsiveInfoLaboral.color = Color.RoyalBlue;
            Transition.run(collapsiveInfoPersonal, "Height", 35, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Top", 245, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Height", 270, new TransitionType_EaseInEaseOut(500));
            return false;
        }

        private void setDataView(int id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Cliente");
            using(SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Cliente where ID = '" + id+"'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtID.Text = row["ID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtTel.Text = row["Telefono"].ToString();
                    txtDireccion.Text = row["Domicilio"].ToString();
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }
         
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Cliente Client = new Cliente();
            Client.C_Nombre = txtNombre.Text;
            Client.C_Domicilio = txtDireccion.Text;
            Client.C_Email = txtEmail.Text;
            Client.C_Telefono = txtTel.Text;

            if (accionformulario == "crear")
            {
                try { Client.Insertar(); }
                catch (Exception ex) { new popup("Inserción fallida", popup.AlertType.error); }
                this.Close();
            }
            else
            {
                try
                {
                    Client.C_Id = int.Parse(txtID.Text);
                    Client.Editar();
                }
                catch (Exception ex) { new popup("Actualización fallida", popup.AlertType.error); }
            }

        }

        private void expandCollapsive_Click(object sender, EventArgs e)
        {
            expand = (expand) ? showCollapsiveInfoLaboral() : showCollapsiveInfoPersonal();
        }

        private void expandInfoLaboral_Click(object sender, EventArgs e)
        {
            expand = (!expand) ? showCollapsiveInfoPersonal() : showCollapsiveInfoLaboral();
        }

        private void foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagen = new Bitmap(open.FileName);
                foto.Image = imagen;
            }

            open.Dispose();
        }
    }
}