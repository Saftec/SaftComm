using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ZkManagement.Datos
{
    class Conexion
    {
        public SqlConnection Conectar()
        {
            Program.log.Error("ERRROR");         
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=SAF05\SQLEXPRESS; Initial Catalog=ZkManagement;Integrated Security=True;User ID=saftec;Password=ana";
            try
            {
                conn.Open();
            }
            catch (SqlException sqlex) //LOGUEAR ERRORES!
            {
                Program.log.Info(sqlex.Message);
            }
            catch(Exception ex)
            {
                Program.log.Info(ex.Message);
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
           //ConfigurationManager.ConnectionStrings["cnsSQL"].ConnectionString = cadena;
        }

    }
}
