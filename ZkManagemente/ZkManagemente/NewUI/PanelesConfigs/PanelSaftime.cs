using System;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class PanelSaftime : GenericConfigsPanel
    {
        LogicConfigSaftime lcs;
        public PanelSaftime()
        {
            InitializeComponent();
        }

        public override void LoadConfigs()
        {
            lcs = new LogicConfigSaftime();
            try
            {
                txtBase.Text = lcs.GetCatalogo();
                txtPassword.Text = lcs.GetContraseña();
                txtServer.Text = lcs.GetServidor();
                txtUsuario.Text = lcs.GetUsuario();
                chckEmpleados.Checked = lcs.IsEmpleados();
                chckRegis.Checked = lcs.IsRegistros();
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Cargar Configuraciones.");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Cargar Configuraciones.");
            }
        }
        protected override void SaveConfigs()
        {
            lcs = new LogicConfigSaftime();
            try
            {
                lcs.SetConnectionString(txtServer.Text, txtBase.Text, txtUsuario.Text, txtPassword.Text);
                lcs.SetEstadoEmpleados(chckEmpleados.Checked);
                lcs.SetEstadoRegistros(chckRegis.Checked);
                base.Informar("Configuraciones guardadas correctamente.", "Guardar Configuración.");
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Guardar Configuración.");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Guardar Configuración.");
            }
        }

        private bool Validar()
        {

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            SaveConfigs();
        }
    }
}
