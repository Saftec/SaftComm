
using System;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.NewUI.Generic;
using ZkManagement.Util;

namespace ZkManagement.NewUI
{
    public partial class EditReloj : GenericAbm
    {
        private Reloj reloj; 
        public EditReloj()
        {
            InitializeComponent();
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
            reloj.Ip = txtIp.Text;
            reloj.DNS = txtDns.Text;
            reloj.Clave = txtClave.Text;

            return reloj;
        }
        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            try
            {
                LogicReloj lr = new LogicReloj();
                reloj = MapearDeFormulario();
                lr.ModifReloj(reloj);
                PanelEquipos.Instancia.RefreshGrid();
                base.Informar("Dispositivo guardado correctamente.", "Editar Dispositivo");
                this.Dispose();
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Editar Equipos");
            }

        }

        public void MapearAFormulario(Reloj r)
        {
            reloj = r;
            if (r.Id > 0)
            {
                txtClave.Text = r.Clave;
                txtDns.Text = r.DNS;
                txtIp.Text = r.Ip;
                txtNombre.Text = r.Nombre;
                txtNumero.Text = r.Numero.ToString();
                txtPuerto.Text = r.Puerto.ToString();
            }
        }

        protected override bool Validar()
        {
            Validate v = new Validate();

            if(!v.NotEmpty(new string[] {txtIp.Text }) && !v.NotEmpty(new string[] { txtDns.Text }))    
            {
                base.InformarError("Debe ingresar una dirección ip o un host dns.", "Modificar Reloj.");
                return false;
            }
            else
            {
                if(!v.NotEmpty(new string[] { txtDns.Text}) && !v.DireccionIP(new string[] { txtIp.Text })) //SI INGRESÓ UNA DIRECCIÓN IP VALIDO QUE SEA CORRECTA.
                {
                    base.InformarError("El formato de la dirección ip ingresada no es valido.", "Modificar Reloj.");
                    return false;
                }
                else
                {
                    if(!v.NotEmpty(new string[] { txtPuerto.Text })) // SI INGRESÓ UNA DIRECCIÓN IP CORRECTA VALIDO QUE HAYA INGRESADO UN PUERTO.
                    {
                        base.InformarError("Debe ingresar un número de puerto.", "Modificar Reloj.");
                        return false;
                    }
                }
            }

            if(!v.NotEmpty(new string[] { txtNombre.Text, txtNumero.Text }))
            {
                base.InformarError("Debe ingresar un número y un nombre del equipo.", "Modificar Reloj.");
                return false;
            }
            return true;
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
