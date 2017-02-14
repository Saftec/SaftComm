using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class DataEmpleadoSaftime
    {
        private static DataEmpleadoSaftime _instancia;
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
        private DataEmpleadoSaftime() { }

        private string query = string.Empty;

        public List<Empleado> Empleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            SqlDataReader dr = null;
            SqlCommand cmd = null;

            try
            {
                query = "SELECT e.legajo, e.EmpId as 'IdEmpleado', (e.nombres + e.apellido) as 'Nombre', e.tarjeta, e.nroDoc, CASE WHEN e.fecbaja IS NULL THEN 0 ELSE 1 END AS 'Baja' FROM Empleados e ORDER BY Nombre ASC";
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
                    e.Baja = Convert.ToInt32(dr["Baja"]);
                    empleados.Add(e);
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar consultar los datos de los empleados de Saftime", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar consultar los datos de los empleados", "Fatal", ex);
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

        public void Eliminar(List<Empleado> empleados)
        {
            SqlCommand cmd = null;
            query = "UPDATE Empleados SET fecBaja= GETDATE() WHERE EmpId=@Id";
            try
            {
                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                var parameter = cmd.CreateParameter();
                parameter.ParameterName = "@Id";
                foreach (Empleado e in empleados)
                {
                    cmd.Parameters.Clear(); //--> Borro el parametro que inserté en la pasada anterior.
                    parameter.Value = e.Id;
                    cmd.Parameters.Add(parameter);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar eliminar empleado de la base de datos de Saftime", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar eliminar el empleado", "Fatal", ex);
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
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar actualizar los datos en la tabla empleados de Saftime", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar actualizar los datos del empleado", "Fatal", ex);
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
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al actualizar la tabla empleados", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar agregar el empleado", "Fatal", ex);
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

        public Empleado GetIdByLegajo(Empleado emp)
        {
            SqlDataReader dr = null;
            SqlCommand cmd = null;
            try
            {
                query = "SELECT e.EmpId, e.nroDoc FROM Empleados e WHERE e.legajo='" + emp.Legajo + "'";
                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp.Id = Convert.ToInt32(dr["EmpId"]);
                    emp.Dni = dr["nroDoc"].ToString();
                    emp.Baja = 0;
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar consultar la tabla empleados", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar consultar la tabla empleados", "Fatal", ex);
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

        public Empleado GetDataByLegajo(Empleado emp)
        {
            SqlDataReader dr = null;
            SqlCommand cmd = null;
            try
            {
                query = "SELECT e.legajo, e.EmpId, (e.nombres + e.apellido) as 'Nombre', e.tarjeta, e.nroDoc FROM Empleados e WHERE e.legajo='" + emp.Legajo + "'";
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
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar consultar la tabla empleados", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar consultar la tabla empleados", "Fatal", ex);
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
