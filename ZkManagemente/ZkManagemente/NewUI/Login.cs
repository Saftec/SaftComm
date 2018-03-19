using System;
using System.Windows.Forms;
using Entidades;
using Logic;
using Util;

namespace ZkManagement.NewUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private LogicLogin ll;
        private Usuario usrAct;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {           
            if (!Validar())
            {
                return;
            }
            usrAct = new Usuario();
            ll = new LogicLogin();
            usrAct.Usr = txtUsuario.Text;
            usrAct.PassEncrypt = txtPassword.Text; // GUARDO LA CONTRASEÑA ENCRIPTADA
            try
            {
                ll.ValidarUsuario(usrAct);
                MainWindow.Instancia.Inicializar();
                MainWindow.Instancia.Show();
                this.Hide();
            }
            catch(AppException appex)
            {
                InformarError(appex.Message, "Iniciar Sesión");
            }
            catch(Exception ex)
            {
                InformarError(ex.Message, "Iniciar Sesión");
            }
        }

        private bool Validar()
        {
            Validate v = new Validate();
            if(!v.NotEmpty(new string[] { txtPassword.Text, txtUsuario.Text }))
            {
                InformarError("Debe ingresar un nombre de usuario y contraseña", "Iniciar Sesión");
                return false;
            }
            return true;
        }
        private void InformarError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Informar(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ll = new LogicLogin();
            try
            {
                ll.TestConnection();
            }
            catch(Exception ex)
            {
                InformarError(ex.Message, "Conexión a base de datos.");
                EditConexionBD window = new EditConexionBD();
                window.Show();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnIngresar.PerformClick();
            }
        }

        private void linkMonitor_Click(object sender, EventArgs e)
        {
            usrAct = new Usuario("Monitor", 0, 0);
            ll = new LogicLogin();
            try
            {
                ll.MonitorMode(usrAct);                
                MainWindow.Instancia.Inicializar();
                this.Hide();
                MainWindow.Instancia.Ocultar();                
            }
            catch(Exception ex)
            {
                InformarError(ex.Message, "Iniciar SafCom");
            }
        }
    }
}
