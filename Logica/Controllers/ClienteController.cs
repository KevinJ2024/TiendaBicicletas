using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.DataEntities;
using Modelo.Entities;

namespace Logica.Controllers
{
    public class ClienteController
    {

        public string RegistrarCliente(int ID_cliente, string Nombre_cliente, string Email, string Telefono, string Contraseña)
        {
            string resultado = "";
            DataCliente db = new DataCliente();
            int filasAfectadas = db.RegistrarCliente(ID_cliente, Nombre_cliente, Email, Telefono, Contraseña);

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

        public ClienteEntity ConsultarCliente(int ID_cliente)
        {
            DataCliente db = new DataCliente();
            ClienteEntity cliente = db.ConsultarCliente(ID_cliente);

            return cliente;
        }

        public List<ClienteEntity> MostrarClientes()
        {
            DataCliente db = new DataCliente();
            List<ClienteEntity> clientes = db.MostrarClientes();

            return clientes;
        }

        public string ActualizarCliente(int ID_cliente, string Nombre_cliente, string Email, string Telefono, string Contraseña)
        {
            string resultado = "";
            DataCliente db = new DataCliente();
            int filasAfectadas = db.ActualizarCliente(ID_cliente, Nombre_cliente, Email, Telefono, Contraseña);

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

        public string EliminarCliente(int ID_cliente)
        {
            string resultado = "";
            DataCliente db = new DataCliente();
            int filasAfectadas = db.EliminarCliente(ID_cliente);

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
