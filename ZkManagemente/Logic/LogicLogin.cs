using System;
using Database;
using Entidades;
using Util;

namespace Logic
{

    public class LogicLogin
    {        
        private static Usuario _usr; //---->Guardo el usuario que inicio

        public static Usuario Usuario
        {
            get
            {
                return _usr;
            }
        }
        public void MonitorMode(Usuario usuario)
        {
            _usr = usuario;
            Log(usuario.Usr);
        }
        private void Log(string usr)
        {
            Logger.LogInfo("-----------------------------------------------------------------\n");
            Logger.LogInfo(" ---------" + " Sesión Iniciada: " + usr.ToUpper() + " ---------" + "\n");
        }
        public void ValidarUsuario(Usuario usuario)
        {
            try
            {
                _usr = DataUsuarios.Instancia.GetUsuario(usuario);
                if (_usr.Usr == null) { throw new AppException("Usuario invalido"); }
                if (_usr.PassDecrypt != usuario.PassDecrypt) { throw new AppException("Password invalida"); }
                DataUsuarios.Instancia.SetUltimLogin(_usr);
                Log(_usr.Usr);
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
        public bool TestConnection()
        {
            bool test = false;
            try
            {
                test = FactoryConnection.Instancia.TestConexion();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Ocurrió un error no esperado al testear la conexión a la base de datos.", "Fatal", ex);
            }
            return test;
        }
    }
}
