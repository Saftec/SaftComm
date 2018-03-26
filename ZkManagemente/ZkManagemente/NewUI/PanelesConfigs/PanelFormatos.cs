using System;
using System.Collections.Generic;
using Entidades;
using Logic;
using Util;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class PanelFormatos : GenericConfigsPanel
    {
        private FormatoExport formatoAct;
        private LogicFormatos lf;
        public PanelFormatos()
        {
            InitializeComponent();
        }

        public override void LoadConfigs()
        {
            lf = new LogicFormatos();
            List<FormatoExport> formatos = new List<FormatoExport>();

            try
            {
                formatos = lf.GetAll();
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
            Validate v = new Validate();
            if(txtPosicionFecha.Text=="" || txtPosicionHora.Text == "" || txtPosicionLegajo.Text == "" || txtPosicionRegistro.Text == "" || txtPosicionReloj.Text == "")
            {
                base.InformarError("Todos los campos deben contener una posición.", "Guardar Formato");
                return false;
            }
            if (txtNombreFormato.Text == "")
            {
                base.InformarError("Debe ingresar un nombre de formato.", "Guardar Formato");
                return false;
            }
            if (txtPath.Text == "")
            {
                base.InformarError("Debe ingresar un path de descarga.", "Guardar Formato");
                return false;
            }
            // ESTA VALIDACION FALLA //
            if(!v.NumerosEnteros(new string[] { txtPosicionFecha.Text, txtPosicionHora.Text, txtPosicionLegajo.Text, txtPosicionRegistro.Text, txtPosicionReloj.Text }))
            {
                base.InformarError("Los campos de posición deben contener sólo números.", "Guardar Formato");
                return false;
            }
            if (!ValidarPosiciones())
            {
                base.InformarError("Las posiciones de los campos no pueden repetirse o ser mayores a 5.", "Guardar Formato");
                return false;
            }
            return true;
        }

        private bool ValidarPosiciones()
        {
            bool band = true;
            if(txtPosicionFecha.Text==txtPosicionHora.Text || txtPosicionFecha.Text == txtPosicionLegajo.Text || txtPosicionFecha.Text == txtPosicionRegistro.Text || txtPosicionFecha.Text == txtPosicionReloj.Text || Convert.ToInt32(txtPosicionFecha.Text)>5)
            {
                band = false;
            }
            if(txtPosicionHora.Text==txtPosicionFecha.Text || txtPosicionHora.Text == txtPosicionLegajo.Text || txtPosicionHora.Text == txtPosicionRegistro.Text || txtPosicionHora.Text == txtPosicionReloj.Text || Convert.ToInt32(txtPosicionHora.Text) > 5)
            {
                band = false;
            }
            if(txtPosicionLegajo.Text==txtPosicionFecha.Text || txtPosicionLegajo.Text == txtPosicionHora.Text || txtPosicionLegajo.Text == txtPosicionRegistro.Text || txtPosicionLegajo.Text == txtPosicionReloj.Text || Convert.ToInt32(txtPosicionLegajo.Text) > 5)
            {
                band = false;
            }
            if(txtPosicionRegistro.Text == txtPosicionFecha.Text || txtPosicionRegistro.Text == txtPosicionHora.Text || txtPosicionRegistro.Text == txtPosicionLegajo.Text || txtPosicionRegistro.Text == txtPosicionReloj.Text || Convert.ToInt32(txtPosicionRegistro.Text) > 5)
            {
                band = false;
            }
            if(txtPosicionReloj.Text == txtPosicionFecha.Text || txtPosicionReloj.Text == txtPosicionHora.Text || txtPosicionReloj.Text == txtPosicionLegajo.Text || txtPosicionReloj.Text == txtPosicionRegistro.Text || Convert.ToInt32(txtPosicionReloj.Text) > 5)
            {
                band = false;
            }

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
            lf = new LogicFormatos();
            try
            {
                if (formatoAct.Id > 0)
                {
                    lf.UpdateFormato(MapearDeForm());
                    base.Informar("Formato actualizado correctamente.", "Modificar Formato");
                }else
                {
                    lf.InsertFormato(MapearDeForm());
                    base.Informar("Formato creado correctamente.", "Modificar Formato");
                } 
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Guardar Formato");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Guardar Formato");
            }
        }
        
        private void LimpiarForm()
        {
            txtCodEntrada.Text = string.Empty;
            txtCodSalida.Text = string.Empty;
            txtLongitudLegajo.Text = string.Empty;
            txtLongitudReloj.Text = string.Empty;
            txtNombreFormato.Text = string.Empty;
            txtPath.Text = string.Empty;
            txtPosicionFecha.Text = string.Empty;
            txtPosicionHora.Text = string.Empty;
            txtPosicionLegajo.Text = string.Empty;
            txtPosicionRegistro.Text = string.Empty;
            txtPosicionReloj.Text = string.Empty;
            txtPrefijoReloj.Text = string.Empty;
            cbFormatos.SelectedIndex = 0;
        }
        private FormatoExport MapearDeForm()
        {
            formatoAct.CodEntrada = txtCodEntrada.Text;
            formatoAct.CodSalida = txtCodSalida.Text;
            formatoAct.FormatoFecha = cbFormatoFecha.Text;
            formatoAct.FormatoHora = cbFormatoHora.Text;
            formatoAct.LongitudLegajo = Convert.ToInt32(txtLongitudLegajo.Text);
            formatoAct.LongitudReloj = Convert.ToInt32(txtLongitudReloj.Text);
            formatoAct.Nombre = txtNombreFormato.Text;
            formatoAct.Path = txtPath.Text;
            formatoAct.PosicionFecha = Convert.ToInt32(txtPosicionFecha.Text);
            formatoAct.PosicionHora = Convert.ToInt32(txtPosicionHora.Text);
            formatoAct.PosicionLegajo = Convert.ToInt32(txtPosicionLegajo.Text);
            formatoAct.PosicionMov = Convert.ToInt32(txtPosicionRegistro.Text);
            formatoAct.PosicionReloj = Convert.ToInt32(txtPosicionReloj.Text);
            formatoAct.PrefijoReloj = txtPrefijoReloj.Text;

            formatoAct.SeparadorCampos = cbSeparador.Text;
            formatoAct.SeparadorFecha = cbSeparadorFecha.Text;
            formatoAct.SeparadorHora = cbSeparadorHora.Text;

            return formatoAct;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formatoAct = (FormatoExport)cbFormatos.SelectedItem;


        }

        private void cbFormatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                formatoAct = (FormatoExport)cbFormatos.SelectedItem;

                txtNombreFormato.Text = formatoAct.Nombre;
                txtCodEntrada.Text = formatoAct.CodEntrada;
                txtCodSalida.Text = formatoAct.CodSalida;
                txtLongitudLegajo.Text = formatoAct.LongitudLegajo.ToString();
                txtLongitudReloj.Text = formatoAct.LongitudReloj.ToString();
                txtPath.Text = formatoAct.Path;
                txtPosicionFecha.Text = formatoAct.PosicionFecha.ToString();
                txtPosicionHora.Text = formatoAct.PosicionHora.ToString();
                txtPosicionLegajo.Text = formatoAct.PosicionLegajo.ToString();
                txtPosicionRegistro.Text = formatoAct.PosicionMov.ToString();
                txtPosicionReloj.Text = formatoAct.PosicionReloj.ToString();
                txtPrefijoReloj.Text = formatoAct.PrefijoReloj;

                if (cbFormatoFecha.Items.Contains(formatoAct.FormatoFecha))
                {
                    cbFormatoFecha.Text = formatoAct.FormatoFecha;
                }
                else
                {
                    throw new AppException("El formato de la fecha no es válido.");
                }

                if (cbFormatoHora.Items.Contains(formatoAct.FormatoHora))
                {
                    cbFormatoHora.Text = formatoAct.FormatoHora;
                }
                else
                {
                    throw new AppException("El formato de la hora no es válido.");
                }
                if (cbSeparador.Items.Contains(formatoAct.SeparadorCampos))
                {
                    cbSeparador.Text = formatoAct.SeparadorCampos;
                }
                else
                {
                    throw new AppException("El separador de los campos no es válido.");
                }
                if (cbSeparadorFecha.Items.Contains(formatoAct.SeparadorFecha))
                {
                    cbSeparadorFecha.Text = formatoAct.SeparadorFecha;
                }
                else
                {
                    throw new AppException("El separador de la fecha no es válido.");
                }
                if (cbSeparadorHora.Items.Contains(formatoAct.SeparadorHora))
                {
                    cbSeparadorHora.Text = formatoAct.SeparadorHora;
                }else
                {
                    throw new AppException("El separador de la hora no es válido.");
                }
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Error al cargar formato seleccionado");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            formatoAct.Id = 0;
            LimpiarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(!base.Question("Está seguro que desea eliminar el formato seleccionado?", "Eliminar Formato"))
            {
                return;
            }
            try
            {
                lf = new LogicFormatos();
                FormatoExport fe = null;
                fe = (FormatoExport)cbFormatos.SelectedItem;
                if (fe == null) { throw new AppException("Error al intentar obtener el formato seleccionado."); }
                List<Reloj> equipos = new LogicReloj().GetAll();
                foreach (Reloj equipo in equipos)
                {
                    if (equipo.Formato == fe)
                        throw new AppException("El formato que desea eliminar se encuentra en uso en algún reloj.");
                }
                lf.DeleteFormato(fe);
                base.Informar("Formato eliminado correctamente.", "Eliminar Formato");
            }
            catch(AppException appex)
            {
                base.InformarError(appex.Message, "Eliminar Formato");
            }
        }
    }
}
