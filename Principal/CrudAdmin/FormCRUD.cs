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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistro us = new FormRegistro(entidad);
            us.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FormConsultar us = new FormConsultar(entidad);
            us.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FormActualizar us = new FormActualizar(entidad);
            us.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormEliminar us = new FormEliminar(entidad);
            us.ShowDialog();
        }

    }
}
