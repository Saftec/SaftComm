using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using ZkManagement.NewUI.Generic;

namespace ZkManagement.NewUI
{
    public partial class MainWindow : MetroForm
    {
        public MetroPanel MetroContainer
        {
            get { return metroPanel; }
        }

        private static MainWindow _instancia;
        public MainWindow Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new MainWindow();
                }
                return _instancia;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PanelPersonal.Instancia.Dock = DockStyle.Fill;
            PanelPersonal.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelPersonal.Instancia);
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            PanelReloj.Instancia.Dock = DockStyle.Fill;
            PanelReloj.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelReloj.Instancia);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            PanelUsuario.Instancia.Dock = DockStyle.Fill;
            PanelUsuario.Instancia.RefreshGrid();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelUsuario.Instancia);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            PanelConfigs.Instancia.Dock = DockStyle.Fill;
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelConfigs.Instancia);
        }

        private void btnSinc_Click(object sender, EventArgs e)
        {
            PanelSincronizacion.Instancia.Dock = DockStyle.Fill;
            PanelSincronizacion.Instancia.RefreshData();
            this.MetroContainer.Controls.Clear();
            this.MetroContainer.Controls.Add(PanelSincronizacion.Instancia);
        }
    }
}
