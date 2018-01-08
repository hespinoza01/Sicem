using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Cliente
    {
        private int C_id;
        private string C_nomb;
        private string C_domi;
        private string C_tel;
        private string C_ema;

        public int C_Id
        {
            get { return C_id; }
            set { C_id = value; }
        }

        public string C_Nombre
        {
            get { return C_nomb; }
            set { C_nomb = value; }
        }

        public string C_Domicilio
        {
            get { return C_domi; }
            set { C_domi = value; }
        }

        public string C_Telefono
        {
            get { return C_tel; }
            set { C_tel = value; }
        }

        public string C_Email
        {
            get { return C_ema; }
            set { C_ema = value; }
        }

        public enum Accion
        {
            insertar, editar
        }

        public Cliente()
        {
        }

        public Cliente(int id, string nombre, string domicilio, string telefono, string email, Accion type)
        {
            C_id = id;
            C_nomb = nombre;
            C_domi = domicilio;
            C_tel = telefono;
            C_ema = email;

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
                cmd.CommandText = "Insertar_Cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 50;
                Name.Value = C_Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Dom = new SqlParameter();
                Dom.ParameterName = "@Domicilio";
                Dom.SqlDbType = SqlDbType.VarChar;
                Dom.Size = 125;
                Dom.Value = C_Domicilio;
                cmd.Parameters.Add(Dom);

                SqlParameter Tel = new SqlParameter();
                Tel.ParameterName = "@Telefono";
                Tel.SqlDbType = SqlDbType.VarChar;
                Tel.Size = 25;
                Tel.Value = C_Telefono;
                cmd.Parameters.Add(Tel);

                SqlParameter Correo = new SqlParameter();
                Correo.ParameterName = "@Email";
                Correo.SqlDbType = SqlDbType.VarChar;
                Correo.Size = 50;
                Correo.Value = C_Email;
                cmd.Parameters.Add(Correo);

                if (cmd.ExecuteNonQuery() == 1)
                    new popup("Cliente registrado correctamente", popup.AlertType.check);
                else
                    new popup("Cliente no registrado", popup.AlertType.error);
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
                cmd.CommandText = "Actualizar_Cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@ID";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = C_Id;
                cmd.Parameters.Add(ID);

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 50;
                Name.Value = C_Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Dom = new SqlParameter();
                Dom.ParameterName = "@Domicilio";
                Dom.SqlDbType = SqlDbType.VarChar;
                Dom.Size = 125;
                Dom.Value = C_Domicilio;
                cmd.Parameters.Add(Dom);

                SqlParameter Tel = new SqlParameter();
                Tel.ParameterName = "@Telefono";
                Tel.SqlDbType = SqlDbType.VarChar;
                Tel.Size = 25;
                Tel.Value = C_Telefono;
                cmd.Parameters.Add(Tel);

                SqlParameter Correo = new SqlParameter();
                Correo.ParameterName = "@Email";
                Correo.SqlDbType = SqlDbType.VarChar;
                Correo.Size = 50;
                Correo.Value = C_Email;
                cmd.Parameters.Add(Correo);

                if (cmd.ExecuteNonQuery() == 1)
                    new popup("Cliente actualizado correctamente", popup.AlertType.check);
                else
                    new popup("Cliente no actualizado", popup.AlertType.error);
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
                cmd.CommandText = "Busqueda_Cliente";
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
                cmd.CommandText = "Mostrar_Clientes";
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
