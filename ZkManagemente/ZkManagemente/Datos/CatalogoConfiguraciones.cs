using System;
using System.Data.SqlClient;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoConfiguraciones
    {
        private Conexion con = new Conexion();
        private SqlConnection conn = new SqlConnection();

        public string GetConfig(int id)
        {         
            string valor;
            SqlCommand cmd;
            SqlDataReader dr;
            try
            {
                                
                conn = con.Conectar();
                cmd = new SqlCommand("SELECT Valor FROM Configuracion WHERE ConfigId=" + id.ToString(),conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                valor = dr["Valor"].ToString();
                dr.Close();
            }
            catch(SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx);
                throw new Exception("Error al consulta el valor de configuracion: " + id.ToString());
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al consultar el valor de configuracion: " + id.ToString());
            }
            finally
            {
                conn.Close();
            }
            return valor;
        }

        public void SetConfig(int id, string valor)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("UPDATE Configuracion SET Valor='"+valor+"' WHERE ConfigId=" + id,conn);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al actualizar la tabla configuracion");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al actualizar la tabla configuracion");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
