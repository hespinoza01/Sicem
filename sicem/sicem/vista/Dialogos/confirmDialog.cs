using BunifuAnimatorNS;
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
    public partial class confirmDialog : Form
    {
        public confirmDialog(string msj)
        {
            InitializeComponent();
            mensaje.Text = msj;
        }

        private void confirmDialog_Load(object sender, EventArgs e)
        {
            this.Region = new region().RoundBorder(this.Width, this.Height, 10);
            content.Region = new region().RoundBorder(content.Width, content.Height, 10);
            txtContraseña.Region = new region().RoundBorder(txtContraseña.Width, txtContraseña.Height+1, 10);

            txtContraseña.PasswordChar = '\u25CF';

            contentConfirm.Visible = false;

            close.Click += cancelar_Click;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            BunifuTransition t = new BunifuTransition();
            t.AnimationType = AnimationType.HorizSlide;
            t.MaxAnimationTime = 1000;
            t.ShowSync(contentConfirm);
            t.Dispose();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if(txtContraseña.Text.Length > 0)
            {
                confirmar.Visible = true;
                txtContraseña.ShowClearButton = true;
            }else
            {
                confirmar.Visible = false;
                txtContraseña.ShowClearButton = false;
            }
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            DataTable data = new usuario().Verifica("Administrador", txtContraseña.Text.Trim());
            this.DialogResult = (data.Rows.Count != 0) ? DialogResult.OK : DialogResult.No ;
            this.Close();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                confirmar_Click(null, null);
        }
    }
}
