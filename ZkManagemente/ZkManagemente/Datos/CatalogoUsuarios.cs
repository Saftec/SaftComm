using System;
using System.Data.SqlClient;
using ZkManagement.Entidades;

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
            }

           catch(InvalidCastException)
            {
                throw new InvalidCastException("Usuario incorrecto");
            }
            catch(SqlException sqlEx)
            {
                throw sqlEx;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            conn.Close();
            return usr;
        }
    }
}
