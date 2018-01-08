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
        public int ID { get; set; }
	    public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

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
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@CategoriaID";
                ParUsuario.SqlDbType = SqlDbType.Int;
                ParUsuario.Value = CategoriaID;
                SqlCmd.Parameters.Add(ParUsuario);


                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Nombre";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 50;
                ParContraseña.Value = Nombre;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@PecioVenta";
                ParNombre.SqlDbType = SqlDbType.Decimal;
                ParNombre.Value = PrecioVenta;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@Stock";
                ParApellido.SqlDbType = SqlDbType.Int;
                ParApellido.Value = Stock;
                SqlCmd.Parameters.Add(ParApellido);


                SqlParameter ParDes = new SqlParameter();
                ParDes.ParameterName = "@Descripcion";
                ParDes.SqlDbType = SqlDbType.VarChar;
                ParDes.Size = 250;
                ParDes.Value = Descripcion;
                SqlCmd.Parameters.Add(ParDes);


                SqlParameter ParApellid = new SqlParameter();
                ParApellid.ParameterName = "@Estado";
                ParApellid.SqlDbType = SqlDbType.Int;
                ParApellid.Value = Estado;
                SqlCmd.Parameters.Add(ParApellid);


                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Producto creado correctamente", popup.AlertType.check);
                else
                    new popup("Producto no creado", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }



        public void Editar()
        {
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Actualizar_Producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@ID";
                ParUsuario.SqlDbType = SqlDbType.Int;
                ParUsuario.Value = ID;
                SqlCmd.Parameters.Add(ParUsuario);


                SqlParameter ParUsuari = new SqlParameter();
                ParUsuari.ParameterName = "@CategoriaID";
                ParUsuari.SqlDbType = SqlDbType.Int;
                ParUsuari.Value = CategoriaID;
                SqlCmd.Parameters.Add(ParUsuari);


                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Nombre";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 50;
                ParContraseña.Value = Nombre;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@PrecioVenta";
                ParNombre.SqlDbType = SqlDbType.Decimal;
                ParNombre.Value = PrecioVenta;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@Stock";
                ParApellido.SqlDbType = SqlDbType.Int;
                ParApellido.Value = Stock;
                SqlCmd.Parameters.Add(ParApellido);


                SqlParameter ParDes = new SqlParameter();
                ParDes.ParameterName = "@Descripcion";
                ParDes.SqlDbType = SqlDbType.VarChar;
                ParDes.Size = 250;
                ParDes.Value = Descripcion;
                SqlCmd.Parameters.Add(ParDes);


                SqlParameter ParApellid = new SqlParameter();
                ParApellid.ParameterName = "@Estado";
                ParApellid.SqlDbType = SqlDbType.Int;
                ParApellid.Value = Estado;
                SqlCmd.Parameters.Add(ParApellid);

                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Producto actualizado correctamente", popup.AlertType.check);
                else
                    new popup("Producto no actualizado", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }


        public DataTable Buscar(string valor, int clave)
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Busqueda_Productos";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@valor";
                ID.SqlDbType = SqlDbType.VarChar;
                ID.Size = 100;
                ID.Value = valor;
                cmd.Parameters.Add(ID);

                SqlParameter Key = new SqlParameter();
                Key.ParameterName = "@clave";
                Key.SqlDbType = SqlDbType.Int;
                Key.Value = clave;
                cmd.Parameters.Add(Key);

                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                Data.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Consulta realizada sin exito: " + ex.ToString());
                dt = null;
            }
            return dt;
        }


        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Mostrar_Productos";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                Data.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Consulta realizada sin exito: " + ex.ToString());
                dt = null;
            }
            return dt;
        }


    }
}
