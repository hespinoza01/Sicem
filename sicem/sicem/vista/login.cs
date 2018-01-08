using sicem.vista.Dialogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace sicem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void log_Load(object sender, EventArgs e)
        {
            picture.Focus();
            inicia();
        }

        /*
            Métodos
        */
        // establecer region para poner bordes redondeados
        private void inicia()
        {
            content.Region = new region().RoundBorder(680, 530, 8);
            picture.Region = new region().Circle(120, 120);

            username.TopLevelControl.Controls.Add(listaSugetencias);
            Point controlLocation = username.TopLevelControl.PointToClient(username.Parent.PointToScreen(username.Location));
            listaSugetencias.Left = controlLocation.X + 5;
            listaSugetencias.Top = controlLocation.Y + username.Height;
            listaSugetencias.Width = 200;
            listaSugetencias.Height = listaSugetencias.ItemHeight * 4;

            password.PasswordChar = '\u25CF';
        }

        private void showPreloader()
        {
            Transition.run(this, "Width", 370, new TransitionType_EaseInEaseOut(1000));
            Transition.run(this, "Left", this.Left + 155, new TransitionType_EaseInEaseOut(1000));
            Transition.run(bglogo, "Left", 20, new TransitionType_EaseInEaseOut(1000));
            Transition.run(content, "BackColor", Color.RoyalBlue, new TransitionType_EaseInEaseOut(1100));
        }

        // verificar usuario
        private bool verifica()
        {
            bool ver = true;
            try
            {
                //DataTable Datos = new user().Verifica(this.username.Text,this.password.Text);

                //if (Datos.Rows.Count != 0){ver= true;}
                //else {ver= false;}

                return ver;
            }
            catch (Exception ex)
            {
                //new popup(ex.Message, popup.AlertType.error);
                return ver;
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text.Length > 0)
                username.ShowClearButton = true;
        }

        private void username_OnValueChanged(object sender, EventArgs e)
        {
            if (username.Text.Length > 0)
            {
                username.ShowClearButton = true;
                listaSugetencias.Visible = true;
                listaSugetencias.BringToFront();
            }
            else
            {
                listaSugetencias.Visible = false;
                username.ShowClearButton = false;
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                password.Focus();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (!listaSugetencias.ContainsFocus)
            {
                listaSugetencias.Visible = false;
                username.ShowClearButton = false;
            }
        }

        private void listaSugetencias_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            username.Text = listaSugetencias.SelectedItem.ToString();
            username.Focus();
            username.Select(username.Text.Length, 0);
            listaSugetencias.Visible = false;
        }

        private void listaSugetencias_Leave(object sender, EventArgs e)
        {
            if (!username.ContainsFocus)
            {
                listaSugetencias.Visible = false;
                username.ShowClearButton = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (username.Text.Length > 0)
                password.ShowClearButton = true;
            else
                password.ShowClearButton = false;
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                ingresar_Click(null, null);
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (username.Text.Length > 0)
                password.ShowClearButton = true;

            //if (username.Text != "")
            //picture.Image = new user().obtenerFoto(username.Text);
        }

        private void password_Leave(object sender, EventArgs e)
        {
            password.ShowClearButton = false;
        }

        private void viewpass_MouseDown(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '\0';
        }

        private void viewpass_MouseUp(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '\u25CF';
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if (verifica())
            {
                //new home().Show();
                //this.Hide();
                showPreloader();
                //new popup("Bienvenido...", popup.AlertType.check);
            }
            else
            {
                //new popup("Usuario o contraseña incorrectos", popup.AlertType.error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if(new logoutDialog("¿ Salir del sistema ?").ShowDialog() == DialogResult.OK)
                Application.Exit();
        }

    }
}
