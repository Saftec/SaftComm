
using System;
using Entidades;
using Logic;
using ZkManagement.NewUI.Generic;
using Util;
using System.Collections.Generic;

namespace ZkManagement.NewUI
{
    public partial class EditReloj : GenericAbm
    {
        private Reloj reloj;
        private List<FormatoExport> formatos;

        public EditReloj()
        {
            InitializeComponent();
            formatos = new LogicFormatos().GetFormatos();
            foreach (FormatoExport formato in formatos)
            {
                cbFormatos.Items.Add(formato);
            }
        }

        public void MapearAFormulario(Reloj r)
        {
            reloj = r;
            if (r.Id > 0)
            {
                txtClave.Text = r.Clave;
                txtDns.Text = r.DNS;
                txtIp.Text = r.IP;
                txtNombre.Text = r.Nombre;
                txtNumero.Text = r.Numero.ToString();
                txtPuerto.Text = r.Puerto.ToString();
                foreach (FormatoExport formato in formatos)
                {
                    if (formato.Id == r.IdFormato)
                    {
                        cbFormatos.SelectedItem = formato;
                        break;
                    }
                }
                cbxRutinas.Checked = r.Rutina;
            }
        }

        private Reloj MapearDeFormulario()
        {
            int valor = 0;
            if(int.TryParse(txtNumero.Text, out valor))
            {
                reloj.Numero = valor;
            }else
            {
                base.InformarError("Error al intentar convertir número a entero.", "Editar Equipos.");
            }

            if(int.TryParse(txtPuerto.Text, out valor))
            {
                reloj.Puerto = valor;
            }
            else
            {
                base.InformarError("Error al intentar convertir puerto a entero.", "Editar Equipos.");
            }
      
            reloj.Nombre = txtNombre.Text;
            reloj.IP = txtIp.Text;
            reloj.DNS = txtDns.Text;
            reloj.Clave = txtClave.Text;
            foreach (FormatoExport formato in formatos)
            {
                if (formato.Nombre == cbFormatos.Text)
                {
                    reloj.IdFormato = formato.Id;
                    break;
                }
            }
            reloj.Rutina = cbxRutinas.Checked;
            return reloj;
        }

        protected override bool Validar()
        {
            Validate v = new Validate();

            if (!v.NotEmpty(new string[] { txtIp.Text }) && !v.NotEmpty(new string[] { txtDns.Text }))
            {
                base.InformarError("Debe ingresar una dirección ip o un host dns.", "Modificar Reloj.");
                return false;
            }
            else
            {
                if (!v.NotEmpty(new string[] { txtDns.Text }) && !v.DireccionIP(new string[] { txtIp.Text })) //SI INGRESÓ UNA DIRECCIÓN IP VALIDO QUE SEA CORRECTA.
                {
                    base.InformarError("El formato de la dirección ip ingresada no es valido.", "Modificar Reloj.");
                    return false;
                }
                else
                {
                    if (!v.NotEmpty(new string[] { txtPuerto.Text })) // SI INGRESÓ UNA DIRECCIÓN IP CORRECTA VALIDO QUE HAYA INGRESADO UN PUERTO.
                    {
                        base.InformarError("Debe ingresar un número de puerto.", "Modificar Reloj.");
                        return false;
                    }
                }
            }

            if (!v.NotEmpty(new string[] { txtNombre.Text, txtNumero.Text }))
            {
                base.InformarError("Debe ingresar un número y un nombre del equipo.", "Modificar Reloj.");
                return false;
            }
            return true;
        }

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if(reloj == null)
            {
                return;
            }
            if (!Validar())
            {
                return;
            }
            try
            {
                LogicReloj lr = new LogicReloj();
                reloj = MapearDeFormulario();
                lr.ModifReloj(reloj);
                PanelReloj.Instancia.RefreshGrid();
                base.Informar("Dispositivo guardado correctamente.", "Editar Dispositivo");
                reloj = null;
                PanelReloj.Instancia.RefreshGrid();
                this.Close();
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Editar Equipos");
            }

        }
        
        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}