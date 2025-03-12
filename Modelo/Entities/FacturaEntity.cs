using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class FacturaEntity
    {
        public int ID_cliente;
        public int ID_vendedor;
        public string Nombre_Producto;
        public string Precio_Producto;
        public DateTime Fecha;
    }
}
