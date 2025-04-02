using Modelo;
using Modelo.DataEntities;
using Modelo.Entities;
using System;

namespace Logica.Controllers.InicioController
{
    public class LoginController
    {
        private DataCliente cliente;
        private DataAdmin admin;


        public string Login(string Email, string Contraseña)
        {
  
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Contraseña))
            {
                return "El correo y la contraseña no pueden estar vacíos.";
            }

            try
            {
                admin = new DataAdmin();
                cliente = new DataCliente();
              bool  adminExistente = admin.VerificarAdmin(Email, Contraseña);
              bool usuarioExiste = cliente.VerificarCliente(Email, Contraseña);

                if (adminExistente)
                {
                    return "Login exitoso. Bienvenido administrador.";
                }
                else  if (usuarioExiste)
                {
                    return "Login exitoso. Bienvenido cliente.";
                }
                else
                {
                    return "El correo o la contraseña son incorrectos.";
                }
            }
            catch (Exception ex)
            {
                return "Hubo un error al intentar iniciar sesión. Intente nuevamente más tarde.";
            }
        }
    }
}
