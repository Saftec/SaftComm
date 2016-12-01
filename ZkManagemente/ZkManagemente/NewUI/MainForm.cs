using MetroFramework.Forms;
using System.Windows.Forms;
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
        private void btnEquipos_Click(object sender, System.EventArgs e)
        {            
            PanelEquipos.Instancia.RefreshGrid();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(PanelEquipos.Instancia);
        }
        private void btnPersonal_Click(object sender, System.EventArgs e)
        {
            PanelPersonal.Instancia.RefreshGrid();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(PanelPersonal.Instancia);
        }
    }
}
