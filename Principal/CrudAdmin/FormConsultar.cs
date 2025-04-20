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
                        resultado += "ID: " + productoActual.ID_producto + "---Nombre: " + productoActual.Nombre_producto + "---Precio_producto: " + productoActual.Precio_producto + "---Stock: " + productoActual.Stock + "---Descripcion: " + productoActual.Descripcion + "--- Imagen: " + productoActual.Imagen + "\n";
                    }
                    lbResultado.Text = resultado;
                    break;

                case "Proveedor":
                    ProveedorController ProveedorController = new ProveedorController();
                    var proveedores = ProveedorController.MostrarProveedores();
                    resultado = "";

                    foreach (var proveedorActual in proveedores)
                    {
                        resultado += "ID: " + proveedorActual.ID_proveedor + "---Nombre: " + proveedorActual.Nombre_proveedor + "---Email: " + proveedorActual.Email + "---Telefono: " + proveedorActual.Telefono +"\n";
                    }
                    lbResultado.Text = resultado;
                    break;

                case "Factura":
                    FacturaController FacturaController = new FacturaController();
                    var facturas = FacturaController.MostrarFacturas();
                    resultado = "";

                    foreach (var FacturaActual in facturas)
                    {
                        resultado += "ID_factura: " + FacturaActual.ID_factura + "---ID_cliente: " + FacturaActual.ID_cliente + "---ID_vendedor: " + FacturaActual.ID_vendedor + "---Fecha: " + FacturaActual.Fecha + "---Total: " +FacturaActual.Total+ "\n";
                    }
                    lbResultado.Text = resultado;
                    break;

                case "ProductoFactura":
                    ProductoFacturaController ProductoFacturaController = new ProductoFacturaController();
                    var productosfacturas = ProductoFacturaController.MostrarProductoFactura();
                    resultado = "";

                    foreach (var productoFacturaActual in productosfacturas)
                    {
                        resultado += "ID_productofactura: " + productoFacturaActual.ID_productofactura + "---ID_factura: " + productoFacturaActual.ID_factura + "---ID_producto: " + productoFacturaActual.ID_producto + "---Cantidad: " + productoFacturaActual.Cantidad + "\n";
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
                lbResultado.Text = "Verifica que el ID sea de tipo numerico entero";
            }
            else
            {
                switch (entidad)
                {
                    case "Cliente":
                        ClienteController ClienteController = new ClienteController();
                        var cliente = ClienteController.ConsultarCliente(int.Parse(tbID.Text));
                        string resultado = "";

                        resultado += "ID: " + cliente.ID_cliente + "---Nombre: " + cliente.Nombre_cliente + "---Email: " + cliente.Email + "---Telefono: " + cliente.Telefono + "--- Contraseña: " + cliente.Contraseña + "\n";

                        lbResultado.Text = resultado;
                        break;

                    case "Vendedor":
                        VendedorController VendedorController = new VendedorController();
                        var vendedor = VendedorController.ConsultarVendedor(int.Parse(tbID.Text));
                        resultado = "";

                        resultado += "ID: " + vendedor.ID_vendedor + "---Nombre: " + vendedor.Nombre_vendedor + "---Email: " + vendedor.Email + "---Telefono: " + vendedor.Telefono + "---Salario: " + vendedor.Salario + "--- Contraseña: " + vendedor.Contraseña + "\n";

                        lbResultado.Text = resultado;
                        break;

                    case "Producto":
                        ProductoController ProductoController = new ProductoController();
                        var producto = ProductoController.ConsultarProducto(int.Parse(tbID.Text));
                        resultado = "";
                        resultado += "ID: " + producto.ID_producto + "---Nombre: " + producto.Nombre_producto + "---Precio: " + producto.Precio_producto + "---Stock: " + producto.Stock + "---Descripcion: " + producto.Descripcion + "\n";
                        MostrarImagen(producto.Imagen);
                        lbResultado.Text = resultado;
                        break;

                    case "Proveedor":
                        ProveedorController ProveedorController = new ProveedorController();
                        var proveedor = ProveedorController.ConsultarProveedor(int.Parse(tbID.Text));
                        resultado = "";

                        resultado += "ID: " + proveedor.ID_proveedor + "---Nombre: " + proveedor.Nombre_proveedor + "---Email: " + proveedor.Email + "---Telefono: " + proveedor.Telefono + "\n";

                        lbResultado.Text = resultado;
                        break;

                    case "Factura":
                        FacturaController FacturaController = new FacturaController();
                        var factura = FacturaController.ConsultarFactura(int.Parse(tbID.Text));
                        resultado = "";

                        resultado += "ID_factura: " + factura.ID_factura + "---ID_cliente: " + factura.ID_cliente + "---ID_vendedor: " + factura.ID_vendedor + "---Fecha: " + factura.Fecha + "---Total: " + factura.Total + "\n";
                        lbResultado.Text = resultado;
                        break;

                    case "ProductoFactura":
                        ProductoFacturaController ProductoFacturaController = new ProductoFacturaController();
                        var productosfacturas = ProductoFacturaController.ConsultarProductosFacturas(int.Parse(tbID.Text));
                        resultado = "";

                        foreach (var productoFacturaActual in productosfacturas)
                        {
                            resultado += "ID_productofactura: " + productoFacturaActual.ID_productofactura + "---ID_factura: " + productoFacturaActual.ID_factura + "---ID_producto: " + productoFacturaActual.ID_producto + "---Cantidad: " + productoFacturaActual.Cantidad + "\n";
                        }
                        lbResultado.Text = resultado;
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
            MostrarEntidades();
        }

        private void MostrarImagen(byte[] imagen)
        {
            PictureBox pbImagen = this.Controls["pbImagen"] as PictureBox;

            if (pbImagen == null)
            {
                pbImagen = new PictureBox();
                pbImagen.Location = new Point(500, 140);
                pbImagen.Name = "pbImagen";
                pbImagen.Size = new Size(195, 195);
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen.TabIndex = 6;
                this.Controls.Add(pbImagen);
            }

            if (imagen != null && imagen.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagen))
                {
                    try
                    {
                        pbImagen.Image = Image.FromStream(ms);  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay imagen disponible para mostrar.");
                pbImagen.Image = null; 
            }
        }
    }
}
