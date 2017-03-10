using System;
using System.Collections.Generic;
using Database;
using Entidades;
using Util;

namespace Logic { 

    public class LogicUsuario
    {
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                usuarios = DataUsuarios.Instancia.GetUsuarios();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al consultar usuarios.", "Fatal", ex);
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
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al modoficar usuario.", "Fatal", ex);
            }
        }

        public void AgregarUsuario(Usuario usuario)
        {
            try
            {
                DataUsuarios.Instancia.AltaUsuario(usuario);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al agregar usuario.", "Fatal", ex);
            }

        }

        public void EliminarUsuario(Usuario usuario)
        {
            try
            {
                DataUsuarios.Instancia.EliminarUsuario(usuario);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al eliminar usuario.", "Fatal", ex);
            }
        }
        #endregion
    }
}
