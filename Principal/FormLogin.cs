using System;
using System.Windows.Forms;
using Modelo.Entities;
using Logica.Controllers.InicioController;

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

<<<<<<< HEAD
                if (resultado == "Login exitoso. Bienvenido administrador.")
                {
                MessageBox.Show(resultado, "Resultado del Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPrincipalCliente cliente = new FormPrincipalCliente();
                cliente.ShowDialog();
                }
                else if (resultado == "Login exitoso. Bienvenido cliente.")
=======
                if (resultado == "Login exitoso. Usuario encontrado")
>>>>>>> ee4cced6066a2a30304e6ef147a90dd2ff44c696
                {
                    MessageBox.Show(resultado, "Resultado del Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormPrincipalCliente cliente = new FormPrincipalCliente();
                    cliente.ShowDialog();
                }
                else
                {
                    MessageBox.Show(resultado, "Resultado del Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Entrar entrar = new Entrar();
            entrar.ShowDialog();
            this.Close();
        }

    }
}
