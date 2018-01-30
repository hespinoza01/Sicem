using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class TarjetaCredito
    {
        DBHelper db = new DBHelper();
        string tipotarjeta, numerotarjeta;
        public TarjetaCredito(){}

        public int ID
        {
            get;
            set;
        }

        public string TipoTarjeta
        {
            get { return (tipotarjeta != null) ? tipotarjeta : "N/A"; }
            set { tipotarjeta = (value != null) ? value : "N/A"; }
        }

        public string NumeroTarjeta
        {
            get { return (numerotarjeta != null) ? numerotarjeta : "N/A"; }
            set { numerotarjeta = (value != null) ? value : "N/A"; }
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

        public string IDCliente
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

        public void InsertarClienteTarjeta()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ClienteID", SqlDbType.VarChar, 25, IDCliente),
                db.Param("@TarjetaCreditoID", SqlDbType.Int, ID)
            };

            db.ExecuteQuery("Insertar_ClienteTarjetaCredito", Parametros);
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
                db.Param("@ClienteID", SqlDbType.VarChar, 25, clienteid)
            };

            return db.Reader("Mostrar_ClienteTarjetaCredito", Parametros);
        }

        public DataTable Listar(string clienteid)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ClienteID", SqlDbType.VarChar, 25, clienteid)
            };

            return db.Reader("Listar_ClienteTarjeta", Parametros);
        }

        public DataTable Detalle(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Detalle_TarjetaCredito", Parametros);
        }

        public void Remover(int id)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, id)
            };

            if (db.ExecuteQuery("Remover_Tarjeta", Parametros))
                new popup("Tarjeta removida correctamente", popup.AlertType.check);
            else
                new popup("Tarjeta no removida", popup.AlertType.error);
        }
    }
}
