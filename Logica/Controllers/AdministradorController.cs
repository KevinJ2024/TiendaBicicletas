using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.DataEntities;
using Modelo.Entities;

namespace Logica.Controllers
{
    public class AdministradorController
    {

        public AdministradorEntity ConsultarAdmin(int ID_admin)
        {

            DataAdmin db = new DataAdmin();

            AdministradorEntity admin = db.ConsultarAdmin(ID_admin);

            return admin;
        }

        public string RegistrarAdmin(int ID_admin, string Nombre_admin, string Email, string Telefono, string Contraseña)
        {
            string resultado = "";

            DataAdmin db = new DataAdmin();
            int filasAfectadas = db.RegistrarAdmin(ID_admin, Nombre_admin, Email, Telefono, Contraseña);


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
