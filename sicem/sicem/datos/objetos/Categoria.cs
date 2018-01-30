using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Categoria
    {
        DBHelper db = new DBHelper();
        string nombre, descripcion;

        public int ID {
            get;
            set;
        }

        public string Nombre {
            get { return (nombre != null) ? nombre : "N/A"; }
            set { nombre = (value != null) ? value : "N/A"; }
        }

        public string Descripcion {
            get { return (descripcion != null) ? descripcion : "N/A"; }
            set { descripcion = (value != null) ? value : "N/A"; }
        }

        public int Estado {
            get;
            set;
        }

        public DateTime FechaCreacion
        {
            get;
            set;
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@Nombre", SqlDbType.VarChar, 50, Nombre),
                db.Param("@Descripcion", SqlDbType.VarChar, 250, Descripcion),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            if (db.ExecuteQuery("Insertar_Categoria", Parametros))
                new popup("Categoría resgistrada correctamente", popup.AlertType.check);
            else
                new popup("Categoría no registrada", popup.AlertType.error);
        }

        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, ID),
                db.Param("@Nombre", SqlDbType.VarChar, 50, Nombre),
                db.Param("@Descripcion", SqlDbType.VarChar, 250, Descripcion),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            if (db.ExecuteQuery("Actualizar_Categoria", Parametros))
                new popup("Categoría actualizada correctamente", popup.AlertType.check);
            else
                new popup("Categoría no actualizada", popup.AlertType.error);
        }

        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Categorias");
        }

        public DataTable Buscar(string valor){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor)
            };

            return db.Reader("Busqueda_Categoria", Parametros);
        }

        public DataTable Detalle(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Detalle_Categoria", Parametros);
        }
    }
}
