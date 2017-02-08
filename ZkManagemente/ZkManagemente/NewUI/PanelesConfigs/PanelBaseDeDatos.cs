using System;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class PanelBaseDeDatos : GenericConfigsPanel
    {
        private LogicConfigSQL lcsql;
        public PanelBaseDeDatos()
        {
            InitializeComponent();
        }

        public override void LoadConfigs()
        {
            lcsql = new LogicConfigSQL("SaftComm");
            try
            {
                if (lcsql.IsSQL())
                {
                    rbSQL.Checked = true;
                    LoadSQL();
                }
                else
                {
                    rbAccess.Checked = true;
                    LoadAccess();
                }
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Cargar Configuración.");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Cargar Configuración.");
            }
        }

        protected override void SaveConfigs()
        {          
            if (rbSQL.Checked)
            {
                if (!lcsql.SetConnectionString(txtServer.Text, txtBase.Text, txtUsuarioSQL.Text, txtPasswordSQL.Text, "SaftComm"))
                {
                    base.InformarError("No se pudo establecer conexión con la base de datos de SaftComm", "Guardar Configuracion.");
                }else
                {
                    base.Informar("Configuración guardada correctamente.", "Guardar Configuración.");
                }
            }
        }

        private bool Validar()
        {
            Validate v = new Validate();

            if (rbSQL.Checked)
            {
                if (!v.NotEmpty(new string[] { txtBase.Text, txtPasswordSQL.Text, txtServer.Text, txtUsuarioSQL.Text }))
                {
                    base.InformarError("Los campos no pueden quedar vacíos.", "Guardar Configuración.");
                    return false;
                }
            }
            return true;
        }
        private void LoadSQL()
        {
            lcsql = new LogicConfigSQL("SaftComm");
            try
            {
                txtBase.Text = lcsql.GetCatalogo();
                txtPasswordSQL.Text = lcsql.GetContraseña();
                txtServer.Text = lcsql.GetServidor();
                txtUsuarioSQL.Text = lcsql.GetUsuario();                
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Cargar Configuración.");
            }
        }
        private void LoadAccess()
        {

        }
        private void rbAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAccess.Checked)
            {
                groupAccess.Enabled = true;
            }else
            {
                groupAccess.Enabled = false;
            }
        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSQL.Checked)
            {
                groupSQL.Enabled = true;
            }else
            {
                groupSQL.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) { return; }
            SaveConfigs();
        }
    }
}
