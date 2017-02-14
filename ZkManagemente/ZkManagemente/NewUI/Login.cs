using System;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

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
    }
}
