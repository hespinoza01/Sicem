using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class DataCategory
    {
        public void AddCategory(Categoria cat)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 100;
                Name.Value = cat.Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Desc = new SqlParameter();
                Desc.ParameterName = "@Descripcion";
                Desc.SqlDbType = SqlDbType.VarChar;
                Desc.Size = 250;
                Desc.Value = cat.Descripcion;
                cmd.Parameters.Add(Desc);

                SqlParameter Status = new SqlParameter();
                Status.ParameterName = "@Estado";
                Status.SqlDbType = SqlDbType.Int;
                Status.Value = cat.Estado;
                cmd.Parameters.Add(Status);

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
        public void UpdateCategory(Categoria cat)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Actualizar_Categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@ID";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = cat.ID;
                cmd.Parameters.Add(ID);

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 100;
                Name.Value = cat.Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Desc = new SqlParameter();
                Desc.ParameterName = "@Descripcion";
                Desc.SqlDbType = SqlDbType.VarChar;
                Desc.Size = 250;
                Desc.Value = cat.Descripcion;
                cmd.Parameters.Add(Desc);

                SqlParameter Status = new SqlParameter();
                Status.ParameterName = "@Estado";
                Status.SqlDbType = SqlDbType.Int;
                Status.Value = cat.Estado;
                cmd.Parameters.Add(Status);

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
        public DataSet SearchCategory(string valor, int state)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Busqueda_Categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@valor";
                ID.SqlDbType = SqlDbType.VarChar;
                ID.Size = 100;
                ID.Value = valor;
                cmd.Parameters.Add(ID);

                SqlParameter Key = new SqlParameter();
                Key.ParameterName = "@estado";
                Key.SqlDbType = SqlDbType.Int;
                Key.Value = state;
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
        public DataSet ShowCategory(int state)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Mostrar_Categorias";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Key = new SqlParameter();
                Key.ParameterName = "@estado";
                Key.SqlDbType = SqlDbType.Int;
                Key.Value = state;
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

    }
}
