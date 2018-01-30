using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Producto
    {
        DBHelper db = new DBHelper();
        string nombre, descripcion;
        public int ID {
            get;
            set;
        }

	    public int CategoriaID {
            get;
            set;
        }

        public string Nombre {
            get { return (nombre != null) ? nombre : "N/A"; }
            set { nombre = (value != null) ? value : "N/A"; }
        }

        public int CantidadPorUnidad
        {
            get;
            set;
        }

        public decimal PrecioVenta {
            get;
            set;
        }

        public int Stock {
            get;
            set;
        }

        public string Descripcion {
            get { return (descripcion != null) ? descripcion : "N/A"; }
            set { descripcion = (value != null) ? value : "N/A"; }
        }

        public int Estado {
            get;
            set;
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@CategoriaID", SqlDbType.Int, CategoriaID),
                db.Param("@Nombre", SqlDbType.VarChar, 50, Nombre),
                db.Param("@CantidadPorUnidad", SqlDbType.Int, CantidadPorUnidad),
                db.Param("@PrecioVenta", SqlDbType.Decimal, PrecioVenta),
                db.Param("@Stock", SqlDbType.Int, Stock),
                db.Param("@Descripcion", SqlDbType.VarChar, 250, Descripcion),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            if (db.ExecuteQuery("Insertar_Producto", Parametros))
                new popup("Producto creado correctamente", popup.AlertType.check);
            else
                new popup("Producto no creado", popup.AlertType.error); ;
        }



        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, ID),
                db.Param("@CategoriaID", SqlDbType.Int, CategoriaID),
                db.Param("@Nombre", SqlDbType.VarChar, 50, Nombre),
                db.Param("@CantidadPorUnidad", SqlDbType.Int, CantidadPorUnidad),
                db.Param("@PrecioVenta", SqlDbType.Decimal, PrecioVenta),
                db.Param("@Stock", SqlDbType.Int, Stock),
                db.Param("@Descripcion", SqlDbType.VarChar, 250, Descripcion),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            if (db.ExecuteQuery("Actualizar_Producto", Parametros))
                new popup("Producto actualizado correctamente", popup.AlertType.check);
            else
                new popup("Producto no actualizado", popup.AlertType.error); ;
        }


        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Productos", Parametros);
        }

        public DataTable BuscarTodo(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Productos_Todo", Parametros);
        }

        public DataTable MostrarHabilitados()
        {
            return db.Reader("Mostrar_Productos");
        }


        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Todo_Productos");
        }


        public void InsertarHistorialPrecio(int id, decimal precio)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ProductoID", SqlDbType.Int, id),
                db.Param("@Precio", SqlDbType.Decimal, precio)
            };

            db.ExecuteQuery("Insertar_Historial_Precio_Producto", Parametros);
        }


        public DataTable HistorialPrecio(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Mostrar_HistorialPrecioProducto", Parametros);
        }


        public DataTable HistorialCosto(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Mostrar_HistorialCostoProducto", Parametros);
        }


        public void InsertarHistorialCosto(int id, decimal precio)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ProductoID", SqlDbType.Int, id),
                db.Param("@Precio", SqlDbType.Decimal, precio)
            };

            db.ExecuteQuery("Insertar_Historial_Costo_Producto", Parametros);
        }


        public DataTable detalleProductoOferta(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@idproducto", SqlDbType.Int, idvalue)
            };

            return db.Reader("Producto_Oferta", Parametros);
        }


        public DataTable Detalle(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Detalle_Producto", Parametros);
        }

    }
}
