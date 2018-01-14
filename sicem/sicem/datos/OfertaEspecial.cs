using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class OfertaEspecial
    {
        DBHelper db = new DBHelper();

        public int ID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get { return (Descripcion != null) ? Descripcion : "N/A"; }
            set { Descripcion = (value != null) ? value : "N/A"; }
        }

        public float PorcentajeDescuento
        {
            get;
            set;
        }

        public string TipoOferta
        {
            get { return (TipoOferta != null) ? TipoOferta : "N/A"; }
            set { TipoOferta = (value != null) ? value : "N/A"; }
        }

        public DateTime FechaInicio
        {
            get;
            set;
        }

        public DateTime FechaFinal
        {
            get;
            set;
        }

        public int MaxCantidad
        {
            get;
            set;
        }

        public int MinCantidad
        {
            get;
            set;
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@Descripcion", SqlDbType.Text, Descripcion),
                db.Param("@PorcentajeDescuento", SqlDbType.Float, PorcentajeDescuento),
                db.Param("@tipoOferta", SqlDbType.VarChar, 75, TipoOferta),
                db.Param("@FechaInicio", SqlDbType.Date, FechaInicio),
                db.Param("@FechaFinal", SqlDbType.Date, FechaFinal),
                db.Param("@MinCantidad", SqlDbType.Int, MinCantidad),
                db.Param("@MaxCantidad", SqlDbType.Int, MaxCantidad)
            };

            if (db.ExecuteQuery("Insertar_OfertaEspecial", Parametros))
                new popup("Oferta registrada correctamente", popup.AlertType.check);
            else
                new popup("Oferta no registrada", popup.AlertType.error);
        }

        public bool InsertarOfertaProducto(int idoferta, int idproducto)
        {
            bool estado = false;
            SqlParameter[] param = new SqlParameter[]
            {
                db.Param("@OfertaEspecialID", SqlDbType.Int, idoferta),
                db.Param("@ProductoID", SqlDbType.Int, idproducto)
            };

            if (db.ExecuteQuery("Insertar_OfertaEspecialProducto", param)){
                new popup("producto agregado", popup.AlertType.check);
                estado = true;
            }else
                new popup("Producto no agregado", popup.AlertType.warning);

            return estado;
        }

        public bool RemoverOfertaProducto(int idoferta, int idproducto)
        {
            bool estado = false;
            SqlParameter[] param = new SqlParameter[]
            {
                db.Param("@OfertaID", SqlDbType.Int, idoferta),
                db.Param("@ProductoID", SqlDbType.Int, idproducto)
            };

            if (db.ExecuteQuery("Remover_OfertaEspecialProducto", param))
            {
                new popup("producto removido", popup.AlertType.check);
                estado = true;
            }
            else
                new popup("Producto no removido", popup.AlertType.warning);

            return estado;
        }

        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, ID),
                db.Param("@Descripcion", SqlDbType.Text, Descripcion),
                db.Param("@PorcentajeDescuento", SqlDbType.Float, PorcentajeDescuento),
                db.Param("@tipoOferta", SqlDbType.VarChar, 75, TipoOferta),
                db.Param("@FechaInicio", SqlDbType.Date, FechaInicio),
                db.Param("@FechaFinal", SqlDbType.Date, FechaFinal),
                db.Param("@MinCantidad", SqlDbType.Int, MinCantidad),
                db.Param("@MaxCantidad", SqlDbType.Int, MaxCantidad)
            };

            if (db.ExecuteQuery("Actualizar_OfertaEspecial", Parametros))
                new popup("Oferta actualizada correctamente", popup.AlertType.check);
            else
                new popup("Oferta no actualizada", popup.AlertType.error);
        }

        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Ofertas");
        }

        public DataTable listadoProductos(int id){
            SqlParameter[] param = new SqlParameter[]{
                db.Param("@idoferta", SqlDbType.Int, id)
            };

            return db.Reader("Productos_Oferta", param);
        }

        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Oferta", Parametros);
        }

        public DataTable Detalle(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Detalle_Oferta", Parametros);
        }

    }
}
