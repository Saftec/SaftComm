using System;
using System.Data;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoEmpleados
    {
        private static CatalogoEmpleados _instancia;

        public static CatalogoEmpleados GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new CatalogoEmpleados();
            }
            return _instancia;
        }

        private string query = string.Empty;

        public DataTable Empleados()
        {
            SqlCommand cmd;
            DataTable empleados = new DataTable();
            try
            { 
                //Ya lo traigo ordenado alfabeticamente desde la BD.
                string query = "SELECT e.Legajo, e.IdEmpleado, e.Nombre, e.Tarjeta, e.DNI, CAST(e.Pin AS varchar(6)) as 'Pin', e.Privilegio, e.Baja, COUNT(h.IdEmpleado) as 'Cant' FROM Empleados e LEFT JOIN Huellas h ON e.IdEmpleado = h.IdEmpleado GROUP BY e.IdEmpleado, e.Nombre, e.Pin, e.Tarjeta, e.Legajo, e.DNI, e.Privilegio, e.Baja ORDER BY e.Nombre ASC";                 
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(empleados);
                da.Dispose();
            }
            catch (SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al intentar consultar los datos de los empleados");
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
                    Conexion.GetInstancia().ReleaseConn();
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
            SqlCommand cmd;
            try
            {
                query = "DELETE FROM Empleados WHERE IdEmpleado=" + emp.Id.ToString();
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                throw new Exception("Error al intentar eliminar empleado de la base de datos");
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
                    Conexion.GetInstancia().ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Actualizar(Empleado emp)
        {
            SqlCommand cmd;
            try
            {
                query = "UPDATE Empleados SET DNI='" + emp.Dni + "', Legajo='" + emp.Legajo + "', Nombre='" + emp.Nombre + "', Pin=" + emp.Pin + ", Tarjeta='" + emp.Tarjeta +
                    "', Privilegio='" + emp.Privilegio.ToString() + "', Baja='" + emp.Baja.ToString() + "' WHERE IdEmpleado=" + emp.Id.ToString();

                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                if (sqlEx.Number == 2627)
                {
                    throw new Exception("Este valor no puede estar duplicado");
                }
                else
                {
                    throw new Exception("Error al intentar actualizar los datos en la tabla empleados");
                }
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
                    Conexion.GetInstancia().ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Agregar(Empleado emp)
        {
            SqlCommand cmd;
            try
            {
                query = "INSERT INTO Empleados (Nombre, Pin, Tarjeta, Legajo, DNI, Privilegio, Baja) Values('" + emp.Nombre + "', " + emp.Pin.ToString() + ", '" + emp.Tarjeta +
                    "', '" + emp.Legajo + "', '" + emp.Dni + "', '" + emp.Privilegio.ToString() + "', " + emp.Baja + " )";

                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn()); 
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Logger.GetLogger().Error(sqlEx.StackTrace);
                if (sqlEx.Number == 2601)
                {
                    throw new Exception("Este valor no puede estar duplicado");
                }
                else
                {
                    throw new Exception("Error al intentar agregar el empleado en la tabla empleados");
                }
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
                    Conexion.GetInstancia().ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int GetEmpId(string legajo)
        {
            int id = 0;
            SqlCommand cmd; 
            try
            {
                query = "SELECT IdEmpleado FROM Empleados e WHERE e.Legajo='" + legajo + "'";
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["IdEmpleado"]);
                }       
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
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
                    Conexion.GetInstancia().ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return id;
        }

        public void InsertarRegis(int id, DateTime fecha, string modo, int reloj)
        {
            SqlCommand cmd;
            try
            {
                query = "INSERT INTO Registros (IdEmpleado, Tipo, Reloj, Fecha) VALUES('" + id.ToString() + "', '" + modo + "', " + reloj.ToString() + ", '" + fecha.ToString("dd-MM-yyyy HH:mm:ss") + "')";
                cmd = new SqlCommand(query, Conexion.GetInstancia().GetConn());
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar insertar en la tabla registros");
            }
            catch(Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar actualizar la tabla registros");
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
