using log4net;
using System;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class Login : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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

            usuario.Usr = textUsuario.Text;
            usuario.Pass = textContraseña.Text;
            try
            {
                ValidarDatos();
                cl.ValidarUsuario(usuario);
                this.Hide();
            }
            catch(AppException appex)
            {
                MessageBox.Show(appex.Message, "Error ingreso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido");
            }
            
        }

        private void ValidarDatos()
        {
            if (textContraseña.Text=="" | textUsuario.Text == "") { throw new AppException("Por favor, complete todos los campos"); }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            log.Info("Esto es info");
            log.Debug("Esto es debug");         
            bool estado = false;
            ControladorLogin cl = new ControladorLogin();
            try
            {
                estado = cl.CheckConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            if (estado==false)
            {
                ConexionBD conexion = new ConexionBD();
                conexion.Show();
            }
        }
    }
}
