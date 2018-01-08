using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem.vista.Dialogos
{
    public partial class logoutDialog : Form
    {
        public logoutDialog(string msj)
        {
            InitializeComponent();
            mensaje.Text = msj;
        }

        private void logoutDialog_Load(object sender, EventArgs e)
        {
            this.Region = new region().RoundBorder(this.Width, this.Height, 10);
            content.Region = new region().RoundBorder(content.Width, content.Height, 10);
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
