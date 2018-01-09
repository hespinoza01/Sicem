using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Categoria
    {
        public int ID {
            get;
            set;
        }

        public string Nombre {
            get { return (Nombre != null) ? Nombre : "N/A"; }
            set { Nombre = (value != null) ? value : "N/A"; }
        }

        public string Descripcion {
            get { return (Descripcion != null) ? Descripcion : "N/A"; }
            set { Descripcion = (value != null) ? value : "N/A"; }
        }

        public int Estado {
            get;
            set;
        }

        public DateTime FechaCreacion
        {
            get;
            set;
        }
    }
}
