using System;
using System.Windows.Forms;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class Configuracion : Form
    {
        private ControladorConfiguraciones cc = new ControladorConfiguraciones();
        public Configuracion()
        {
            InitializeComponent();
            CargarConfigs();
        }
            private void CargarConfigs()
        {
            string valor;
            txtPathRegs.Text = cc.GetConfig(2);
            txtPathLog.Text = cc.GetConfig(3);
            txtMinRegs.Text = cc.GetConfig(5);
            txtMinHs.Text = cc.GetConfig(8);
            valor = cc.GetConfig(4);
            if (valor=="S") { chckActivaReg.Checked = true; }
            valor = cc.GetConfig(7);
            if (valor=="S") { chckActivaHora.Checked = true; }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                cc.SetConfig(2, txtPathRegs.Text);
                cc.SetConfig(3, txtPathLog.Text);
                MessageBox.Show("Actualizacion grabada");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void chckActivaReg_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
