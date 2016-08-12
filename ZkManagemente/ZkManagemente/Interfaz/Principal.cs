using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class btnEmpleados : Form
    {
        Relojes relojesRutinas = new Relojes();
        public btnEmpleados()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            InicializarTimer();
            //CENTRAR PANEL DE MENÚ!
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Capturo tamaño del monitor
            Int32 ancho = (this.Width = panelMenu.Width) / 2;
            panelMenu.Location = new Point(ancho, panelMenu.Location.Y);
            //Hasta aca
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)  //SI MINIZO LA VENTANA, MUESTRO EL ÍCONO DE LA APP EN LA BANDEJA
            {
                Hide();
                iconoBandeja.Visible = true;
            }
            else
            {
                iconoBandeja.Visible = false;
            }
        }
        internal void SetPermisos(Usuario usuario)
        {
            ControladorConfiguraciones cc = new ControladorConfiguraciones();
            try
            {
                lblUsuario.Text = "Usuario: " + usuario.Usr;
                lblVersion.Text = "Version: " + ConfigurationManager.AppSettings["Version"].ToString();
                if (usuario.Nivel>2) { btnConfig.Enabled = false; }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relojes relojes = new Relojes();
            ControladorLogin cl = new ControladorLogin();
            relojes.ShowDialog(this);           
        }

        protected override void OnClosed(EventArgs e)
        {
            iconoBandeja.Visible = false;
            Application.Exit(); //CIERRA LA APLICACION POR COMPLETO AL CERRAR EL FORM PRINCIPAL
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion();
            config.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            relojesRutinas.RutinaBajarRegistros();
        }

        private void InicializarTimer()
        {
            ControladorConfiguraciones cc = new ControladorConfiguraciones();
            if (cc.GetConfig(4) == "S")
            {
                timerRutinaRegs.Enabled = true;
                timerRutinaRegs.Interval = Convert.ToInt32(cc.GetConfig(5)) * 60000; //Convierto los minutos en milisegundos
            }                             
            if (cc.GetConfig(6) == "S")
            {
                timerRutinaHora.Enabled = true;
                timerRutinaRegs.Interval = Convert.ToInt32(cc.GetConfig(7)) * 60000;
            }            
        }

        private void timerRutinaHora_Tick(object sender, EventArgs e)
        {
            relojesRutinas.RutinaSincronizarHora();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            emp.ShowDialog(this);
        }

        private void btnEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
