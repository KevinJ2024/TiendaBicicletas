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
    public partial class FormPrincipalCliente : Form
    {
        private int ID_cliente;
        public FormPrincipalCliente(int ID_cliente)
        {
            InitializeComponent();
            this.ID_cliente = ID_cliente;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            carrito carritos = new carrito(ID_cliente);
            carritos.ShowDialog();
        }
    }
}
