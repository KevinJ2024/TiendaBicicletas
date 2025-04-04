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

        public ClienteEntity ConsultarCliente(int ID_cliente)
        {
            DataCliente db = new DataCliente();
            ClienteEntity cliente = db.ConsultarCliente(ID_cliente);

            return cliente;
        }

        public string RegistrarCliente(int ID_cliente, string Nombre_cliente, string Email, string Telefono, string Contraseña)
        {
            string resultado = "";
            DataCliente db = new DataCliente();
            int filasAfectadas = db.RegistrarCliente( ID_cliente, Nombre_cliente, Email, Telefono, Contraseña);

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
