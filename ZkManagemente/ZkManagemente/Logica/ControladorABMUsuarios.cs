using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorABMUsuarios
    {
        private CatalogoUsuarios cu;
        public DataTable GetUsuarios()
        {
            DataTable usuarios = new DataTable();
            cu = new CatalogoUsuarios();
            try
            {
                usuarios = cu.GetUsuarios();
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
            cu = new CatalogoUsuarios();
            if (usuario.Id == 0)
            {
                try
                {
                    cu.AltaUsuario(usuario);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                try
                {
                    cu.ModifUsuario(usuario);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public void EliminarUsuario(Usuario usuario)
        {
            cu = new CatalogoUsuarios();
            try
            {
                cu.EliminarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion //-->DFalta agregar usuario!
    }
}
