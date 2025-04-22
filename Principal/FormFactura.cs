using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Entities;
using Logica.Controllers;
using MySqlX.XDevAPI;

namespace Principal
{
    public partial class FormFactura : Form
    {
        public FormFactura(FacturaEntity factura, List<ProductoFacturaEntity> productoFacturas)
        {
            InitializeComponent();
            ClienteController ClienteController = new ClienteController();
            var cliente = ClienteController.ConsultarCliente(factura.ID_cliente);

            VendedorController VendedorController = new VendedorController();
            var vendedor = VendedorController.ConsultarVendedor(factura.ID_vendedor);

            lbCliente.Text = cliente.Nombre_cliente;
            lbVendedor.Text = vendedor.Nombre_vendedor;
            MostrarProductos(productoFacturas);
            lbFecha.Text = factura.Fecha.ToString();
            lbTotal.Text = factura.Total.ToString();
        }

        public void MostrarProductos(List<ProductoFacturaEntity> productoFacturas)
        {
            string resultado = "";
            ProductoController ProductoController = new ProductoController();
            foreach (var ProductoFacturaActual in productoFacturas)
            {
                var producto = ProductoController.ConsultarProducto(ProductoFacturaActual.ID_producto);
                resultado += "ID_Producto: " + producto.ID_producto + "---Nombre: " + producto.Nombre_producto + "---Precio: " + producto.Precio_producto + "---Descripcion" + producto.Descripcion + "---Imagen: " + producto.Imagen + "\n";
            }
            lbProductos.Text = resultado;
        }
    }
}
