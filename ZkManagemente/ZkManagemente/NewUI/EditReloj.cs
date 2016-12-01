
using System;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.NewUI.Generic;

namespace ZkManagement.NewUI
{
    public partial class EditReloj : GenericAbm
    {
        private Reloj reloj; 
        public EditReloj()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
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
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
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
    }
}
