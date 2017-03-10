using System;
using Entidades;
using Logic;
using ZkManagement.NewUI.Generic;
using Util;

namespace ZkManagement.NewUI
{
    public partial class EditPsw : GenericAbm
    {
        Usuario usrAct;
        LogicUsuario lu;

        public EditPsw()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, System.EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            try
            {
                lu = new LogicUsuario();
                usrAct = MapearDeForm();
                lu.ModificarUsuario(usrAct);
                base.Informar("La contraseña ha sido modificada correctamente.", "Modificar Contraseña.");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message, "Modificar Contraseña.");
            }
        }

        protected new Usuario MapearDeForm()
        {
            usrAct.PassEncrypt = txtPswNew1.Text;
            return usrAct;
        }
        public void SetUsuario(Usuario u)
        {
            usrAct = u;
        }
        protected override bool Validar()
        {
            Validate v = new Validate();

            if(!v.NotEmpty(new string[] { txtPswVieja.Text, txtPswNew1.Text, txtPswNew2.Text }))
            {
                base.InformarError("Los campos no pueden estar vacíos.", "Modificar Contraseña.");
                return false;
            }
            if (txtPswVieja.Text != usrAct.PassDecrypt)
            {
                base.InformarError("La contraseña ingresada no coincide con la actual", "Modificar Contraseña.");
                return false;
            }
            if (txtPswNew1.Text != txtPswNew2.Text)
            {
                base.InformarError("Las contraseñas ingresadas no coinciden", "Modificar Contraseña.");
                return false;
            }
            return true;
        }
    }
}
