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
using System.Threading;

namespace sicem
{
    public partial class home : Form
    {
        Bunifu.Framework.UI.Drag drag = new Bunifu.Framework.UI.Drag();
        string tabActiva = "";

        //login login = new login();

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
            inicia();
        }

        private void inicia() {
            CirclePicture();

            topNavbar.Height = 0;
            navbar.Width = 40;

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

            menu.Click += menu_open;
            menu.MouseHover += menu_open;
            closemenu.Click += menu_close;

            moreMenu.TopLevelControl.Controls.Add(contentMenuMore);
            Point controlLocation = moreMenu.TopLevelControl.PointToClient(moreMenu.Parent.PointToScreen(moreMenu.Location));
            contentMenuMore.Left = (controlLocation.X + moreMenu.Width) - contentMenuMore.Width;
            contentMenuMore.Top = controlLocation.Y + moreMenu.Height;
            contentMenuMore.Height = 0;
            contentMenuMore.BringToFront();
            moreMenu.Click += toogle_MenuMore;

            salir.Click += closeButton_Click;
            salir.MouseHover += hoverstatus;
            salir.MouseLeave += hoverleavestatus;

            cerrarsesion.Click += logout_Click;
            cerrarsesion.MouseHover += hoverstatus;
            cerrarsesion.MouseLeave += hoverleavestatus;

            configuraperfil.Click += configurarPerfil;
            configuraperfil.MouseHover += hoverstatus;
            configuraperfil.MouseLeave += hoverleavestatus;
        }

        public void CirclePicture()
        {
            userPicture.Region = new region().Circle(userPicture.Width, userPicture.Height);
            userPictureNavbar.Region = new region().Circle(userPictureNavbar.Width, userPictureNavbar.Height);
            logout.Region = new region().Circle(logout.Width, logout.Height);
        }

        private void clearColorTabs()
        {
            //inicioTab.BackColor = Color.FromArgb(47, 50, 58);
            inicio.Visible = false;
            directorio.Visible = false;
            operaciones.Visible = false;
            productos.Visible = false;
            administrar.Visible = false;
            inventario.Visible = false;

            inicioTab.Textcolor = Color.RoyalBlue;
            directorioTab.Textcolor = Color.RoyalBlue;
            OperacionesTab.Textcolor = Color.RoyalBlue;
            productosTab.Textcolor = Color.RoyalBlue;
            inventarioTab.Textcolor = Color.RoyalBlue;
            proveedorTab.Textcolor = Color.RoyalBlue;
            administrarTab.Textcolor = Color.RoyalBlue;
        }

        private void hoverstatus(object sender, EventArgs e)
        {
            Label b = sender as Label;
            b.BackColor = Color.RoyalBlue;
            b.ForeColor = Color.White;
        }

        private void hoverleavestatus(object sender, EventArgs e)
        {
            Label b = sender as Label;
            b.BackColor = Color.FromArgb(230, 230, 230);
            b.ForeColor = Color.RoyalBlue;
        }

        // evento boton menu
        private void menu_open(object sender, EventArgs e)
        {
            Transition.run(navbar, "Width", 230, new TransitionType_EaseInEaseOut(1000));
            Transition.run(topNavbar, "Height", 155, new TransitionType_EaseInEaseOut(1000));
            userPicture.Visible = false;
        }

        private void menu_close(object sender, EventArgs e)
        {
            Transition.run(navbar, "Width", 40, new TransitionType_EaseInEaseOut(1000));
            Transition.run(topNavbar, "Height", 0, new TransitionType_EaseInEaseOut(1000));
            userPicture.Visible = true;
        }

        private void toogle_MenuMore(object sender, EventArgs e)
        {
            int a = (contentMenuMore.Height == 0) ? 140 : 0;
            Transition.run(contentMenuMore, "Height", a, new TransitionType_EaseInEaseOut(750));
        }

        private void configurarPerfil(object sender, EventArgs e)
        {
            //if (new Register(idUsuario.Text).ShowDialog() == DialogResult.OK)
            //    setInfo(idUsuario.Text);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (new logoutDialog("¿ Cerrar sesión ?").ShowDialog() == DialogResult.OK)
            {
                new login().Show();
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

        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            drag.MoveObject();
        }

        private void inicioTab_Click(object sender, EventArgs e)
        {
            if (tabActiva != "inicio")
            {
                clearColorTabs();
                inicioTab.Textcolor = Color.White;
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
                directorioTab.Textcolor = Color.White;
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
                OperacionesTab.Textcolor = Color.White;
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
                inventarioTab.Textcolor = Color.White;
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
                productosTab.Textcolor = Color.White;
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
                proveedorTab.Textcolor = Color.White;
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
                administrarTab.Textcolor = Color.White;
                tabActiva = "administrar";
                administrar.BringToFront();
                viewTransition.ShowSync(administrar);
            }
        }
    }
}
