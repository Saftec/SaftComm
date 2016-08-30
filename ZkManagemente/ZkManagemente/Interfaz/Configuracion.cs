using System;
using System.Windows.Forms;
using ZkManagement.Logica;

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
                cc.SetConfig(2, txtPathRegs.Text);
                cc.SetConfig(5, txtMinRegs.Text);
                cc.SetConfig(7, txtMinHs.Text);
                cc.SetConfig(6, chckActivaHora.Checked.ToString());
                cc.SetConfig(4, chckActivaReg.Checked.ToString());
                cc.SetConfig(8, chckActivarFtp.Checked.ToString());
                cc.SetConfig(16, chckActivarHorarios.Checked.ToString());
                cc.SetConfig(14, txtHSDesde.Text);
                cc.SetConfig(15, txtHSHasta.Text);
                base.InformarEvento("Configuraciones guardadas", "Configuraciones");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message);
            }
            Cursor = Cursors.Default;
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
    }
}
