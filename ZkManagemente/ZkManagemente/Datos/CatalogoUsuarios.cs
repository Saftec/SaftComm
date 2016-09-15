using System;
using System.Data;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoUsuarios
    {
        private string query = string.Empty;
        public Usuario GetUsuario(Usuario usuario)
        {
            Usuario usr = new Usuario();
            SqlDataReader dr;
            try
            {
                query = "SELECT Usuario, Password, IdUsuario, idPermisos FROM Usuarios u WHERE u.Usuario='" + usuario.Usr + "';";
                SqlCommand cmd = new SqlCommand(query, Conexion.OpenConn());
                dr = cmd.ExecuteReader();
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
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al consultar datos de usuario");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);            
               throw new Exception("Error desconocido al consultar datos de usuario");
            }
            finally
            {
                try
                {
                    Conexion.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return usr;
        }

        public DataTable GetUsuarios()
        {
            DataTable usuarios = new DataTable();
            SqlDataAdapter da;
            SqlCommand cmd;
            try
            {
                query = "SELECT IdUsuario, Usuario, Password, u.IdPermisos, Permisos FROM Usuarios u INNER JOIN Permisos p ON u.idPermisos=p.IdPermisos";
                cmd = new SqlCommand(query, Conexion.OpenConn());
                da = new SqlDataAdapter(cmd);
                da.Fill(usuarios);
                da.Dispose();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al consultar los datos de usuario");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al consultar los datos de usuario");
            }
            finally
            {
                try
                {
                    Conexion.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return usuarios;
        }

        public void AltaUsuario(Usuario usr)
        {
            try
            {
                query = "INSERT INTO Usuarios (Usuario, Password, IdPermisos) VALUES('" + usr.Usr + "', '" + usr.Pass + "', '" + usr.Nivel + "')";
                SqlCommand cmd = new SqlCommand(query, Conexion.OpenConn());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar dar de alta el empelado");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar dar de alta el empelado");
            }
            finally
            {
                try
                {
                    Conexion.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void ModifUsuario(Usuario usr)
        {
            SqlCommand cmd;
            try
            {
                query = "UPDATE Usuarios SET Usuario='" + usr.Usr + "', Password='" + usr.Pass + "', IdPermisos=" + usr.Nivel.ToString() + " WHERE IdUsuario=" + usr.Id.ToString();
                cmd = new SqlCommand(query, Conexion.OpenConn());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar modificar usuario");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar modificar usuario");
            }
            finally
            {
                try
                {
                     Conexion.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void EliminarUsuario(Usuario usr)
        {
            try
            {
                query = "DELETE FROM Usuarios WHERE IdUsuario=" + usr.Id;
                SqlCommand cmd = new SqlCommand(query, Conexion.OpenConn());
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar eliminar el usuario");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar eliminar el usuario");
            }
            finally
            {
                try
                {
                    Conexion.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
