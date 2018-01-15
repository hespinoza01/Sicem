using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Cliente
    {
        DBHelper db = new DBHelper();

        public string ID
        {
            get { return (ID != null) ? ID : "N/A"; }
            set { ID = (value != null) ? value : "N/A"; }
        }

        public string Nombre
        {
            get { return (Nombre != null) ? Nombre : "N/A"; }
            set { Nombre = (value != null) ? value : "N/A"; }
        }

        public string NombreContacto
        {
            get { return (NombreContacto != null) ? NombreContacto : "N/A"; }
            set { NombreContacto = (value != null) ? value : "N/A"; }
        }

        public string TituloContacto
        {
            get { return (TituloContacto != null) ? TituloContacto : "N/A"; }
            set { TituloContacto = (value != null) ? value : "N/A"; }
        }

        public string Domicilio
        {
            get { return (Domicilio != null) ? Domicilio : "N/A"; }
            set { Domicilio = (value != null) ? value : "N/A"; }
        }

        public string Ciudad
        {
            get { return (Ciudad != null) ? Ciudad : "N/A"; }
            set { Ciudad = (value != null) ? value : "N/A"; }
        }

        public string Telefono
        {
            get { return (Telefono != null) ? Telefono : "N/A"; }
            set { Telefono = (value != null) ? value : "N/A"; }
        }

        public string Email
        {
            get { return (Email != null) ? Email : "N/A"; }
            set { Email = (value != null) ? value : "N/A"; }
        }

        public int Estado
        {
            get;
            set;
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 25, ID),
                db.Param("@NombreCliente", SqlDbType.VarChar, 75, Nombre),
                db.Param("@NombreContacto", SqlDbType.VarChar, 50, NombreContacto),
                db.Param("@TituloContacto", SqlDbType.VarChar, 35, TituloContacto),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, Telefono),
                db.Param("@Email", SqlDbType.VarChar, 50, Email),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            if (db.ExecuteQuery("Insertar_Cliente", Parametros))
                new popup("Cliente registrado correctamente", popup.AlertType.check);
            else
                new popup("Cliente no registrado", popup.AlertType.error);
        }


        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 25, ID),
                db.Param("@NombreCliente", SqlDbType.VarChar, 75, Nombre),
                db.Param("@NombreContacto", SqlDbType.VarChar, 50, NombreContacto),
                db.Param("@TituloContacto", SqlDbType.VarChar, 35, TituloContacto),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, Telefono),
                db.Param("@Email", SqlDbType.VarChar, 50, Email),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            if (db.ExecuteQuery("Actualizar_Cliente", Parametros))
                new popup("Cliente actualizado correctamente", popup.AlertType.check);
            else
                new popup("Cliente no actualizado", popup.AlertType.error);
        }


        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Cliente", Parametros);
        }


        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Clientes");
        }

        public DataTable Detalle(string idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.VarChar, 25, idvalue)
            };

            return db.Reader("Detalle_Cliente", Parametros);
        }

    }
}
