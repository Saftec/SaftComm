using System;
using System.Collections.Generic;
using Database;
using Entidades;
using Util;

namespace Logic { 

    public class LogicUsuario
    {
        private DataUsuarios dataUsuarios;
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            dataUsuarios = new DataUsuarios();
            try
            {
                usuarios = dataUsuarios.GetUsuarios();
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
            dataUsuarios = new DataUsuarios();
            try
            {
                dataUsuarios.ModifUsuario(usuario);
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
            dataUsuarios = new DataUsuarios();
            try
            {
                dataUsuarios.AltaUsuario(usuario);
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
            dataUsuarios = new DataUsuarios();
            try
            {
                dataUsuarios.EliminarUsuario(usuario);
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
