using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Logica.Controllers;

namespace Principal
{
    public partial class FormActualizar : Form
    {

        private string entidad;
        public TextBox tbSalario;
        public TextBox tbPrecio_producto;
        public TextBox tbStock;
        public TextBox tbDescripcion_producto;
        public PictureBox pbImagen;
        public byte[] imagenSeleccionada;

        public FormActualizar(string entidad)
        {
            InitializeComponent();
            lbTitle.Text += entidad;

            this.entidad = entidad;
            tbID.PlaceholderText += entidad;
            tbNombre.PlaceholderText += entidad;

            ModificarFormularioPorEntidad();
        }

        private void ModificarFormularioPorEntidad()
        {
            switch (entidad)
            {
                case "Vendedor":
                    lbTitle.Location = new Point(262, 59);
                    tbSalario = new TextBox();
                    tbSalario.Name = "tbSalario";
                    tbSalario.Location = new Point(304, 300);
                    tbSalario.Size = new Size(195, 23);
                    tbSalario.PlaceholderText = "Ingrese el salario";

                    this.Controls.Add(tbSalario);
                    break;

                case "Producto":
                    this.Controls.Remove(tbEmail);
                    tbEmail.Dispose();
                    this.Controls.Remove(tbTelefono);
                    tbTelefono.Dispose();
                    this.Controls.Remove(tbContraseña);
                    tbContraseña.Dispose();

                    btnBuscarEntidad.Location = new Point(200, 112);
                    lbTitle.Location = new Point(272, 59);
                    tbID.Location = new Point(282, 112);
                    tbNombre.Location = new Point(282, 148);


                    tbPrecio_producto = new TextBox();
                    tbPrecio_producto.Location = new Point(282, 180);
                    tbPrecio_producto.Name = "tbPrecio_producto";
                    tbPrecio_producto.PlaceholderText = "Precio del producto";
                    tbPrecio_producto.Size = new Size(195, 23);
                    tbPrecio_producto.TabIndex = 2;

                    tbStock = new TextBox();
                    tbStock.Location = new Point(282, 210);
                    tbStock.Name = "tbStock";
                    tbStock.PlaceholderText = "Stock del producto";
                    tbStock.Size = new Size(195, 23);
                    tbStock.TabIndex = 3;

                    tbDescripcion_producto = new TextBox();
                    tbDescripcion_producto.Location = new Point(282, 240);
                    tbDescripcion_producto.Name = "tbDescripcion_producto";
                    tbDescripcion_producto.PlaceholderText = "descripcion del producto";
                    tbDescripcion_producto.Size = new Size(195, 23);
                    tbDescripcion_producto.TabIndex = 4;

                    Button btnSeleccionar_Imagen = new Button();
                    btnSeleccionar_Imagen.Location = new Point(282, 270);
                    btnSeleccionar_Imagen.Name = "btnSeleccionar_Imagen";
                    btnSeleccionar_Imagen.Size = new Size(195, 30);
                    btnSeleccionar_Imagen.Text = "Seleccionar Imagen";
                    btnSeleccionar_Imagen.Click += new EventHandler(btnSeleccionar_Imagen_Click);
                    tbDescripcion_producto.TabIndex = 5;



                    this.Controls.Add(tbPrecio_producto);
                    this.Controls.Add(tbStock);
                    this.Controls.Add(tbDescripcion_producto);
                    this.Controls.Add(btnSeleccionar_Imagen);
                    break;

                case "Proveedor":
                    this.Controls.Remove(tbContraseña);
                    tbContraseña.Dispose();
                    break;

                case "Factura":
                    this.Controls.Remove(tbID);
                    tbID.Dispose();
                    this.Controls.Remove(tbNombre);
                    tbNombre.Dispose();
                    this.Controls.Remove(tbEmail);
                    tbEmail.Dispose();
                    this.Controls.Remove(tbTelefono);
                    tbTelefono.Dispose();

                    TextBox tbID_cliente = new TextBox();
                    tbID_cliente.Location = new Point(282, 170);
                    tbID_cliente.Name = "tbID_cliente";
                    tbID_cliente.PlaceholderText = "ID_cliente";
                    tbID_cliente.Size = new Size(195, 23);
                    tbID_cliente.TabIndex = 1;

                    TextBox tbID_vendedor = new TextBox();
                    tbID_vendedor.Location = new Point(282, 220);
                    tbID_vendedor.Name = "tbID_vendedor";
                    tbID_vendedor.PlaceholderText = "ID_vendedor";
                    tbID_vendedor.Size = new Size(195, 23);
                    tbID_vendedor.TabIndex = 2;

                    TextBox tbID_producto = new TextBox();
                    tbID_producto.Location = new Point(282, 270);
                    tbID_producto.Name = "tbID_Producto";
                    tbID_producto.PlaceholderText = "ID_producto";
                    tbID_producto.Size = new Size(195, 23);
                    tbID_producto.TabIndex = 3;


                    this.Controls.Add(tbID_cliente);
                    this.Controls.Add(tbID_vendedor);
                    this.Controls.Add(tbID_producto);
                    break;

                default:

                    break;
            }
        }

        private void btnBuscarEntidad_Click(object sender, EventArgs e)
        {
            string resultado;
            switch (entidad)
            {
                case "Cliente":
                    ClienteController ClienteController = new ClienteController();
                    var cliente = ClienteController.ConsultarCliente(int.Parse(tbID.Text));
                    resultado = "";

                    tbNombre.Text = cliente.Nombre_cliente;
                    tbEmail.Text = cliente.Email;
                    tbTelefono.Text = cliente.Telefono;
                    tbContraseña.Text = cliente.Contraseña;

                    lbResultado.Text = resultado;
                    break;
                case "Vendedor":
                    VendedorController VendedorController = new VendedorController();
                    var vendedor = VendedorController.ConsultarVendedor(int.Parse(tbID.Text));
                    resultado = "";

                    tbNombre.Text = vendedor.Nombre_vendedor;
                    tbEmail.Text = vendedor.Email;
                    tbTelefono.Text = vendedor.Telefono;
                    tbSalario.Text = vendedor.Salario.ToString();
                    tbContraseña.Text = vendedor.Contraseña;

                    break;
                case "Producto":
                    ProductoController ProductoController = new ProductoController();
                    var producto = ProductoController.ConsultarProducto(int.Parse(tbID.Text));
                    resultado = "";

                    tbNombre.Text = producto.Nombre_producto;
                    tbPrecio_producto.Text = producto.Precio_producto.ToString();
                    tbStock.Text = producto.Stock.ToString();
                    tbDescripcion_producto.Text = producto.Descripcion;
                    MostrarImagen(producto.Imagen);

                    break;

                case "Proveedor":
                    ProveedorController ProveedorController = new ProveedorController();
                    var proveedor = ProveedorController.ConsultarProveedor(int.Parse(tbID.Text));
                    resultado = "";

                    tbNombre.Text = proveedor.Nombre_proveedor;
                    tbEmail.Text = proveedor.Email;
                    tbTelefono.Text = proveedor.Telefono;

                    break;

                default:
                    lbResultado.Text = "algo salio mal";
                    break;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string resultado;
            switch (entidad)
            {
                case "Cliente":
                    ClienteController Clientecontroller = new ClienteController();
                    resultado = Clientecontroller.ActualizarCliente(int.Parse(tbID.Text), tbNombre.Text, tbEmail.Text, tbTelefono.Text, tbContraseña.Text);
                    lbResultado.Text = resultado;
                    break;
                case "Vendedor":
                    VendedorController VendedorController = new VendedorController();
                    resultado = VendedorController.ActualizarVendedor(int.Parse(tbID.Text), tbNombre.Text, tbEmail.Text, tbTelefono.Text, decimal.Parse(tbSalario.Text), tbContraseña.Text);
                    lbResultado.Text = resultado;
                    break;
                case "Producto":
                    ProductoController ProductoController = new ProductoController();
                    resultado = ProductoController.ActualizarProducto(int.Parse(tbID.Text), tbNombre.Text, decimal.Parse(tbPrecio_producto.Text), int.Parse(tbStock.Text), tbDescripcion_producto.Text, imagenSeleccionada);
                    lbResultado.Text = resultado;
                    break;
                case "Proveedor":
                    ProveedorController ProveedorController = new ProveedorController();
                    resultado = ProveedorController.ActualizarProveedor(int.Parse(tbID.Text), tbNombre.Text, tbEmail.Text, tbTelefono.Text);
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
            tbNombre.Text = "";
            tbEmail.Text = "";
            tbTelefono.Text = "";
            tbContraseña.Text = "";
            if (tbSalario != null)
            {
                tbSalario.Text = "";

            }
            else if (tbPrecio_producto != null || tbStock != null || tbDescripcion_producto != null || pbImagen.Image != null) // fallita en la verificacion de la imagen
            {
                tbPrecio_producto.Text = "";
                tbStock.Text = "";
                tbDescripcion_producto.Text = "";
                pbImagen.Image = null;
            }
        }

        private void btnSeleccionar_Imagen_Click(object sender, EventArgs e)
        {
            pbImagen = this.Controls["pbImagen"] as PictureBox;

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

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar Imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                pbImagen.Image = Image.FromFile(rutaImagen);

                using (MemoryStream ms = new MemoryStream())
                {
                    pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
                    imagenSeleccionada = ms.ToArray();
                }
            }
        }

        private void MostrarImagen(byte[] imagen)
        {
            pbImagen = this.Controls["pbImagen"] as PictureBox;

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
