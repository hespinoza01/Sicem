using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem.datos
{
    class Departamento
    {
        public int ID
        {
            get;
            set;
        }

        public string Nombre
        {
            get { return (Nombre != null) ? Nombre : "N/A"; }
            set { Nombre = (value != null) ? value : "N/A"; }
        }

        public string NombreGrupo
        {
            get { return (NombreGrupo != null) ? NombreGrupo : "N/A"; }
            set { NombreGrupo = (value != null) ? value : "N/A"; }
        }
    }
}
