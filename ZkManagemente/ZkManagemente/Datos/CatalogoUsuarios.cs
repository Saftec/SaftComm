using System;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoUsuarios
    {
        Conexion con = new Conexion();
        SqlConnection conn = new SqlConnection();
        public Usuario GetUsuario(Usuario usuario)
        {
            Usuario usr = new Usuario();
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT Usuario, Password FROM Usuarios u WHERE u.Usuario='" + usuario.usr + "';", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                usr.usr=(dr["Usuario"].ToString());
                usr.pass = (dr["Password"].ToString());
                dr.Close();
            }

           catch(InvalidOperationException)  //si cacheo esto es porque la consulta no devolvió nada
            {
                throw new AppException("Usuario incorrecto");
            }
            catch(SqlException sqlEx)
            {
                Program.log.Error(sqlEx.Message);
                throw new Exception("Error al consultar datos de usuario");
            }
            catch(Exception ex)
            {
                Program.log.Error(ex.Message);
                throw new Exception("Error desconocido al consultar datos de usuario");
            }
            conn.Close();
            return usr;
        }
    }
}
