using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class PanelFichadas : GenericConfigsPanel
    {
        private LogicFormatos lf;
        private LogicConfigRutinas lcr;

        // The path to the key where Windows looks for startup applications
        private RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public PanelFichadas()
        {
            InitializeComponent();
        }
        protected override void SaveConfigs()
        {
            lf = new LogicFormatos();
            lcr = new LogicConfigRutinas();
            try
            {
                // GUARDO EN EL REGISTRO EL INICIO CON WINDOWS
                if (chckIniciarWindows.Checked)
                {
                    rkApp.SetValue("SaftComm", Application.ExecutablePath);
                }else
                {
                    rkApp.DeleteValue("SaftComm", false);
                }
                // HASTA ACA //

                FormatoExport fe = new FormatoExport();
                fe = (FormatoExport)cbFormatos.SelectedItem;
                lf.SetFormatoActivo(fe);

                lcr.SetDescarga(chckEjecutarRutina.Checked);
                lcr.SetEstadoRango(chckActivarHorario.Checked);
                lcr.SetEstadoRutinaHs(chckActivarHora.Checked);
                lcr.SetEstadoRutinaRegs(chckActivarRegs.Checked);
                lcr.SetFicheroCopia(chckFicheroCopia.Checked);
                lcr.SetFinRango(txtHoraFin.Text);
                lcr.SetInicioRango(txtHoraInicio.Text);
                lcr.SetIntervaloHs(txtMinutosHora.Text);
                lcr.SetIntervaloRegs(txtMinutosRegs.Text);
                lcr.SetBorrarRegistros(chckBorrarRegs.Checked);

                MainWindow.Instancia.Inicializar();
                base.Informar("Configuraciones guardadas correctamente.", "Guardar Configuraciones.");
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message, "Guardar Configuraciones.");
            }
        }
        public override void LoadConfigs()
        {
            List<FormatoExport> formatos = new List<FormatoExport>();
            FormatoExport formatoAct = new FormatoExport();
            lf = new LogicFormatos();
            lcr = new LogicConfigRutinas();
            try
            {
                // RECUPERO DESDE EL REGISTRO EL INICIO CON WINDOWS //
                if (rkApp.GetValue("SaftComm") == null)
                {
                    chckIniciarWindows.Checked = false;
                }
                else
                {
                    chckIniciarWindows.Checked = true;
                }
                // HASTA ACA //

                formatos = lf.GetFormatos();
                formatoAct = lf.GetFormatoActivo();
                cbFormatos.DataSource = formatos;
                cbFormatos.SelectedIndex = cbFormatos.Items.IndexOf(formatoAct);
                chckFicheroCopia.Checked = lcr.IsFicheroCopia();

                // RUTINAS //
                chckBorrarRegs.Checked = lcr.IsBorradoRegs();
                chckEjecutarRutina.Checked = lcr.IsDescarga();
                chckActivarHora.Checked = lcr.GetEstadoRutinaHs();
                chckActivarHorario.Checked = lcr.GetEstadoRango();
                chckActivarRegs.Checked = lcr.GetEstadoRutinaRegs();
                txtMinutosHora.Text = lcr.GetIntervaloHs();
                txtMinutosRegs.Text = lcr.GetIntervaloRegs();
                txtHoraFin.Text = lcr.GetHoraFinRango();
                txtHoraInicio.Text = lcr.GetHoraInicioRango();
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Cargar Formatos.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            SaveConfigs();
        }

        private bool Validar()
        {
            Validate v = new Validate();

            if (!v.NumerosEnteros(new string[] { txtMinutosHora.Text, txtMinutosRegs.Text }))
            {
                base.InformarError("Los campos de minutos deben contener sólo números.", "Guardar Configuraciones.");
                return false;
            }
            if (!v.TimeFormat(new string[] { txtHoraFin.Text, txtHoraInicio.Text }))
            {
                base.InformarError("El formato de la hora no es correcto.", "Guardar Configuraciones.");
                return false;
            }
            if (cbFormatos.SelectedIndex < 0)
            {
                base.InformarError("Debe seleccionar un formato activo.", "Guardar Configuraciones.");
                return false;
            }
            return true;
        }
        private void chckEjecutarRutina_CheckedChanged(object sender, EventArgs e)
        {
            if (chckEjecutarRutina.Checked)
            {
                groupRutinas.Enabled = true;
            }else
            {
                groupRutinas.Enabled = false;
            }
        }

        private void chckActivarRegs_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivarRegs.Checked)
            {
                txtMinutosRegs.Enabled = true;
            }else
            {
                txtMinutosRegs.Enabled = false;
            }
        }
        private void chckActivarHora_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivarHora.Checked)
            {
                txtMinutosHora.Enabled = true;
            }else
            {
                txtMinutosRegs.Enabled = false;
            }
        }

        private void chckActivarHorario_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivarHorario.Checked)
            {
                txtHoraFin.Enabled = true;
                txtHoraInicio.Enabled = true;
            }else
            {
                txtHoraFin.Enabled = false;
                txtHoraInicio.Enabled = false;
            }
        }
    }
}
