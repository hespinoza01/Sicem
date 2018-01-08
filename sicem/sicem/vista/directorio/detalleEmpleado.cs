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
            collapsiveInfoPersonal.Height = 300;
            collapsiveInfoLaboral.Height = 35;
            collapsiveInfoLaboral.Top = 460;

            expandInfoPersonal.Click += expandCollapsive_Click;
            expandInfoLaboral.Click += expandInfoLaboral_Click;
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
    }
}
