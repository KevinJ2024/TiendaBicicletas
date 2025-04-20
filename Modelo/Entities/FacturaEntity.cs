using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class FacturaEntity
    {
        public int ID_factura;
        public int ID_cliente;
        public int ID_vendedor;
        public DateTime Fecha;
        public decimal Total;
    }
}
