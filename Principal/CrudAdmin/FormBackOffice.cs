using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FormBackOffice : FormBase
    {
        public string entidad;

        public FormBackOffice()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            entidad = "Cliente";
            FormCRUD us = new FormCRUD(entidad);
            us.ShowDialog();
            this.Show();

        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            entidad = "Vendedor";
            FormCRUD us = new FormCRUD(entidad);
            us.ShowDialog();
            this.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            entidad = "Producto";
            FormCRUD us = new FormCRUD(entidad);
            us.ShowDialog();
            this.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            entidad = "Proveedor";
            FormCRUD us = new FormCRUD(entidad);
            us.ShowDialog();
            this.Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            this.Hide();
            entidad = "Factura";
            FormCRUD us = new FormCRUD(entidad);
            us.ShowDialog();
            this.Show();
        }
    }
}
