using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Entidades;
using Util;

namespace Database
{
    public class DataEmpleadoSaftime
    {
        private string query = string.Empty;

        public List<Empleado> Empleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            SqlDataReader dr = null;
            SqlCommand cmd = null;

            try
            {
                query = "SELECT legajo, EmpId, nombres, apellido, tarjeta, nroDoc, fecBaja FROM empleados e ORDER BY nombres ASC";
                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DateTime parseValue;
                    Empleado e = new Empleado();
                    e.Legajo = dr["legajo"].ToString();
                    e.Id = Convert.ToInt32(dr["EmpId"]);
                    e.Nombre = dr["nombres"].ToString();
                    e.Apellido = dr["Apellido"].ToString();
                    e.Tarjeta = dr["tarjeta"].ToString();
                    e.DNI = dr["nroDoc"].ToString();
                    e.Pin = string.Empty;
                    e.Privilegio = 0;
                    if(DateTime.TryParse(dr["fecBaja"].ToString(),out parseValue))
                    {
                        if(parseValue!=null && parseValue!= DateTime.MinValue)
                        {
                            e.Baja = parseValue;
                        }
                    }else
                    {
                        e.Baja = null;
                    }
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
                query = "UPDATE Empleados SET nroDoc='" + emp.DNI + "', legajo='" + emp.Legajo.PadLeft(5, '0') + "', tarjeta='" + emp.Tarjeta + "', nombres='" + emp.Nombre + "', apellido='" + emp.Apellido +"' WHERE EmpId=" + emp.Id.ToString();

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
                query = "INSERT INTO Empleados (nombres, apellido, Pin, Tarjeta, Legajo, DNI, Privilegio, Baja) Values('" + emp.Nombre + "', ' " + emp.Apellido + "', " + emp.Pin.ToString() + ", '" + emp.Tarjeta +
                    "', '" + emp.Legajo.PadLeft(5, '0') + "', '" + emp.DNI + "', '" + emp.Privilegio.ToString() + "', " + emp.Baja + " )";

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
                query = "SELECT e.EmpId, e.nroDoc FROM Empleados e WHERE LTRIM(e.legajo)='" + emp.Legajo.PadLeft(5,'0') + "'";
                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp.Id = Convert.ToInt32(dr["EmpId"]);
                    emp.DNI = dr["nroDoc"].ToString();
                    emp.Baja = null;
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
                query = "SELECT e.legajo, e.EmpId, e.nombres as 'Nombre', e.apellido, e.tarjeta, e.nroDoc FROM Empleados e WHERE e.legajo='" + emp.Legajo + "'";
                cmd = new SqlCommand(query, ConnectionSaftime.Instancia.GetConn());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp.Id = Convert.ToInt32(dr["EmpId"]);
                    emp.Nombre = dr["Nombre"].ToString();
                    emp.Apellido = dr["Apellido"].ToString();
                    emp.Tarjeta = dr["tarjeta"].ToString();
                    emp.DNI = dr["nroDoc"].ToString();
                    emp.Pin = string.Empty;
                    emp.Privilegio = 0;
                    emp.Baja = null;
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
