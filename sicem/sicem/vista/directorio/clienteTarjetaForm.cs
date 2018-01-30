using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem
{
    public partial class clienteTarjetaForm : Form
    {
        string idcliente;
        List<int> idvalues = new List<int>();
        public clienteTarjetaForm(string id)
        {
            InitializeComponent();
            setInfo(id);
        }

        private void clienteTarjetaForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia() {
            agregar.Click += agregar_Click;
        }

        private void setInfo(string id)
        {
            DataTable data = new TarjetaCredito().Listar(id);

            if(data != null)
            {
                idcliente = id;
                idvalues.Clear();
                listado.Rows.Clear();
                foreach(DataRow r in data.Rows)
                {
                    string t, n, em, ea, f;

                    idvalues.Add(int.Parse(r["ID"].ToString()));
                    t = r["TipoTarjeta"].ToString();
                    n = r["NumeroTarjeta"].ToString();
                    em = r["ExpiraMes"].ToString();
                    ea = r["ExpiraAño"].ToString();
                    f = r["FechaModificacion"].ToString();

                    listado.Rows.Add(t, n, em, ea, f);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (new tarjetaCreditoForm(idcliente).ShowDialog() == DialogResult.OK)
                setInfo(idcliente);
        }

        private void listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (new tarjetaCreditoForm(idvalues[e.RowIndex]).ShowDialog() == DialogResult.OK)
                    setInfo(idcliente);
            }
            catch (Exception ex) { }
        }
    }
}
