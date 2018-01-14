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
using System.Threading;

namespace sicem
{
    public partial class home : Form
    {
        string tabActiva = "";

        inicio inicio = new inicio();
        directorio directorio = new directorio();
        operaciones operaciones = new operaciones();
        productos productos = new productos();
        administrar administrar = new administrar();
        inventario inventario = new inventario();


        public home()
        {
            InitializeComponent();
        }

        // evt carga del form
        private void home_Load(object sender, EventArgs e)
        {
            inicia();
        }

        private void inicia() {
            CirclePicture();
            inicioTab.Textcolor = Color.White;

            topNavbar.Height = 0;
            navbar.Width = 40;

            tabActiva = "inicio";
            this.contenedor.Controls.Add(inicio);
            this.contenedor.Controls.Add(directorio);
            this.contenedor.Controls.Add(operaciones);
            this.contenedor.Controls.Add(productos);
            this.contenedor.Controls.Add(administrar);
            this.contenedor.Controls.Add(inventario);

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

            new drag().setDragable(toppanel);
        }

        public void CirclePicture()
        {
            userPicture.Region = new region().Circle(userPicture.Width, userPicture.Height);
            userPictureNavbar.Region = new region().Circle(userPictureNavbar.Width, userPictureNavbar.Height);
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

        public void setInfo(string id){
            DataTable data = new usuario().Detalle(id);

            if(data != null){
                DataRow row = data.Rows[0];

                idUsuario.Text = row["ID"].ToString();
                nameUser.Text = row["Nombre"].ToString()+" "+row["Apellido"].ToString();
                    byte[] img = (byte[])row["FotoPerfil"];
                    MemoryStream ms = new MemoryStream(img);
                userPicture.Image = Image.FromStream(ms);
                userPictureNavbar.Image = Image.FromStream(ms);
                ms.Dispose();
            }
            else
                new popup("Error al mostrar información", popup.AlertType.error);
        }

        private void hoverstatus(object sender, EventArgs e)
        {
            Label b = sender as Label;
            b.BackColor = Color.FromArgb(85, 125, 245);
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
            if (new usuarioForm(idUsuario.Text).ShowDialog() == DialogResult.OK)
                setInfo(idUsuario.Text);
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

        private void inicioTab_Click(object sender, EventArgs e)
        {
            inicio.cargar();
            if (tabActiva != "inicio")
            {
                clearColorTabs();
                inicioTab.Textcolor = Color.White;
                tabActiva = "inicio";
                inicio.BringToFront();
                viewTransition.ShowSync(inicio);
            }
        }

        private void directorioTab_Click(object sender, EventArgs e)
        {
            directorio.Cargar(false);
            if (tabActiva != "directorio")
            {
                clearColorTabs();
                directorioTab.Textcolor = Color.White;
                tabActiva = "directorio";
                directorio.BringToFront();
                viewTransition.ShowSync(directorio);
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
                //operaciones.Cargar();
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
            productos.Cargar(false);
            if (tabActiva != "productos")
            {
                clearColorTabs();
                productosTab.Textcolor = Color.White;
                tabActiva = "productos";
                productos.BringToFront();
                viewTransition.ShowSync(productos);
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
            administrar.Cargar(false);
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
