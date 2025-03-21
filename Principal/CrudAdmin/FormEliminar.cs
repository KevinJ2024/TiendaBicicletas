using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class FormEliminar : Form
    {

        public string entidad;

        public FormEliminar(string entidad)
        {
            InitializeComponent();
            lbTitle.Text += entidad;
            tbID.PlaceholderText += entidad;

            this.entidad = entidad;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (entidad)
            {
                case "Cliente":
                    ClienteController controller = new ClienteController();
                    string resultado = controller.EliminarCliente(int.Parse(tbID.Text));
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
        }
    }
}
