using System;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Interfaz;
using ZkManagement.Util;

namespace ZkManagement.Logica
{

    class ControladorLogin
    {        
        private static Usuario usr = new Usuario(); //---->La uso como variable de sesión
        public void ValidarUsuario(Usuario usuario)
        {                       
            try
            {
                usr = CatalogoUsuarios.GetInstancia().GetUsuario(usuario);
                if (usr.Usr == null) { throw new AppException("Usuario invalido"); }
                if (Encrypt.DesEncriptar(usr.Pass)!=usuario.Pass) { throw new AppException("Password invalida"); }
                CatalogoUsuarios.GetInstancia().SetUltimLogin(usr);
                Logger.GetLogger().Info("-----------------------------------------------------------------\n");
                Logger.GetLogger().Info(" ---------" + " Sesión Iniciada: " + usr.Usr.ToUpper() + " ---------" + "\n");
                Principal.GetInstancia().SetPermisos(usr);
                Principal.GetInstancia().Show();                               
            }
            catch  (Exception ex)
            {
                throw ex;
            }
        }
        public bool CheckConexion()
        {
            try
            {
                return (Conexion.GetInstancia().TestConexion());
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
            return usr.Nivel;
        }
    }
}
