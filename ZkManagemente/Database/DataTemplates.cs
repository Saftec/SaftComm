using System;
using Entidades;
using Util;
using System.Data;
using System.Data.Common;

namespace Database
{
    public class DataTemplates
    {
        private string query = string.Empty;
        public void InsertarHuella(Huella h)
        {
            IDbCommand cmd = null;
            try
            {
                query = "INSERT INTO Huellas (IdEmpleado, Template, FingerIndex, Lengh, Flag) VALUES(" + h.Empleado.Legajo.ToString() + ", '" + h.Template + "', '" + h.FingerIndex.ToString() + "', '" + h.Lengh.ToString() + "', '" + h.Flag.ToString() + "')";
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al insertar registros en la tabla huellas", "Error", dbex);
            }
            catch(Exception ex)
            {
                throw new AppException("Error desconocido al intentar actualizar en la tabla huellas", "Fatal", ex);
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
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool Existe(Huella h)
        {
            IDataReader dr = null;
            try
            {
                query = "SELECT TOP 1 HuellaId FROM HUELLAS WHERE IdEmpleado='" + h.Empleado.Id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'";
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                if (dr.Read())
                {                    
                    return true;
                }
                else
                {
                    return false;                  
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al consultar la tabla de huellas", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al consultar la tabla huellas", "Fatal", ex);
            }
            finally
            {
                try
                {
                    if (dr != null)
                    {
                        dr.Close();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void ActualizarHuella(Huella h)
        {
            IDbCommand cmd = null;
            try
            {
                query = "UPDATE Huellas SET Template='" + h.Template + "', Lengh='" + h.Lengh + "', Flag='" + h.Flag.ToString() +
                    "' WHERE IdEmpleado='" + h.Empleado.Id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'";

                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al actualizar la tabla de huellas", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al actualizar la tabla huellas", "Fatal", ex);
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
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public void EliminarHuella(Huella h)
        {
            IDbCommand cmd = null;
            try
            {
                query = "DELETE FROM Huellas WHERE IdEmpleado=" + h.Empleado.Id.ToString();
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar eliminar las huellas", "Error", dbex);
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al intentar eliminar las huellas", "Fatal", ex);
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
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
