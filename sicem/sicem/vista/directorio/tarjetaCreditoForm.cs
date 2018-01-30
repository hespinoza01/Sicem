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
    public partial class tarjetaCreditoForm : Form
    {
        string accionformulario, idcliente="";
        int idtarjeta;
        public tarjetaCreditoForm(string idc)
        {
            InitializeComponent();
            idcliente = idc;
            accionformulario = "crear";
        }

        public tarjetaCreditoForm(int idt)
        {
            InitializeComponent();
            setInfo(idt);
            accionformulario = "editar";
        }

        private void tarjetaCreditoForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            if (accionformulario == "crear") LoadID();
            aceptar.ButtonText = (accionformulario == "crear") ? "Guardar" : "Actualizar";

            txtTipoTarjeta.Region = new region().RoundBorder(txtTipoTarjeta.Width, txtTipoTarjeta.Height+1, 7);
            txtNumeroTarjeta.Region = new region().RoundBorder(txtNumeroTarjeta.Width, txtNumeroTarjeta.Height+1, 7);
            txtExpiraMes.Region = new region().RoundBorder(txtExpiraMes.Width, txtExpiraMes.Height+1, 7);
            txtExpiraAño.Region = new region().RoundBorder(txtExpiraAño.Width, txtExpiraAño.Height+1, 7);

            cancelar.Click += canelar_Click;
            aceptar.Click += aceptar_Click;
            remover.Click += remover_Click;
        }

        private void LoadID()
        {
            object value = new DBHelper().ReaderScalar("select count(*)+1 from TarjetaCredito");
            if (value != null)
                idtarjeta = (int)value;
        }

        private void setInfo(int id)
        {
            DataTable data = new TarjetaCredito().Detalle(id);

            if(data != null)
            {
                remover.Visible = true;
                DataRow r = data.Rows[0];

                idtarjeta = id;
                txtTipoTarjeta.Text = r["TipoTarjeta"].ToString();
                txtNumeroTarjeta.Text = r["NumeroTarjeta"].ToString();
                txtExpiraMes.Value = decimal.Parse(r["ExpiraMes"].ToString());
                txtExpiraAño.Value = decimal.Parse(r["ExpiraAño"].ToString());
            }
            else{
                new popup("Error al mostrar la información", popup.AlertType.error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void canelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (new logoutDialog("¿ Remover del registro ? \nEsta acción no puede deshacerse.").ShowDialog() == DialogResult.OK)
            {
                new TarjetaCredito().Remover(idtarjeta);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try {
                TarjetaCredito t = new TarjetaCredito();
                t.IDCliente = idcliente;
                t.ID = idtarjeta;
                t.TipoTarjeta = txtTipoTarjeta.Text;
                t.NumeroTarjeta = txtNumeroTarjeta.Text;
                t.ExpiraMes = (int)txtExpiraMes.Value;
                t.ExpiraAño = (int)txtExpiraAño.Value;

                if (accionformulario == "crear")
                {
                    t.Insertar();
                    t.InsertarClienteTarjeta();
                }
                else
                    t.Editar();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }catch(Exception ex) { }
        }
    }
}
