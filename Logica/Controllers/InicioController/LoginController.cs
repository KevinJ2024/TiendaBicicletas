using Modelo;
using Modelo.DataEntities;

namespace Logica.Controllers.InicioController
{
    public class LoginController
    {
        public string Login(string Email, string Contraseña)
        {
            DataCliente cliente = new DataCliente();

            bool adminExistente = cliente.VerificarAdministrador(Email, Contraseña);

            if (adminExistente)
            {
                string yes = "Login exitoso. Administrador encontrado";
                return yes;
            }
            else
            {
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
}
