using System;
using System.Configuration;
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
            IniciarReloj();
            InicializarTimer();
            CentrarElementos();
            iconoBandeja.Visible = false;
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
            /* Si es operador sólo puede utilizar la pestaña empleados y relojes.
             * Si es supervisor puede acceder a la pantalla de configuraciones.
             * El administrador es el UNICO que puede acceder a los usuarios.
             */
            ControladorConfiguraciones cc = new ControladorConfiguraciones();
            try
            {
                lblUsuario.Text = "Usuario: " + usuario.Usr;
                lblVersion.Text = "Version: " + ConfigurationManager.AppSettings["Version"].ToString();
                if (usuario.Nivel <= 2) { btnConfig.Enabled = true; }
                if (usuario.Nivel == 1) { btnUsuarios.Enabled = true; }
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
            try
            {
                relojes.ShowDialog(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            ControladorConfiguraciones cc = new ControladorConfiguraciones();
            relojesRutinas.RutinaSincronizarHora();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            try
            {
                emp.ShowDialog(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CentrarElementos()
        {
            //CENTRAR PANEL DE MENÚ!
            panelMenu.Top = (panel1.Height / 2) - (panelMenu.Height / 2);
            panelMenu.Left = (panel1.Width / 2) - (panelMenu.Width / 2);
            panel1.Controls.Add(panelMenu);
            //Hasta aca
            //CENTRAR IMAGEN PPAL
            pictureBox1.Top = (this.Height / 2) - (pictureBox1.Height / 2);
            pictureBox1.Left = (this.Width / 2) - (pictureBox1.Width / 2);
            this.Controls.Add(pictureBox1);
            //Hasta acá
            lblUsuario.Left = (this.Width) - (lblUsuario.Width + 50);
            lblVersion.Left = (this.Width) - (lblVersion.Width + 50);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void IniciarReloj()
        {
            timerHora.Interval = 1000; //se actualiza cada 1 segundo.
            timerHora.Enabled = true;
        }
        private void timerHora_Tick(object sender, EventArgs e)
        {
            toolStriplabelHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
