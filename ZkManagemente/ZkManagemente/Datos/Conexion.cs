using log4net;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ZkManagement.Datos
{
    class Conexion
    {
        ILog logger = LogManager.GetLogger("Conexion.cs");
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
                logger.Error(sqlex.StackTrace);
                throw sqlex;
            }
            catch(Exception ex)
            {
                logger.Fatal(ex.StackTrace);
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
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al conectar con la base de datos");
            }
            if (conn.State==System.Data.ConnectionState.Open) { return true; }
            else { return false; }
        }
    }
}
