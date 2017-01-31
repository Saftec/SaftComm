using System;
using System.Collections.Generic;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class PanelDescarga : GenericConfigsPanel
    {
        public PanelDescarga()
        {
            InitializeComponent();
        }

        public override void LoadConfigs()
        {
            LogicFormatos lf = new LogicFormatos();
            List<FormatoExport> formatos = new List<FormatoExport>();

            try
            {
                formatos = lf.GetFormatos();
                cbFormatos.DataSource = formatos;
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Cargar Configuraciones.");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Cargar Configuraciones.");
            }
        }
        private bool Validar()
        {
            bool band = true;

            return band;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveConfigs();
        }

        protected override void SaveConfigs()
        {
            if (!Validar())
            {
                return;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormatoExport fe = new FormatoExport();
            fe = (FormatoExport)cbFormatos.SelectedItem;
        }

        private void cbFormatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatoExport fe = null;
            try
            {
                fe = (FormatoExport)cbFormatos.SelectedItem;
                if (fe == null)
                {
                    throw new AppException("Error al leer el formato seleccionado.");
                }
                txtNombreFormato.Text = fe.Nombre;
                txtCodEntrada.Text = fe.CodEntrada;
                txtCodSalida.Text = fe.CodSalida;
                txtLongitudLegajo.Text = fe.LongitudLegajo.ToString();
                txtLongitudReloj.Text = fe.LongitudReloj.ToString();
                txtPath.Text = fe.Path;
                txtPosicionFecha.Text = fe.PosicionFecha.ToString();
                txtPosicionHora.Text = fe.PosicionHora.ToString();
                txtPosicionLegajo.Text = fe.PosicionLegajo.ToString();
                txtPosicionRegistro.Text = fe.PosicionMov.ToString();
                txtPosicionReloj.Text = fe.PosicionReloj.ToString();
                txtPrefijoReloj.Text = fe.PrefijoReloj;

                cbFormatoFecha.Text = fe.FormatoFecha;
                cbFormatoHora.Text = fe.FormatoHora;
                if (fe.SeparadorCampos == string.Empty)
                {
                    cbSeparador.Text = "ninguno";
                }else
                {
                    cbSeparador.Text = fe.SeparadorCampos;
                }
                if (fe.SeparadorFecha == string.Empty)
                {
                    cbSeparadorFecha.Text = "ninguno";
                }
                else
                {
                    cbSeparadorFecha.Text = fe.SeparadorFecha;
                }
                if (fe.SeparadorHora == string.Empty)
                {
                    cbSeparadorHora.Text = "ninguno";
                }
                else
                {
                    cbSeparadorHora.Text = fe.SeparadorHora;
                }
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Error al cargar formato seleccionado");
            }
        }
    }
}
