using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Logica;
using Logica.Controllers;

namespace Principal
{
    public partial class FormRegistro : Form
    {

        public string entidad;
        public TextBox tbSalario;
        public TextBox tbPrecio_producto;
        public TextBox tbStock;
        public TextBox tbDescripcion_producto;
        public PictureBox pbImagen;
        public byte[] imagenSeleccionada;
        public TextBox tbID_vendedor;
        public TextBox tbID_producto;
        public TextBox tbCantidadProducto;


        public FormRegistro(string entidad)
        {
            InitializeComponent();
            lbTitle.Text += entidad;
            tbID.PlaceholderText += entidad;
            tbNombre.PlaceholderText += entidad;

            this.entidad = entidad;

            ModificarFormularioPorEntidad();
        }

        private void ModificarFormularioPorEntidad()
        {
            switch (entidad)
            {
                case "Vendedor":
                    lbTitle.Location = new Point(262, 59);
                    tbID.PlaceholderText = "ID del vendedor";
                    tbNombre.PlaceholderText = "Nombre Vendedor";
                    tbSalario = new TextBox();
                    tbSalario.Name = "tbSalario";
                    tbSalario.Location = new Point(282, 298);
                    tbSalario.Size = new Size(195, 23);
                    tbSalario.PlaceholderText = "Ingrese el salario";

                    tbContraseña.Location = new Point(282, 340);
                    btnConfirmar.Location = new Point(257, 380);
                    btnCancelar.Location = new Point(388, 380);

                    this.Controls.Add(tbSalario);
                    break;

                case "Producto":
                    this.Controls.Remove(tbID);
                    tbID.Dispose();
                    this.Controls.Remove(tbEmail);
                    tbEmail.Dispose();
                    this.Controls.Remove(tbTelefono);
                    tbTelefono.Dispose();
                    this.Controls.Remove(tbContraseña);
                    tbContraseña.Dispose();

                    lbTitle.Location = new Point(272, 59);
                    tbNombre.PlaceholderText = "Nombre Producto";
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
                    this.Controls.Remove(tbNombre);
                    tbNombre.Dispose();
                    this.Controls.Remove(tbEmail);
                    tbEmail.Dispose();
                    this.Controls.Remove(tbTelefono);
                    tbTelefono.Dispose();
                    this.Controls.Remove(tbContraseña);
                    tbContraseña.Dispose();

                    tbID.Location = new Point(282,180);
                    tbID.PlaceholderText = "ID Cliente";

                    tbID_vendedor = new TextBox();
                    tbID_vendedor.Location = new Point(282, 220);
                    tbID_vendedor.Name = "tbID_vendedor";
                    tbID_vendedor.PlaceholderText = "ID Vendedor";
                    tbID_vendedor.Size = new Size(195, 23);
                    tbID_vendedor.TabIndex = 2;

                    this.Controls.Add(tbID_vendedor);
                    break;

                default:

                    break;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string resultado;
            switch (entidad)
            {
                case "Cliente":
                    ClienteController ClienteController = new ClienteController();
                    if (tbID.Text == "" || tbNombre.Text == "" || tbEmail.Text == "" || tbTelefono.Text == "" || tbContraseña.Text == "" || !int.TryParse(tbID.Text, out _))
                    {
                        lbResultado.Text = "Completa todos los campos y verifica que el ID sea numerico";
                    }
                    else
                    {
                        resultado = ClienteController.RegistrarCliente(int.Parse(tbID.Text), tbNombre.Text, tbEmail.Text, tbTelefono.Text, tbContraseña.Text);
                        lbResultado.Text = resultado;
                    }
                    break;
                case "Vendedor":
                    VendedorController VendedorController = new VendedorController();
                    if (tbID.Text == "" || tbNombre.Text == "" || tbEmail.Text == "" || tbTelefono.Text == "" || tbSalario.Text == "" || tbContraseña.Text == "" || !int.TryParse(tbID.Text, out _))
                    {
                        lbResultado.Text = "Completa todos los campos y verifica que el ID sea numerico";
                    }
                    else
                    {
                        resultado = VendedorController.RegistrarVendedor(int.Parse(tbID.Text), tbNombre.Text, tbEmail.Text, tbTelefono.Text, decimal.Parse(tbSalario.Text), tbContraseña.Text);
                        lbResultado.Text = resultado;
                    }
                    break;

                case "Producto":
                    ProductoController ProductoController = new ProductoController();
                    if (tbNombre.Text == "" || tbPrecio_producto.Text == "" || tbStock.Text == "" || tbDescripcion_producto.Text == "")
                    {
                        lbResultado.Text = "Completa todos los campos";
                    }
                    else
                    {
                        resultado = ProductoController.RegistrarProducto(tbNombre.Text, decimal.Parse(tbPrecio_producto.Text), int.Parse(tbStock.Text), tbDescripcion_producto.Text, imagenSeleccionada);
                        lbResultado.Text = resultado;
                    }
                    break;

                case "Proveedor":
                    ProveedorController ProveedorController = new ProveedorController();
                    if (tbID.Text == "" || tbNombre.Text == "" || tbEmail.Text == "" || tbTelefono.Text == "" || !int.TryParse(tbID.Text, out _))
                    {
                        lbResultado.Text = "Completa todos los campos y verifica que el ID sea numerico";
                    }
                    else
                    {
                        resultado = ProveedorController.RegistrarProveedor(int.Parse(tbID.Text), tbNombre.Text, tbEmail.Text, tbTelefono.Text);
                        lbResultado.Text = resultado;
                    }
                    break;

                case "Factura":
                    DateTime fechaUtc = DateTime.UtcNow;
                    FacturaController FacturaController = new FacturaController();
                    if (tbID.Text == "" || tbID_vendedor.Text == "" || !int.TryParse(tbID.Text, out _) || !int.TryParse(tbID_vendedor.Text, out _))
                    {
                        lbResultado.Text = "Completa todos los campos y verifica que los ID sean numericos";
                    }
                    else
                    { 
                        resultado = FacturaController.RegistrarFactura(int.Parse(tbID.Text), int.Parse(tbID_vendedor.Text), fechaUtc);
                        lbResultado.Text = resultado;
                    }

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
            if (tbSalario != null )
            {
                tbSalario.Text = "";
                
            } else if (tbPrecio_producto != null || tbStock != null || tbDescripcion_producto != null || pbImagen != null) // fallita en la verificacion de la imagen
            {
                tbPrecio_producto.Text = "";
                tbStock.Text = "";
                tbDescripcion_producto.Text = "";
                pbImagen.Image = null;
            }
            string entidad;


            Entrar entrada = new Entrar();
            entrada.ShowDialog();
        }

        private void btnSeleccionar_Imagen_Click(object sender, EventArgs e)
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

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar Imagen";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                pbImagen.Image = Image.FromFile(rutaImagen);
            }
        }
    }
}

