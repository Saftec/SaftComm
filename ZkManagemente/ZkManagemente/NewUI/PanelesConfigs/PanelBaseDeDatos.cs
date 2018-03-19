using System;
using System.IO;
using System.Windows.Forms;
using Logic;
using Util;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class PanelBaseDeDatos : GenericConfigsPanel
    {
        private LogicConfigSQL lcsql;
        private LogicConfigBD lcbd;
        public PanelBaseDeDatos()
        {
            InitializeComponent();
        }

        #region Cargar
        public override void LoadConfigs()
        {
            lcbd = new LogicConfigBD();
            try
            {
                if (lcbd.IsSQL())
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
            catch (AppException appex)
            {
                base.InformarError(appex.Message, "Cargar Configuración.");
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Cargar Configuración.");
            }
        }
        private void LoadSQL()
        {
            lcsql = new LogicConfigSQL("SafCom");
            try
            {
                txtBase.Text = lcsql.GetCatalogo();
                txtPasswordSQL.Text = lcsql.GetContraseña();
                txtServer.Text = lcsql.GetServidor();
                txtUsuarioSQL.Text = lcsql.GetUsuario();
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message, "Cargar Configuración.");
            }
        }
        private void LoadAccess()
        {
            lcbd = new LogicConfigBD();
            try
            {
                txtPath.Text = lcbd.GetPath();
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message, "Cargar Configuración.");
            }

        }
        #endregion

        #region Guardar
        protected override void SaveConfigs()
        {
            lcbd = new LogicConfigBD();
            lcsql = new LogicConfigSQL("Empty");

            try
            {
                if (rbSQL.Checked)
                {
                    lcbd.SetType("SQL");
                    if (!lcsql.SetConnectionString(txtServer.Text, txtBase.Text, txtUsuarioSQL.Text, txtPasswordSQL.Text, "SafCom"))
                    {
                        base.InformarError("No se pudo establecer conexión con la base de datos de SafCom", "Guardar Configuracion.");
                    }
                    else
                    {
                        base.Informar("Configuración guardada correctamente. Acontinuación, la apliación se reiniciará.", "Guardar Configuración.");
                        Application.Restart();
                    }
                }
                else
                {
                    lcbd.SetType("Access");
                    if (!lcbd.SetConnection(txtPath.Text))
                    {
                        base.InformarError("No se pudo establecer conexión con la base de datos de SafCom", "Guardar Configuración.");
                    }
                    else
                    {
                        base.Informar("Configuración guardada correctamente. Acontinuación, la apliación se reiniciará.", "Guardar Configuración.");
                        Application.Restart();
                    }
                }                
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message, "Guardar Configuración.");
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Guardar Configuración.");
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
            if (rbAccess.Checked)
            {
                if(!v.NotEmpty(new string[] { txtPath.Text }))
                {
                    base.InformarError("Los campos no pueden quedar vacíos.", "Guardar Configuración.");
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Events
        private void rbAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAccess.Checked)
            {
                groupAccess.Enabled = true;
            }
            else
            {
                groupAccess.Enabled = false;
            }
        }
        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSQL.Checked)
            {
                groupSQL.Enabled = true;
            }
            else
            {
                groupSQL.Enabled = false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) { return; }
            SaveConfigs();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Database files (*.mdb, *.accdb)|*.mdb;*.accdb";
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fileDialog.FileName;
            }
        }
        #endregion

    }
}
