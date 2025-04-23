using System;
using System.Windows.Forms;
using Modelo.Entities;
using Logica.Controllers.InicioController;
using Logica.Controllers;
using MySqlX.XDevAPI;

namespace Principal
{
    public partial class FormLogin : FormBase
    {
        string tipo;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string Email = tbEmailLogin.Text;
                string Contraseña = tbContraseñaLogin.Text;


                LoginController controllerLogin = new LoginController();
                string resultado = controllerLogin.Login(Email, Contraseña);


                if (resultado == "Login exitoso. Usuario encontrado")
                { 
                    MessageBox.Show(resultado, "Resultado del Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClienteController clienteController = new ClienteController();
                    var usuario = clienteController.ConsultarClienteEmail(Email);
                    tipo = "Cliente";
                    this.Hide();
                    FormPrincipalCliente FormUsuario = new FormPrincipalCliente(usuario.ID_cliente, tipo);
                    FormUsuario.ShowDialog();
                    this.Show();
                }
                else if (resultado == "Login exitoso. Administrador encontrado")
                {
                    MessageBox.Show(resultado, "Resultado del Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdministradorController administradorController = new AdministradorController();
                    var usuario = administradorController.ConsultarAdmin(Email);
                    tipo = "Administrador";
                    this.Hide();
                    FormPrincipalCliente FormUsuario = new FormPrincipalCliente(usuario.ID_admin, tipo);
                    FormUsuario.ShowDialog();
                    this.Show();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbEmailLogin.Text = "";
            tbContraseñaLogin.Text = "";
        }
    }
}
