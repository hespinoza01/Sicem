using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class venta
    {
        DBHelper db = new DBHelper();
        

        public string Id{ get; set; }
        public int ClientId{ get; set; }
        public DateTime FechaVenta{ get; set; }
        public int TipoPago{ get; set; }
        public int TipoVenta{ get; set; }
        public decimal SubTotal { get;set; }
        public decimal Tax { get; set; }
        public decimal MontoTotal{ get; set; }


        // Insertar
        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 15, Id),
                db.Param("@ClienteID", SqlDbType.VarChar, 25, ClientId),
                db.Param("@FechaVenta", SqlDbType.Date, FechaVenta),
                db.Param("@TipoPago", SqlDbType.Int, TipoPago),
                db.Param("@TipoVenta", SqlDbType.Int, TipoVenta),
                db.Param("@SubTotal", SqlDbType.Decimal, SubTotal),
                db.Param("@Impuesto", SqlDbType.Decimal, Tax),
                db.Param("@Total", SqlDbType.Decimal, MontoTotal)
            };

            if (db.ExecuteQuery("Insertar_Venta", Parametros))
                new popup("Venta registrada correctamente", popup.AlertType.check);
            else
                new popup("Venta no registrada", popup.AlertType.error);
        }

        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 15, Id),
                db.Param("@ClienteID", SqlDbType.VarChar, 25, ClientId),
                db.Param("@FechaVenta", SqlDbType.Date, FechaVenta),
                db.Param("@TipoPago", SqlDbType.Int, TipoPago),
                db.Param("@TipoVenta", SqlDbType.Int, TipoVenta),
                db.Param("@SubTotal", SqlDbType.Decimal, SubTotal),
                db.Param("@Impuesto", SqlDbType.Decimal, Tax),
                db.Param("@Total", SqlDbType.Decimal, MontoTotal)
            };

            if (db.ExecuteQuery("Actualizar_Venta", Parametros))
                new popup("Venta actualizada correctamente", popup.AlertType.check);
            else
                new popup("Venta no actualizada", popup.AlertType.error); 
        }


        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Ventas");
        }

        public DataTable Detalle(string idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 15, idvalue)
            };

            return db.Reader("VentaDetallada", Parametros);
        }

        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Ventas", Parametros);
        }
        
    }
}
