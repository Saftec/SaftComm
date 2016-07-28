using System;
using System.Collections.Generic;
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
                SqlCommand cmd = new SqlCommand("SELECT Usuario, Password FROM Usuarios u WHERE u.Usuario='" + usuario.Usr + "';", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                usr.Usr=(dr["Usuario"].ToString());
                usr.Pass = (dr["Password"].ToString());
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

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            conn = con.Conectar();
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios u INNER JOIN Permisos p ON u.idPermisos=p.IdPermisos",conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usr = new Usuario();
                    usr.Usr = (dr["Usuario"].ToString());
                    usr.Pass = (dr["Password"].ToString());
                    usr.Nivel = Convert.ToInt32((dr["idPermisos"]));
                    usr.Permisos = (dr["Permisos"].ToString());
                    usuarios.Add(usr);                  
                }
                dr.Close();
            }
            catch (SqlException)
            {
                throw new Exception("Error al consultar los datos de usuario");
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al consultar los datos de usuario");
            }
            conn.Close();
            return usuarios;
        }
    }
}
