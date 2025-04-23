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
    public partial class FormFactura : FormBase
    {
        public FormFactura(FacturaEntity factura, List<ProductoFacturaEntity> productoFacturas)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ClienteController ClienteController = new ClienteController();
            var cliente = ClienteController.ConsultarCliente(factura.ID_cliente);

            VendedorController VendedorController = new VendedorController();
            var vendedor = VendedorController.ConsultarVendedor(factura.ID_vendedor);

            lbCliente.Text = "Comprador: " + cliente.Nombre_cliente;
            lbVendedor.Text = "Vendedor: " + vendedor.Nombre_vendedor;
            MostrarProductos(productoFacturas);
            lbFecha.Text = "Fecha: " + factura.Fecha.ToString();
            lbTotal.Text = factura.Total.ToString();
        }

        public void MostrarProductos(List<ProductoFacturaEntity> productoFacturas)
        {
            string resultado = "";
            List<byte[]> listaDeImagenes = new List<byte[]>();
            ProductoController ProductoController = new ProductoController();
            foreach (var ProductoFacturaActual in productoFacturas)
            {
                var producto = ProductoController.ConsultarProducto(ProductoFacturaActual.ID_producto);
                resultado += "ID_Producto: " + producto.ID_producto + "\nNombre: " + producto.Nombre_producto + "\nPrecio: " + producto.Precio_producto + "\nDescripcion: " + producto.Descripcion + "\nCantidad: " + ProductoFacturaActual.Cantidad + "\n\n\n\n\n";
                listaDeImagenes.Add(producto.Imagen);
            }
            MostrarImagenesFactura(listaDeImagenes);
            lbProductos.Text = resultado;
        }
    }
}
