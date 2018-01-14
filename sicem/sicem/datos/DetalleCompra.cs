using System;
using System.Data;
using System.Data.SqlClient;

namespace sicem
{
    public class DetalleCompra
    {
        DBHelper db = new DBHelper();

        public DetalleCompra(){}

        public int CompraID { get; set; }
        public int ProdID { get; set; }
        public int Cant { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@CompraID", SqlDbType.VarChar, 15, CompraID),
                db.Param("@ProductoID", SqlDbType.Int, ProdID),
                db.Param("@Cantidad", SqlDbType.Int, Cant),
                db.Param("@CostoUnitario", SqlDbType.Decimal, UnitPrice),
                db.Param("@Total", SqlDbType.Decimal, Total)
            };

            db.ExecuteQuery("Insertar_Detalle_Compra", Parametros);
        }
        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@CompraID", SqlDbType.VarChar, 15, CompraID),
                db.Param("@ProductoID", SqlDbType.Int, ProdID),
                db.Param("@Cantidad", SqlDbType.Int, Cant),
                db.Param("@CostoUnitario", SqlDbType.Decimal, UnitPrice),
                db.Param("@Total", SqlDbType.Decimal, Total)
            };

            db.ExecuteQuery("Actualizar_Detalle_Compra", Parametros);
        }

        public DataTable Mostrar(string idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@CompraID", SqlDbType.VarChar, 15, idvalue)
            };

            return db.Reader("Mostrar_Detalle_Compra", Parametros);
        }

    }
}