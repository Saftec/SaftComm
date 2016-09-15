using System;
using System.Data;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class CatalogoEmpleados
    {
        private Conexion con = new Conexion();
        private SqlConnection conn = new SqlConnection();

        public DataTable Empleados()
        {
            DataTable empleados = new DataTable();
            try
            {
                conn = con.Conectar();
                //Ya lo traigo ordenado alfabeticamente desde la BD.
                string consulta = "SELECT e.Legajo, e.IdEmpleado, e.Nombre, e.Tarjeta, e.DNI, CAST(e.Pin AS varchar(6)) as 'Pin', e.Privilegio, e.Baja, COUNT(h.IdEmpleado) as 'Cant' FROM Empleados e LEFT JOIN Huellas h ON e.IdEmpleado = h.IdEmpleado GROUP BY e.IdEmpleado, e.Nombre, e.Pin, e.Tarjeta, e.Legajo, e.DNI, e.Privilegio, e.Baja ORDER BY e.Nombre ASC";                 
                SqlCommand cmd = new SqlCommand(consulta,conn);
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
                conn.Close();
            }
            return empleados;
        }

        public void Eliminar(Empleado emp)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("DELETE FROM Empleados WHERE IdEmpleado=" + emp.Id.ToString(),conn);
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
                conn.Close();
            }
        }

        public void Actualizar(Empleado emp)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("UPDATE Empleados SET DNI='"+emp.Dni+"', Legajo='"+emp.Legajo+"', Nombre='"+emp.Nombre+"', Pin="+emp.Pin+", Tarjeta='"+emp.Tarjeta +
                    "', Privilegio='" + emp.Privilegio.ToString() +"', Baja='" + emp.Baja.ToString() +"' WHERE IdEmpleado="+emp.Id.ToString(), conn);
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
                conn.Close();
            }
        }

        public void Agregar(Empleado emp)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Empleados (Nombre, Pin, Tarjeta, Legajo, DNI, Privilegio, Baja) Values('" +emp.Nombre +"', "+emp.Pin.ToString()+", '"+emp.Tarjeta+"', '"+emp.Legajo+"', '"+emp.Dni+"', '" + emp.Privilegio.ToString() + "', " + emp.Baja + " )",conn);
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
                conn.Close();
            }
        }

        public int GetEmpId(string legajo)
        {
            int id = 0; //El simbolo "?" indica que la variable puede tomar el valor NULL
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT IdEmpleado FROM Empleados e WHERE e.Legajo='" + legajo + "'", conn);
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
                conn.Close();
            }            
            return id;
        }

        public void InsertarRegis(int id, DateTime fecha, string modo, int reloj)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Registros (IdEmpleado, Tipo, Reloj, Fecha) VALUES('" + id.ToString() + "', '" + modo + "', " + reloj.ToString() + ", '" + fecha.ToString("dd-MM-yyyy HH:mm:ss") + "')", conn);
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
                conn.Close();
            }            
        }
    }
}
