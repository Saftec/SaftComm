using System;
using System.Data;
using ZkManagement.Entidades;
using ZkManagement.Util;
using System.Collections.Generic;
using System.Data.Common;

namespace ZkManagement.Datos
{
    class DataEmpleado
    {
        private static DataEmpleado _instancia;

        public static DataEmpleado Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DataEmpleado();
                }
                return _instancia;
            }
        }
        private DataEmpleado() { }


        private string query = string.Empty;

        public List<Empleado> Empleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            IDataReader dr = null;

            try
            {                            
                query = "SELECT e.Legajo, e.IdEmpleado, e.Nombre, e.Tarjeta, e.DNI, e.Pin, e.Privilegio, e.Baja FROM Empleados e GROUP BY e.IdEmpleado, e.Nombre, e.Pin, e.Tarjeta, e.Legajo, e.DNI, e.Privilegio, e.Baja ORDER BY e.Nombre ASC";           
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                while (dr.Read())
                {
                    Empleado e = new Empleado();
                    e.Legajo = dr["Legajo"].ToString();
                    e.Id = Convert.ToInt32(dr["IdEmpleado"]);
                    e.Nombre = dr["Nombre"].ToString();
                    e.Tarjeta = dr["Tarjeta"].ToString();
                    e.Dni = dr["DNI"].ToString();
                    e.Pin = dr["Pin"].ToString();
                    e.Privilegio = Convert.ToInt32(dr["Privilegio"]);
                    e.Baja = Convert.ToInt32(dr["Baja"]);             
                    empleados.Add(e);
                }
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar consultar los datos de los empleados", "Error", dbEx);
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
                    FactoryConnection.Instancia.ReleaseConn();
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
            IDbCommand cmd = null;
            try
            {
                query = "DELETE FROM Empleados WHERE IdEmpleado=" + emp.Id.ToString();
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar eliminar empleado de la base de datos", "Error", dbEx);
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
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Actualizar(Empleado emp)
        {
            IDbCommand cmd = null;
            try
            {
                query = "UPDATE Empleados SET DNI='" + emp.Dni + "', Legajo='" + emp.Legajo + "', Nombre='" + emp.Nombre + "', Pin='" + emp.Pin + "', Tarjeta='" + emp.Tarjeta +
                    "', Privilegio='" + emp.Privilegio.ToString() + "', Baja='" + emp.Baja.ToString() + "' WHERE IdEmpleado=" + emp.Id.ToString();

                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar actualizar los datos en la tabla empleados", "Error", dbEx);
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
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Agregar(Empleado emp)
        {
            IDbCommand cmd = null;
            try
            {
                query = "INSERT INTO Empleados (Nombre, Pin, Tarjeta, Legajo, DNI, Privilegio, Baja) Values('" + emp.Nombre + "', " + emp.Pin.ToString() + ", '" + emp.Tarjeta +
                    "', '" + emp.Legajo + "', '" + emp.Dni + "', '" + emp.Privilegio.ToString() + "', " + emp.Baja + " )";

                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al actualizar la tabla empleados", "Error", dbEx);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar agregar el empleado", "Fatal", ex);
            }
            finally
            {
                try
                {
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Empleado GetIdByLegajo(string legajo)
        {
            IDataReader dr = null;
            Empleado emp = new Empleado();
            try
            {
                query = "SELECT e.Legajo, e.IdEmpleado, e.Nombre, e.Tarjeta, e.DNI, e.Pin, e.Privilegio, e.Baja FROM Empleados e WHERE e.Legajo='" + legajo +"'";
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                if (dr.Read())
                {
                    emp.Id = Convert.ToInt32(dr["IdEmpleado"]);
                    emp.Nombre = dr["Nombre"].ToString();
                    emp.Tarjeta = dr["Tarjeta"].ToString();
                    emp.Dni = dr["DNI"].ToString();
                    emp.Pin = dr["Pin"].ToString();
                    emp.Privilegio = Convert.ToInt32(dr["Privilegio"]);
                    emp.Baja = Convert.ToInt32(dr["Baja"]);
                }       
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar consultar la tabla empleados", "Error", dbEx);
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
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return emp;
        }

        public void InsertarRegis(Fichada f)
        {
            IDbCommand cmd = null;
            try
            {
                query = "INSERT INTO Registros (IdEmpleado, Tipo, Reloj, Fecha) VALUES('" + f.Empleado.Id.ToString() + "', '" + f.Movimiento + "', " + f.Reloj.Numero.ToString() + ", '" + f.Registro.ToString("dd-MM-yyyy HH:mm:ss") + "')";
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar insertar en la tabla registros", "Error", dbEx);
            }
            catch(Exception ex)
            {
                throw new AppException("Error desconocido al intentar actualizar la tabla registros", "Fatal", ex);
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

        //Este método lo utilizo para setearle las huellas al list de empleados
        public List<Empleado> SetHuellas(List<Empleado> empleados)
        {
            query = "SELECT FingerIndex, Template, Lengh, Flag FROM Huellas WHERE IdEmpleado = @Id";
            IDataReader dr = null;
            IDbCommand cmd = null;

            try
            {
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                var parameter = cmd.CreateParameter();
                parameter.ParameterName = "@Id";
                foreach (Empleado e in empleados)
                {
                    cmd.Parameters.Clear(); //--> Borro el parametro que inserté en la pasada anterior.
                    parameter.Value = e.Id;
                    cmd.Parameters.Add(parameter);

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Huella h = new Huella();
                        h.FingerIndex = Convert.ToInt32(dr["FingerIndex"]);
                        h.Lengh = Convert.ToInt32(dr["Lengh"]);
                        h.Template = dr["Template"].ToString();
                        h.Flag = Convert.ToInt32(dr["Flag"]);
                        e.Huellas.Add(h);
                    }
                    dr.Close(); //--> Lo cierro para poder iniciarlizarlo cuando vuelvo a pasar por el bucle.
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al consultar la tabla huellas", "Error", dbEx);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar consultar la tabla huellas", "Fatal", ex);
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
            return empleados;
        }
    }
}
