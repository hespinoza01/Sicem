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
using sicem.vista.Dialogos;
using Transitions;

namespace sicem
{
    public partial class home : Form
    {
        Bunifu.Framework.UI.Drag drag = new Bunifu.Framework.UI.Drag();
        string tabActiva = "";

        login login = new login();

        inicio inicio = new inicio();
        directorio directorio = new directorio();
        operaciones operaciones = new operaciones();
        productos productos = new productos();
        administrar administrar = new administrar();
        //proveedores proveedores = new proveedores();
        inventario inventario = new inventario();
        //ventas ventas = new ventas();


        public home()
        {
            InitializeComponent();
            navbar.Width = 0;
        }

        public void setInfo(string id){
            //Conexión conexion = new Conexión();
            //DataTable data = new DataTable("Usuario");
            //using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            //{
            //    try
            //    {
            //        cn.Open();

            //        SqlCommand cmd = new SqlCommand("Select ID, Nombre, Apellido from Usuario where ID = '"+id+"'",cn);

            //        SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
            //        SqlDat.Fill(data);

            //        DataRow row = data.Rows[0];
            //        idUsuario.Text = row["ID"].ToString();
            //        nameUser.Text = row["Nombre"].ToString()+" "+row["Apellido"].ToString();
            //        userPicture.Image = new user().obtenerFoto(id);
            //    }
            //    catch (Exception ex)
            //    {
            //        new popup("Error al mostrar información", popup.AlertType.error);
            //    }
            //    finally
            //    {
            //        cn.Close();
            //    }
            //}
        }

        // evt carga del form
        private void home_Load(object sender, EventArgs e)
        {
            //CircleUserPicture();
            tabActiva = "inicio";
            this.contenedor.Controls.Add(inicio);
            this.contenedor.Controls.Add(directorio);
            this.contenedor.Controls.Add(operaciones);
            this.contenedor.Controls.Add(productos);
            this.contenedor.Controls.Add(administrar);
            //this.contenedor.Controls.Add(proveedores);
            this.contenedor.Controls.Add(inventario);
            //this.contenedor.Controls.Add(ventas);

            inicio.BringToFront();
        }


        // evento boton menu
        private void menu_Click(object sender, EventArgs e)
        {
            Transition.run(navbar, "Width", 230, new TransitionType_EaseInEaseOut(1000));
        }

        private void menu_MouseHover(object sender, EventArgs e)
        {
            Transition.run(navbar, "Width", 230, new TransitionType_EaseInEaseOut(1000));
        }

        private void closemenu_Click(object sender, EventArgs e)
        {
            Transition.run(navbar, "Width", 0, new TransitionType_EaseInEaseOut(1000));
        }

        private void userPicture_Click(object sender, EventArgs e)
        {
            //if (new Register(idUsuario.Text).ShowDialog() == DialogResult.OK)
            //    setInfo(idUsuario.Text);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (new logoutDialog("¿ Cerrar sesión ?").ShowDialog() == DialogResult.OK)
            {
                login.Show();
                this.Close();
            }
        }


        // evt close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            if (new logoutDialog("¿ Salir del sistema ?").ShowDialog() == DialogResult.OK)
                Application.Exit();
        }


        // evt min button
        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // eventos para el arrastre del form
        private void toppanel_MouseDown(object sender, MouseEventArgs e){
            drag.Grab(this);
        }

        private void toppanel_MouseUp(object sender, MouseEventArgs e){
            drag.Release();
        }

        private void toppanel_MouseMove(object sender, MouseEventArgs e){
            drag.MoveObject();
        }

        /* * * * Métodos * * * */
        public void CircleUserPicture()
        {
            userPicture.Region = new region().Circle(userPicture.Width, userPicture.Height);
        }

        private void clearColorTabs()
        {
            //inicioTab.BackColor = Color.FromArgb(47, 50, 58);
            //directorioTab.BackColor = Color.FromArgb(47, 50, 58);
            //OperacionesTab.BackColor = Color.FromArgb(47, 50, 58);
            //comprasTab.BackColor = Color.FromArgb(47, 50, 58);
            //productosTab.BackColor = Color.FromArgb(47, 50, 58);
            //proveedorTab.BackColor = Color.FromArgb(47, 50, 58);
            //administrarTab.BackColor = Color.FromArgb(47, 50, 58);
            inicio.Visible = false;
            directorio.Visible = false;
            operaciones.Visible = false;
            productos.Visible = false;
            administrar.Visible = false;
            inventario.Visible = false;
        }

        private void inicioTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "inicio")
            {
                clearColorTabs();
                tabActiva = "inicio";
                inicio.BringToFront();
                viewTransition.ShowSync(inicio);
                //inicio.cargar();
            }
        }

        private void directorioTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "directorio")
            {
                clearColorTabs();
                tabActiva = "directorio";
                directorio.BringToFront();
                viewTransition.ShowSync(directorio);
                //proveedores.Cargar();
            }
        }

        private void OperacionesTab_Click(object sender, EventArgs e)
        {
            if(tabActiva != "operaciones")
            {
                clearColorTabs();
                tabActiva = "operaciones";
                operaciones.BringToFront();
                viewTransition.ShowSync(operaciones);
                //ventas.cargar();
            }
        }

        private void inventarioTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "inventario")
            {
                clearColorTabs();
                tabActiva = "inventario";
                inventario.BringToFront();
                viewTransition.ShowSync(inventario);
                //compras.Cargar();
            }
        }

        private void productosTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "productos")
            {
                clearColorTabs();
                tabActiva = "productos";
                productos.BringToFront();
                viewTransition.ShowSync(productos);
                //productos.Cargar();
            }
        }

        private void proveedorTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "proveedor")
            {
                clearColorTabs();
                tabActiva = "proveedor";
                //proveedores.BringToFront();
                //proveedores.Cargar();
            }
        }

        private void administrarTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "administrar")
            {
                clearColorTabs();
                tabActiva = "administrar";
                administrar.BringToFront();
                viewTransition.ShowSync(administrar);
            }
        }

        
    }
}
