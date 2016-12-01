using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class DataEmpleadoSaftime
    {
        private static DataEmpleadoSaftime _instancia;

        private DataEmpleadoSaftime()
        {

        }

        public static DataEmpleadoSaftime Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DataEmpleadoSaftime();
                }
                return _instancia;
            }

        }

        private string query = string.Empty;

        public List<Empleado> Empleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            SqlDataReader dr = null;
            SqlCommand cmd = null;

            try
            {
                query = "SELECT e.legajo, e.EmpId as 'IdEmpleado', (e.nombres + e.apellido) as 'Nombre', e.tarjeta, e.nroDoc FROM Empleados e WHERE e.fecBaja IS NULL ORDER BY Nombre ASC";
                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Empleado e = new Empleado();
                    e.Legajo = dr["legajo"].ToString();
                    e.Id = Convert.ToInt32(dr["IdEmpleado"]);
                    e.Nombre = dr["Nombre"].ToString();
                    e.Tarjeta = dr["tarjeta"].ToString();
                    e.Dni = dr["nroDoc"].ToString();
                    e.Pin = string.Empty;
                    e.Privilegio = 0;
                    e.Baja = 0;
                    empleados.Add(e);
                }
            }
            catch (SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al intentar consultar los datos de los empleados de Saftime");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar consultar los datos de los empleados");
            }
            finally
            {
                try
                {
                    if (dr != null)
                    {
                        dr.Close();
                    }
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    ConnectionSaftime.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return empleados;
        }

        public void Eliminar(Empleado emp)
        {
            SqlCommand cmd = null;
            try
            {
                query = "UPDATE Empleados SET fecBaja= GETDATE() WHERE EmpId=" + emp.Id.ToString();
                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al intentar eliminar empleado de la base de datos de Saftime");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar eliminar el empleado");
            }
            finally
            {
                try
                {
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    ConnectionSaftime.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Actualizar(Empleado emp)
        {
            SqlCommand cmd = null;
            try
            {
                query = "UPDATE Empleados SET nroDoc='" + emp.Dni + "', legajo='" + emp.Legajo + "', tarjeta='" + emp.Tarjeta + "' WHERE EmpId=" + emp.Id.ToString();

                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al intentar actualizar los datos en la tabla empleados de Saftime");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar actualizar los datos del empleado");
            }
            finally
            {
                try
                {
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    ConnectionSaftime.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Agregar(Empleado emp)
        {
            SqlCommand cmd = null;
            try
            {
                query = "INSERT INTO Empleados (Nombre, Pin, Tarjeta, Legajo, DNI, Privilegio, Baja) Values('" + emp.Nombre + "', " + emp.Pin.ToString() + ", '" + emp.Tarjeta +
                    "', '" + emp.Legajo + "', '" + emp.Dni + "', '" + emp.Privilegio.ToString() + "', " + emp.Baja + " )";

                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al actualizar la tabla empleados");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar agregar el empleado");
            }
            finally
            {
                try
                {
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    ConnectionSaftime.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Empleado GetIdByLegajo(string legajo)
        {
            SqlDataReader dr = null;
            SqlCommand cmd = null;
            Empleado emp = new Empleado();
            try
            {
                query = "SELECT e.legajo, e.EmpId, (e.nombres + e.apellido) as 'Nombre', e.tarjeta, e.nroDoc FROM Empleados e WHERE e.legajo='" + legajo + "'";
                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp.Id = Convert.ToInt32(dr["EmpId"]);
                    emp.Nombre = dr["Nombre"].ToString();
                    emp.Tarjeta = dr["tarjeta"].ToString();
                    emp.Dni = dr["nroDoc"].ToString();
                    emp.Pin = string.Empty;
                    emp.Privilegio = 0;
                    emp.Baja = 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al intentar consultar la tabla empleados");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar consultar la tabla empleados");
            }
            finally
            {
                try
                {
                    if (dr != null)
                    {
                        dr.Close();
                    }
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    ConnectionSaftime.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return emp;
        }

    }
}
