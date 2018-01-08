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

    public string ID { get; set; }
    public int ProveedorID { get; set; }
	public DateTime FechaCompra { get; set; }
    public int TipoPago { get; set; }
	public decimal Monto { get; set; }

        public void Insertar()
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter DESC = new SqlParameter();
                DESC.ParameterName = "@ID";
                DESC.SqlDbType = SqlDbType.VarChar;
                DESC.Size = 15;
                DESC.Value = ID;
                cmd.Parameters.Add(DESC);

                SqlParameter Prov = new SqlParameter();
                Prov.ParameterName = "@ProveedorID";
                Prov.SqlDbType = SqlDbType.Int;
                Prov.Value = ProveedorID;
                cmd.Parameters.Add(Prov);

                SqlParameter FComp = new SqlParameter();
                FComp.ParameterName = "@FechaCompra";
                FComp.SqlDbType = SqlDbType.Date;
                FComp.Value = FechaCompra;
                cmd.Parameters.Add(FComp);

                SqlParameter TipoPago = new SqlParameter();
                TipoPago.ParameterName = "@TipoPago";
                TipoPago.SqlDbType = SqlDbType.Int;
                TipoPago.Value = TipoPago;
                cmd.Parameters.Add(TipoPago);

                SqlParameter Mont = new SqlParameter();
                Mont.ParameterName = "@Monto";
                Mont.SqlDbType = SqlDbType.Decimal;
                Mont.Value = Monto;
                cmd.Parameters.Add(Mont);

                if (cmd.ExecuteNonQuery() == 1)
                    new popup("Compra guardada correctamente", popup.AlertType.check);
                else
                    new popup("Compra no guardada", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible insertar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        public void Editar()
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Actualizar_Compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter DESC = new SqlParameter();
                DESC.ParameterName = "@ID";
                DESC.SqlDbType = SqlDbType.VarChar;
                DESC.Size = 15;
                DESC.Value = ID;
                cmd.Parameters.Add(DESC);

                SqlParameter Prov = new SqlParameter();
                Prov.ParameterName = "@ProveedorID";
                Prov.SqlDbType = SqlDbType.Int;
                Prov.Value = ProveedorID;
                cmd.Parameters.Add(Prov);

                SqlParameter FComp = new SqlParameter();
                FComp.ParameterName = "@FechaCompra";
                FComp.SqlDbType = SqlDbType.Date;
                FComp.Value = FechaCompra;
                cmd.Parameters.Add(FComp);

                SqlParameter TipoPago = new SqlParameter();
                TipoPago.ParameterName = "@TipoPago";
                TipoPago.SqlDbType = SqlDbType.Int;
                TipoPago.Value = TipoPago;
                cmd.Parameters.Add(TipoPago);

                SqlParameter Mont = new SqlParameter();
                Mont.ParameterName = "@Monto";
                Mont.SqlDbType = SqlDbType.Decimal;
                Mont.Value = Monto;
                cmd.Parameters.Add(Mont);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible actualizar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
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
                cmd.CommandText = "Busqueda_Compras";
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
                cmd.CommandText = "Mostrar_Compras";
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
