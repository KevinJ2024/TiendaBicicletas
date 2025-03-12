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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente us = new FormCliente();
            us.ShowDialog();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            FormVendedor us = new FormVendedor();
            us.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormProducto us = new FormProducto();
            us.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            FormFactura us = new FormFactura();
            us.ShowDialog();
        }
    }
}
