using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using sicem.datos;

namespace sicem
{
    public partial class empleadoForm : Form
    {
        string accionformulario;
        bool expand = true;
        int idd = -1, idr = -1;
        List<int> iddepartamento = new List<int>();
        List<int> idreportara = new List<int>();
        bool cargainfo = false;
        public empleadoForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public empleadoForm(int id)
        {
            InitializeComponent();
            accionformulario = "editar";
            setDataView(id);
        }
        
        private void clienteForm_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia()
        {
            guardar.ButtonText = (accionformulario == "crear" ? "Guardar" : "Actualizar");
            if (accionformulario == "crear")
            {
                loadID();
                fechaNacimiento.Value = DateTime.Now;
                fechaContratacion.Value = DateTime.Now;
            }

            foto.Region = new region().Circle(foto.Width, foto.Height);
            txtNombre.Region = new region().RoundBorder(txtNombre.Width, txtNombre.Height + 1, 7);
            txtApellido.Region = new region().RoundBorder(txtApellido.Width, txtApellido.Height + 1, 7);
            txtID.Region = new region().RoundBorder(txtID.Width, txtID.Height + 1, 7);
            txtEmail.Region = new region().RoundBorder(txtEmail.Width, txtEmail.Height + 1, 7);
            txtTel.Region = new region().RoundBorder(txtTel.Width, txtTel.Height + 1, 7);
            txtCedula.Region = new region().RoundBorder(txtCedula.Width, txtCedula.Height + 1, 7);
            txtDireccion.Region = new region().RoundBorder(txtDireccion.Width, txtDireccion.Height + 1, 7);
            txtDepartamento.Region = new region().RoundBorder(txtDepartamento.Width, txtDepartamento.Height + 1, 7);
            txtTituloLaboral.Region = new region().RoundBorder(txtTituloLaboral.Width, txtTituloLaboral.Height + 1, 7);
            txtReportarA.Region = new region().RoundBorder(txtReportarA.Width, txtReportarA.Height + 1, 7);
            txtObservaciones.Region = new region().RoundBorder(txtObservaciones.Width, txtObservaciones.Height + 1, 7);

            listaSugerencia();

            collapsiveInfoPersonal.Height = 300;
            collapsiveInfoLaboral.Height = 35;
            collapsiveInfoLaboral.Top = 510;

            //foreach (string s in new listadoItems().ciudad())
            //    txtCiudad.AddItem(s);

            new drag().setDragable(toppanel);
        }

        private void listaSugerencia()
        {
            sugerencia.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            sugerencia.ForeColor = Color.RoyalBlue;
            sugerencia.ItemHeight = 15;
            sugerenciaRA.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            sugerenciaRA.ForeColor = Color.RoyalBlue;
            sugerenciaRA.ItemHeight = 15;

            txtDepartamento.TopLevelControl.Controls.Add(sugerencia);
            Point controlLocation = txtDepartamento.TopLevelControl.PointToClient(txtDepartamento.Parent.PointToScreen(txtDepartamento.Location));
            sugerencia.Left = controlLocation.X + 5;
            sugerencia.Top = controlLocation.Y + txtDepartamento.Height;
            sugerencia.Width = txtDepartamento.Width - 10;
            sugerencia.Height = 0;
            //sugerencia.Click += sugerencia_Click;
            sugerencia.Leave += sugerencia_Leave;
            sugerencia.Visible = true;

            txtReportarA.TopLevelControl.Controls.Add(sugerenciaRA);
            controlLocation = txtReportarA.TopLevelControl.PointToClient(txtReportarA.Parent.PointToScreen(txtReportarA.Location));
            sugerenciaRA.Left = controlLocation.X + 5;
            sugerenciaRA.Top = controlLocation.Y + txtReportarA.Height;
            sugerenciaRA.Width = txtReportarA.Width - 10;
            sugerenciaRA.Height = 0;
            //sugerenciaRA.Click += sugerenciaRA_Click;
            sugerenciaRA.Leave += sugerenciaRA_Leave;
            sugerenciaRA.Visible = true;

            txtDepartamento.TextChanged += txtDepartamento_TextChanged;
            txtDepartamento.KeyDown += txtDepartamento_KeyDown;
            txtDepartamento.Leave += txtDepartamento_Leave;

            txtReportarA.TextChanged += txtReportarA_TextChanged;
            txtReportarA.KeyDown += txtReportarA_KeyDown;
            txtReportarA.Leave += txtReportarA_Leave;
        }

        private bool showCollapsiveInfoPersonal()
        {
            //expand = true;
            Transition.run(collapsiveInfoPersonal, "Height", 300, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Top", 510, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Height", 35, new TransitionType_EaseInEaseOut(500));
            expandInfoPersonal.Iconimage = sicem.Properties.Resources.hide_collapse;
            expandInfoLaboral.Iconimage = sicem.Properties.Resources.expand_collapse;
            collapsiveInfoPersonal.color = Color.RoyalBlue;
            collapsiveInfoLaboral.color = Color.White;
            return true;
        }

        private bool showCollapsiveInfoLaboral()
        {
            //expand = false;
            expandInfoPersonal.Iconimage = sicem.Properties.Resources.expand_collapse;
            expandInfoLaboral.Iconimage = sicem.Properties.Resources.hide_collapse;
            collapsiveInfoPersonal.color = Color.White;
            collapsiveInfoLaboral.color = Color.RoyalBlue;
            Transition.run(collapsiveInfoPersonal, "Height", 35, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Top", 245, new TransitionType_EaseInEaseOut(500));
            Transition.run(collapsiveInfoLaboral, "Height", 270, new TransitionType_EaseInEaseOut(500));
            return false;
        }

        private void loadID()
        {
            object value = new DBHelper().ReaderScalar("select count(*) + 1 from RH_Empleado");
            if (value != null)
                txtID.Text = value.ToString();
        }

        private void setDataView(int id)
        {
            DataTable data = new Empleado().Detalle(id);
            
            if(data != null){
                cargainfo = true;
                DataRow row = data.Rows[0];

                txtID.Text = row["ID"].ToString();
                txtNombre.Text = row["Nombres"].ToString();
                txtApellido.Text = row["Apellidos"].ToString();
                setValueDepartamento(int.Parse(row["DepartamentoID"].ToString()));
                txtTituloLaboral.Text = row["TituloLaboral"].ToString();
                fechaNacimiento.Value = (DateTime)row["FechaDeNacimiento"];
                fechaContratacion.Value = (DateTime)row["FechaDeContratacion"];

                ecSoltero.Checked = (int.Parse(row["Genero"].ToString()) == 0) ? true : false;
                generoFemenino.Checked = (int.Parse(row["Genero"].ToString()) == 0) ? true : false;

                txtCiudad.selectedIndex = new listadoItems().indexCiudad(row["Ciudad"].ToString());
                txtCedula.Text = row["Cedula"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtTel.Text = row["Telefono"].ToString();
                txtDireccion.Text = row["Domicilio"].ToString();
                txtObservaciones.Text = row["Observaciones"].ToString();
                setValueReportarA(int.Parse(row["ReportarA"].ToString()));
                    byte[] img = (byte[])row["Foto"];
                    MemoryStream ms = new MemoryStream(img);
                foto.Image = Image.FromStream(ms);
                estadoValue.Checked = (int.Parse(row["Estado"].ToString()) == 1) ? true : false;

                cargainfo = false;
            }else{
                new popup("Error al mostrar información", popup.AlertType.error);
                this.Close();
            }
        }

        private void setValueDepartamento(int id)
        {
            DataRow r = new Departamento().Detalle(id).Rows[0];
            idd = int.Parse(r["ID"].ToString());
            txtDepartamento.Text = r["Nombre"].ToString();
        }

        private void setValueReportarA(int id)
        {
            DataRow r = new Empleado().Detalle(id).Rows[0];
            idr = int.Parse(r["ID"].ToString());
            txtReportarA.Text = r["Nombres"].ToString();
        }

        private void sugerenciaDepartamento()
        {
            DataTable data = new Departamento().Buscar(txtDepartamento.Text, 0);
            idd = -1;

            if (data != null)
            {
                sugerencia.Items.Clear();
                iddepartamento.Clear();
                foreach (DataRow row in data.Rows)
                {
                    iddepartamento.Add((int)row["ID"]);
                    sugerencia.Items.Add(row["Nombre"].ToString());
                }

                Point controlLocation = txtDepartamento.TopLevelControl.PointToClient(txtDepartamento.Parent.PointToScreen(txtDepartamento.Location));
                sugerencia.Left = controlLocation.X + 5;
                sugerencia.Top = controlLocation.Y + txtDepartamento.Height;
                sugerencia.Height = (sugerencia.Items.Count < 5) ? (sugerencia.ItemHeight * sugerencia.Items.Count) : (sugerencia.ItemHeight * 5);
                sugerencia.BringToFront();
            }
        }

        private void sugerenciaReportarA()
        {
            DataTable data = new Empleado().Buscar(txtReportarA.Text, 0);
            idr = -1;

            if (data != null)
            {
                sugerenciaRA.Items.Clear();
                idreportara.Clear();
                foreach (DataRow row in data.Rows)
                {
                    idreportara.Add((int)row["ID"]);
                    sugerenciaRA.Items.Add(row["Nombres"].ToString());
                }

                Point controlLocation = txtReportarA.TopLevelControl.PointToClient(txtReportarA.Parent.PointToScreen(txtReportarA.Location));
                sugerenciaRA.Left = controlLocation.X + 5;
                sugerenciaRA.Top = controlLocation.Y + txtReportarA.Height;
                sugerenciaRA.Height = (sugerenciaRA.Items.Count < 5) ? (sugerenciaRA.ItemHeight * sugerenciaRA.Items.Count) : (sugerenciaRA.ItemHeight * 5);
                sugerenciaRA.BringToFront();
            }
        }

        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {
            if (!cargainfo)
            {
                if (txtDepartamento.Text.Length > 0)
                    sugerenciaDepartamento();
                else
                    sugerencia.Height = 0;
            }
        }

        private void sugerencia_Click(object sender, EventArgs e)
        {
            if (sugerencia.SelectedIndex >= 0)
            {
                cargainfo = true;
                txtDepartamento.Text = sugerencia.SelectedItem.ToString();
                idd = iddepartamento[sugerencia.SelectedIndex];
                cargainfo = false;
            }

            txtDepartamento.Focus();
            txtDepartamento.Select(txtDepartamento.Text.Length, 0);
            sugerencia.Height = 0;
        }

        private void txtDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((sugerencia.Visible) && (sugerencia.SelectedIndex < sugerencia.Items.Count - 1))
                            sugerencia.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (sugerencia.Visible && sugerencia.SelectedIndex >= 0)
                            sugerencia.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (sugerencia.Visible)
                        {
                            sugerencia_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void txtDepartamento_Leave(object sender, EventArgs e)
        {
            if (!sugerencia.ContainsFocus)
                sugerencia.Height = 0;
        }

        private void sugerencia_Leave(object sender, EventArgs e)
        {
            if (!txtDepartamento.ContainsFocus)
                sugerencia.Height = 0;
        }

        private void txtReportarA_TextChanged(object sender, EventArgs e)
        {
            if (!cargainfo)
            {
                if (txtReportarA.Text.Length > 0)
                    sugerenciaReportarA();
                else
                    sugerenciaRA.Height = 0;
            }
        }

        private void sugerenciaRA_Click(object sender, EventArgs e)
        {
            if (sugerenciaRA.SelectedIndex >= 0)
            {
                cargainfo = true;
                txtReportarA.Text = sugerenciaRA.SelectedItem.ToString();
                idr = idreportara[sugerenciaRA.SelectedIndex];
                cargainfo = false;
            }

            txtReportarA.Focus();
            txtReportarA.Select(txtReportarA.Text.Length, 0);
            sugerenciaRA.Height = 0;
        }

        private void txtReportarA_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    {
                        if ((sugerenciaRA.Visible) && (sugerenciaRA.SelectedIndex < sugerenciaRA.Items.Count - 1))
                            sugerenciaRA.SelectedIndex++;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (sugerenciaRA.Visible && sugerenciaRA.SelectedIndex >= 0)
                            sugerenciaRA.SelectedIndex--;
                        e.SuppressKeyPress = true;
                        break;
                    }
                case Keys.Enter:
                    {
                        if (sugerenciaRA.Visible)
                        {
                            sugerenciaRA_Click(null, null);
                            e.SuppressKeyPress = true;
                        }
                        break;
                    }
            }
        }

        private void txtReportarA_Leave(object sender, EventArgs e)
        {
            if (!sugerenciaRA.ContainsFocus)
                sugerenciaRA.Height = 0;
        }

        private void sugerenciaRA_Leave(object sender, EventArgs e)
        {
            if (!txtReportarA.ContainsFocus)
                sugerenciaRA.Height = 0;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try {
                if (idd != -1 && idr != -1)
                {
                    Empleado em = new Empleado();
                    em.Nombres = txtNombre.Text;
                    em.Apellidos = txtApellido.Text;
                    em.DepartamentoID = idd;
                    em.TituloLaboral = txtTituloLaboral.Text;
                    em.FechaNacimiento = fechaNacimiento.Value;
                    em.FechaContratacion = fechaContratacion.Value;
                    em.EstadoCivil = (ecSoltero.Checked) ? 0 : 1;
                    em.Genero = (generoFemenino.Checked) ? 0 : 1;
                    em.Domicilio = txtDireccion.Text;
                    em.Ciudad = txtCiudad.selectedValue;
                    em.Telefono = txtTel.Text;
                    em.Cedula = txtCedula.Text;
                    em.Email = txtEmail.Text;
                    em.Observaciones = txtObservaciones.Text;
                    em.ReportarA = int.Parse(txtReportarA.Text);
                    em.Foto = foto.Image;
                    em.Estado = (estadoValue.Checked) ? 1 : 0;

                    if (accionformulario == "crear")
                        em.Insertar();
                    else
                        em.Editar();
                }
                else
                    new popup("Se encontraron campos no validos", popup.AlertType.error);
            }catch(Exception ex) { }

        }

        private void expandCollapsive_Click(object sender, EventArgs e)
        {
            expand = (expand) ? showCollapsiveInfoLaboral() : showCollapsiveInfoPersonal();
        }

        private void expandInfoLaboral_Click(object sender, EventArgs e)
        {
            expand = (!expand) ? showCollapsiveInfoPersonal() : showCollapsiveInfoLaboral();
        }

        private void foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagen = new Bitmap(open.FileName);
                foto.Image = imagen;
            }

            open.Dispose();
        }

    }
}
