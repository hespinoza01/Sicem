using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace sicem
{
    public class usuario
    {
        //Clase de validacion de usuario
        public string nombre, apellido, username, password;
        public Image pPic;

        public usuario() { }

        public usuario(string nombre, string apellido, string password, string usuario, Image picture, Accion type)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Password = password;
            this.UserName = usuario;
            this.PPic = picture;

            switch (type)
            {
                case Accion.insertar:
                    Insertar();
                    break;

                case Accion.editar:
                    Editar();
                    break;

                case Accion.borrar:
                    Borrar();
                    break;
            }
        }


        public enum Accion
        {
            insertar, editar, borrar
        }

        public string Nombre
        {
            get { return (nombre != null) ? nombre : "N/A"; }
            set { nombre = (value != null) ? value : "N/A"; }
        }

        public string Apellido
        {
            get { return (apellido != null) ? apellido : "N/A"; }
            set { apellido = (value != null) ? value : "N/A"; }
        }

        public string UserName
        {
            get { return (username != null) ? username : "N/A"; }
            set { username = (value != null) ? value : "N/A"; }
        }

        public string Password
        {
            get { return (password != null) ? password : "N/A"; }
            set { password = (value != null) ? value : "N/A"; }
        }

        public Image PPic
        {
            get { return (pPic != null) ? pPic : sicem.Properties.Resources.picture_user; }
            set { pPic = (value != null) ? value : sicem.Properties.Resources.picture_user; }
        }

        public int Estado
        {
            get;
            set;
        }

        public DateTime FechaCreacion
        {
            get;
            set;
        }

        // Método insertar
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
                SqlCmd.CommandText = "Insertar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@ID";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 15;
                ParUsuario.Value = UserName;
                SqlCmd.Parameters.Add(ParUsuario);


                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Contraseña";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 50;
                ParContraseña.Value = Password;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@Apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Apellido;
                SqlCmd.Parameters.Add(ParApellido);


                SqlParameter ParPerfilPicture = new SqlParameter();
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.PPic.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ParPerfilPicture.ParameterName = "@FotoPerfil";
                ParPerfilPicture.SqlDbType = SqlDbType.Image;
                ParPerfilPicture.Value = ms.GetBuffer();
                SqlCmd.Parameters.Add(ParPerfilPicture);

                //SqlCmd.ExecuteNonQuery();

                //Ejecutamos nuestro comando

                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Usuario creado correctamente", popup.AlertType.check);
                else
                    new popup("Usuario no creado", popup.AlertType.error); 

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


        // Método editar
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
                SqlCmd.CommandText = "Actualizar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@ID";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 15;
                ParUsuario.Value = UserName;
                SqlCmd.Parameters.Add(ParUsuario);


                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Contraseña";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 50;
                ParContraseña.Value = this.Password;
                SqlCmd.Parameters.Add(ParContraseña);


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = this.Nombre;
                SqlCmd.Parameters.Add(ParNombre);


                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@Apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = this.Apellido;
                SqlCmd.Parameters.Add(ParApellido);


                //ImageConverter c = new ImageConverter();
                //byte[] aByte = (byte[])c.ConvertTo(PPic, typeof(byte[]));

                SqlParameter ParPerfilPicture = new SqlParameter();
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.PPic.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ParPerfilPicture.ParameterName = "@FotoPerfil";
                ParPerfilPicture.SqlDbType = SqlDbType.Image;
                ParPerfilPicture.Value = ms.ToArray();
                SqlCmd.Parameters.Add(ParPerfilPicture);



                //Ejecutamos nuestro comando

                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Cambios guardados correctamente", popup.AlertType.check);
                else
                    new popup("Cambios no guardados", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                //new popup("error", popup.AlertType.error);
                Console.WriteLine("El error es: "+ex.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }


        //Método borrar
        public void Borrar()
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
                SqlCmd.CommandText = "Deshabilitar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.NVarChar;
                ParID.Size = 10;
                ParID.Value = UserName;
                SqlCmd.Parameters.Add(ParID);

                //Ejecutamos nuestro comando

                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                else
                    new popup("Cuenta no eliminada", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Verifica(string User, string Pass)
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
                SqlCmd.CommandText = "Validar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@Usuario";
                ParID.SqlDbType = SqlDbType.VarChar;
                ParID.Size = 15;
                ParID.Value = User;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Contraseña";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 50;
                ParContraseña.Value = Pass;
                SqlCmd.Parameters.Add(ParContraseña);
                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }

        public Image obtenerFoto(string id)
        {
            Conexión conex = new Conexión();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexión.Cn))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "select FotoPerfil from Usuario where ID = '"+ id+"'",
                        cn
                        );

                    byte[] arrImg = (byte[])cmd.ExecuteScalar();
                    cn.Close();

                    MemoryStream ms = new MemoryStream(arrImg);
                    Image img = Image.FromStream(ms);

                    ms.Close();

                    return img;
                }
            }
            catch (Exception ex)
            {
                new popup("Usuario no válido", popup.AlertType.error);
                return sicem.Properties.Resources.picture_user;
            }
        }

    }
}
