using System;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.NewUI.Generic;
using ZkManagement.Util;

namespace ZkManagement.NewUI
{
    public partial class EditUsuario : GenericAbm
    {
        Usuario usrAct;
        LogicUsuario lu;
        public EditUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, System.EventArgs e)
        {
            if(usrAct == null)
            {
                return;
            }
            if (!Validar())
            {
                return;
            }
            lu = new LogicUsuario();
            try
            {
                if (usrAct.Id > 0)
                {
                    lu.AgregarUsuario(usrAct);
                }else
                {
                    lu.ModificarUsuario(usrAct);
                }
                PanelUsuario.Instancia.RefreshGrid();
                base.Informar("Usuario modificado correctamente.", "Modificar Usuario.");
                usrAct = null;
                this.Close();
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Modificar Usuario.");
            }
        }

        public void MapearAForm(Usuario u)
        {
            usrAct = u;
            if (usrAct.Id == 0)
            {
                return;
            }
            txtUsuario.Text = usrAct.Usr;
            cbPermisos.SelectedIndex = usrAct.Nivel - 1;
         
        }

        protected override bool Validar()
        {
            Validate v = new Validate();

            if(!v.NotEmpty(new string[] { txtUsuario.Text }))
            {
                base.InformarError("Debe ingresar un nombre de usuario.", "Modificar Usuario.");
                return false;
            }

            if (cbPermisos.SelectedIndex == -1)
            {
                base.InformarError("Debe seleccionar un nivel de permisos.", "Modificar Usuario.");
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
