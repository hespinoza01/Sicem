using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem.datos
{
    class Empleado
    {
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
    }
}
