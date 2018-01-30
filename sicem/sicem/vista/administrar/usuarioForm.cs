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
        public usuarioForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public usuarioForm(string id)
        {
            InitializeComponent();
            accionformulario = "editar";
            Edit(id);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            iniciarVista();
        }

        private void iniciarVista()
        {
            border();
            lateral.Visible = false;
            bac.Visible = false;
            pass.PasswordChar = '\u25CF';
            confirPass.PasswordChar = '\u25CF';
        }

        public void border()
        {
            perfil.Region = new region().Circle(perfil.Width, perfil.Height);
            editPerfilPicture.Region = new region().Circle(editPerfilPicture.Width, editPerfilPicture.Height);

            nombreTxt.Region = new region().RoundBorder(nombreTxt.Width, nombreTxt.Height+1, 7);
            apellidoTxt.Region = new region().RoundBorder(apellidoTxt.Width, apellidoTxt.Height + 1, 7);
            nomUser.Region = new region().RoundBorder(nomUser.Width, nomUser.Height+1, 7);
            pass.Region = new region().RoundBorder(pass.Width, pass.Height+1, 7);
            confirPass.Region = new region().RoundBorder(confirPass.Width, confirPass.Height+1, 7);
        }

        public void Edit(string id)
        {
            DataTable data = new usuario().Detalle(id);

            if(data != null){
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
                else
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }

        }

        private string UserName()
        {
            string codigo = nombreTxt.Text.Substring(0, 3).ToLower() + apellidoTxt.Text.Substring(0, 3).ToLower();
            string cmd = "select count(*) + 1 from Usuario s where substring(s.ID, 1, 6) = '" + codigo + "'";

            object value = new DBHelper().ReaderScalar(cmd);
            if(value != null) {
                int cont = (int)value; 

                if (cont <= 9) codigo += "00" + cont;
                else if (cont <= 99) codigo += "0" + cont;
                else if (cont <= 999) codigo += cont;

            }else{ codigo += "001"; }

            return codigo;
        }

        private bool validaCampoContraseñas()
        {
            return (pass.Text.Equals("") || confirPass.Text.Equals("")) ? true : false;
        }

        public bool validaCamposNombreApellido()
        {
            return (nombreTxt.Text.Equals("") || apellidoTxt.Text.Equals("")) ? true : false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (validaCampoContraseñas()){
                popup p = new popup("Campos vacios...", popup.AlertType.error);

            }else{
                if (pass.Text.Equals(confirPass.Text)) {
                    usuario u = new usuario();
                    u.UserName = nomUser.Text;
                    u.Nombre = nombreTxt.Text;
                    u.Apellido = apellidoTxt.Text;
                    u.Password = pass.Text;
                    u.PPic = perfil.Image;

                    switch (accionformulario) {
                        case "editar":
                            if (new confirmDialog("¿ Actualizar perfil ?", nomUser.Text).ShowDialog() == DialogResult.OK)
                                u.Editar();
                            break;

                        case "crear":
                            u.Estado = 1;
                            u.Insertar();
                            break;
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }else{
                    popup p = new popup("Contraseñas no coinciden...", popup.AlertType.error);
                }
            }
            
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(!validaCamposNombreApellido())
            {
                bunifuTransition1.ShowSync(lateral);
                bac.Visible = true;
                if (accionformulario != "editar")
                    nomUser.Text = UserName();
            }
            else
                new popup("Rellenar todos los campos", popup.AlertType.error);
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

        private void perfil_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagen = new Bitmap(open.FileName);
                perfil.Image = imagen;
            }
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
