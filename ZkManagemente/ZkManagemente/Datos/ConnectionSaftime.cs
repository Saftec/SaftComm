using System;
using System.Configuration;
using System.Data.SqlClient;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class ConnectionSaftime
    {
        private static ConnectionSaftime _instancia;
        private static SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["saftimeDB"].ConnectionString);

        private ConnectionSaftime() { }
        public static ConnectionSaftime GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ConnectionSaftime();
            }
            return _instancia;
        }
        public SqlConnection GetConn()
        {
            try
            {
                _conn.Open();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar conectar a la base de datos Saftime");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar conectar a la base de datos de Saftime");
            }
            return _conn;
        }

        public void ReleaseConn()
        {
            try
            {
               _conn.Close();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar cerrar la conexión a la base de datos de Saftime");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar cerrar la conexión a la base de datos de Saftime");
            }
        }
        public bool TestConexion()
        {
            try
            {
                GetConn();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al conectar con la base de datos");
            }
            if (_conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return true;
            }
            else { return false; }
        }
    }
}
