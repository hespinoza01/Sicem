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
        public string VentaID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }


        public void Insertar()
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                //cmd.Transaction = trx;
                cmd.CommandText = "Insertar_Detalle_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter vtaID = new SqlParameter();
                vtaID.ParameterName = "@VentaID";
                vtaID.SqlDbType = SqlDbType.VarChar;
                vtaID.Size = 15;
                vtaID.Value = VentaID;
                cmd.Parameters.Add(vtaID);

                SqlParameter PorductoID = new SqlParameter();
                PorductoID.ParameterName = "@ProductoID";
                PorductoID.SqlDbType = SqlDbType.Int;
                PorductoID.Value = ProductoID;
                cmd.Parameters.Add(PorductoID);

                SqlParameter Cant = new SqlParameter();
                Cant.ParameterName = "@Cantidad";
                Cant.SqlDbType = SqlDbType.Int;
                Cant.Value = Cantidad;
                cmd.Parameters.Add(Cant);

                SqlParameter UnitPrice = new SqlParameter();
                UnitPrice.ParameterName = "@PrecioUnitario";
                UnitPrice.SqlDbType = SqlDbType.Decimal;
                UnitPrice.Value = PrecioUnitario;
                cmd.Parameters.Add(UnitPrice);

                SqlParameter Desc = new SqlParameter();
                Desc.ParameterName = "@Descuento";
                Desc.SqlDbType = SqlDbType.Decimal;
                Desc.Value = Descuento;
                cmd.Parameters.Add(Desc);

                SqlParameter Tax = new SqlParameter();
                Tax.ParameterName = "@Impuesto";
                Tax.SqlDbType = SqlDbType.Decimal;
                Tax.Value = Impuesto;
                cmd.Parameters.Add(Tax);

                SqlParameter Tot = new SqlParameter();
                Tot.ParameterName = "@Total";
                Tot.SqlDbType = SqlDbType.Decimal;
                Tot.Value = Total;
                cmd.Parameters.Add(Tot);

                cmd.ExecuteNonQuery();

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
                //cmd.Transaction = trx;
                cmd.CommandText = "Actualizar_Detalle_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter vtaID = new SqlParameter();
                vtaID.ParameterName = "@VentaID";
                vtaID.SqlDbType = SqlDbType.VarChar;
                vtaID.Size = 15;
                vtaID.Value = VentaID;
                cmd.Parameters.Add(vtaID);

                SqlParameter PorductoID = new SqlParameter();
                PorductoID.ParameterName = "@ProductoID";
                PorductoID.SqlDbType = SqlDbType.Int;
                PorductoID.Value = ProductoID;
                cmd.Parameters.Add(PorductoID);

                SqlParameter Cant = new SqlParameter();
                Cant.ParameterName = "@Cantidad";
                Cant.SqlDbType = SqlDbType.Int;
                Cant.Value = Cantidad;
                cmd.Parameters.Add(Cant);

                SqlParameter UnitPrice = new SqlParameter();
                UnitPrice.ParameterName = "@PrecioUnitario";
                UnitPrice.SqlDbType = SqlDbType.Decimal;
                UnitPrice.Value = PrecioUnitario;
                cmd.Parameters.Add(UnitPrice);

                SqlParameter Desc = new SqlParameter();
                Desc.ParameterName = "@Descuento";
                Desc.SqlDbType = SqlDbType.Decimal;
                Desc.Value = Descuento;
                cmd.Parameters.Add(Desc);

                SqlParameter Tax = new SqlParameter();
                Tax.ParameterName = "@Impuesto";
                Tax.SqlDbType = SqlDbType.Decimal;
                Tax.Value = Impuesto;
                cmd.Parameters.Add(Tax);

                SqlParameter Tot = new SqlParameter();
                Tot.ParameterName = "@Total";
                Tot.SqlDbType = SqlDbType.Decimal;
                Tot.Value = Total;
                cmd.Parameters.Add(Tot);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible Actualizar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

    }
}
