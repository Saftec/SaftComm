using System;
using System.Collections.Generic;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class PanelFichadas : GenericConfigsPanel
    {
        private LogicFormatos lf;
        private LogicConfigRutinas lcr;
        public PanelFichadas()
        {
            InitializeComponent();
        }

        public override void LoadConfigs()
        {
            List<FormatoExport> formatos = new List<FormatoExport>();
            FormatoExport formatoAct = new FormatoExport();
            lf = new LogicFormatos();
            lcr = new LogicConfigRutinas();
            try
            {
                formatos = lf.GetFormatos();
                formatoAct = lf.GetFormatoActivo();
                cbFormatos.DataSource = formatos;
                cbFormatos.SelectedIndex = cbFormatos.Items.IndexOf(formatoAct);
                chckFicheroCopia.Checked = lcr.IsFicheroCopia();
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Cargar Formatos.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lf = new LogicFormatos();

            try
            {
                FormatoExport fe = new FormatoExport();
                fe = (FormatoExport)cbFormatos.SelectedItem;
                lf.SetFormatoActivo(fe);
                base.Informar("Configuraciones guardadas correctamente.", "Guardar Configuraciones.");
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Guardar Configuraciones.");
            }
        }
    }
}
