using log4net;
using System;
using System.Data;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoUsuarios
    {
        private Conexion con = new Conexion();
        private SqlConnection conn = new SqlConnection();
        private ILog logger = LogManager.GetLogger("");
        public Usuario GetUsuario(Usuario usuario)
        {
            Usuario usr = new Usuario();
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT Usuario, Password, IdUsuario, idPermisos FROM Usuarios u WHERE u.Usuario='" + usuario.Usr + "';", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                usr.Usr = (dr["Usuario"].ToString());
                usr.Pass = (dr["Password"].ToString());
                usr.Id = Convert.ToInt32(dr["IdUsuario"]);
                usr.Nivel = Convert.ToInt32(dr["IdPermisos"]);
                dr.Close();
            }

           catch(InvalidOperationException)  //Si cacheo esto es porque la consulta no devolvió nada
            {
                throw new AppException("Usuario incorrecto");
            }
            catch(SqlException sqlex)
            {
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al consultar datos de usuario");
            }
            catch(Exception ex)
            {
                logger.Fatal(ex.StackTrace);            
               throw new Exception("Error desconocido al consultar datos de usuario");
            }
            conn.Close();
            return usr;
        }

        public DataTable GetUsuarios()
        {
            DataTable usuarios = new DataTable();
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT IdUsuario, Usuario, Password, u.IdPermisos, Permisos FROM Usuarios u INNER JOIN Permisos p ON u.idPermisos=p.IdPermisos", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(usuarios);
                da.Dispose();
            }
            catch (SqlException sqlex)
            {
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al consultar los datos de usuario");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.StackTrace);
               throw new Exception("Error desconocido al consultar los datos de usuario");
            }
            conn.Close();
            return usuarios;
        }

        public void AltaUsuario(Usuario usr)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios VALUES('" + usr.Usr + "', '" + usr.Pass + "', '" + usr.Nivel + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al intentar dar de alta el empelado");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar dar de alta el empelado");
            }
            conn.Close();
        }

        public void ModifUsuario(Usuario usr)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Usuario='" + usr.Usr + "', Password='" + usr.Pass + "', IdPermisos=" + usr.Nivel.ToString() + " WHERE IdUsuario=" + usr.Id.ToString(),conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al intentar modificar usuario");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar modificar usuario");
            }
            conn.Close();
        }

        public void EliminarUsuario(Usuario usr)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE IdUsuario=" + usr.Id,conn);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlex)
            {
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al intentar eliminar el usuario");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar eliminar el usuario");
            }
            conn.Close();
        }
    }
}
