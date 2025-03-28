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
    public partial class FormBackOffice : Form
    {
        public string entidad;

        public FormBackOffice()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            entidad = "Cliente";
            FormCRUD us = new FormCRUD(entidad);
            us.ShowDialog();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            entidad = "Vendedor";
            FormCRUD us = new FormCRUD(entidad);
            us.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            entidad = "Producto";
            FormCRUD us = new FormCRUD(entidad);
            us.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            entidad = "Factura";
            FormCRUD us = new FormCRUD(entidad);
            us.ShowDialog();
        }
    }
}
