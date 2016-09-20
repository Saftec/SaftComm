using System;
using System.Data;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorABMUsuarios
    {        public DataTable GetUsuarios()
        {
            DataTable usuarios = new DataTable();
            try
            {
                usuarios = CatalogoUsuarios.GetInstancia().GetUsuarios();
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
                CatalogoUsuarios.GetInstancia().ModifUsuario(usuario);
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
                CatalogoUsuarios.GetInstancia().AltaUsuario(usuario);
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
                CatalogoUsuarios.GetInstancia().EliminarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion //-->DFalta agregar usuario!
    }
}
