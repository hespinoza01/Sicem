using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem.datos
{
    class Empleado
    {
        DBHelper db = new DBHelper();

        public Empleado(){}

        public int ID {
            get;
            set;
        }

        public string Nombres{
            get{return (Nombres != null) ? Nombres : "N/A";}
            set{ Nombres = (value != null) ? value : "N/A";}
        }

        public string Apellidos{
            get{return (Apellidos != null) ? Apellidos : "N/A";}
            set{ Apellidos = (value != null) ? value : "N/A";}
        }

        public int DepartamentoID{
            get;
            set;
        }

        public string TituloLaboral{
            get{return (TituloLaboral != null) ? TituloLaboral : "N/A";}
            set{TituloLaboral = (value != null) ? value : "N/A";}
        }

        public DateTime FechaNacimiento{
            get;
            set;
        }

        public DateTime FechaContratacion{
            get;
            set;
        }

        public int EstadoCivil
        {
            get;
            set;
        }

        public int Genero
        {
            get;
            set;
        }

        public string Domicilio{
            get{return (Domicilio != null) ? Domicilio : "N/A";}
            set{Domicilio = (value != null) ? value : "N/A";}
        }

        public string Ciudad{
            get{return (Ciudad != null) ? Ciudad : "N/A";}
            set{Ciudad = (value != null) ? value : "N/A";}
        }

        public string Telefono{
            get{return (Telefono != null) ? Telefono : "N/A";}
            set{Telefono = (value != null) ? value : "N/A";}
        }

        public string Cedula{
            get{return (Cedula != null) ? Cedula : "N/A";}
            set{ Cedula = (value != null) ? value : "N/A";}
        }

        public string Email{
            get{return (Email != null) ? Email : "N/A";}
            set{Email = (value != null) ? value : "N/A";}
        }

        public int HorasVacaciones
        {
            get;
            set;
        }

        public int HorasLicenciaEnfermedad
        {
            get;
            set;
        }

        public string Observaciones{
            get{return (Observaciones != null) ? Observaciones : "N/A";}
            set{Observaciones = (value != null) ? value : "N/A";}
        }

        public int ReportarA
        {
            get;
            set;
        }

        public Image Foto
        {
            get { return (Foto != null) ? Foto : sicem.Properties.Resources.picture_user; }
            set { Foto = (value != null) ? value : sicem.Properties.Resources.picture_user; }
        }

        public int Estado
        {
            get;
            set;
        }

        public void Insertar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@Nombres", SqlDbType.VarChar, 80, Nombres),
                db.Param("@Apellidos", SqlDbType.VarChar, 80, Apellidos),
                db.Param("@DepartamentoID", SqlDbType.Int, DepartamentoID),
                db.Param("@TituloLaboral", SqlDbType.VarChar, 35, TituloLaboral),
                db.Param("@FechaDeNacimiento", SqlDbType.Date, FechaNacimiento),
                db.Param("@FechaDeContratacion", SqlDbType.Date, FechaContratacion),
                db.Param("@EstadoCivil", SqlDbType.Int, EstadoCivil),
                db.Param("@Genero", SqlDbType.Int, Genero),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, Telefono),
                db.Param("@Cedula", SqlDbType.VarChar, 25, Cedula),
                db.Param("@Email", SqlDbType.VarChar, 50, Email),
                db.Param("@Observaciones", SqlDbType.Text, Observaciones),
                db.Param("@ReportarA", SqlDbType.Int, ReportarA),
                db.Param("@Foto", SqlDbType.Image, Foto),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            if (db.ExecuteQuery("Insertar_Empleado", Parametros))
                new popup("Empleado registrado correctamente", popup.AlertType.check);
            else
                new popup("Empleado no registrado", popup.AlertType.error);
        }

        public void Editar()
        {
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@ID", SqlDbType.Int, ID),
                db.Param("@Nombres", SqlDbType.VarChar, 80, Nombres),
                db.Param("@Apellidos", SqlDbType.VarChar, 80, Apellidos),
                db.Param("@DepartamentoID", SqlDbType.Int, DepartamentoID),
                db.Param("@TituloLaboral", SqlDbType.VarChar, 35, TituloLaboral),
                db.Param("@FechaDeNacimiento", SqlDbType.Date, FechaNacimiento),
                db.Param("@FechaDeContratacion", SqlDbType.Date, FechaContratacion),
                db.Param("@EstadoCivil", SqlDbType.Int, EstadoCivil),
                db.Param("@Genero", SqlDbType.Int, Genero),
                db.Param("@Domicilio", SqlDbType.VarChar, 200, Domicilio),
                db.Param("@Ciudad", SqlDbType.VarChar, 35, Ciudad),
                db.Param("@Telefono", SqlDbType.VarChar, 25, Telefono),
                db.Param("@Cedula", SqlDbType.VarChar, 25, Cedula),
                db.Param("@Email", SqlDbType.VarChar, 50, Email),
                db.Param("@Observaciones", SqlDbType.Text, Observaciones),
                db.Param("@ReportarA", SqlDbType.Int, ReportarA),
                db.Param("@Foto", SqlDbType.Image, Foto),
                db.Param("@Estado", SqlDbType.Int, Estado)
            };

            if (db.ExecuteQuery("Actualizar_Empleado", Parametros))
                new popup("Empleado actualizado correctamente", popup.AlertType.check);
            else
                new popup("Empleado no actualizado", popup.AlertType.error);
        }

        public DataTable Buscar(string valor, int clave){
            SqlParameter[] Parametros = new SqlParameter[]{
                db.Param("@valor", SqlDbType.VarChar, 100, valor),
                db.Param("@clave", SqlDbType.Int, clave)
            };

            return db.Reader("Busqueda_Empleado", Parametros);
        }

        public DataTable Mostrar()
        {
            return db.Reader("Mostrar_Empleados");
        }

        public DataTable Detalle(int idvalue)
        {
            SqlParameter[] Parametros = new SqlParameter[]
            {
                db.Param("@ID", SqlDbType.Int, idvalue)
            };

            return db.Reader("Detalle_Empleado", Parametros);
        }
    }
}
