using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class compra
    {
        DBHelper db = new DBHelper();

        public compra(){}

        public string ID {
                get;
                set;
            }

        public int ProveedorID {
                get;
                set;
            }

	    public DateTime FechaCompra {
                get;
                set;
            }

        public int TipoPago {
                get;
                set;
            }

	    public decimal Monto {
                get;
                set;
            }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 15, ID),
                db.Param("@ProveedorID", SqlDbType.Int, ProveedorID),
                db.Param("@FechaCompra", SqlDbType.Date, FechaCompra),
                db.Param("@TipoPago", SqlDbType.Int, TipoPago),
                db.Param("@Monto", SqlDbType.Decimal, Monto)
            };

            if (db.ExecuteQuery("Insertar_Compra", Parametros))
                new popup("Compra guardada correctamente", popup.AlertType.check);
            else
                new popup("Compra no guardada", popup.AlertType.error); 
        }

        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 15, ID),
                db.Param("@ProveedorID", SqlDbType.Int, ProveedorID),
                db.Param("@FechaCompra", SqlDbType.Date, FechaCompra),
                db.Param("@TipoPago", SqlDbType.Int, TipoPago),
                db.Param("@Monto", SqlDbType.Decimal, Monto)
            };

            if (db.ExecuteQuery("Actualizar_Compra", Parametros))
                new popup("Compra actualizada correctamente", popup.AlertType.check);
            else
                new popup("Compra no actualizada", popup.AlertType.error);
        }


        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Compras", Parametros);
        }


        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Compras");
        }

        public DataTable Detalle(string idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 15, idvalue)
            };

            return db.Reader("CompraDetallada", Parametros);
        }

    }
}
