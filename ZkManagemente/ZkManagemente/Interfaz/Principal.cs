using System;
using System.Drawing;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class btnUsuarios : Form
    {
        public btnUsuarios()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //CENTRAR PANEL DE MENÚ!
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Capturo tamaño del monitor
            Int32 ancho = (this.Width = panelMenu.Width) / 2;
            panelMenu.Location = new Point(ancho, panelMenu.Location.Y);
            //Hasta aca
        }

        internal void SetPermisos(Usuario usuario)
        {
            ControladorConfiguraciones cc = new ControladorConfiguraciones();
            try
            {
                lblUsuario.Text = "Usuario: " + usuario.usr;
                lblVersion.Text = "Version: " + cc.GetConfig(1);
                if (usuario.nivel>2) { btnConfig.Enabled = false; }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relojes relojes = new Relojes();
            relojes.Open();
            relojes.ShowDialog(this);           
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit(); //CIERRA LA APLICACION POR COMPLETO AL CERRAR EL FORM PRINCIPAL
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion();
            config.Open();
            config.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog(this);
        }
    }
}
