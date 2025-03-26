using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Modelo.DataEntities;
using Modelo.Entities;

namespace Logica.Controllers
{
    public class ProductoController
    {

        public string RegistrarProducto(string Nombre_producto, decimal Precio_producto, int Stock, string Descripcion, byte[] Imagen)
        {
            string resultado = "";
            DataProducto db = new DataProducto();
            int filasAfectadas = db.RegistrarProducto(Nombre_producto, Precio_producto, Stock, Descripcion, Imagen);

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

        public ProductoEntity ConsultarProducto(int ID_producto)
        {
            DataProducto db = new DataProducto();
            ProductoEntity producto = db.ConsultarProducto(ID_producto);

            return producto;
        }

        public List<ProductoEntity> MostrarProductos()
        {
            DataProducto db = new DataProducto();
            List<ProductoEntity> productos = db.MostrarProductos();

            return productos;
        }

        //public string ActualizarVendedor(int ID_vendedor, string Nombre_vendedor, string Email, string Telefono, decimal Salario, string Contraseña)
        //{
        //    string resultado = "";
        //    DataVendedor db = new DataVendedor();
        //    int filasAfectadas = db.ActualizarVendedor(ID_vendedor, Nombre_vendedor, Email, Telefono, Salario, Contraseña);

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

        public string EliminarProducto(int ID_producto)
        {
            string resultado = "";
            DataProducto db = new DataProducto();
            int filasAfectadas = db.EliminarProducto(ID_producto);

            if (filasAfectadas > 0)
            {
                resultado = "Eliminado con exito";

            }
            else
            {
                resultado = "No Eliminado";
            }

            return resultado;
        }
    }
}
