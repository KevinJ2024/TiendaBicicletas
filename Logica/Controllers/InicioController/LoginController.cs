using Modelo;
using Modelo.DataEntities;
<<<<<<< HEAD
using Modelo.Entities;
using System;
=======
>>>>>>> ee4cced6066a2a30304e6ef147a90dd2ff44c696

namespace Logica.Controllers.InicioController
{
    public class LoginController
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> ee4cced6066a2a30304e6ef147a90dd2ff44c696
            }
        }
    }
}
