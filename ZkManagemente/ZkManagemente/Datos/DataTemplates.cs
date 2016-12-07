using System;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;
using System.Data;

namespace ZkManagement.Datos
{
    class DataTemplates
    {
        // Patrón Singleton //
        private static DataTemplates _instancia;
        public static DataTemplates Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DataTemplates();
                }
                return _instancia;
            }

        }

        // Hasta acá //

        private string query = string.Empty;
        public void InsertarHuella(Huella h)
        {
            IDbCommand cmd = null;
            try
            {
                query = "INSERT INTO Huellas (IdEmpleado, Template, FingerIndex, Lengh, Flag) VALUES(" + h.Empleado.Legajo.ToString() + ", '" + h.Template + "', '" + h.FingerIndex.ToString() + "', '" + h.Lengh.ToString() + "', '" + h.Flag.ToString() + "')";
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al insertar registros en la tabla huellas");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar actualizar en la tabla huellas");
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

        public bool Existe(Huella h)
        {
            IDataReader dr = null;
            try
            {
                query = "SELECT HuellaId FROM HUELLAS WHERE IdEmpleado='" + h.Empleado.Id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'";
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                if (dr.Read())
                {                    
                    return true;
                }
                else
                {
                    return false;                  
                }
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al consultar la tabla de huellas");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al consultar la tabla huellas");
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
        }

        public void ActualizarHuella(Huella h)
        {
            IDbCommand cmd = null;
            try
            {
                query = "UPDATE Huellas SET Template='" + h.Template + "', Lengh='" + h.Lengh + "', Flag='" + h.Flag.ToString() +
                    "' WHERE IdEmpleado='" + h.Empleado.Id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'";

                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al actualizar la tabla de huellas");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al actualizar la tabla huellas");
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
        public void EliminarHuella(Huella h)
        {
            IDbCommand cmd = null;
            try
            {
                query = "DELETE FROM Huellas WHERE IdEmpleado=" + h.Empleado.Id.ToString();
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar eliminar las huellas");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar eliminar las huellas");
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
