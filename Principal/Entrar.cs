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
  
    public partial class Entrar : FormBase
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string entidad;

            entidad = "Cliente";
            FormRegistro us = new FormRegistro(entidad);
            us.ShowDialog();
        }
    }
}
