using System;
using System.Windows.Forms;
using TiendaBicicletas.Logica.Controller;
using Modelo.Entities;

namespace Principal
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
        
                string email = tbEmailLogin.Text;
                string contraseña = tbContraseñaLogin.Text;

            
                LoginController controllerLogin = new LoginController();
                string resultado = controllerLogin.Login(email, contraseña);

                MessageBox.Show(resultado, "Resultado del Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          


        }
    }
}
