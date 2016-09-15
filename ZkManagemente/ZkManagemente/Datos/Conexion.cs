using System;
using System.Configuration;
using System.Data.SqlClient;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class Conexion
    {
        private static int cantConn;
        private static SqlConnection instancia;

        private static SqlConnection GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new SqlConnection();
                instancia.ConnectionString = ConfigurationManager.ConnectionStrings["cnsSQL"].ConnectionString;
            }
            return instancia;
        }
        public static SqlConnection OpenConn()
        {
            try
            {
                cantConn++;
                GetInstancia().Open();
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
            return GetInstancia();
        }

        public static void ReleaseConn()
        {
            try
            {
                cantConn--;                
                if (cantConn == 0)
                {
                    instancia.Close();
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
                OpenConn();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al conectar con la base de datos");
            }
            if (GetInstancia().State == System.Data.ConnectionState.Open)
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
