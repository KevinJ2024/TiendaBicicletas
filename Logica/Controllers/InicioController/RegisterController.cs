using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Logica.Controllers.InicioController
{
    public class RegisterController
    {
        private ConexionMySql conexion = new ConexionMySql();


        public string register(int ID_cliente, string Nombre_cliente, string Email, string Telefono, string Contraseña)
        {
            ClienteController controller = new ClienteController();
            string resultado = controller.RegistrarCliente(ID_cliente, Nombre_cliente, Email, Telefono, Contraseña);
            return resultado;
        }
    }
}
