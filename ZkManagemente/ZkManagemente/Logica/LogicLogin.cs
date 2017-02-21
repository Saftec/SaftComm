using System;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Logica
{

    class LogicLogin
    {        
        private static Usuario _usr; //---->Guardo el usuario que inicio

        public static Usuario Usuario
        {
            get
            {
                return _usr;
            }
        }
        public void ValidarUsuario(Usuario usuario)
        {
            try
            {
                _usr = DataUsuarios.Instancia.GetUsuario(usuario);
                if (_usr.Usr == null) { throw new AppException("Usuario invalido"); }
                if (_usr.PassDecrypt != usuario.PassDecrypt) { throw new AppException("Password invalida"); }
                DataUsuarios.Instancia.SetUltimLogin(_usr);
                Logger.GetLogger().Info("-----------------------------------------------------------------\n");
                Logger.GetLogger().Info(" ---------" + " Sesión Iniciada: " + _usr.Usr.ToUpper() + " ---------" + "\n");
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado durante la validación de usuario", "Fatal", ex);
            }
        }
        public bool CheckConexion()
        {
            try
            {
                return true;
                //return (FactoryConnection.Instancia.TestConexion());
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                Logger.GetLogger("").Fatal(ex.StackTrace);
                throw ex;
            }
            
        }
    }
}
