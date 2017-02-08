using System;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class PanelSaftime : GenericConfigsPanel
    {
        LogicConfigSQL lcsql;
        LogicConfigSaftime lcs;
        public PanelSaftime()
        {
            InitializeComponent();
        }

        public override void LoadConfigs()
        {
            lcsql = new LogicConfigSQL("Saftime");
            lcs = new LogicConfigSaftime();
            try
            {
                txtBase.Text = lcsql.GetCatalogo();
                txtPassword.Text = lcsql.GetContraseña();
                txtServer.Text = lcsql.GetServidor();
                txtUsuario.Text = lcsql.GetUsuario();
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
            lcsql = new LogicConfigSQL("Saftime");
            lcs = new LogicConfigSaftime();
            try
            {
                if(!lcsql.SetConnectionString(txtServer.Text, txtBase.Text, txtUsuario.Text, txtPassword.Text, "Saftime"))
                {
                    base.InformarError("No se pudo establecer conexión con la base de datos de Saftime.", "Conexión Saftime.");
                    return;
                }
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
            Validate v = new Validate();
            if(!v.NotEmpty(new string[] { txtBase.Text, txtPassword.Text, txtServer.Text, txtUsuario.Text }))
            {
                base.InformarError("Estos campos no pueden estar vacíos", "Guardar Configuración.");
                return false;
            }
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
