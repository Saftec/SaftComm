using System;
using System.Data;
using Util;
using System.Data.Common;

namespace Database
{
    public class DataDeptos
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
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al consultar la tabla de Departamentos", "Error", dbex);
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al intentar consultar la tabla de Departamentos", "Fatal", ex);
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
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar agregar el Departamento a la base de datos", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar crear el departamento", "Fatal", ex);
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
