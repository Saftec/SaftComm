

using ZkManagement.NewUI.PanelesConfigs;

namespace ZkManagement.NewUI
{
    public partial class PanelConfigs : GenericPanel
    {
        private static PanelConfigs _instancia;

        public static PanelConfigs Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PanelConfigs();
                }
                return _instancia;
            }
        }
        private PanelConfigs()
        {
            InitializeComponent();
        }

        private void linkRutinas_Click(object sender, System.EventArgs e)
        {
            PanelRutinas pr = new PanelRutinas();
            pr.LoadConfigs();
            pConfigs.Controls.Clear();
            pConfigs.Controls.Add(pr);
        }
    }
}
