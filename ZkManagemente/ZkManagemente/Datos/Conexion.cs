using System;
using System.Configuration;
using System.Data.SqlClient;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class Conexion
    {
        public SqlConnection Conectar()
        {         
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["cnsSQL"].ConnectionString;
            try
            {
                conn.Open();
            }
            catch (SqlException sqlex)
            {               
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw sqlex;
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw ex;
            }
            return conn;
        }

        public bool TestConexion()
        {
            Conexion con = new Conexion();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = con.Conectar();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al conectar con la base de datos");
            }
            if (conn.State==System.Data.ConnectionState.Open) { return true; }
            else { return false; }
        }
    }
}
