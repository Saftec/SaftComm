using System;
using System.Configuration;
using System.Data.SqlClient;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class Conexion
    {
        private static int cantConn;
        private static Conexion _instancia;
        private static SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsSQL"].ConnectionString);

        private Conexion() { }
        public static Conexion GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Conexion();
                
            }
            return _instancia;
        }
        public SqlConnection GetConn()
        {
            try
            {
                cantConn++;
                _conn.Open();
            }
            catch(SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar conectar a la base de datos");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar conectar a la base de datos");
            }
            return _conn;
        }

        public void ReleaseConn()
        {
            try
            {
                cantConn--;                
                if (cantConn == 0)
                {
                    _conn.Close();
                }
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar cerrar la conexión a la base de datos");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar cerrar la conexión a la base de datos");
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
