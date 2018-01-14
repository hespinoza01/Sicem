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
        private string C_id;
        private string C_nomb;
        private string C_domi;
        private string C_tel;
        private string C_ema;


        public string C_Id
        {
            get { return (C_id != null) ? C_id : "N/A"; }
            set { C_id = (value != null) ? value : "N/A"; }
        }

        public string C_Nombre
        {
            get { return (C_nomb != null) ? C_nomb : "N/A"; }
            set { C_nomb = (value != null) ? value : "N/A"; }
        }

        public string C_NombreContacto
        {
            get { return (C_NombreContacto != null) ? C_NombreContacto : "N/A"; }
            set { C_NombreContacto = (value != null) ? value : "N/A"; }
        }

        public string C_TituloContacto
        {
            get { return (C_TituloContacto != null) ? C_TituloContacto : "N/A"; }
            set { C_TituloContacto = (value != null) ? value : "N/A"; }
        }

        public string C_Domicilio
        {
            get { return (C_domi != null) ? C_domi : "N/A"; }
            set { C_domi = (value != null) ? value : "N/A"; }
        }

        public string C_Ciudad
        {
            get { return (C_Ciudad != null) ? C_Ciudad : "N/A"; }
            set { C_Ciudad = (value != null) ? value : "N/A"; }
        }

        public string C_Telefono
        {
            get { return (C_tel != null) ? C_tel : "N/A"; }
            set { C_tel = (value != null) ? value : "N/A"; }
        }

        public string C_Email
        {
            get { return (C_ema != null) ? C_ema : "N/A"; }
            set { C_ema = (value != null) ? value : "N/A"; }
        }

        public int Estado
        {
            get;
            set;
        }

        public enum Accion
        {
            insertar, editar
        }

        public Cliente()
        {
        }

        public Cliente(string id, string nombre, string domicilio, string telefono, string email, Accion type)
        {
            C_id = id;
            C_nomb = nombre;
            C_domi = domicilio;
            C_tel = telefono;
            C_ema = email;

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
                db.Param("@ID", SqlDbType.VarChar, 25, C_Id),
                db.Param("@NombreCliente", SqlDbType.VarChar, 75, C_Nombre),
                db.Param("@NombreContacto", SqlDbType.VarChar, 50, C_NombreContacto),
                db.Param("@TituloContacto", SqlDbType.VarChar, 35, C_TituloContacto),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, C_Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, C_Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, C_Telefono),
                db.Param("@Email", SqlDbType.VarChar, 50, C_Email),
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
                db.Param("@ID", SqlDbType.VarChar, 25, C_Id),
                db.Param("@NombreCliente", SqlDbType.VarChar, 75, C_Nombre),
                db.Param("@NombreContacto", SqlDbType.VarChar, 50, C_NombreContacto),
                db.Param("@TituloContacto", SqlDbType.VarChar, 35, C_TituloContacto),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, C_Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, C_Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, C_Telefono),
                db.Param("@Email", SqlDbType.VarChar, 50, C_Email),
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
