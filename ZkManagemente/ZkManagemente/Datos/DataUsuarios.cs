using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class DataUsuarios
    {
        private static DataUsuarios _instancia;

        public static DataUsuarios Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DataUsuarios();
                }
                return _instancia;
            }

        }
        private string query = string.Empty;
        public Usuario GetUsuario(Usuario usuario)
        {
            Usuario usr = new Usuario();
            IDataReader dr = null;
            try
            {
                query = "SELECT Usuario, Password, IdUsuario, idPermisos FROM Usuarios u WHERE u.Usuario='" + usuario.Usr + "';";
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                if (dr.Read())
                {
                    usr.Usr = (dr["Usuario"].ToString());
                    usr.PassDecrypt = (dr["Password"].ToString());
                    usr.Id = Convert.ToInt32(dr["IdUsuario"]);
                    usr.Nivel = Convert.ToInt32(dr["IdPermisos"]);
                }else
                {
                    throw new AppException("Usuario incorrecto");
                }
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
                    if(dr != null)
                    {
                        dr.Close();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return usr;
        }

        public List<Usuario> GetUsuarios()
        {
            IDataReader dr = null;
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                query = "SELECT IdUsuario, Usuario, Password, u.IdPermisos, UltimoInicio, Permisos FROM Usuarios u INNER JOIN Permisos p ON u.idPermisos=p.IdPermisos";
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                while (dr.Read())
                {
                    Usuario usr = new Usuario();
                    DateTime fecha;

                    usr.Usr = (dr["Usuario"].ToString());
                    usr.PassDecrypt = (dr["Password"].ToString());
                    usr.Id = Convert.ToInt32(dr["IdUsuario"]);
                    usr.Nivel = Convert.ToInt32(dr["IdPermisos"]);
                    usr.Permisos = (dr["Permisos"].ToString());

                    if(DateTime.TryParse(dr["UltimoInicio"].ToString(), out fecha))
                    {
                        usr.UltimoAcceso = fecha;
                    }
                    else
                    {
                        usr.UltimoAcceso = null;
                    }

                    usuarios.Add(usr);
                }
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
                    if (dr != null)
                    {
                        dr.Close();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
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
            IDbCommand cmd = null;
            try
            {
                query = "INSERT INTO Usuarios (Usuario, Password, IdPermisos) VALUES('" + usr.Usr + "', '" + usr.PassEncrypt + "', '" + usr.Nivel + "')";
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
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
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void ModifUsuario(Usuario usr)
        {
            IDbCommand cmd = null;
            try
            {
                query = "UPDATE Usuarios SET Usuario='" + usr.Usr + "', Password='" + usr.PassEncrypt + "', IdPermisos=" + usr.Nivel.ToString() + " WHERE IdUsuario=" + usr.Id.ToString();
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
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
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                     FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void EliminarUsuario(Usuario usr)
        {
            IDbCommand cmd = null;
            try
            {
                query = "DELETE FROM Usuarios WHERE IdUsuario=" + usr.Id;
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
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
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void SetUltimLogin(Usuario usr)
        {
            IDbCommand cmd = null;
            try
            {
                query = "UPDATE Usuarios SET UltimoInicio='" + DateTime.Now + "' WHERE IdUsuario=" + usr.Id.ToString();
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar actualizar la tabla usuarios");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar actualizar la tabla usuario");
            }
            finally
            {
                try
                {
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
