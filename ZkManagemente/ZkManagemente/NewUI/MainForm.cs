using MetroFramework.Forms;
using ZkManagement.NewUI.Generic;

namespace ZkManagement.NewUI
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void linkPersonal_Click(object sender, System.EventArgs e)
        {
            PanelPersonal.GetInstancia().RefreshGrid();
            MainPanel.Controls.Add(PanelPersonal.GetInstancia());
        }

        private void btnEquipos_Click(object sender, System.EventArgs e)
        {            
            PanelEquipos.GetInstancia().RefreshGrid();
            MainPanel.Controls.Add(PanelEquipos.GetInstancia());
        }
    }
}
