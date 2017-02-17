using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using ZkManagement.Logica;
using ZkManagement.NewUI.Generic;
using ZkManagement.Util;

namespace ZkManagement.NewUI
{
    public partial class MainWindow : MetroForm
    {

        #region Singleton
        private static MainWindow _instancia;

        public static MainWindow Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new MainWindow();
                }
                return _instancia;
            }
        }
        private MainWindow()
        {
            InitializeComponent();          
        }
        #endregion
        private LogicConfigRutinas lcr;    
        public MetroPanel MetroContainer
        {
            get { return metroPanel; }
        }

        public void Inicializar()
        {
            lcr = new LogicConfigRutinas();
            LogicConfigBD lcbd = new LogicConfigBD();
            try
            {
                if (lcr.IsDescarga())
                {
                    InicializarTimers();
                }

                lblVersionBD.Text = "Versión BD: " + lcbd.GetVersion();
                lblVersionApp.Text = "Versión SaftComm: " + ConfigurationManager.AppSettings["Version"].ToString();
                lblUsr.Text = "Usuario: " + LogicLogin.Usuario.Usr;
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Inicializar Aplicación");
            }
        }
        #region Menu
        private void linkPersonal_Click(object sender, EventArgs e)
        {
            PanelPersonal.Instancia.Dock = DockStyle.Fill;
            PanelPersonal.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelPersonal.Instancia);
        }
        private void linkDispositivos_Click(object sender, EventArgs e)
        {
            PanelReloj.Instancia.Dock = DockStyle.Fill;
            PanelReloj.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelReloj.Instancia);
        }
        private void linkUsuarios_Click(object sender, EventArgs e)
        {
            PanelUsuario.Instancia.Dock = DockStyle.Fill;
            PanelUsuario.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelUsuario.Instancia);
        }
        private void linkConfiguracion_Click(object sender, EventArgs e)
        {
            PanelConfigs.Instancia.Dock = DockStyle.Fill;
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelConfigs.Instancia);
        }
        private void linkSincronizacion_Click(object sender, EventArgs e)
        {
            PanelSincronizacion.Instancia.Dock = DockStyle.Fill;
            PanelSincronizacion.Instancia.RefreshData();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelSincronizacion.Instancia);
        }
        #endregion

        #region Rutinas
        public void InicializarTimers()
        {
            lcr = new LogicConfigRutinas();
            if (lcr.GetEstadoRutinaRegs())
            {
                timerRutinaRegs.Enabled = true;
                timerRutinaRegs.Interval = Convert.ToInt32(lcr.GetIntervaloRegs()) * 60000; //Convierto los minutos en milisegundos
            }
            if (lcr.GetEstadoRutinaHs())
            {
                timerRutinaHora.Enabled = true;
                timerRutinaHora.Interval = Convert.ToInt32(lcr.GetIntervaloHs()) * 60000;
            }
        }
        private bool ValidarHora()
        {
            lcr = new LogicConfigRutinas();
            DateTime horaInicio;
            DateTime horaFin;
            try
            {
                if (!lcr.GetEstadoRango()) //Si no está activado el rango de horario devuelvo true.
                {
                    return true;
                }
                horaInicio = DateTime.ParseExact(lcr.GetHoraInicioRango(), "HH:mm", CultureInfo.CurrentCulture);
                horaFin = DateTime.ParseExact(lcr.GetHoraFinRango(), "HH:mm", CultureInfo.CurrentCulture);
                if (horaInicio < DateTime.Now && horaFin > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (AppException appex)
            {
                InformarError(appex.Message, "Ejecución de rutinas.");
                return false;
            }
            catch(Exception ex)
            {
                InformarError(ex.Message, "Ejecución de rutinas.");
                return false;
            }
        }
        private void timerRutinaRegs_Tick(object sender, EventArgs e)
        {

            if (!ValidarHora())
            {
                return;
            }
            backgroundWorkerRutinaRegistros.RunWorkerAsync();
        }
        private void timerRutinaHora_Tick(object sender, EventArgs e)
        {
            if (!ValidarHora())
            {
                return;
            }
            backgroundWorkerRutinaHora.RunWorkerAsync();
        }
        private void backgroundWorkerRutinaHora_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                PanelReloj.Instancia.RefreshList();
                PanelReloj.Instancia.RutinaSincronizacionHora();
            }
            catch (AppException appex)
            {
                InformarError(appex.Message, "Ejecución de rutinas.");
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Ejecución de rutinas.");
            }
        }
        private void backgroundWorkerRutinaRegistros_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                PanelReloj.Instancia.RefreshList();
                PanelReloj.Instancia.RutinaBajadaRegistros();
            }
            catch (AppException appex)
            {
                InformarError(appex.Message, "Ejecución de rutinas.");
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Ejecución de rutinas.");
            }
        }
        #endregion

        #region InformesUI
        private void InformarError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Informar(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Bandeja
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            iconoBandeja.Visible = false;
            Application.Exit();
        }
        private void iconoBandeja_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainWindow.Instancia.Show();
            MainWindow.Instancia.TopMost = true;
            MainWindow.Instancia.BringToFront();
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
        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                MainWindow.Instancia.Hide();
                iconoBandeja.Visible = true;
                MostrarNotificacionEvento("El sistema continuará trabajando en segundo plano", "SaftComm");
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow.Instancia.Show();
            MainWindow.Instancia.TopMost = true;
            MainWindow.Instancia.BringToFront();
            iconoBandeja.Visible = false;
        }
        #endregion
    }
}
