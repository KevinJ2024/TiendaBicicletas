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
    public partial class FormCRUD : Form
    {
        public string entidad;
        public FormCRUD(string entidad)
        {
            InitializeComponent();
            this.entidad = entidad;
            lbTitle.Text += entidad;
            EditarCrud();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormRegistro us = new FormRegistro(entidad);
            us.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormConsultar us = new FormConsultar(entidad);
            us.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormActualizar us = new FormActualizar(entidad);
            us.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormEliminar us = new FormEliminar(entidad);
            us.ShowDialog();
        }

        private void EditarCrud()
        {
            if (entidad == "Factura")
            {
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

    }
}
