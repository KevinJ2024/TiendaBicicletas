using Modelo;
using Modelo.DataEntities;

namespace Logica.Controllers.InicioController
{
    public class LoginController
    {
        public string Login(string Email, string Contraseña)
        {
            DataCliente cliente = new DataCliente();

            bool usuarioExiste = cliente.VerificarCliente(Email, Contraseña);

            if (usuarioExiste)
            {
                string yes = "Login exitoso. Usuario encontrado";
                return yes;
            }
            else
            {
                string no = "El correo o la contraseña son incorrectos.";
                return no;
            }
        }
    }
}
