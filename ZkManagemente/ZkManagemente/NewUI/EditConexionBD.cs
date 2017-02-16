using System;
using System.Windows.Forms;
using ZkManagement.NewUI.PanelesConfigs;

namespace ZkManagement.NewUI
{
    public partial class EditConexionBD : Form
    {
        public EditConexionBD()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditConexionBD_Load(object sender, EventArgs e)
        {
            PanelBaseDeDatos panel = new PanelBaseDeDatos();
            panel.LoadConfigs();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(panel);
        }
    }
}
