using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class Inventario
    {
        DBHelper db = new DBHelper();

        public Inventario(){}

        public int ProductoID
        {
            get;
            set;
        }

        public int BodegaID
        {
            get;
            set;
        }

        public string Estante
        {
            get { return (Estante != null) ? Estante : "N/A"; }
            set { Estante = (value != null) ? value : "N/A"; }
        }

        public int Cantidad
        {
            get;
            set;
        }
    }
}
