using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.DataEntities;
using Modelo.Entities;

namespace Logica.Controller
{
    public class ClienteController
    {

        public List<ClienteEntity> ConsultarCliente()
        {
            DataCliente db = new DataCliente();
            List<ClienteEntity> clientes = db.MostrarCliente();

            return clientes;
        }

        public string RegistrarCliente(string ID_cliente, string Nombre_cliente, string Email, string Telefono)
        {
            string resultado = "";
            DataCliente db = new DataCliente();
            int filasAfectadas = db.RegistrarCliente(ID_cliente, Nombre_cliente, Email, Telefono);

            if (filasAfectadas > 0)
            {
                resultado = "Guardado";

            }
            else
            {
                resultado = "No guardado";
            }

            return resultado;
        }

    }
}
