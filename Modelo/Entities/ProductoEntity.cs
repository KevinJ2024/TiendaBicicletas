using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProductoEntity
    {
        public int ID_producto;
        public string Nombre_producto;
        public int Precio_producto;
        public int Stock;
        public string Descripcion;
        public Blob Imagen;
    }
}
