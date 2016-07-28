using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Interfaz;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class ControladorLogin
    {
        private CatalogoUsuarios cu = new CatalogoUsuarios();
        public void ValidarUsuario(Usuario usuario)
        {
            Usuario usr = new Usuario();           
            ControladorArchivos ca = new ControladorArchivos();
            try
            {
                usr = cu.GetUsuario(usuario);
                if (usr.Usr == null) { throw new AppException("Usuario invalido"); }
                if (usr.Pass!=usuario.Pass) { throw new AppException("Password invalida"); }

                btnEmpleados ppal = new btnEmpleados();
                ca.InicioSesion(usr.Usr);
                ppal.SetPermisos(usr);
                ppal.Show();                               
            }
            catch  (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
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
    }
}
