using MetroFramework.Forms;

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
            PanelPersonal.GetInstancia().RefreshData();
            MainPanel.Controls.Add(PanelPersonal.GetInstancia());
        }
    }
}
