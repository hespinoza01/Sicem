using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem
{
    public partial class usuarioForm : Form
    {
        string accionformulario;
        Image pic;
        public usuarioForm()
        {
            InitializeComponent();
            iniciarVista();
            accionformulario = "crear";
        }

        public usuarioForm(string id)
        {
            InitializeComponent();
            iniciarVista();
            accionformulario = "editar";
            Edit(id);
        }

        private void iniciarVista()
        {
            CircleUserPicture();
            lateral.Visible = false;
            bac.Visible = false;
            pass.PasswordChar = '\u25CF';
            confirPass.PasswordChar = '\u25CF';
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (CVacios()){
                popup p = new popup("Campos vacios...", popup.AlertType.error);

            }else{
                if (pass.Text.Equals(confirPass.Text)){

                    if (accionformulario == "editar"){
                        editInfo();
                    }else{
                        saveNew();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }else{
                    popup p = new popup("Contraseñas no coinciden...", popup.AlertType.error);
                }
            }
            
        }

        private void confirmarActualizarPerfil()
        {
            //if (new dialogoConfirmarContraseña(nomUser.Text).ShowDialog() == DialogResult.OK)
            //    editInfo();
            //else
            //    new popup("Verificación de contraseña incorrecta", popup.AlertType.error);
        }

        private bool CVacios()
        {
            bool vacio = false;

            //if (nomUser.Text.Equals("")) { vacio = true; }    

            if (pass.Text.Equals("")) { vacio = true; }  

            if (confirPass.Text.Equals("")) { vacio = true; }
            Console.Write(vacio);
            return vacio;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(val())
            {
                bunifuTransition1.ShowSync(lateral);
                bac.Visible = true;
                if (accionformulario != "editar")
                    nomUser.Text = UserName();
            }
            else
            {
                popup p = new popup("Rellenar todos los campos", popup.AlertType.error);
            }
        }

        public bool val()
        {
            bool val = true;

            if (nombreTxt.Text.Equals("")) { val = false; }
            if(apellidoTxt.Text.Equals("")) { val = false; }

            return val;
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                confirPass.Focus();
        }

        private void confirPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                registrar_Click(null, null);
        }

        private void apellidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                pass.Focus();
                next_Click(null, null);
            }

            if (apellidoTxt.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (apellidoTxt.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void nombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                apellidoTxt.Focus();

            if(nombreTxt.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if(nombreTxt.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void bac_Click(object sender, EventArgs e)
        {
            lateral.Visible = false;
            bac.Visible = false;
        }

        void saveNew()
        {
            new usuario(
                nombreTxt.Text,
                apellidoTxt.Text,
                pass.Text,
                nomUser.Text,
                perfil.Image,
                usuario.Accion.insertar
                );
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        public void Edit(string id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Usuario");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select ID, Nombre, Apellido, Contraseña, FotoPerfil from Usuario where ID = '" + id+"'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    nomUser.Text = row["ID"].ToString();
                    nombreTxt.Text = row["Nombre"].ToString();
                    apellidoTxt.Text = row["Apellido"].ToString();
                    pass.Text = row["Contraseña"].ToString();
                    confirPass.Text = row["Contraseña"].ToString();

                    byte[] img = (byte[])row["FotoPerfil"];
                    MemoryStream ms = new MemoryStream(img);
                    perfil.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    //this.Close();
                }
            }

        }

        private string UserName()
        {
            string codigo = "@" + nombreTxt.Text.Substring(0, 3) + apellidoTxt.Text.Substring(0, 3);
            codigo += "001";
            //Conexión conexion = new Conexión();

            //using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            //{
            //    try
            //    {
            //        cn.Open();

            //        SqlCommand cmd = new SqlCommand("select count(*) + 1 from Usuario s where substring(s.ID, 1, 7) = '" + codigo+"'", cn);

            //        int cont = (int)cmd.ExecuteScalar();
            //        if (cont <= 9)
            //            codigo += "00" + cont;
            //        if (cont <= 99)
            //            codigo += "0" + cont;
            //        if (cont <= 999)
            //            codigo += cont;
            //    }
            //    catch (Exception ex) { codigo += "001"; }
            //}

            return codigo;
        }

        private void perfil_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagen = new Bitmap(open.FileName);
                perfil.Image = imagen;
            }
        }

        public void editInfo()
        {
            new usuario(
                nombreTxt.Text,
                apellidoTxt.Text,
                pass.Text,
                nomUser.Text,
                perfil.Image,
                usuario.Accion.editar
                );
        }

        public void CircleUserPicture()
        {
            perfil.Region = new region().Circle(perfil.Width, perfil.Height);
            editPerfilPicture.Region = new region().Circle(editPerfilPicture.Width, editPerfilPicture.Height);

            nombreTxt.Region = new region().RoundBorder(nombreTxt.Width, nombreTxt.Height+1, 7);
            apellidoTxt.Region = new region().RoundBorder(apellidoTxt.Width, apellidoTxt.Height + 1, 7);
            nomUser.Region = new region().RoundBorder(nomUser.Width, nomUser.Height+1, 7);
            pass.Region = new region().RoundBorder(pass.Width, pass.Height+1, 7);
            confirPass.Region = new region().RoundBorder(confirPass.Width, confirPass.Height+1, 7);
        }

        private void contraseñaVisible_OnValueChange(object sender, EventArgs e)
        {
            if (contraseñaVisible.Value)
            {
                pass.PasswordChar = '\0';
                confirPass.PasswordChar = '\0';
            }
            else
            {
                pass.PasswordChar = '\u25CF';
                confirPass.PasswordChar = '\u25CF';
            }
        }
    }
}
