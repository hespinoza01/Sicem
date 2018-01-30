using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Departamento
    {
        DBHelper db = new DBHelper();
        string nombre, nombregrupo;
        public Departamento(){}

        public int ID
        {
            get;
            set;
        }

        public string Nombre
        {
            get { return (nombre != null) ? nombre : "N/A"; }
            set { nombre = (value != null) ? value : "N/A"; }
        }

        public string NombreGrupo
        {
            get { return (nombregrupo != null) ? nombregrupo : "N/A"; }
            set { nombregrupo = (value != null) ? value : "N/A"; }
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@Nombre", SqlDbType.VarChar, 35, Nombre),
                db.Param("@NombreGrupo", SqlDbType.VarChar, 35, NombreGrupo)
            };

            if (db.ExecuteQuery("Insertar_Departamento", Parametros))
                new popup("Departamento laboral registrado correctamente", popup.AlertType.check);
            else
                new popup("Departamento laboral no registrado", popup.AlertType.error);
        }

        public void Editar(){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, ID),
                db.Param("@Nombre", SqlDbType.VarChar, 35, Nombre),
                db.Param("@NombreGrupo", SqlDbType.VarChar, 35, NombreGrupo)
            };

            if (db.ExecuteQuery("Actualizar_Departamento", Parametros))
                new popup("Departamento laboral actualizado correctamente", popup.AlertType.check);
            else
                new popup("Departamento laboral no actualizado", popup.AlertType.error);
        }

        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Departamento", Parametros);
        }

        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Departamentos");
        }

        public DataTable Detalle(int idvalue)
        {
            SqlParameter[] Param = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Detalle_Departamento", Param);
        }
    }
}
