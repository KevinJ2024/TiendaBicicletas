using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DataEntities;
using Modelo.Entities;

namespace Logica.Controllers
{
    public class ProductoFacturaController
    {

        public List<ProductoFacturaEntity> ConsultarProductosFacturas(int ID_factura)
        {
            DataProductoFactura db = new DataProductoFactura();
            List<ProductoFacturaEntity> productofactura = db.ConsultarProductosFacturas(ID_factura);

            return productofactura;
        }
    }
}