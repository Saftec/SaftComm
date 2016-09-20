using System;
using System.Data.SqlClient;
using System.Data;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoDepartamentos
    {
        private string query = string.Empty;

        private DataTable GetDeptos()
        {
            SqlCommand cmd;
            DataTable departamentos = new DataTable();
            try
            {
                query = "SELECT IdDepto, Nombre, Nivel FROM Departamentos";
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(departamentos);
                da.Dispose();
            }
            catch(SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al consultar la tabla de Departamentos");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar consultar la tabla de Departamentos");
            }
            finally
            {
                try
                {
                    Conexion.GetInstancia().ReleaseConn();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            return departamentos;
        }

        private void AddDept(string nombre, int nivel)
        {
            query = "INSERT INTO Departamentos (IdDepto, Nombre, Nivel) VALUES('" + nombre + "', " + nivel.ToString() + ")";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar agregar el Departamento a la base de datos");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar crear el departamento");
            }

        }
    }
}
