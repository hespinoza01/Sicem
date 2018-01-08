using System;
using System.Data;
using System.Data.SqlClient;

namespace sicem
{
    public class DetalleCompra
    {
        public int CompraID { get; set; }
        public int ProdID { get; set; }
        public int Cant { get; set; }
        public decimal UnitPrice { get; set; }
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
                cmd.CommandText = "Insertar_Detalle_Compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IdCmp = new SqlParameter();
                IdCmp.ParameterName = "@CompraID";
                IdCmp.SqlDbType = SqlDbType.VarChar;
                IdCmp.Size = 15;
                IdCmp.Value = CompraID;
                cmd.Parameters.Add(IdCmp);

                SqlParameter ProdID = new SqlParameter();
                ProdID.ParameterName = "@ProductoID";
                ProdID.SqlDbType = SqlDbType.Int;
                ProdID.Value = this.ProdID;
                cmd.Parameters.Add(ProdID);

                SqlParameter Cant = new SqlParameter();
                Cant.ParameterName = "@Cantidad";
                Cant.SqlDbType = SqlDbType.Int;
                Cant.Value = this.Cant;
                cmd.Parameters.Add(Cant);

                SqlParameter cst = new SqlParameter();
                cst.ParameterName = "@CostoUnitario";
                cst.SqlDbType = SqlDbType.Decimal;
                cst.Value = UnitPrice;
                cmd.Parameters.Add(cst);

                SqlParameter Total = new SqlParameter();
                Total.ParameterName = "@Total";
                Total.SqlDbType = SqlDbType.Decimal;
                Total.Value = Total;
                cmd.Parameters.Add(Total);
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
                cmd.CommandText = "Actualizar_Detalle_Compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IdCmp = new SqlParameter();
                IdCmp.ParameterName = "@CompraID";
                IdCmp.SqlDbType = SqlDbType.VarChar;
                IdCmp.Size = 15;
                IdCmp.Value = CompraID;
                cmd.Parameters.Add(IdCmp);

                SqlParameter ProdID = new SqlParameter();
                ProdID.ParameterName = "@ProductoID";
                ProdID.SqlDbType = SqlDbType.Int;
                ProdID.Value = this.ProdID;
                cmd.Parameters.Add(ProdID);

                SqlParameter Cant = new SqlParameter();
                Cant.ParameterName = "@Cantidad";
                Cant.SqlDbType = SqlDbType.Int;
                Cant.Value = this.Cant;
                cmd.Parameters.Add(Cant);

                SqlParameter cst = new SqlParameter();
                cst.ParameterName = "@CostoUnitario";
                cst.SqlDbType = SqlDbType.Decimal;
                cst.Value = UnitPrice;
                cmd.Parameters.Add(cst);

                SqlParameter Total = new SqlParameter();
                Total.ParameterName = "@Total";
                Total.SqlDbType = SqlDbType.Decimal;
                Total.Value = this.Total;
                cmd.Parameters.Add(Total);
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

    }
}