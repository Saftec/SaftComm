using System;
using System.Data.SqlClient;
using System.Data;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class DataDeptos
    {
        private string query = string.Empty;

        private DataTable GetDeptos() //CREAR UNA ENTIDAD DEPARTAMENTO PARA PODER DEVOLVER UN LIST<DEPTO>
        {
            IDbCommand cmd = null; 
            DataTable departamentos = new DataTable();
            try
            {
                query = "SELECT IdDepto, Nombre, Nivel FROM Departamentos";
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
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
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
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
            IDbCommand cmd = null;
            query = "INSERT INTO Departamentos (IdDepto, Nombre, Nivel) VALUES('" + nombre + "', " + nivel.ToString() + ")";
            try
            {
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
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
            finally
            {
                try
                {
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
