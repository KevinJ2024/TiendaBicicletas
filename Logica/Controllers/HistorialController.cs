using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DataEntities;

namespace Logica.Controllers
{
    public class HistorialController
    {


        public string IngresarProducto(int ID_Cliente, int ID_Producto)
        {
            string resultado = "";
            DataHistorial db = new DataHistorial();
            int filasAfectadas = db.IngresarProducto(ID_Cliente, ID_Producto);

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
    }
}
