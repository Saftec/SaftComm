using System;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class GenericConfigsPanel : GenericPanel
    {
        public GenericConfigsPanel()
        {
            InitializeComponent();
        }

        public virtual void LoadConfigs() { }

        protected virtual void SaveConfigs() { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.LoadConfigs();
        }
    }
}
