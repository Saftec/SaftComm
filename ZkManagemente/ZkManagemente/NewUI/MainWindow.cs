using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Globalization;
using System.Windows.Forms;
using ZkManagement.Logica;
using ZkManagement.NewUI.Generic;
using ZkManagement.Util;

namespace ZkManagement.NewUI
{
    public partial class MainWindow : MetroForm
    {
        private LogicConfigRutinas lcr;
        public MetroPanel MetroContainer
        {
            get { return metroPanel; }
        }
        public MainWindow()
        {
            InitializeComponent();
            lcr = new LogicConfigRutinas();
            if (lcr.IsDescarga())
            {
                InicializarTimers();
            }
        }

        #region Menu
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PanelPersonal.Instancia.Dock = DockStyle.Fill;
            PanelPersonal.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelPersonal.Instancia);
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            PanelReloj.Instancia.Dock = DockStyle.Fill;
            PanelReloj.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelReloj.Instancia);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            PanelUsuario.Instancia.Dock = DockStyle.Fill;
            PanelUsuario.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelUsuario.Instancia);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            PanelConfigs.Instancia.Dock = DockStyle.Fill;
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelConfigs.Instancia);
        }

        private void btnSinc_Click(object sender, EventArgs e)
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
                if (!lcr.GetEstadoRango()) //Si no está activado el rango de horario devuelvo false.
                {
                    return false;
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
            backgroundWorkerRutinaRegistros.RunWorkerAsync();
        }
        private void timerRutinaHora_Tick(object sender, EventArgs e)
        {
            backgroundWorkerRutinaHora.RunWorkerAsync();
        }
        private void backgroundWorkerRutinaHora_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                PanelReloj.Instancia.RefreshGrid();
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
                PanelReloj.Instancia.RefreshGrid();
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
