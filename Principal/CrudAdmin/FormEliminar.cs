using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Controllers;

namespace Principal
{
    public partial class FormEliminar : FormBase
    {

        public string entidad;

        public FormEliminar(string entidad)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            lbTitle.Text += entidad;
            tbID.PlaceholderText += entidad;

            this.entidad = entidad;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string resultado;
            switch (entidad)
            {
                case "Cliente":
                    ClienteController ClienteController = new ClienteController();
                     resultado = ClienteController.EliminarCliente(int.Parse(tbID.Text));
                    lbResultado.Text = resultado;
                    break;
                case "Vendedor":
                    VendedorController VendedorController = new VendedorController();
                    resultado = VendedorController.EliminarVendedor(int.Parse(tbID.Text));
                    lbResultado.Text = resultado;
                    break;
                case "Producto":
                    ProductoController ProductoController = new ProductoController();
                    resultado = ProductoController.EliminarProducto(int.Parse(tbID.Text));
                    lbResultado.Text = resultado;
                    break;
                case "Proveedor":
                    ProveedorController ProveedorController = new ProveedorController();
                    resultado = ProveedorController.EliminarProveedor(int.Parse(tbID.Text));
                    lbResultado.Text = resultado;
                    break;
                default:
                    lbResultado.Text = "algo salio mal";
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
        }
    }
}
