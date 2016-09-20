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
        public void InsertarHuella(Huella h, int id)
        {
            SqlCommand cmd;
            try
            {
                query = "INSERT INTO Huellas (IdEmpleado, Template, FingerIndex, Lengh, Flag) VALUES(" + id.ToString() + ", '" + h.Template + "', '" + h.FingerIndex.ToString() + "', '" + h.Lengh.ToString() + "', '" + h.Flag.ToString() + "')";
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

        public bool Existe(Huella h, int id)
        {
            SqlCommand cmd;
            try
            {
                query = "SELECT HuellaId FROM HUELLAS WHERE IdEmpleado='" + id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'";
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

        public void ActualizarHuella(Huella h, int id)
        {
            SqlCommand cmd;
            try
            {
                query = "UPDATE Huellas SET Template='" + h.Template + "', Lengh='" + h.Lengh + "', Flag='" + h.Flag.ToString() +
                    "' WHERE IdEmpleado='" + id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'";

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
        public List<Huella> GetHuellas(int id)
        {
            List<Huella> huellas = new List<Huella>();
            SqlCommand cmd;
            try
            {
                query = "SELECT FingerIndex, Template, Lengh, Flag FROM Huellas WHERE IdEmpleado=" + id.ToString();
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Huella h = new Huella();
                    h.FingerIndex = Convert.ToInt32(dr["FingerIndex"]);
                    h.Lengh = Convert.ToInt32(dr["Lengh"]);
                    h.Template = dr["Template"].ToString();
                    h.Flag = Convert.ToInt32(dr["Flag"]);
                    huellas.Add(h);
                }
            }
            catch(SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al consultar la tabla huellas");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar consultar la tabla huellas");
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
            return huellas;
        }

        public void EliminarHuella(int id)
        {
            SqlCommand cmd;
            try
            {
                query = "DELETE FROM Huellas WHERE IdEmpleado=" + id.ToString();
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
