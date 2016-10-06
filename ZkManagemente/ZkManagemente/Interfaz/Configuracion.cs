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
            Config config = new Config();
            try
            {
                txtCodEntrada.Text = config.Read("Movimientos", "CodEntrada");
                txtCodsalida.Text = config.Read("Movimientos", "CodSalida");
                cbPosicionMovimientos.SelectedIndex = Convert.ToInt32(config.Read("Movimientos", "Posicion")) - 1;
                comboFormatoFecha.Text = config.Read("Fecha", "Formato");
                cbPosicionFecha.SelectedIndex = Convert.ToInt32(config.Read("Fecha", "Posicion")) - 1;
                cbSeparadorFecha.Text = config.Read("Fecha", "Separador");
                comboFormatoHora.Text = config.Read("Hora", "Formato");
                cbPosicionHora.SelectedIndex = Convert.ToInt32(config.Read("Hora", "Posicion")) - 1;
                cbSeparadorHora.Text = config.Read("Hora", "Separador");
                txtCompletarLegajo.Text = config.Read("Legajo", "Completar");
                cbPosicionLegajo.SelectedIndex = Convert.ToInt32(config.Read("Legajo", "Posicion")) - 1;
                txtReloj.Text = config.Read("Reloj", "Completar");
                cbPosicionReloj.SelectedIndex = Convert.ToInt32(config.Read("Reloj", "Posicion")) - 1;
                cbSeparadorCampos.Text = config.Read("General", "Separador");
                txtPathRegs.Text = config.Read("General", "Path");
                txtAnteponer.Text = config.Read("Reloj", "Cadena");
            }
            catch(Exception ex)
            {
                InformarError(ex.Message);
            } 

        }
        private void GrabarEnArchivo()
        {
            Config config = new Config();
            try
            {
                config.Write("Movimientos", "CodEntrada", txtCodEntrada.Text);
                config.Write("Movimientos", "CodSalida", txtCodsalida.Text);
                config.Write("Movimientos", "Posicion", (cbPosicionMovimientos.SelectedIndex + 1).ToString());
                config.Write("Fecha", "Formato", comboFormatoFecha.Text);
                config.Write("Fecha", "Posicion", (cbPosicionFecha.SelectedIndex + 1).ToString());
                config.Write("Fecha", "Separador", cbSeparadorFecha.Text);
                config.Write("Hora", "Formato", comboFormatoHora.Text);
                config.Write("Hora", "Posicion", (cbPosicionHora.SelectedIndex + 1).ToString());
                config.Write("Hora", "Separador", cbSeparadorHora.Text);
                config.Write("Legajo", "Completar", txtCompletarLegajo.Text);
                config.Write("Legajo", "Posicion", (cbPosicionLegajo.SelectedIndex + 1).ToString());
                config.Write("Reloj", "Completar", txtReloj.Text);
                config.Write("Reloj", "Posicion", (cbPosicionReloj.SelectedIndex + 1).ToString());
                config.Write("General", "Separador", cbSeparadorCampos.Text);
                config.Write("General", "Path", txtPathRegs.Text);
                config.Write("Reloj", "Cadena", txtAnteponer.Text);
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
