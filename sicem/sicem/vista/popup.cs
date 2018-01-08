using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Transitions;

namespace sicem
{
    public partial class popup : Form
    {
        int h;
        public popup(string message, AlertType type)
        {
            InitializeComponent();
            h = this.Height;
            switch (type)
            {
                case AlertType.check:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = lista.Images[0];
                    txtMessage.Text = message;
                    break;

                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    icon.Image = lista.Images[1];
                    txtMessage.Text = message;
                    break;

                case AlertType.info:
                    this.BackColor = Color.RoyalBlue;
                    icon.Image = lista.Images[2];
                    txtMessage.Text = message;
                    break;

                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255,128,0);
                    icon.Image = lista.Images[3];
                    txtMessage.Text = message;
                    break;
            }

            this.Show();
        }

        public popup(string message, int c, AlertType type)
        {
            InitializeComponent();
            h = (this.Height * c);

            switch (type)
            {
                case AlertType.check:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = lista.Images[0];
                    txtMessage.Text = message;
                    break;

                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    icon.Image = lista.Images[1];
                    txtMessage.Text = message;
                    break;

                case AlertType.info:
                    this.BackColor = Color.RoyalBlue;
                    icon.Image = lista.Images[2];
                    txtMessage.Text = message;
                    break;

                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    icon.Image = lista.Images[3];
                    txtMessage.Text = message;
                    break;
            }

            this.Show();
        }

        public enum AlertType
        {
            check,error,info,warning
        }

        private void popup_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            this.Top = Screen.PrimaryScreen.Bounds.Height;
            Transition.run(this, "Top", Screen.PrimaryScreen.WorkingArea.Height - (h + 15), new TransitionType_EaseInEaseOut(750));
            show.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            closed.Start();
        }

        private void show_Tick(object sender, EventArgs e)
        {
            Transition.run(this, "Top", Screen.PrimaryScreen.WorkingArea.Height - h, new TransitionType_EaseInEaseOut(275));
            show.Stop();
            time.Start();
        }

        private void closed_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
                this.Opacity -= 0.02;
            else
                this.Close();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            closed.Start();
        }

        private void popup_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void popup_Shown(object sender, EventArgs e)
        {
        }


    }
}
