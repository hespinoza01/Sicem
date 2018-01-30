using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Inventario
    {
        DBHelper db = new DBHelper();
        string estante;
        public int ID
        {
            get;
            set;
        }

        public int ProductoID
        {
            get;
            set;
        }

        public int BodegaID
        {
            get;
            set;
        }

        public string Estante
        {
            get { return (estante != null) ? estante : "N/A"; }
            set { estante = (value != null) ? value : "N/A"; }
        }

        public int Cantidad
        {
            get;
            set;
        }


        public void Insertar()
        {
            SqlParameter[] Param = new SqlParameter[]
            {
                db.Param("@ProductoID", SqlDbType.Int, ProductoID),
                db.Param("@BodegaID", SqlDbType.Int, BodegaID),
                db.Param("@Estante", SqlDbType.VarChar, 50, Estante),
                db.Param("@Cantidad", SqlDbType.Int, Cantidad)
            };

            db.ExecuteQuery("Insertar_Inventario", Param);
        }


        public void Editar()
        {
            SqlParameter[] Param = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, ID),
                db.Param("@ProductoID", SqlDbType.Int, ProductoID),
                db.Param("@BodegaID", SqlDbType.Int, BodegaID),
                db.Param("@Estante", SqlDbType.VarChar, 50, Estante),
                db.Param("@Cantidad", SqlDbType.Int, Cantidad)
            };

            db.ExecuteQuery("Actualizar_Inventario", Param);
        }


        public void Remover(int id)
        {
            SqlParameter[] Param = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, id)
            };

            db.ExecuteQuery("Remover_Inventario", Param);
        }


        public DataTable Mostrar(int idproducto)
        {
            SqlParameter[] Param = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, idproducto)
            };

            return db.Reader("Mostrar_Inventario", Param);
        }


        public DataTable Detalle(int id)
        {
            SqlParameter[] Param = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, id)
            };

            return db.Reader("Detalle_Inventario", Param);
        }


        public DataTable EntradaProducto(int id)
        {
            SqlParameter[] Param = new SqlParameter[]
            {
                db.Param("@ProductoID", SqlDbType.Int, id)
            };

            return db.Reader("Mostrar_Entrada_Producto", Param);
        }
    }
}
