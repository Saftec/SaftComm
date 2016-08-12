using System;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using log4net;

namespace ZkManagement.Datos
{
    class CatalogoHuellas
    {
        private Conexion con = new Conexion();
        private SqlConnection conn = new SqlConnection();
        private ILog logger = LogManager.GetLogger("");

        public void InsertarHuella(Empleado emp)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Huellas VALUES(" + emp.Id.ToString() + ", '" + emp.Huella + "' )", conn);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
            {
                logger.Error(sqlEx.StackTrace);
                throw (sqlEx);
              //  throw new Exception("Error al insertar registros en la tabla huellas");
            }
            catch(Exception ex)
            {
                logger.Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar actualizar en la tabla huellas");
            }
            conn.Close();
        }
    }
}
