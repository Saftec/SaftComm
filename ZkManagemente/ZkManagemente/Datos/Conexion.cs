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
            conn.ConnectionString = @"Data Source=SAF05\sqlexpress;Initial Catalog=ZkManagement;Integrated Security=True;User ID=saftec;Password=ana";
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
