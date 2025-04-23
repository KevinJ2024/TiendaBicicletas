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
using Modelo.Entities;
using MySqlX.XDevAPI;

namespace Principal
{
    public partial class FormConsultar : FormBase
    {

        public string entidad;

        public FormConsultar(string entidad)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
                        resultado += "ID: " + clienteActual.ID_cliente + "\nNombre: " + clienteActual.Nombre_cliente + "\nEmail: " + clienteActual.Email + "\nTelefono: " + clienteActual.Telefono + "\nContraseña: " + clienteActual.Contraseña + "\n\n\n\n\n\n\n\n";
                    }
                    lbResultado.Text = resultado;
                    break;

                case "Vendedor":
                    VendedorController VendedorController = new VendedorController();
                    var vendedores = VendedorController.MostrarVendedores();
                    resultado = "";

                    foreach (var vendedorActual in vendedores)
                    {
                        resultado += "ID: " + vendedorActual.ID_vendedor + "\nNombre: " + vendedorActual.Nombre_vendedor + "\nEmail: " + vendedorActual.Email + "\nTelefono: " + vendedorActual.Telefono + "\nSalario: " + vendedorActual.Salario + "\nContraseña: " + vendedorActual.Contraseña + "\n\n\n\n\n\n\n\n";
                    }
                    lbResultado.Text = resultado;
                    break;

                case "Producto":
                    List<byte[]> listaDeImagenes = new List<byte[]>();
                    ProductoController ProductoController = new ProductoController();
                    var productos = ProductoController.MostrarProductos();
                    resultado = "";

                    foreach (var productoActual in productos)
                    {
                        resultado += "ID: " + productoActual.ID_producto + "\nNombre: " + productoActual.Nombre_producto + "\nPrecio_producto: " + productoActual.Precio_producto + "\nStock: " + productoActual.Stock + "\nDescripcion: " + productoActual.Descripcion + "\n\n\n\n\n\n\n\n";
                        listaDeImagenes.Add(productoActual.Imagen);
                    }
                    MostrarImagenes(listaDeImagenes);
                    lbResultado.Text = resultado;
                    break;

                case "Proveedor":
                    ProveedorController ProveedorController = new ProveedorController();
                    var proveedores = ProveedorController.MostrarProveedores();
                    resultado = "";

                    foreach (var proveedorActual in proveedores)
                    {
                        resultado += "ID: " + proveedorActual.ID_proveedor + "\nNombre: " + proveedorActual.Nombre_proveedor + "\nEmail: " + proveedorActual.Email + "\nTelefono: " + proveedorActual.Telefono + "\n\n\n\n\n\n\n\n";
                    }
                    lbResultado.Text = resultado;
                    break;

                case "Factura":
                    FacturaController FacturaController = new FacturaController();
                    var facturas = FacturaController.MostrarFacturas();
                    resultado = "";

                    foreach (var FacturaActual in facturas)
                    {
                        resultado += "ID_factura: " + FacturaActual.ID_factura + "\nID_cliente: " + FacturaActual.ID_cliente + "\nID_vendedor: " + FacturaActual.ID_vendedor + "\nFecha: " + FacturaActual.Fecha + "\nTotal: " + FacturaActual.Total+ "\n\n\n\n\n\n\n\n";
                    }
                    lbResultado.Text = resultado;
                    break;

                default:

                    break;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbID.Text, out _))
            {
                MessageBox.Show("verifica que el ID sea numerico entero");
            }
            else
            {
                switch (entidad)
                {
                    case "Cliente":
                        ClienteController ClienteController = new ClienteController();
                        var cliente = ClienteController.ConsultarCliente(int.Parse(tbID.Text));
                        string resultado = "";

                        resultado += "ID: " + cliente.ID_cliente + "\nNombre: " + cliente.Nombre_cliente + "\nEmail: " + cliente.Email + "\nTelefono: " + cliente.Telefono + "\nContraseña: " + cliente.Contraseña + "\n\n\n\n";

                        lbResultado.Text = resultado;
                        break;

                    case "Vendedor":
                        VendedorController VendedorController = new VendedorController();
                        var vendedor = VendedorController.ConsultarVendedor(int.Parse(tbID.Text));
                        resultado = "";

                        resultado += "ID: " + vendedor.ID_vendedor + "\nNombre: " + vendedor.Nombre_vendedor + "\nEmail: " + vendedor.Email + "\nTelefono: " + vendedor.Telefono + "\nSalario: " + vendedor.Salario + "\nContraseña: " + vendedor.Contraseña + "\n\n\n\n";

                        lbResultado.Text = resultado;
                        break;

                    case "Producto":
                        EliminarTodosLosPictureBox();
                        List<byte[]> listaDeImagenes = new List<byte[]>();
                        ProductoController ProductoController = new ProductoController();
                        var producto = ProductoController.ConsultarProducto(int.Parse(tbID.Text));
                        resultado = "";
                        resultado += "ID: " + producto.ID_producto + "\nNombre: " + producto.Nombre_producto + "\nPrecio: " + producto.Precio_producto + "\nStock: " + producto.Stock + "\nDescripcion: " + producto.Descripcion + "\n\n\n\n";
                        listaDeImagenes.Add(producto.Imagen);
                        MostrarImagenes(listaDeImagenes);
                        lbResultado.Text = resultado;
                        break;

                    case "Proveedor":
                        ProveedorController ProveedorController = new ProveedorController();
                        var proveedor = ProveedorController.ConsultarProveedor(int.Parse(tbID.Text));
                        resultado = "";

                        resultado += "ID: " + proveedor.ID_proveedor + "\nNombre: " + proveedor.Nombre_proveedor + "\nEmail: " + proveedor.Email + "\nTelefono: " + proveedor.Telefono + "\n\n\n\n";

                        lbResultado.Text = resultado;
                        break;

                    case "Factura":
                        FacturaController FacturaController = new FacturaController();
                        var factura = FacturaController.ConsultarFactura(int.Parse(tbID.Text));
                        resultado = "";

                        resultado += "ID_factura: " + factura.ID_factura + "\nID_cliente: " + factura.ID_cliente + "\nID_vendedor: " + factura.ID_vendedor + "\nFecha: " + factura.Fecha + "\nTotal: " + factura.Total + "\n\n\n\n";
                        lbResultado.Text = resultado;

                        ProductoFacturaController ProductoFacturaController = new ProductoFacturaController();
                        var productosfacturas = ProductoFacturaController.ConsultarProductosFacturas(int.Parse(tbID.Text));
                        this.Hide();
                        FormFactura us = new FormFactura(factura, productosfacturas);
                        us.ShowDialog();
                        this.Show();

                        
                        break;

                    default:
                        lbResultado.Text = "algo salio mal";
                        break;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            EliminarTodosLosPictureBox();
            MostrarEntidades();
        }
    }
}
