using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DataEntities;
using Modelo.Entities;

namespace Logica.Controllers
{
    public class VendedorController
    {

        public string RegistrarVendedor(int ID_vendedor, string Nombre_vendedor, string Email, string Telefono, decimal Salario, string Contraseña)
        {
            string resultado = "";
            DataVendedor db = new DataVendedor();
            int filasAfectadas = db.RegistrarVendedor(ID_vendedor, Nombre_vendedor, Email, Telefono, Salario, Contraseña);

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

        public VendedorEntity ConsultarVendedor(int ID_vendedor)
        {
            DataVendedor db = new DataVendedor();
            VendedorEntity vendedor = db.ConsultarVendedor(ID_vendedor);

            return vendedor;
        }

        public List<VendedorEntity> MostrarVendedores()
        {
            DataVendedor db = new DataVendedor();
            List<VendedorEntity> clientes = db.MostrarVendedores();

            return clientes;
        }

        public string ActualizarVendedor(int ID_vendedor, string Nombre_vendedor, string Email, string Telefono, decimal Salario, string Contraseña)
        {
            string resultado = "";
            DataVendedor db = new DataVendedor();
            int filasAfectadas = db.ActualizarVendedor(ID_vendedor, Nombre_vendedor, Email, Telefono, Salario, Contraseña);

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

        public string EliminarVendedor(int ID_vendedor)
        {
            string resultado = "";
            DataVendedor db = new DataVendedor();
            int filasAfectadas = db.EliminarVendedor(ID_vendedor);

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
