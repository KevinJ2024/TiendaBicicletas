using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo.DataEntities;

namespace Logica.Controllers
{
    public class FacturaController
    {

<<<<<<< HEAD
        public string RegistrarFactura(int ID_cliente, int ID_vendedor, DateTime Fecha)
        {
            string resultado = "";
            DataFactura db = new DataFactura();
            int filasAfectadas = db.RegistrarFactura(ID_cliente, ID_vendedor, Fecha);
=======
        public string RegistrarFactura(int ID_cliente, int ID_producto, int ID_vendedor, DateTime Fecha)
        {
            string resultado = "";
            DataFactura db = new DataFactura();
            int filasAfectadas = db.RegistrarFactura(ID_cliente, ID_producto, ID_vendedor, Fecha);
>>>>>>> ee4cced6066a2a30304e6ef147a90dd2ff44c696

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

        public FacturaEntity ConsultarFactura(int ID_factura)
        {
            DataFactura db = new DataFactura();
            FacturaEntity factura = db.ConsultarFactura(ID_factura);

            return factura;
        }

        public List<FacturaEntity> MostrarFacturas()
        {
            DataFactura db = new DataFactura();
            List<FacturaEntity> facturas = db.MostrarFacturas();

            return facturas;
        }

        //public string ActualizarFactura(int ID_cliente, int ID_producto, int ID_vendedor, DateTime Fecha)
        //{
        //    string resultado = "";
        //    DataFactura db = new DataFactura();
        //    int filasAfectadas = db.ActualizarFactura(ID_cliente, ID_producto, ID_vendedor, Fecha);

        //    if (filasAfectadas > 0)
        //    {
        //        resultado = "Actualizado con exito";

        //    }
        //    else
        //    {
        //        resultado = "No actualizado";
        //    }

        //    return resultado;
        //}
    }
}
