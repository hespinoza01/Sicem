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
        DBHelper db = new DBHelper();
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
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.PPic.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Parámetros del Procedimiento Almacenado
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.VarChar, 15, UserName),
                db.Param("@Contraseña", SqlDbType.VarChar, 50, Password),
                db.Param("@Nombre", SqlDbType.NVarChar, 50, Nombre),
                db.Param("@Apellido", SqlDbType.VarChar, 50, Apellido),
                db.Param("@FotoPerfil", SqlDbType.Image, ms.GetBuffer()),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };
            
            if (db.ExecuteQuery("Insertar_Usuario", Parametros))
                new popup("Usuario creado correctamente", popup.AlertType.check);
            else
                new popup("Usuario no creado", popup.AlertType.error);

            ms.Dispose();
        }


        // Método editar
        public void Editar()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.PPic.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 15, UserName),
                db.Param("@Contraseña", SqlDbType.VarChar, 50, Password),
                db.Param("@Nombre", SqlDbType.NVarChar, 50, Nombre),
                db.Param("@Apellido", SqlDbType.VarChar, 50, Apellido),
                db.Param("@FotoPerfil", SqlDbType.Image, ms.ToArray()),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            //Ejecutamos nuestro comando
            if (db.ExecuteQuery("Actualizar_Usuario", Parametros))
                new popup("Cambios guardados correctamente", popup.AlertType.check);
            else
                new popup("Cambios no guardados", popup.AlertType.error); ;

            ms.Dispose();
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

        public DataTable Mostrar(){
            return db.Reader("Mostrar_Usuarios");
        }

        public DataTable Detalle(string id){
            SqlParameter[] param = new SqlParameter[]{
                db.Param("@ID", SqlDbType.VarChar, 15, id)
            };

            return db.Reader("Detalle_Usuario", param);
        }

        public DataTable Verifica(string User, string Pass)
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@Usuario", SqlDbType.VarChar, 15, User),
                db.Param("@Contraseña", SqlDbType.VarChar, 50, Pass)
            };

            return db.Reader("Validar_Usuario", Parametros);
        }

        public Image obtenerFoto(string id)
        {
            DataTable table = db.DataReader("select FotoPerfil from Usuario where ID = '" + id + "'");

            if (table != null)
            {
                DataRow data = table.Rows[0];

                byte[] img = (byte[])data["FotoPerfil"];

                MemoryStream ms = new MemoryStream(img);
                Image value = Image.FromStream(ms);

                return value;
            }
            else
            {
                new popup("Usuario no válido", popup.AlertType.error);
                return sicem.Properties.Resources.picture_user;
            }
        }

        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Usuario", Parametros);
        }

    }
}
