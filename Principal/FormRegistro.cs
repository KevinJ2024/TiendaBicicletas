using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Controller.InicioController;
using Modelo.Entities;


namespace Principal
{
    public partial class FormRegistro : Form
    {

        public string entidad;

        public FormRegistro(string entidad)
        {
            InitializeComponent();
            lbTitle.Text += entidad;

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
                    TextBox tbSalario = new TextBox();
                    tbSalario.Name = "tbSalario";
                    tbSalario.Location = new Point(282, 300);
                    tbSalario.Size = new Size(195, 23);
                    tbSalario.PlaceholderText = "Ingrese el salario";

                    this.Controls.Add(tbSalario);
                    break;

                case "Producto":
                    this.Controls.Remove(tbID);
                    tbID.Dispose();
                    this.Controls.Remove(tbEmail);
                    tbEmail.Dispose();
                    this.Controls.Remove(tbTelefono);
                    tbTelefono.Dispose();

                    lbTitle.Location = new Point(272, 59);
                    tbNombre.PlaceholderText = "Nombre Producto";
                    tbNombre.Location = new Point(282, 148);
                    TextBox tbPrecio_producto = new TextBox();
                    tbPrecio_producto.Location = new Point(282, 180);
                    tbPrecio_producto.Name = "tbPrecio_producto";
                    tbPrecio_producto.PlaceholderText = "Precio del producto";
                    tbPrecio_producto.Size = new Size(195, 23);
                    tbPrecio_producto.TabIndex = 2;

                    TextBox tbStock = new TextBox();
                    tbStock.Location = new Point(282, 210);
                    tbStock.Name = "tbStock";
                    tbStock.PlaceholderText = "Stock del producto";
                    tbStock.Size = new Size(195, 23);
                    tbStock.TabIndex = 3;

                    TextBox tbDescripcion_producto = new TextBox();
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
                    //btnSeleccionar_Imagen.Click += new EventHandler(btnSeleccionar_Imagen_Click);
                    tbDescripcion_producto.TabIndex = 5;



                    this.Controls.Add(tbPrecio_producto);
                    this.Controls.Add(tbStock);
                    this.Controls.Add(tbDescripcion_producto);
                    this.Controls.Add(btnSeleccionar_Imagen);
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

        //private void btnSeleccionar_Imagen_Click(object sender, EventArgs e)
        //{
        //    PictureBox pbImagen = this.Controls["pbImagen"] as PictureBox;
        //    Label labelPrueba = this.Controls["labelPrueba"] as Label;
        //    if (pbImagen == null)
        //    {
        //        pbImagen = new PictureBox();
        //        pbImagen.Location = new Point(500, 140);
        //        pbImagen.Name = "pbImagen";
        //        pbImagen.Size = new Size(195, 195);
        //        pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        //        pbImagen.TabIndex = 6;
        //        this.Controls.Add(pbImagen);
        //    }

        //    if (labelPrueba == null)
        //    {
        //        labelPrueba = new Label();
        //        labelPrueba.Name = "labelPrueba";
        //        labelPrueba.Location = new Point(500, 400);
        //        labelPrueba.Size = new Size(300, 195);
        //        this.Controls.Add(labelPrueba);
        //    }

        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
        //    openFileDialog.Title = "Seleccionar Imagen";


        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string rutaImagen = openFileDialog.FileName;
        //        pbImagen.Image = Image.FromFile(rutaImagen);
        //        labelPrueba.Text = rutaImagen;
        //    }
        //}

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                ClienteEntity cliente = new ClienteEntity
                {
                    ID_cliente = int.Parse(tbID.Text),
                    Nombre_cliente = tbNombre.Text,
                    Email = tbEmail.Text,
                    Telefono = tbTelefono.Text,
                    Contraseña = tbContraseña.Text
                };

                RegisterController controller = new RegisterController();
                string resultado = controller.register(cliente.ID_cliente, cliente.Nombre_cliente, cliente.Email, cliente.Telefono, cliente.Contraseña);
                lbResult.Text = resultado;

                MessageBox.Show(resultado, "Resultado del Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
               FormPrincipalCliente formPrincipalCliente = new FormPrincipalCliente();
                formPrincipalCliente.ShowDialog();

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo ID.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string entidad;

            
            Entrar entrada = new Entrar();
            entrada.ShowDialog();
        }
    }
}

