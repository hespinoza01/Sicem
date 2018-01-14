using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Proveedor
    {
        DBHelper db = new DBHelper();


        public int P_Id{
            get;
            set; 
        }

        public string P_Nombre{
            get { return (P_Nombre != null) ? P_Nombre : "N/A"; }
            set { P_Nombre = (value != null) ? value : "N/A"; }
        }

        public string P_NombreContacto
        {
            get { return (P_NombreContacto != null) ? P_NombreContacto : "N/A"; }
            set { P_NombreContacto = (value != null) ? value : "N/A"; }
        }

        public string P_TituloContacto
        {
            get { return (P_TituloContacto != null) ? P_TituloContacto : "N/A"; }
            set { P_TituloContacto = (value != null) ? value : "N/A"; }
        }

        public string P_Domicilio{
            get { return (P_Domicilio != null) ? P_Domicilio : "N/A"; }
            set { P_Domicilio = (value != null) ? value : "N/A"; }
        }

        public string P_Ciudad
        {
            get { return (P_Ciudad != null) ? P_Ciudad : "N/A"; }
            set { P_Ciudad = (value != null) ? value : "N/A"; }
        }

        public string P_Telefono{
            get { return (P_Telefono != null) ? P_Telefono : "N/A"; }
            set { P_Telefono = (value != null) ? value : "N/A"; }
        }

        public string P_Email{
            get { return (P_Email != null) ? P_Email : "N/A"; }
            set { P_Email = (value != null) ? value : "N/A"; }
        }

        public int P_Estado
        {
            get;
            set;
        }

        public enum Accion
        {
            insertar, editar
        }

        public Proveedor()
        {
        }

        public Proveedor(int id, string nombre, string domicilio, string telefono, string email, Accion type)
        {
            P_Id = id;
            P_Nombre = nombre;
            P_Domicilio = domicilio;
            P_Telefono = telefono;
            P_Email = email;

            switch (type)
            {
                case Accion.insertar:
                    Insertar();
                    break;

                case Accion.editar:
                    Editar();
                    break;
            }
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@Nombre", SqlDbType.VarChar, 75, P_Nombre),
                db.Param("@NombreContacto", SqlDbType.VarChar, 50, P_NombreContacto),
                db.Param("@TituloContacto", SqlDbType.VarChar, 35, P_TituloContacto),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, P_Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, P_Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, P_Telefono),
                db.Param("@Email", SqlDbType.VarChar, 50, P_Email),
                db.Param("@Estado", SqlDbType.Int, P_Estado)
            };

            if (db.ExecuteQuery("Insertar_Proveedor", Parametros))
                new popup("Proveedor registrado correctamente", popup.AlertType.check);
            else
                new popup("Proveedor no registrado", popup.AlertType.error);
        }


        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, P_Id),
                db.Param("@Nombre", SqlDbType.VarChar, 75, P_Nombre),
                db.Param("@NombreContacto", SqlDbType.VarChar, 50, P_NombreContacto),
                db.Param("@TituloContacto", SqlDbType.VarChar, 35, P_TituloContacto),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, P_Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, P_Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, P_Telefono),
                db.Param("@Email", SqlDbType.VarChar, 50, P_Email),
                db.Param("@Estado", SqlDbType.Int, P_Estado)
            };

            if (db.ExecuteQuery("Actualizar_Proveedores", Parametros))
                new popup("Proveedor actualizado correctamente", popup.AlertType.check);
            else
                new popup("Proveedor no actualizado", popup.AlertType.error);
        }


        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Proveedor", Parametros);
        }


        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Proveedores");
        }

        public DataTable Detalle(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Detalle_Proveedor", Parametros);
        }

    }
}
