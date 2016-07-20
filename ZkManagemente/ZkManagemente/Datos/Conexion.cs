using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ZkManagement.Datos
{
    class Conexion
    {
        public object ConfigurationManager { get; private set; }

        public SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-1FK88J0\SQLSERVER;Initial Catalog=ZkManagement;Integrated Security=True";
      //      conn.ConnectionString = ConfigurationManager.ConnectionStrings["cnsSQL"].ConnectionString;
            try
            {
                conn.Open();
            }
            catch (SqlException ex) //LOGUEAR ERRORES!
            { 
            }

            return conn;
        }

        public SqlConnection TestConexion()
        {
            Conexion con = new Conexion();
            SqlConnection conn = new SqlConnection();

            conn = con.Conectar();
            return conn;
        }

        public void ModificarStringConnection(String cadena)
        {
      //      ConfigurationManager.ConnectionStrings["cnsSQL"].ConnectionString = cadena;
        }

    }
}
