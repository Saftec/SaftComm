using System;
using System.Data;
using System.Data.SqlClient;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class DataConfigs
    {
        // Patrón Singleton //
        private static DataConfigs _instancia;
        public static DataConfigs Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DataConfigs();
                }
                return _instancia;
            }

        }

        // Hasta acá //

        private string query = string.Empty;

        public string GetConfig(int id)
        {         
            string valor;
            IDataReader dr = null;
            try
            {

                query = "SELECT Valor FROM Configuracion WHERE ConfigId=" + id.ToString();
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                dr.Read();
                valor = dr["Valor"].ToString();
                dr.Close();
            }
            catch(SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx);
                throw new Exception("Error al consulta el valor de configuracion: " + id.ToString());
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al consultar el valor de configuracion: " + id.ToString());
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
            return valor;
        }

        public void SetConfig(int id, string valor)
        {
            IDbCommand cmd = null;
            try
            {
                query = "UPDATE Configuracion SET Valor='" + valor + "' WHERE ConfigId=" + id.ToString();
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al actualizar la tabla configuracion");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al actualizar la tabla configuracion");
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
