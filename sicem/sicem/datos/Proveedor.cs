using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Proveedor
    {

        public int P_Id{ 
            get {return (P_Id != null) ? P_Id : -1;} 
            set {P_Id = (value != null) ? value : -1;} 
        }

        public string P_Nombre{
            get { return (P_Nombre != null) ? P_Nombre : "N/A"; }
            set { P_Nombre = (value != null) ? value : "N/A"; }
        }

        public string P_Domicilio{
            get { return (P_Domicilio != null) ? P_Domicilio : "N/A"; }
            set { P_Domicilio = (value != null) ? value : "N/A"; }
        }

        public string P_Telefono{
            get { return (P_Telefono != null) ? P_Telefono : "N/A"; }
            set { P_Telefono = (value != null) ? value : "N/A"; }
        }

        public string P_Email{
            get { return (P_Email != null) ? P_Email : "N/A"; }
            set { P_Email = (value != null) ? value : "N/A"; }
        }

        public enum Accion
        {
            insertar, editar
        }

        public Proveedor()
        {
        }

        public Proveedor(int id, string nombre, string domicilio, string telefono, string email, Accion type)
        {
            P_Id = id;
            P_Nombre = nombre;
            P_Domicilio = domicilio;
            P_Telefono = telefono;
            P_Email = email;

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
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 50;
                Name.Value = P_Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Dom = new SqlParameter();
                Dom.ParameterName = "@Domicilio";
                Dom.SqlDbType = SqlDbType.VarChar;
                Dom.Size = 125;
                Dom.Value = P_Domicilio;
                cmd.Parameters.Add(Dom);

                SqlParameter Tel = new SqlParameter();
                Tel.ParameterName = "@Telefono";
                Tel.SqlDbType = SqlDbType.VarChar;
                Tel.Size = 25;
                Tel.Value = P_Telefono;
                cmd.Parameters.Add(Tel);

                SqlParameter Correo = new SqlParameter();
                Correo.ParameterName = "@Email";
                Correo.SqlDbType = SqlDbType.VarChar;
                Correo.Size = 50;
                Correo.Value = P_Email;
                cmd.Parameters.Add(Correo);

                if (cmd.ExecuteNonQuery() == 1)
                    new popup("Proveedor registrado correctamente", popup.AlertType.check);
                else
                    new popup("Proveedor no registrado", popup.AlertType.error);
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
                cmd.CommandText = "Actualizar_Proveedores";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@ID";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = P_Id;
                cmd.Parameters.Add(ID);

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 50;
                Name.Value = P_Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Dom = new SqlParameter();
                Dom.ParameterName = "@Domicilio";
                Dom.SqlDbType = SqlDbType.VarChar;
                Dom.Size = 125;
                Dom.Value = P_Domicilio;
                cmd.Parameters.Add(Dom);

                SqlParameter Tel = new SqlParameter();
                Tel.ParameterName = "@Telefono";
                Tel.SqlDbType = SqlDbType.VarChar;
                Tel.Size = 25;
                Tel.Value = P_Telefono;
                cmd.Parameters.Add(Tel);

                SqlParameter Correo = new SqlParameter();
                Correo.ParameterName = "@Email";
                Correo.SqlDbType = SqlDbType.VarChar;
                Correo.Size = 50;
                Correo.Value = P_Email;
                cmd.Parameters.Add(Correo);

                if (cmd.ExecuteNonQuery() == 1)
                    new popup("Proveedor actualizado correctamente", popup.AlertType.check);
                else
                    new popup("Proveedor no actualizado", popup.AlertType.error);
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


        public DataTable Buscar(string valor, int clave)
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Busqueda_Proveedor";
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
                cmd.CommandText = "Mostrar_Proveedores";
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
