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
        string nombre, nombrecontacto, titulocontacto, domicilio, ciudad, telefono, email;

        public int ID{
            get;
            set; 
        }

        public string Nombre{
            get { return (nombre != null) ? nombre : "N/A"; }
            set { nombre = (value != null) ? value : "N/A"; }
        }

        public string NombreContacto
        {
            get { return (nombrecontacto != null) ? nombrecontacto : "N/A"; }
            set { nombrecontacto = (value != null) ? value : "N/A"; }
        }

        public string TituloContacto
        {
            get { return (titulocontacto != null) ? titulocontacto : "N/A"; }
            set { titulocontacto = (value != null) ? value : "N/A"; }
        }

        public string Domicilio{
            get { return (domicilio != null) ? domicilio : "N/A"; }
            set { domicilio = (value != null) ? value : "N/A"; }
        }

        public string Ciudad
        {
            get { return (ciudad != null) ? ciudad : "N/A"; }
            set { ciudad = (value != null) ? value : "N/A"; }
        }

        public string Telefono{
            get { return (telefono != null) ? telefono : "N/A"; }
            set { telefono = (value != null) ? value : "N/A"; }
        }

        public string Email{
            get { return (email != null) ? email : "N/A"; }
            set { email = (value != null) ? value : "N/A"; }
        }

        public int Estado
        {
            get;
            set;
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@Nombre", SqlDbType.VarChar, 75, Nombre),
                db.Param("@NombreContacto", SqlDbType.VarChar, 50, NombreContacto),
                db.Param("@TituloContacto", SqlDbType.VarChar, 35, TituloContacto),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, Telefono),
                db.Param("@Email", SqlDbType.VarChar, 50, Email),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            if (db.ExecuteQuery("Insertar_Proveedor", Parametros))
                new popup("Proveedor registrado correctamente", popup.AlertType.check);
            else
                new popup("Proveedor no registrado", popup.AlertType.error);
        }


        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, ID),
                db.Param("@Nombre", SqlDbType.VarChar, 75, Nombre),
                db.Param("@NombreContacto", SqlDbType.VarChar, 50, NombreContacto),
                db.Param("@TituloContacto", SqlDbType.VarChar, 35, TituloContacto),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, Telefono),
                db.Param("@Email", SqlDbType.VarChar, 50, Email),
                db.Param("@Estado", SqlDbType.Int, Estado)
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
