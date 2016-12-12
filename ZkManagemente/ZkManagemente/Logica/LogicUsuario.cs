using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class LogicUsuario
    {
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                usuarios = DataUsuarios.Instancia.GetUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuarios;
        }

        #region ABM
        public void ModificarUsuario(Usuario usuario)
        {
            try
            {
                DataUsuarios.Instancia.ModifUsuario(usuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarUsuario(Usuario usuario)
        {
            try
            {
                DataUsuarios.Instancia.AltaUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarUsuario(Usuario usuario)
        {
            try
            {
                DataUsuarios.Instancia.EliminarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion //-->DFalta agregar usuario!
    }
}
