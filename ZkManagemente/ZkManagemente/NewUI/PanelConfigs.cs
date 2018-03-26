

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

        private void metroLink2_Click(object sender, System.EventArgs e)
        {
            PanelFormatos pd = new PanelFormatos();
            pd.LoadConfigs();
            pConfigs.Controls.Clear();
            pConfigs.Controls.Add(pd);
        }

        private void linkSaftime_Click(object sender, System.EventArgs e)
        {
            PanelSaftime ps = new PanelSaftime();
            ps.LoadConfigs();
            pConfigs.Controls.Clear();
            pConfigs.Controls.Add(ps);
        }

        private void linkBaseDeDatos_Click(object sender, System.EventArgs e)
        {
            PanelBaseDeDatos pbd = new PanelBaseDeDatos();
            pbd.LoadConfigs();
            pConfigs.Controls.Clear();
            pConfigs.Controls.Add(pbd);
        }
    }
}
