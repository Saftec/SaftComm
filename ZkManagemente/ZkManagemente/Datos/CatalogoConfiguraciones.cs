using System;
using System.Data.SqlClient;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoConfiguraciones
    {
        private string query = string.Empty;

        public string GetConfig(int id)
        {         
            string valor;
            SqlCommand cmd;
            SqlDataReader dr;
            try
            {

                query = "SELECT Valor FROM Configuracion WHERE ConfigId=" + id.ToString();
                cmd = new SqlCommand(query,Conexion.OpenConn());
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
                try
                {
                    Conexion.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return valor;
        }

        public void SetConfig(int id, string valor)
        {
            try
            {
                query = "UPDATE Configuracion SET Valor='" + valor + "' WHERE ConfigId=" + id.ToString();
                SqlCommand cmd = new SqlCommand(query, Conexion.OpenConn());
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
                try
                {
                    Conexion.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
