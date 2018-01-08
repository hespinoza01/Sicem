using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class venta
    {
        public venta() { }

        public venta(string id, int clienteid, DateTime fechaventa, int tipopago, int tipoventa, decimal subtotal, decimal tax, decimal total, Accion type)
        {
            this.Id = id;
            this.ClientId = clienteid;
            this.FechaVenta = fechaventa;
            this.TipoPago = tipopago;
            this.TipoVenta = tipoventa;
            this.SubTotal = subtotal;
            this.Tax = tax;
            this.MontoTotal = total;

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

        public enum Accion
        {
            insertar, editar
        }

        public string Id{ get; set; }
        public int ClientId{ get; set; }
        public DateTime FechaVenta{ get; set; }
        public int TipoPago{ get; set; }
        public int TipoVenta{ get; set; }
        public decimal SubTotal { get;set; }
        public decimal Tax { get; set; }
        public decimal MontoTotal{ get; set; }


        // Insertar
        public void Insertar()
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@ID";
                ID.SqlDbType = SqlDbType.VarChar;
                ID.Size = 15;
                ID.Value = Id;
                cmd.Parameters.Add(ID);

                SqlParameter Client = new SqlParameter();
                Client.ParameterName = "@ClienteID";
                Client.SqlDbType = SqlDbType.Int;
                Client.Value = ClientId;
                cmd.Parameters.Add(Client);

                SqlParameter FechaVta = new SqlParameter();
                FechaVta.ParameterName = "@FechaVenta";
                FechaVta.SqlDbType = SqlDbType.Date;
                FechaVta.Value = FechaVenta;
                cmd.Parameters.Add(FechaVta);

                SqlParameter PagoTipo = new SqlParameter();
                PagoTipo.ParameterName = "@TipoPago";
                PagoTipo.SqlDbType = SqlDbType.Int;
                PagoTipo.Value = TipoPago;
                cmd.Parameters.Add(PagoTipo);

                SqlParameter TipoVenta = new SqlParameter();
                TipoVenta.ParameterName = "@TipoVenta";
                TipoVenta.SqlDbType = SqlDbType.Int;
                TipoVenta.Value = this.TipoVenta;
                cmd.Parameters.Add(TipoVenta);

                SqlParameter Sub = new SqlParameter();
                Sub.ParameterName = "@SubTotal";
                Sub.SqlDbType = SqlDbType.Decimal;
                Sub.Value = SubTotal;
                cmd.Parameters.Add(Sub);

                SqlParameter Tax = new SqlParameter();
                Tax.ParameterName = "@Impuesto";
                Tax.SqlDbType = SqlDbType.Decimal;
                Tax.Value = this.Tax;
                cmd.Parameters.Add(Tax);

                SqlParameter Tot = new SqlParameter();
                Tot.ParameterName = "@Total";
                Tot.SqlDbType = SqlDbType.Decimal;
                Tot.Value = MontoTotal;
                cmd.Parameters.Add(Tot);

                if (cmd.ExecuteNonQuery() == 1)
                    new popup("Venta registrada correctamente", popup.AlertType.check);
                else
                    new popup("Venta no registrada", popup.AlertType.error);
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
                cmd.CommandText = "Actualizar_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@ID";
                ID.SqlDbType = SqlDbType.VarChar;
                ID.Size = 15;
                ID.Value = Id;
                cmd.Parameters.Add(ID);

                SqlParameter Client = new SqlParameter();
                Client.ParameterName = "@ClienteID";
                Client.SqlDbType = SqlDbType.Int;
                Client.Value = ClientId;
                cmd.Parameters.Add(Client);

                SqlParameter FechaVta = new SqlParameter();
                FechaVta.ParameterName = "@FechaVenta";
                FechaVta.SqlDbType = SqlDbType.Date;
                FechaVta.Value = FechaVenta;
                cmd.Parameters.Add(FechaVta);

                SqlParameter PagoTipo = new SqlParameter();
                PagoTipo.ParameterName = "@TipoPago";
                PagoTipo.SqlDbType = SqlDbType.Int;
                PagoTipo.Value = TipoPago;
                cmd.Parameters.Add(PagoTipo);

                SqlParameter TipoVenta = new SqlParameter();
                TipoVenta.ParameterName = "@TipoVenta";
                TipoVenta.SqlDbType = SqlDbType.Int;
                TipoVenta.Value = this.TipoVenta;
                cmd.Parameters.Add(TipoVenta);

                SqlParameter Sub = new SqlParameter();
                Sub.ParameterName = "@SubTotal";
                Sub.SqlDbType = SqlDbType.Decimal;
                Sub.Value = SubTotal;
                cmd.Parameters.Add(Sub);

                SqlParameter Tax = new SqlParameter();
                Tax.ParameterName = "@Impuesto";
                Tax.SqlDbType = SqlDbType.Decimal;
                Tax.Value = this.Tax;
                cmd.Parameters.Add(Tax);

                SqlParameter Tot = new SqlParameter();
                Tot.ParameterName = "@Total";
                Tot.SqlDbType = SqlDbType.Decimal;
                Tot.Value = MontoTotal;
                cmd.Parameters.Add(Tot);

                if (cmd.ExecuteNonQuery() == 1)
                    new popup("Venta actualizada correctamente", popup.AlertType.check);
                else
                    new popup("Venta no actualizada", popup.AlertType.error); 
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


        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Ventas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
            }
            catch (Exception ex)
            {
                new popup("Error al mostrar ventas", popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
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
                cmd.CommandText = "Busqueda_Ventas";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Valor = new SqlParameter();
                Valor.ParameterName = "@valor";
                Valor.SqlDbType = SqlDbType.VarChar;
                Valor.Size = 100;
                Valor.Value = valor;
                cmd.Parameters.Add(Valor);

                SqlParameter Clave = new SqlParameter();
                Clave.ParameterName = "@clave";
                Clave.SqlDbType = SqlDbType.Int;
                Clave.Value = clave;
                cmd.Parameters.Add(Clave);

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
