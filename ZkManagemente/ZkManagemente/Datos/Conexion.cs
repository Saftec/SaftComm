using log4net;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace ZkManagement.Datos
{
    class Conexion
    {
        public SqlConnection Conectar()
        {
            Program.log.Error("ERRROR");         
            SqlConnection conn = new SqlConnection();
            // conn.ConnectionString = @"Data Source=DESKTOP-1FK88J0\SQLSERVER;Initial Catalog=ZkManagement;Integrated Security=True";
            // conn.ConnectionString = @"Data Source=SAF05\SQLEXPRESS;Initial Catalog=ZkManagement;User ID=saftec;Password=ana";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["cnsSQL"].ConnectionString;
            try
            {
                conn.Open();
            }
            catch (SqlException sqlex) //LOGUEAR ERRORES!
            {
                Program.log.Info(sqlex.Message);
                throw sqlex;
            }
            catch(Exception ex)
            {
                Program.log.Info(ex.Message);
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
            catch (SqlException)
            {
                throw new Exception("Error al conectar con la base de datos");
            }
            if (conn.State==System.Data.ConnectionState.Open) { return true; }
            else { return false; }
        }

        public void ModificarStringConnection(string cadena)
        {
           ConfigurationManager.ConnectionStrings["cnsSQL"].ConnectionString = cadena;
        }

    }
}
