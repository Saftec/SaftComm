using System;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            ControladorLogin cl = new ControladorLogin();

            usuario.usr = textUsuario.Text;
            usuario.pass = textContraseña.Text;
            try
            {
                ValidarDatos();
                cl.ValidarUsuario(usuario);
                this.Hide();
            }
            catch(AppException appex)
            {
                MessageBox.Show(appex.Message, "Error pass");
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("Usuario incorrecto", "Error usr");
            }
            
        }

        private void ValidarDatos()
        {
            if (textContraseña.Text=="" | textUsuario.Text == "") { throw new AppException("Por favor, complete todos los campos"); }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
