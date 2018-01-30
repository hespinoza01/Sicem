using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sicem
{
    public partial class Reportes : UserControl
    {
        DBHelper db = new DBHelper();
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia() {
            DateTime d = DateTime.Now;
            mes.selectedIndex = int.Parse(d.Month.ToString())-1;
            año.Maximum = int.Parse(d.Year.ToString());
            año.Value = int.Parse(d.Year.ToString());
        }

        public void Cargar() {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                db.Param("@mes", SqlDbType.Int, mes.selectedIndex+1),
                db.Param("@año", SqlDbType.Int, (int)año.Value)
                };

                switch (tipo.selectedIndex)
                {
                    case 0:
                        report.DataSource = db.Reader("Reporte_ventas", param);
                        sumaventa();
                        break;

                    case 1:
                        report.DataSource = db.Reader("Reporte_Compras", param);
                        sumacompra();
                        break;

                    case 2:
                        report.DataSource = db.Reader("Reporte_estado", param);
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void sumacompra()
        {
            if (report.DataSource != null)
            {
                float suma = 0;
                foreach (DataGridViewRow r in report.Rows)
                {
                    suma += float.Parse(r.Cells[1].Value.ToString());
                }

                report.Rows.Add("", "");
                report.Rows.Add("Total egresos", suma);
            }
        }

        private void sumaventa()
        {
            if (report.DataSource != null)
            {
                float suma = 0;
                foreach (DataGridViewRow r in report.Rows)
                {
                    suma += float.Parse(r.Cells[3].Value.ToString());
                }

                report.Rows.Add("", "");
                report.Rows.Add("Total recaudación", "", "", suma);
            }
        }

        private void generar_Click(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
