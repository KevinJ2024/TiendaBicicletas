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
using Logica;
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
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            ClienteController controller = new ClienteController();
            var clientes = controller.MostrarClientes();
            string resultado = "";

            foreach (var clienteActual in clientes)
            {
                resultado += "ID: " + clienteActual.ID_cliente + "---Nombre: " + clienteActual.Nombre_cliente + "---Email: " + clienteActual.Email + "---Telefono: " + clienteActual.Telefono + "--- Contraseña: "+ clienteActual.Contraseña + "\n";
            }
            lbResultado.Text = resultado;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (entidad)
            {
                case "Cliente":
                    ClienteController controller = new ClienteController();
                    var cliente = controller.ConsultarCliente(int.Parse(tbID.Text));
                    string resultado = "";

                    resultado += "ID: " + cliente.ID_cliente + "---Nombre: " + cliente.Nombre_cliente + "---Email: " + cliente.Email + "---Telefono: " + cliente.Telefono + "--- Contraseña: " + cliente.Contraseña + "\n";

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
            MostrarClientes();
        }
    }
}
