using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Windows.Forms;
using ZkManagement.NewUI.Generic;

namespace ZkManagement.NewUI
{
    public partial class MainForm : MetroForm
    {

        public MetroPanel MetroContainer
        {
            get { return mainPanel; }
            set { mainPanel = value; }
        }

        private static MainForm _instancia;
        public MainForm Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new MainForm();
                }
                return _instancia;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
        private void btnEquipos_Click(object sender, System.EventArgs e)
        {
            /*            
            PanelEquipos.Instancia.RefreshGrid();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(PanelEquipos.Instancia);*/
        }
        private void btnPersonal_Click(object sender, System.EventArgs e)
        {
            /*
            PanelPersonal.Instancia.RefreshGrid();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(PanelPersonal.Instancia);*/
            PanelPersonal.Instancia.Dock = DockStyle.Fill;
            PanelPersonal.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelPersonal.Instancia);
        }

        private void btnUsuarios_Click(object sender, System.EventArgs e)
        {/*
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(PanelUsuario.Instancia);*/
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
        }
    }
}
