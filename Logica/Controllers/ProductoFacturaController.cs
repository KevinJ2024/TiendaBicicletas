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

        public string RegistrarProductoFactura(int ID_factura, int ID_producto, int Cantidad)
        {
            string resultado = "";
            DataProductoFactura db = new DataProductoFactura();
            int filasAfectadas = db.RegistrarProductoFactura(ID_factura, ID_producto, Cantidad);

            if (filasAfectadas > 0)
            {
                resultado = "Guardado con exito";

            }
            else
            {
                resultado = "No guardado";
            }

            return resultado;
        }

        public List<ProductoFacturaEntity> ConsultarProductosFacturas(int ID_ProductoFactura)
        {
            DataProductoFactura db = new DataProductoFactura();
            List<ProductoFacturaEntity> productofactura = db.ConsultarProductosFacturas(ID_ProductoFactura);

            return productofactura;
        }

        public List<ProductoFacturaEntity> MostrarProductoFactura(int ID_ProductoFactura)
        {
            DataProductoFactura db = new DataProductoFactura();

            List<ProductoFacturaEntity> productosfacturas = db.MostrarProductoFactura();

            return productosfacturas;
        }
    }
}