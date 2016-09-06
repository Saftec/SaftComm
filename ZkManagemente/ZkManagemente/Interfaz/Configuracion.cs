using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Windows.Forms;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class Configuracion : GenericaPadre
    {
        private ControladorConfiguraciones cc;
        public Configuracion()
        {
            InitializeComponent();
        }
        private void CargarConfigs()
        {
            cc = new ControladorConfiguraciones();

            txtPathRegs.Text = cc.GetConfig(2);
            txtMinRegs.Text = cc.GetConfig(5);
            txtMinHs.Text = cc.GetConfig(7);
            txtHSDesde.Text = cc.GetConfig(14);
            txtHSHasta.Text = cc.GetConfig(15);
            chckActivaReg.Checked = Convert.ToBoolean(cc.GetConfig(4));
            chckActivaHora.Checked = Convert.ToBoolean(cc.GetConfig(6));
            chckActivarHorarios.Checked = Convert.ToBoolean(cc.GetConfig(16));
            if(Convert.ToBoolean(cc.GetConfig(8)))
            {
                groupFtp.Enabled = true;
                chckActivarFtp.Checked = true;
                txtServidor.Text = cc.GetConfig(9);
                txtUsuario.Text = cc.GetConfig(10);
                txtContraseña.Text = cc.GetConfig(11);
                txtPathFtp.Text = cc.GetConfig(12);
                txtPuerto.Text = cc.GetConfig(13);
            }
        }

        private void LeerDeArchivo()
        {
            Config config = new Config();
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
            txtAnteponer.Text = config.Read("Reloj", "Cadena");
        }
        private void GrabarEnArchivo()
        {
            Config config = new Config();
            config.Write("Movimientos", "CodEntrada", txtCodEntrada.Text);
            config.Write("Movimientos", "CodSalida", txtCodsalida.Text);
            config.Write("Movimientos", "Posicion", (cbPosicionMovimientos.SelectedIndex + 1).ToString());
            config.Write("Fecha", "Formato", comboFormatoFecha.Text);
            config.Write("Fecha", "Posicion", (cbPosicionFecha.SelectedIndex+1).ToString());
            config.Write("Fecha", "Separador", cbSeparadorFecha.Text);
            config.Write("Hora", "Formato", comboFormatoHora.Text);
            config.Write("Hora", "Posicion", (cbPosicionHora.SelectedIndex + 1).ToString());
            config.Write("Hora", "Separador", cbSeparadorHora.Text);
            config.Write("Legajo", "Completar", txtCompletarLegajo.Text);
            config.Write("Legajo", "Posicion", (cbPosicionLegajo.SelectedIndex + 1).ToString());
            config.Write("Reloj", "Completar", txtReloj.Text);
            config.Write("Reloj", "Posicion", (cbPosicionReloj.SelectedIndex + 1).ToString());
            config.Write("General", "Separador", cbSeparadorCampos.Text);
            config.Write("Reloj", "Cadena", txtAnteponer.Text);
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            cc = new ControladorConfiguraciones();
            Cursor = Cursors.WaitCursor;
            try
            {                
                cc.SetConfig(5, txtMinRegs.Text);
                cc.SetConfig(7, txtMinHs.Text);
                cc.SetConfig(6, chckActivaHora.Checked.ToString());
                cc.SetConfig(4, chckActivaReg.Checked.ToString());               
                cc.SetConfig(16, chckActivarHorarios.Checked.ToString());
                cc.SetConfig(14, txtHSDesde.Text);
                cc.SetConfig(15, txtHSHasta.Text);
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
            LeerDeArchivo();
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
            cc = new ControladorConfiguraciones();
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
            }
        }

        private void btnGuardarRegs_Click(object sender, EventArgs e)
        {
            cc = new ControladorConfiguraciones();
            Cursor = Cursors.WaitCursor;
            try
            {
                cc.SetConfig(2, txtPathRegs.Text);
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
