using log4net;
using System;
using System.Data;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Interfaz;
using ZkManagement.Util;

namespace ZkManagement.Logica
{

    class ControladorLogin
    {        
        private CatalogoUsuarios cu = new CatalogoUsuarios();
        private static Usuario usr = new Usuario(); //---->La uso como variable de sesión
        private ILog logger = LogManager.GetLogger("");
        public void ValidarUsuario(Usuario usuario)
        {                       
            try
            {
                usr = cu.GetUsuario(usuario);
                if (usr.Usr == null) { throw new AppException("Usuario invalido"); }
                if (usr.Pass!=usuario.Pass) { throw new AppException("Password invalida"); }

                principal ppal = new principal();
                logger.Info("-----------------------------------------------------------------\n");
                logger.Info(" ---------" + " Sesión Iniciada: " + usr.Usr.ToUpper() + " ---------" + "\n");
                ppal.SetPermisos(usr);
                ppal.Show();                               
            }
            catch  (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetUsuarios()
        {
            DataTable usuarios = new DataTable();
            try
            {
                usuarios = cu.GetUsuarios();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return usuarios;
        }

        public void ModificarUsuario(Usuario usuario)
        {
            if (usuario.Id==0)
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
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            
        }

        public void EliminarUsuario(Usuario usuario)
        {
            try
            {
                cu.EliminarUsuario(usuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool CheckConexion()
        {
            Conexion con = new Conexion();
            try
            {
                return (con.TestConexion());
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
