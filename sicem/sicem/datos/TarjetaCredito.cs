using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem.datos
{
    class TarjetaCredito
    {
        public int ID
        {
            get;
            set;
        }

        public string TipoTarjeta
        {
            get { return (TipoTarjeta != null) ? TipoTarjeta : "N/A"; }
            set { TipoTarjeta = (value != null) ? value : "N/A"; }
        }

        public string NumeroTarjeta
        {
            get { return (NumeroTarjeta != null) ? NumeroTarjeta : "N/A"; }
            set { NumeroTarjeta = (value != null) ? value : "N/A"; }
        }

        public int ExpiraMes
        {
            get;
            set;
        }

        public int ExpiraAño
        {
            get;
            set;
        }
    }
}
