using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem.datos
{
    class OfertaEspecial
    {
        public int ID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get { return (Descripcion != null) ? Descripcion : "N/A"; }
            set { Descripcion = (value != null) ? value : "N/A"; }
        }

        public float PorcentajeDescuento
        {
            get;
            set;
        }

        public string TipoOferta
        {
            get { return (TipoOferta != null) ? TipoOferta : "N/A"; }
            set { TipoOferta = (value != null) ? value : "N/A"; }
        }

        public DateTime FechaInicio
        {
            get;
            set;
        }

        public DateTime FechaFinal
        {
            get;
            set;
        }

        public int MaxCantidad
        {
            get;
            set;
        }

        public int MinCantidad
        {
            get;
            set;
        }
    }
}
