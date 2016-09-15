using System;
using System.Data.SqlClient;
using System.Data;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoDepartamentos
    {

        private DataTable GetDeptos()
        {
            DataTable departamentos = new DataTable();
            try
            {
                string query = "SELECT * FROM Departamentos";
                SqlCommand cmd = new SqlCommand(query, Conexion.OpenConn());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(departamentos);
                da.Dispose();
            }
            catch(SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Error(ex.StackTrace);
            }
            finally
            {
                try
                {
                    Conexion.ReleaseConn();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            return departamentos;
        }

        private void AddDept()
        {

        }
    }
}
