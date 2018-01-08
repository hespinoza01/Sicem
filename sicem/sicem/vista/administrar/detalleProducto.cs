using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem.vista.directorio
{
    public partial class detalleProducto : UserControl
    {
        public detalleProducto()
        {
            InitializeComponent();
        }

        public void ocultaCampos() {
            txtEstado.Visible = false;
            labelestado.Visible = false;
            editar.Visible = false;
            labelmsj.Visible = false;
            labelFechaModificacion.Visible = false;

            this.Left += 21;
            this.Top += 20;
        }
    }
}
