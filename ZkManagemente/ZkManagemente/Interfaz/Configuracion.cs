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
        }
    
        public void Open()
        {
            CargarConfigs();
        }

        private void CargarConfigs()
        {
            textPathRegs.Text = cc.GetConfig(2);
            textPathLog.Text = cc.GetConfig(3);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                cc.SetConfig(2, textPathRegs.Text);
                cc.SetConfig(3, textPathLog.Text);
                MessageBox.Show("Actualizacion grabada");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
