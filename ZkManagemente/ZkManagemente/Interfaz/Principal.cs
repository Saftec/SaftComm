using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class Principal : Form
    {
        private Relojes relojes;
        private ControladorConfigRutinas ccr;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            IniciarReloj();
            InicializarTimers();
            CentrarElementos();
            iconoBandeja.Visible = false;
        }
        internal void SetPermisos(Usuario usuario)
        {
            /* Si es operador sólo puede utilizar la pestaña empleados y relojes.
             * Si es supervisor puede acceder a la pantalla de configuraciones.
             * El administrador es el UNICO que puede acceder a los usuarios.
             */            
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
        protected override void OnClosed(EventArgs e)
        {
            iconoBandeja.Visible = false;
            Application.Exit(); //CIERRA LA APLICACION POR COMPLETO AL CERRAR EL FORM PRINCIPAL
        }

        #region Menu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                relojes = new Relojes();
                relojes.ShowDialog(this);
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                MessageBox.Show("Se produjo un error no controlado.");
            }
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion();
            try
            {
                config.ShowDialog(this);
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                MessageBox.Show("Se produjo un error no controlado");
            }
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            try
            {
                usuarios.ShowDialog(this);
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                MessageBox.Show("se produjo un error no controlado");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            try
            {
                emp.ShowDialog(this);
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Timers
        public void InicializarTimers()
        {
            ccr = new ControladorConfigRutinas();
            if (Convert.ToBoolean(ccr.GetConfig(4)))
            {
                timerRutinaRegs.Enabled = true;
                timerRutinaRegs.Interval = Convert.ToInt32(ccr.GetConfig(5)) * 60000; //Convierto los minutos en milisegundos
            }
            if (Convert.ToBoolean(ccr.GetConfig(6)))
            {
                timerRutinaHora.Enabled = true;
                timerRutinaHora.Interval = Convert.ToInt32(ccr.GetConfig(7)) * 60000;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!ValidarHora())
            {
                return;
            }
            MostrarNotificacionEvento("Ejecutando rutina descarga registros..", "Rutinas");
            relojes = new Relojes();
            relojes.CargarRelojes();
            relojes.RutinaBajarRegistros();
        }
        private void timerRutinaHora_Tick(object sender, EventArgs e)
        {
            MostrarNotificacionEvento("Ejecutando rutina...", "Rutinas");
            relojes = new Relojes();
            relojes.CargarRelojes();
            relojes.RutinaSincronizarHora();
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

        #endregion

        #region Bandeja
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            iconoBandeja.Visible = false;
        }
        private void MostrarNotificacionEvento(string mensaje, string titulo)
        {
            iconoBandeja.BalloonTipTitle = titulo;
            iconoBandeja.BalloonTipText = mensaje;
            iconoBandeja.BalloonTipIcon = ToolTipIcon.Info;
            iconoBandeja.ShowBalloonTip(5000);
        }
        private void MostrarNotificacionError(string mensaje, string titulo)
        {
            iconoBandeja.BalloonTipTitle = titulo;
            iconoBandeja.BalloonTipText = mensaje;
            iconoBandeja.BalloonTipIcon = ToolTipIcon.Error;
            iconoBandeja.ShowBalloonTip(5000);
        }
        private void iconoBandeja_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            iconoBandeja.Visible = false;
        }
        #endregion

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

        //Devuelve TRUE si está dentro del rango horario de ejecución de la rutina, FALSE de lo contrario.
        private bool ValidarHora()
         {
            DateTime horaInicio;
            DateTime horaFin;
            try
            {
                if (!Convert.ToBoolean(ccr.GetConfig(10))) //Si no está activado el rango de horario devuelvo false.
                {
                    return false;
                }
                horaInicio = DateTime.ParseExact(ccr.GetConfig(8), "HH:mm", CultureInfo.CurrentCulture);
                horaFin = DateTime.ParseExact(ccr.GetConfig(9), "HH:mm", CultureInfo.CurrentCulture);
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
        //ESTE ES EL EVENTO QUE MINIMIZA LA APP A LA BANDEJA
        private void btnEmpleados_SizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState) 
            {
                this.Hide();
                iconoBandeja.Visible = true;
                MostrarNotificacionEvento("El sistema continuará trabajando en segundo plano", "SAFTEC");
            }
        }
    }
}
