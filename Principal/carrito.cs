using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logica.Controllers;

namespace Principal
{
    public partial class carrito : FormBase
    {
        private int _idCliente;

        public carrito(int ID_cliente)
        {
            InitializeComponent();
            _idCliente = ID_cliente;

            // Cargar el historial de productos al iniciar el formulario
            CargarHistorialDeProductos();
        }

        /// <summary>
        /// Método para obtener y mostrar los productos en el carrito del cliente.
        /// </summary>
        private void CargarHistorialDeProductos()
        {
            try
            {
                ProductoController productoController = new ProductoController();
                var productos = productoController.MostrarProductos();

                string resultado = string.Empty;
                List<byte[]> listaDeImagenes = new List<byte[]>();

                foreach (var producto in productos)
                {
                    resultado += $"ID: {producto.ID_producto} --- Nombre: {producto.Nombre_producto} --- " +
                                 $"Precio: {producto.Precio_producto} --- Stock: {producto.Stock} --- " +
                                 $"Descripción: {producto.Descripcion}\n\n";

                    listaDeImagenes.Add(producto.Imagen);
                }

                MostrarImagen(listaDeImagenes);
                label1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
