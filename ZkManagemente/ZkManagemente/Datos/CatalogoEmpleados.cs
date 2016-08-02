using System;
using System.Data;
using System.Data.SqlClient;

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

                string consulta = "SELECT e.Legajo, e.EmpId, e.Nombre + ' ' + e.Apellido as 'Nombre', e.Tarjeta, e.DNI, e.Pin, COUNT(h.EmpId) as 'Cant' FROM Empleados e LEFT JOIN Huellas h ON e.EmpId = h.EmpId GROUP BY e.EmpId, e.Nombre, e.Apellido, e.Pin, e.Tarjeta, e.Legajo, e.DNI";
                SqlCommand cmd = new SqlCommand(consulta,conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(empleados);
                da.Dispose();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
              //  throw new Exception("Error al intentar consultar los datos de los empleados");
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
    }
}
