using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;

namespace sicem
{
    public class DBHelper
    {
        Conexión conexion = new Conexión();
        public DBHelper(){}

        public object ReaderScalar(string sqlComandName)
        {
            object data;
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sqlComandName, cn);
                    data = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    new popup("Error al realizar la lectura", popup.AlertType.error);
                    data = null;

                }
                finally
                {
                    if (cn.State == ConnectionState.Open) cn.Close();
                }
            }

            return data;
        }

        public DataTable DataReader(string sqlComandName)
        {
            DataTable data = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexión.Cn)){

                try{
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sqlComandName, cn);
                    
                    SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                    sqlData.Fill(data);
                    
                }catch (Exception ex){
                    new popup("Error al realizar la lectura", popup.AlertType.error);
                    data = null;

                }finally{
                    if (cn.State == ConnectionState.Open) cn.Close();
                }
            }

            return data;
        }

        public DataTable Reader(string sqlComandName, SqlParameter[] dbParams)
        {
            DataTable data = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sqlComandName, cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (dbParams != null)
                        foreach (SqlParameter dbParam in dbParams)
                            cmd.Parameters.Add(dbParam);

                    SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                    sqlData.Fill(data);

                }
                catch (Exception ex)
                {
                    new popup("Error al realizar la lectura", popup.AlertType.error);
                    data = null;

                }
                finally
                {
                    if (cn.State == ConnectionState.Open) cn.Close();
                }
            }

            return data;
        }

        public DataTable Reader(string sqlComandName)
        {
            DataTable data = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sqlComandName, cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                    sqlData.Fill(data);

                }
                catch (Exception ex)
                {
                    new popup("Error al realizar la lectura", popup.AlertType.error);
                    data = null;

                }
                finally
                {
                    if (cn.State == ConnectionState.Open) cn.Close();
                }
            }

            return data;
        }

        public bool ExecuteQuery(string sqlComandName, SqlParameter[] dbParams)
        {
            bool estado = false;
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sqlComandName, cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (dbParams != null)
                        foreach (SqlParameter dbParam in dbParams)
                            cmd.Parameters.Add(dbParam);

                    estado = (cmd.ExecuteNonQuery() != 0) ? true : false;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR EN EL QUERY : "+ex.Message);
                    estado = false;
                }
                finally
                {
                    if (cn.State == ConnectionState.Open) cn.Close();
                }
            }

            return estado;
        }

        public bool ExecuteQuery(string sqlComandName)
        {
            bool estado = false;
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sqlComandName, cn);

                    estado = (cmd.ExecuteNonQuery() != 0) ? true : false;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR EN EL QUERY : " + ex.Message);
                    estado = false;
                }
                finally
                {
                    if (cn.State == ConnectionState.Open) cn.Close();
                }
            }

            return estado;
        }

        public SqlParameter Param(string paramName, SqlDbType dbType, int size, object objValue)
        {
            SqlParameter param = new SqlParameter();

            param.ParameterName = paramName;
            param.SqlDbType = dbType;
            param.Size = size;
            param.Value = objValue;

            return param;
        }

        public SqlParameter Param(string paramName, SqlDbType dbType, object objValue)
        {
            SqlParameter param = new SqlParameter();

            param.ParameterName = paramName;
            param.SqlDbType = dbType;
            param.Value = objValue;

            return param;
        }

    }
}