using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class listadoItems
    {
        public string[] usuario()
        {
            string[] data = new string[] {
                "Nombre/ID",
                "Apellido"
            };

            return data;
        }

        public string[] cliente()
        {
            string[] data = new string[] {
                "Nombre/ID",
                "Email",
                "Domicilio",
                "Teléfono"
            };

            return data;
        }

        public string[] proveedor()
        {
            string[] data = new string[] {
                "Nombre/ID",
                "Email",
                "Domicilio",
                "Teléfono"
            };

            return data;
        }

        public string[] empleado()
        {
            string[] data = new string[] {
                "Nombre/ID",
                "Email",
                "Domicilio",
                "Teléfono"
            };

            return data;
        }

        public string[] departamento()
        {
            string[] data = new string[] {
                "Nombre/ID",
                "Nombre grupo"
            };

            return data;
        }

        public string[] bodega()
        {
            string[] data = new string[] {
                "Nombre/ID",
                "Almacenaje"
            };

            return data;
        }

        public string[] compra()
        {
            string[] data = new string[] {
                "ID",
                "ProveedorID",
                "Fecha compra",
                "Total"
            };

            return data;
        }

        public string[] venta()
        {
            string[] data = new string[] {
                "ID",
                "ClienteID",
                "Fecha venta",
                "Total"
            };

            return data;
        }

        public string[] producto()
        {
            string[] data = new string[] {
                "Nombre/ID",
                "CategoríaID",
                "Precio venta",
                "Stock"
            };

            return data;
        }

        public string[] categoria()
        {
            string[] data = new string[] {
                "Nombre/ID"
            };

            return data;
        }

        public string[] oferta()
        {
            string[] data = new string[] {
                "ID/Tipo oferta",
                "Descuento(%)",
                "Fecha inicio",
                "Fecha final"
            };

            return data;
        }

        public void llenar(iTalk.iTalk_ComboBox c, string[] value)
        {
            c.Items.Clear();
            c.Items.AddRange(value);
        }

        public string[] ciudad()
        {
            string[] data = new string[]
            {
                "Managua",
                "León",
                "Masaya"
            };

            return data;
        }

        public int indexCiudad(string value)
        {
            int index = 0;

            foreach(string s in ciudad())
            {
                if (s.Equals(value))
                    break;

                index++;
            }

            return index;
        }
    }
}
