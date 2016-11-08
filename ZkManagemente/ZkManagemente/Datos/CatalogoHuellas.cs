using System;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using System.Collections.Generic;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoHuellas
    {
        private string query = string.Empty;
        public void InsertarHuella(Huella h)
        {
            SqlCommand cmd;
            try
            {
                query = "INSERT INTO Huellas (IdEmpleado, Template, FingerIndex, Lengh, Flag) VALUES(" + h.Empleado.Legajo.ToString() + ", '" + h.Template + "', '" + h.FingerIndex.ToString() + "', '" + h.Lengh.ToString() + "', '" + h.Flag.ToString() + "')";
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al insertar registros en la tabla huellas");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar actualizar en la tabla huellas");
            }
            finally
            {
                try
                {
                    Conexion.GetInstancia().ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool Existe(Huella h)
        {
            SqlCommand cmd;
            try
            {
                query = "SELECT HuellaId FROM HUELLAS WHERE IdEmpleado='" + h.Empleado.Id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'";
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {                    
                    return true;
                }
                else
                {
                    return false;                  
                }
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al consultar la tabla de huellas");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al consultar la tabla huellas");
            }
            finally
            {
                try
                {
                    Conexion.GetInstancia().ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void ActualizarHuella(Huella h)
        {
            SqlCommand cmd;
            try
            {
                query = "UPDATE Huellas SET Template='" + h.Template + "', Lengh='" + h.Lengh + "', Flag='" + h.Flag.ToString() +
                    "' WHERE IdEmpleado='" + h.Empleado.Id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'";

                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al actualizar la tabla de huellas");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al actualizar la tabla huellas");
            }
            finally
            {
                try
                {
                    Conexion.GetInstancia().ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public void EliminarHuella(Huella h)
        {
            SqlCommand cmd;
            try
            {
                query = "DELETE FROM Huellas WHERE IdEmpleado=" + h.Empleado.Id.ToString();
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar eliminar las huellas");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar eliminar las huellas");
            }
            finally
            {
                try
                {
                    Conexion.GetInstancia().ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
