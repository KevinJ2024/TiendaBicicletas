using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Controllers;
using MySqlX.XDevAPI;

namespace Principal
{
    public partial class FormConsultar : Form
    {

        public string entidad;

        public FormConsultar(string entidad)
        {
            InitializeComponent();
            lbTitle.Text += entidad;
            tbID.PlaceholderText += entidad;

            this.entidad = entidad;
            MostrarEntidades();
        }

        private void MostrarEntidades()
        {
            string resultado;
            switch (entidad)
            {
                case "Cliente":
                    ClienteController Clientecontroller = new ClienteController();
                    var clientes = Clientecontroller.MostrarClientes();
                    resultado = "";

                    foreach (var clienteActual in clientes)
                    {
                        resultado += "ID: " + clienteActual.ID_cliente + "---Nombre: " + clienteActual.Nombre_cliente + "---Email: " + clienteActual.Email + "---Telefono: " + clienteActual.Telefono + "--- Contraseña: " + clienteActual.Contraseña + "\n";
                    }
                    lbResultado.Text = resultado;
                    break;

                case "Vendedor":
                    VendedorController VendedorController = new VendedorController();
                    var vendedores = VendedorController.MostrarVendedores();
                    resultado = "";

                    foreach (var vendedorActual in vendedores)
                    {
                        resultado += "ID: " + vendedorActual.ID_vendedor + "---Nombre: " + vendedorActual.Nombre_vendedor + "---Email: " + vendedorActual.Email + "---Telefono: " + vendedorActual.Telefono + "---Salario: " + vendedorActual.Salario + "--- Contraseña: " + vendedorActual.Contraseña + "\n";
                    }
                    lbResultado.Text = resultado;
                    break;

                case "Producto":
                    ProductoController ProductoController = new ProductoController();
                    var productos = ProductoController.MostrarProductos();
                    resultado = "";

                    foreach (var productoActual in productos)
                    {
                        resultado += "ID: " + productoActual.ID_producto + "---Nombre: " + productoActual.Nombre_producto + "---Email: " + productoActual.Precio_producto + "---Telefono: " + productoActual.Stock + "---Salario: " + productoActual.Descripcion + "--- Contraseña: " + productoActual.Imagen + "\n";
                    }
                    lbResultado.Text = resultado;
                    break;
                default:

                    break;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (entidad)
            {
                case "Cliente":
                    ClienteController Clientecontroller = new ClienteController();
                    var cliente = Clientecontroller.ConsultarCliente(int.Parse(tbID.Text));
                    string resultado = "";

                    resultado += "ID: " + cliente.ID_cliente + "---Nombre: " + cliente.Nombre_cliente + "---Email: " + cliente.Email + "---Telefono: " + cliente.Telefono + "--- Contraseña: " + cliente.Contraseña + "\n";

                    lbResultado.Text = resultado;
                    break;

                case "Vendedor":
                    VendedorController Vendedorcontroller = new VendedorController();
                    var vendedor = Vendedorcontroller.ConsultarVendedor(int.Parse(tbID.Text));
                    resultado = "";

                    resultado += "ID: " + vendedor.ID_vendedor + "---Nombre: " + vendedor.Nombre_vendedor + "---Email: " + vendedor.Email + "---Telefono: " + vendedor.Telefono + "---Salario: "+ vendedor.Salario + "--- Contraseña: " + vendedor.Contraseña + "\n";

                    lbResultado.Text = resultado;
                    break;
                case "Producto":
                    ProductoController ProductoController = new ProductoController();
                    var producto = ProductoController.ConsultarProducto(int.Parse(tbID.Text));
                    resultado = "";

                    resultado += "ID: " + producto.ID_producto + "---Nombre: " + producto.Nombre_producto + "---Precio: " + producto.Precio_producto + "---Stock: " + producto.Stock + "---Descripcion: " + producto.Descripcion + "---Imagen: " + producto.Imagen + "\n";
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
            MostrarEntidades();
        }
    }
}
