using System;
using System.Data;
using System.Data.SqlClient;
using ZkManagement.Entidades;

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

                string consulta = "SELECT e.Legajo, e.IdEmpleado, e.Nombre, e.Tarjeta, e.DNI, e.Pin, COUNT(h.IdEmpleado) as 'Cant' FROM Empleados e LEFT JOIN Huellas h ON e.IdEmpleado = h.IdEmpleado GROUP BY e.IdEmpleado, e.Nombre, e.Pin, e.Tarjeta, e.Legajo, e.DNI";
                SqlCommand cmd = new SqlCommand(consulta,conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(empleados);
                da.Dispose();
            }
            catch (SqlException)
            {
                throw new Exception("Error al intentar consultar los datos de los empleados");
            }
            catch (Exception)
            {
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
            catch (SqlException)
            {
                throw new Exception("Error al intentar eliminar empleado de la base de datos");
            }
            catch (Exception)
            {
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
                SqlCommand cmd = new SqlCommand("UPDATE Empleados SET DNI='"+emp.Dni+"', Legajo='"+emp.Legajo+"', Nombre='"+emp.Nombre+"', Pin='"+emp.Pin+"', Tarjeta='"+emp.Tarjeta+"' WHERE IdEmpleado="+emp.Id.ToString(), conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al intentar actualizar la tabla empleados");
            }
            catch (Exception)
            {
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Empleados Values('" +emp.Nombre +"', '"+emp.Pin.ToString()+"', '"+emp.Tarjeta+"', '"+emp.Legajo+"', '"+emp.Dni+"')",conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al intentar agregar el empleado a la tabla empleados");
            }
            catch (Exception ex)
            {
                throw ex;
               // throw new Exception("Error desconocido al intentar agregar el empleado");
            }
            finally
            {
                conn.Close();
            }
        }

        public int GetEmpId(Empleado emp)
        {
            int id = 0; //El simbolo "?" indica que la variable puede tomar el valor NULL
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT IdEmpleado FROM Empleados e WHERE e.Legajo='" + emp.Legajo + "'", conn);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["IdEmpleado"]);
                }       
            }
            catch (SqlException)
            {
                throw new Exception("Error al intentar consultar la tabla empleados");
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al intentar consultar la tabla empleados");
            }
            conn.Close();
            return id;
        }

        public void InsertarRegis(int id, DateTime fecha, string modo, int reloj)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Registros VALUES('" + id.ToString() + "', '" + modo + "', " + reloj.ToString() + ", '" + fecha.ToString("yyyy-MM-dd HH:mm:ss") + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException)
            {
                throw new Exception("Error al intentar insertar en la tabla registros");
            }
            catch(Exception)
            {
                throw new Exception("Error desconocido al intentar actualizar la tabla registros");
            }
            conn.Close();
        }
    }
}
