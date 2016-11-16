

namespace ZkManagement.NewUI.Generic
{
    public partial class PanelEquipos : GenericPanel
    {
        //         PATRON SINGLETON            //
        private static PanelEquipos _instancia;

        public static PanelEquipos GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new PanelEquipos();
            }
            return _instancia;
        }
        public PanelEquipos()
        {
            InitializeComponent();
        }
    }
}
