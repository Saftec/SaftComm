using System;
using System.Data.SqlClient;
using ZkManagement.Datos;

namespace ZkManagement.Util
{
    class UltId
    {
        public int GetId(string tabla, string columna)
        {
            SqlConnection conn = new SqlConnection();
            Conexion con = new Conexion();
            int id = 0;
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT MAX(" + columna + ") as 'Id' FROM " + tabla, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                id = Convert.ToInt32(dr["Id"]);               
            }
            catch (SqlException)
            {
                throw new Exception("Error al consultar id de " + tabla);
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al consultar id de " + tabla);
            }
            return id;
        }

    }
}
