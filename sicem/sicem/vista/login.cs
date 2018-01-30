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
        home home = new home();
        public login()
        {
            InitializeComponent();
        }

        private void log_Load(object sender, EventArgs e)
        {
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

            username.TopLevelControl.Controls.Add(listaSugerencias);
            Point controlLocation = username.TopLevelControl.PointToClient(username.Parent.PointToScreen(username.Location));
            listaSugerencias.Left = controlLocation.X + 5;
            listaSugerencias.Top = controlLocation.Y + username.Height;
            listaSugerencias.Width = 200;
            listaSugerencias.Height = listaSugerencias.ItemHeight * 4;

            password.PasswordChar = '\u25CF';
            picture.Focus();
        }

        private void sugerencias() {
            DataTable data = new usuario().Buscar(username.Text, 0);

            if(data != null){
                listaSugerencias.Items.Clear();
                foreach(DataRow r in data.Rows)
                    listaSugerencias.Items.Add(r["ID"].ToString());

                listaSugerencias.Height = (listaSugerencias.Items.Count > 5) ? (listaSugerencias.ItemHeight * 5) : (listaSugerencias.Items.Count * listaSugerencias.ItemHeight);
                listaSugerencias.Visible = true;
                listaSugerencias.BringToFront();
            }
        }

        private void showPreloader()
        {
            Transition.run(this, "Width", 370, new TransitionType_EaseInEaseOut(1000));
            Transition.run(this, "Left", this.Left + 155, new TransitionType_EaseInEaseOut(1000));
            Transition.run(bglogo, "Left", 20, new TransitionType_EaseInEaseOut(1000));
            Transition.run(content, "BackColor", Color.RoyalBlue, new TransitionType_EaseInEaseOut(1100));
            preloaderTime.Start();
            home.setInfo(username.Text);
            new popup("Bienvenido...", popup.AlertType.check);
        }

        // verificar usuario
        private bool verifica()
        {
            DataTable data = new usuario().Verifica(this.username.Text.Trim(),this.password.Text.Trim());
            return (data.Rows.Count != 0) ? true : false;
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
                sugerencias();
            }
            else
            {
                listaSugerencias.Visible = false;
                username.ShowClearButton = false;
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                password.Focus();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((listaSugerencias.Visible) && (listaSugerencias.SelectedIndex < listaSugerencias.Items.Count - 1))
                            listaSugerencias.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (listaSugerencias.Visible && listaSugerencias.SelectedIndex >= 0)
                            listaSugerencias.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (listaSugerencias.Visible)
                        {
                            listaSugerencias_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (!listaSugerencias.ContainsFocus)
            {
                listaSugerencias.Visible = false;
                username.ShowClearButton = false;
            }
        }

        private void listaSugerencias_Click(object sender, EventArgs e)
        {
            if (listaSugerencias.SelectedIndex >= 0)
                username.Text = listaSugerencias.SelectedItem.ToString();

            username.Focus();
            username.Select(username.Text.Length, 0);
            listaSugerencias.Visible = false;
        }

        private void listaSugerencias_Leave(object sender, EventArgs e)
        {
            if (!username.ContainsFocus)
            {
                listaSugerencias.Visible = false;
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

            if (username.Text.Length > 0)
                picture.Image = new usuario().obtenerFoto(username.Text.Trim());
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
                showPreloader();
            else
                new popup("Usuario o contraseña incorrectos", popup.AlertType.error);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if(new logoutDialog("¿ Salir del sistema ?").ShowDialog() == DialogResult.OK)
                Application.Exit();
        }

        private void preloaderTime_Tick(object sender, EventArgs e)
        {
            preloaderTime.Stop();
            home.Show();
            this.Close();
        }
    }
}
