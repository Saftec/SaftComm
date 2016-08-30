using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class btnEmpleados : Form
    {
        private Relojes relojes;
        private ControladorConfiguraciones cc;
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
        internal void SetPermisos(Usuario usuario)
        {
            /* Si es operador sólo puede utilizar la pestaña empleados y relojes.
             * Si es supervisor puede acceder a la pantalla de configuraciones.
             * El administrador es el UNICO que puede acceder a los usuarios.
             */
            cc = new ControladorConfiguraciones();
            try
            {
                lblUsuario.Text = "Usuario: " + usuario.Usr;
                lblVersion.Text = "Version: " + ConfigurationManager.AppSettings["Version"].ToString();
                lblVersionBD.Text = "Version BD: " + cc.GetConfig(1);
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
            try
            {
                relojes = new Relojes();
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
            if (!ValidarHora())
            {
                return;
            }
            relojes = new Relojes();
            relojes.CargarRelojes();
            relojes.RutinaBajarRegistros();
        }

        private void InicializarTimer()
        {
            cc = new ControladorConfiguraciones();
            if (Convert.ToBoolean(cc.GetConfig(4)))
            {
                timerRutinaRegs.Enabled = true;
                timerRutinaRegs.Interval = Convert.ToInt32(cc.GetConfig(5)) * 60000; //Convierto los minutos en milisegundos
            }                             
            if (Convert.ToBoolean(cc.GetConfig(6)))
            {
                timerRutinaHora.Enabled = true;
                timerRutinaRegs.Interval = Convert.ToInt32(cc.GetConfig(7)) * 60000;
            }            
        }

        private void timerRutinaHora_Tick(object sender, EventArgs e)
        {
            relojes = new Relojes();
            relojes.CargarRelojes();
            relojes.RutinaSincronizarHora();
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
            lblVersionBD.Left = (this.Width) - (lblVersionBD.Width + 50);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void IniciarReloj()
        {
            timerHora.Interval = 1000; //se actualiza cada 1 segundo.
            timerHora.Enabled = true;
        }
        //Este timer es el utilizado para el reloj, se actualiza cada 1 seg.
        private void timerHora_Tick(object sender, EventArgs e)
        {
            toolStriplabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        //Devuelve TRUE si está dentro del rango horario de ejecución de la rutina, FALSE de lo contrario.
        private bool ValidarHora()
         {
            DateTime horaInicio;
            DateTime horaFin;
            cc = new ControladorConfiguraciones();
            try
            {
                if (!Convert.ToBoolean(cc.GetConfig(16))) //Si no está activado el rango de horario devuelvo false.
                {
                    return false;
                }
                horaInicio = DateTime.ParseExact(cc.GetConfig(14), "HH:mm", CultureInfo.CurrentCulture);
                horaFin = DateTime.ParseExact(cc.GetConfig(15), "HH:mm", CultureInfo.CurrentCulture);
                if (horaInicio<DateTime.Now && horaFin > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }                        
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnEmpleados_SizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)  //SI MINIZO LA VENTANA, MUESTRO EL ÍCONO DE LA APP EN LA BANDEJA
            {
                this.Hide();
                iconoBandeja.Visible = true;
                iconoBandeja.BalloonTipTitle = "SAFTEC";
                iconoBandeja.BalloonTipText = "El sistema continuará trabajando en segundo plano";
                iconoBandeja.BalloonTipIcon = ToolTipIcon.Info;
                iconoBandeja.ShowBalloonTip(5000);
            }
        }
    }
}
