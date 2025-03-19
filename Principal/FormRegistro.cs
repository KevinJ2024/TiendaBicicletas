using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                case "Cliente":

                    break;

                case "Vendedor":
                    TextBox tbSalario = new TextBox();
                    tbSalario.Name = "tbSalario";  
                    tbSalario.Location = new Point(282, 300); 
                    tbSalario.Size = new Size(195, 23);  
                    tbSalario.PlaceholderText = "Ingrese el salario";

                    this.Controls.Add(tbSalario);
                    break;

                case "Producto":
                    

                    break;

                case "Factura":

                    this.Controls.Remove(tbNombre);
                    tbNombre.Dispose();
                    this.Controls.Remove(tbEmail);
                    tbNombre.Dispose();
                    this.Controls.Remove(tbTelefono);
                    tbNombre.Dispose();

                    TextBox tbID_cliente = new TextBox();
                    tbID_cliente.Location = new Point(282, 120);
                    tbID_cliente.Name = "tbID_cliente";
                    tbID_cliente.PlaceholderText = "ID_cliente";
                    tbID_cliente.Size = new Size(195, 23);
                    tbID_cliente.TabIndex = 5;

                    TextBox tbID_vendedor = new TextBox();
                    tbID_vendedor.Location = new Point(282, 160);
                    tbID_vendedor.Name = "tbID_vendedor";
                    tbID_vendedor.PlaceholderText = "ID_vendedor";
                    tbID_vendedor.Size = new Size(195, 23);
                    tbID_vendedor.TabIndex = 3;

                    TextBox tbID_producto = new TextBox();
                    tbID_producto.Location = new Point(282, 200);
                    tbID_producto.Name = "tbID_Producto";
                    tbID_producto.PlaceholderText = "ID_producto";
                    tbID_producto.Size = new Size(195, 23);
                    tbID_producto.TabIndex = 4;

         
                    this.Controls.Add(tbID_cliente);
                    this.Controls.Add(tbID_vendedor);
                    this.Controls.Add(tbID_producto);
                    break;

                default: 
                     
                    break;
            }   
        }
    }
}

