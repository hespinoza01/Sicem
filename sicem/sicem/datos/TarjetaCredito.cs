using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem.datos
{
    class TarjetaCredito
    {
        DBHelper db = new DBHelper();

        public TarjetaCredito(){}

        public int ID
        {
            get;
            set;
        }

        public string TipoTarjeta
        {
            get { return (TipoTarjeta != null) ? TipoTarjeta : "N/A"; }
            set { TipoTarjeta = (value != null) ? value : "N/A"; }
        }

        public string NumeroTarjeta
        {
            get { return (NumeroTarjeta != null) ? NumeroTarjeta : "N/A"; }
            set { NumeroTarjeta = (value != null) ? value : "N/A"; }
        }

        public int ExpiraMes
        {
            get;
            set;
        }

        public int ExpiraAño
        {
            get;
            set;
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@TipoTarjeta", SqlDbType.VarChar, 25, TipoTarjeta),
                db.Param("@NumeroTarjeta", SqlDbType.VarChar, 25, NumeroTarjeta),
                db.Param("@ExpiraMes", SqlDbType.Int, ExpiraMes),
                db.Param("@ExpiraAño", SqlDbType.Int, ExpiraAño)
            };

            if (db.ExecuteQuery("Insertar_TarjetaCredito", Parametros))
                new popup("Tarjeta registrada correctamente", popup.AlertType.check);
            else
                new popup("Tarjeta no registrada", popup.AlertType.error);
        }

        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, ID),
                db.Param("@TipoTarjeta", SqlDbType.VarChar, 25, TipoTarjeta),
                db.Param("@NumeroTarjeta", SqlDbType.VarChar, 25, NumeroTarjeta),
                db.Param("@ExpiraMes", SqlDbType.Int, ExpiraMes),
                db.Param("@ExpiraAño", SqlDbType.Int, ExpiraAño)
            };

            if (db.ExecuteQuery("Actualizar_TarjetaCredito", Parametros))
                new popup("Tarjeta actualizada correctamente", popup.AlertType.check);
            else
                new popup("Tarjeta no actualizada", popup.AlertType.error);
        }

        public DataTable Mostrar(string clienteid)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 25, clienteid)
            };

            return db.Reader("Mostrar_ClienteTarjetaCredito", Parametros);
        }

        public DataTable Detalle(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Detalle_TarjetaCredito", Parametros);
        }
    }
}
