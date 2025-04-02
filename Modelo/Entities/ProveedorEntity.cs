using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProveedorEntity
    {
        public int ID_Proveedor;
        public string Nombre_proveedor;
        public string Email;
        public string Telefono;

        public int ID_proveedor { get; internal set; }
    }
}
