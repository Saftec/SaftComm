using System;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Interfaz;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class ControladorLogin
    {
        public void ValidarUsuario(Usuario usuario)
        {
            Usuario usr = new Usuario();
            CatalogoUsuarios cu = new CatalogoUsuarios();
            ControladorArchivos ca = new ControladorArchivos();
            try
            {
                usr = cu.GetUsuario(usuario);
                if (usr.usr == null) { throw new AppException("Usuario invalido"); }
                if (usr.pass!=usuario.pass) { throw new AppException("Password invalida"); }

                Principal ppal = new Principal();
                ca.InicioSesion(usr.usr);
                ppal.SetPermisos(usr);
                ppal.Show();                               
            }
            catch  (Exception ex)
            {
                throw ex;
            }
        }
    }
}
