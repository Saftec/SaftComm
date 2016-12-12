using System;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.NewUI.Generic;
using ZkManagement.Util;

namespace ZkManagement.NewUI
{
    public partial class EditUsuario : GenericAbm
    {
        Usuario usrAct = new Usuario();
        LogicUsuario lu;
        public EditUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, System.EventArgs e)
        {
            if (!Validar())
            {
                Informar("Error", "error");
            }
            lu = new LogicUsuario();
            try
            {
                
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Modificar Usuario.");
            }
        }

        public void MapearAForm(Usuario u)
        {
            usrAct = u;
            txtUsuario.Text = u.Usr;
            if (u.Id == 0)
            {

            }
        }

        protected override bool Validar()
        {
            Validate v = new Validate();

            if(!v.NotEmpty(new string[] { txtUsuario.Text }))
            {
                base.InformarError("Debe ingresar un nombre de usuario.", "Modificar Usuario.");
                return false;
            }

            // CONTRASEÑA //
            return true;
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
