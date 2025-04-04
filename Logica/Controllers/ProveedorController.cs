using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DataEntities;
using Modelo.Entities;

namespace Logica.Controllers
{
    public class ProveedorController
    {
        public string RegistrarProveedor(int ID_proveedor, string Nombre_proveedor, string Email, string Telefono)
        {
            string resultado = "";
            DataProveedor db = new DataProveedor();
            int filasAfectadas = db.RegistrarProveedor(ID_proveedor, Nombre_proveedor, Email, Telefono);

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

        public ProveedorEntity ConsultarProveedor(int ID_proveedor)
        {
            DataProveedor db = new DataProveedor();
            ProveedorEntity proveedor = db.ConsultarProveedor(ID_proveedor);

            return proveedor;
        }

        public List<ProveedorEntity> MostrarProveedores()
        {
            DataProveedor db = new DataProveedor();
            List<ProveedorEntity> proveedores = db.MostrarProveedores();

            return proveedores;
        }

        public string ActualizarProveedor(int ID_proveedor, string Nombre_proveedor, string Email, string Telefono)
        {
            string resultado = "";
            DataProveedor db = new DataProveedor();
            int filasAfectadas = db.ActualizarProveedor(ID_proveedor, Nombre_proveedor, Email, Telefono);

            if (filasAfectadas > 0)
            {
                resultado = "Actualizado con exito";

            }
            else
            {
                resultado = "No actualizado";
            }

            return resultado;
        }

        public string EliminarProveedor(int ID_proveedor)
        {
            string resultado = "";
            DataProveedor db = new DataProveedor();
            int filasAfectadas = db.EliminarProveedor(ID_proveedor);

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
