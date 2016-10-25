using System;
using System.Configuration;
using System.Windows.Forms;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class Configuracion : GenericaPadre
    {
        private ControladorConfigRutinas ccr;
        private LogicConfigExport lce;
        public Configuracion()
        {
            InitializeComponent();
        }
        private void CargarConfigs()
        {
            ccr = new ControladorConfigRutinas();
            
                    //FICHERO DE REGISTROS//
            LeerDeArchivo();
            //RUTINAS//
            txtMinRegs.Text = ccr.GetIntervaloRegs();
            txtMinHs.Text = ccr.GetIntervaloHs();
            txtHSDesde.Text = ccr.GetHoraInicioRango();
            txtHSHasta.Text = ccr.GetHoraFinRango();
            chckActivaReg.Checked = Convert.ToBoolean(ccr.GetEstadoRutinaRegs());
            chckActivaHora.Checked = Convert.ToBoolean(ccr.GetEstadoRutinaHs());
            chckActivarHorarios.Checked = Convert.ToBoolean(ccr.GetEstadoRango());
                    //FTP//
           /* if(Convert.ToBoolean(cc.GetConfig(8)))
            {
                groupFtp.Enabled = true;
                chckActivarFtp.Checked = true;
                txtServidor.Text = cc.GetConfig(9);
                txtUsuario.Text = cc.GetConfig(10);
                txtContraseña.Text = cc.GetConfig(11);
                txtPathFtp.Text = cc.GetConfig(12);
                txtPuerto.Text = cc.GetConfig(13);
            }*/
        }

        private void LeerDeArchivo()
        {
            lce = new LogicConfigExport();
            try
            {
                txtCodEntrada.Text = lce.GetCodEntrada();
                txtCodsalida.Text = lce.GetCodSalida();
                cbPosicionMovimientos.SelectedIndex = Convert.ToInt32(lce.GetPosMov()) - 1;
                comboFormatoFecha.Text = lce.GetFormatoFecha();
                cbPosicionFecha.SelectedIndex = Convert.ToInt32(lce.GetPosFecha()) - 1;
                cbSeparadorFecha.Text = lce.GetSeparadorFecha();
                comboFormatoHora.Text = lce.GetFormatoHora();
                cbPosicionHora.SelectedIndex = Convert.ToInt32(lce.GetPosHora()) - 1;
                cbSeparadorHora.Text = lce.GetSeparadorHora();
                txtCompletarLegajo.Text = lce.GetLongitudLegajo();
                cbPosicionLegajo.SelectedIndex = Convert.ToInt32(lce.GetPosLegajo()) - 1;
                txtReloj.Text = lce.GetLongitudReloj();
                cbPosicionReloj.SelectedIndex = Convert.ToInt32(lce.GetPosReloj()) - 1;
                cbSeparadorCampos.Text = lce.GetSeparadorCampos();
                txtPathRegs.Text = lce.GetPath();
                txtAnteponer.Text = lce.GetPrefijoReloj();
            }
            catch(Exception ex)
            {
                InformarError(ex.Message);
            } 

        }
        private void GrabarEnArchivo()
        {
            lce = new LogicConfigExport();
            try
            {
                lce.SetCodEntrada(txtCodEntrada.Text);
                lce.SetCodSalida(txtCodsalida.Text);
                lce.SetPosMov((cbPosicionMovimientos.SelectedIndex + 1).ToString());
                lce.SetFormatoFecha(comboFormatoFecha.Text);
                lce.SetPosFecha((cbPosicionFecha.SelectedIndex + 1).ToString());
                lce.SetSeparadorFecha(cbSeparadorFecha.Text);
                lce.SetFormatoHora(comboFormatoHora.Text);
                lce.SetPosHora((cbPosicionHora.SelectedIndex + 1).ToString());
                lce.SetSeparadorHora(cbSeparadorHora.Text);
                lce.SetLongitudLegajo(txtCompletarLegajo.Text);
                lce.SetPosLegajo((cbPosicionLegajo.SelectedIndex + 1).ToString());
                lce.SetPrefijoReloj(txtAnteponer.Text);
                lce.SetPosReloj((cbPosicionReloj.SelectedIndex + 1).ToString());
                lce.SetSeparadorCampos(cbSeparadorCampos.Text);
                lce.SetPathDescarga(txtPathRegs.Text);
                lce.SetLongitudReloj(txtReloj.Text);
            }
            catch(Exception ex)
            {
                InformarError(ex.Message);
            }

        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            ControladorConfigRutinas ccr = new ControladorConfigRutinas();
            Cursor = Cursors.WaitCursor;

            try
            {
                ccr.SetEstadoRango(chckActivarHorarios.Checked.ToString());
                ccr.SetEstadoRutinaHs(chckActivaHora.Checked.ToString());
                ccr.SetEstadoRutinaRegs(chckActivaReg.Checked.ToString());
                ccr.SetFinRango(txtHSHasta.Text);
                ccr.SetInicioRango(txtHSDesde.Text);
                ccr.SetIntervaloHs(txtMinHs.Text);
                ccr.SetIntervaloRegs(txtMinRegs.Text);                            
                base.InformarEvento("Configuraciones guardadas correctamente", "Configuraciones");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }            
        }

        private void chckActivaReg_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivaReg.Checked == true)
            {
                txtMinRegs.Enabled = true;
            }
            else
            {
                txtMinRegs.Enabled = false;
            }
        }

        private void chckActivarFtp_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivarFtp.Checked == false)
            {
                groupFtp.Enabled = false;
                txtPathFtp.Text = string.Empty;
                txtPuerto.Text = string.Empty;
                txtServidor.Text = string.Empty;
                txtUsuario.Text = string.Empty;
                txtContraseña.Text = string.Empty;
            }
            else
            {
                groupFtp.Enabled = true;
            }
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            CargarConfigs();
        }

        private void chckActivarHorarios_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivarHorarios.Checked == true)
            {
                txtHSDesde.Enabled = true;
                txtHSHasta.Enabled = true;
            }
            else
            {
                txtHSDesde.Enabled = false;
                txtHSHasta.Enabled = false;
            }
        }

        private void chckActivaHora_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivaHora.Checked == true)
            {
                txtMinHs.Enabled = true;
            }
            else
            {
                txtMinHs.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager.GetSection("Registros");
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarFTP_Click(object sender, EventArgs e)
        {
          /*  cc = new ControladorConfiguraciones();
            Cursor = Cursors.WaitCursor;
            try
            {
                cc.SetConfig(8, chckActivarFtp.Checked.ToString());
                InformarEvento("Configuraciones guardadas correctamente", "Guardar Configuraciones");
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }*/
        }

        private void btnGuardarRegs_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                GrabarEnArchivo();
                InformarEvento("Configuraciones guardadas correctamente", "Guardar Configuraciones");
            }
            catch(Exception ex)
            {
                InformarError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
