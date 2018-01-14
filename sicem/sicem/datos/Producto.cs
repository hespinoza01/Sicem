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

        public int ID {
            get;
            set;
        }

	    public int CategoriaID {
            get;
            set;
        }

        public string Nombre {
            get { return (Nombre != null) ? Nombre : "N/A"; }
            set { Nombre = (value != null) ? value : "N/A"; }
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
            get { return (Descripcion != null) ? Descripcion : "N/A"; }
            set { Descripcion = (value != null) ? value : "N/A"; }
        }

        public int Estado {
            get;
            set;
        }

        public enum Accion
        {
            insertar, editar
        }

        public Producto() { }

        public Producto(int id, int categoriaid, string nombre, decimal precioventa, int stock, string descripcion, int estado, Accion type)
        {
            this.ID = id;
            this.CategoriaID = categoriaid;
            this.Nombre = nombre;
            this.PrecioVenta = precioventa;
            this.Stock = stock;
            this.Descripcion = descripcion;
            this.Estado = estado;

            switch (type)
            {
                case Accion.insertar:
                    Insertar();
                    break;

                case Accion.editar:
                    Editar();
                    break;
            }
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

        public DataTable HistorialPrecio(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Mostrar_HistorialPrecioProducto");
        }

        public DataTable HistorialCosto(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Mostrar_HistorialCostoProducto");
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
