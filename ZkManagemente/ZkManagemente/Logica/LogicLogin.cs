using System;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Interfaz;
using ZkManagement.Util;

namespace ZkManagement.Logica
{

    class LogicLogin
    {        
        private static Usuario usr; //---->Guardo el usuario que inicio
        public void ValidarUsuario(Usuario usuario)
        {
            try
            {
                usr = DataUsuarios.Instancia.GetUsuario(usuario);
                if (usr.Usr == null) { throw new AppException("Usuario invalido"); }
                if (usr.PassDecrypt != usuario.PassDecrypt) { throw new AppException("Password invalida"); }
                DataUsuarios.Instancia.SetUltimLogin(usr);
                Logger.GetLogger().Info("-----------------------------------------------------------------\n");
                Logger.GetLogger().Info(" ---------" + " Sesión Iniciada: " + usr.Usr.ToUpper() + " ---------" + "\n");
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
                throw ex;
            }
            
        }
        public int GetUsrId()
        {
            return usr.Id;
        }

        public int GetNivelUsr()
        {
            return 1; //usr.Nivel;
        }
    }
}
