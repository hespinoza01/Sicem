﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem.datos
{
    class Bodega
    {
        DBHelper db = new DBHelper();

        public Bodega(){}

        public int ID
        {
            get;
            set;
        }

        public string Nombre
        {
            get { return (Nombre != null) ? Nombre : "N/A"; }
            set { Nombre = (value != null) ? value : "N/A"; }
        }

        public int Almacenaje
        {
            get;
            set;
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[] {
                db.Param("@Nombre", SqlDbType.VarChar, 35, Nombre),
                db.Param("@Almacenaje", SqlDbType.Int, Almacenaje)
            };

            if (db.ExecuteQuery("Insertar_Bodega", Parametros))
                new popup("Bodega registrada correctamente", popup.AlertType.check);
            else
                new popup("Bodega no registrada", popup.AlertType.error);
        }

        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[] {
                db.Param("@ID", SqlDbType.Int, ID),
                db.Param("@Nombre", SqlDbType.VarChar, 35, Nombre),
                db.Param("@Almacenaje", SqlDbType.Int, Almacenaje)
            };

            if (db.ExecuteQuery("Actualizar_Bodega", Parametros))
                new popup("Bodega actualizada correctamente", popup.AlertType.check);
            else
                new popup("Bodega no actualizada", popup.AlertType.error);
        }

        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Bodega", Parametros);
        }

        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Bodegas");
        }


        public DataTable Detalle(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[] {
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Detalle_Bodega", Parametros);
        }

    }
}
