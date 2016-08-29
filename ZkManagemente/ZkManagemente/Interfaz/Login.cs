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
        private ControladorLogin cl;
        private ILog logger = LogManager.GetLogger("ALL");
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
            cl = new ControladorLogin();

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
        private void Login_Load(object sender, EventArgs e)
        {
            //Cuando inicio la APP chequeo la conexión a la BD.
            //Sino funciona abro la ventana para modificar la connectionstring.

            log4net.Config.XmlConfigurator.Configure();
            bool estado = false;
            cl = new ControladorLogin();

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
