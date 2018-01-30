using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class DetalleVenta
    {
        DBHelper db = new DBHelper();

        public DetalleVenta(){}

        public string VentaID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }


        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@VentaID", SqlDbType.VarChar, 15, VentaID),
                db.Param("@ProductoID", SqlDbType.Int, ProductoID),
                db.Param("@Cantidad", SqlDbType.Int, Cantidad),
                db.Param("@PrecioUnitario", SqlDbType.Decimal, PrecioUnitario),
                db.Param("@Descuento", SqlDbType.Decimal, Descuento),
                db.Param("@Impuesto", SqlDbType.Decimal, Impuesto),
                db.Param("@Total", SqlDbType.Decimal, Total)
            };

            db.ExecuteQuery("Insertar_Detalle_Venta", Parametros);
        }

        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@VentaID", SqlDbType.VarChar, 15, VentaID),
                db.Param("@ProductoID", SqlDbType.Int, ProductoID),
                db.Param("@Cantidad", SqlDbType.Int, Cantidad),
                db.Param("@PrecioUnitario", SqlDbType.Decimal, PrecioUnitario),
                db.Param("@Descuento", SqlDbType.Decimal, Descuento),
                db.Param("@Impuesto", SqlDbType.Decimal, Impuesto),
                db.Param("@Total", SqlDbType.Decimal, Total)
            };

            db.ExecuteQuery("Actualizar_Detalle_Venta", Parametros);
        }

        public DataTable Mostrar(string idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@VentaID", SqlDbType.VarChar, 15, idvalue)
            };

            return db.Reader("Mostrar_Detalle_Venta", Parametros);
        }

    }
}
