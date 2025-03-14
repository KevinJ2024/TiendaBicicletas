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
                    this.Controls.Remove(tbNombre);
                    tbNombre.Dispose(); 

                    TextBox tbID_cliente = new TextBox();
                    tbID_cliente.Location = new Point(282, 152);
                    tbID_cliente.Name = "tbID_cliente";
                    tbID_cliente.PlaceholderText = "ID_cliente";
                    tbID_cliente.Size = new Size(195, 23);
                    tbID_cliente.TabIndex = 5;

                    break;

                case "Factura":

                    break;

                default: 
                     
                    break;
            }   
        }
    }
}

