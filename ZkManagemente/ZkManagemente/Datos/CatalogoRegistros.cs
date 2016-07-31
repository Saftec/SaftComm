using System;
using System.Data;
using System.Data.SqlClient;

namespace ZkManagement.Datos
{
    class CatalogoRegistros
    {
        private Conexion con = new Conexion();
        private SqlConnection conn = new SqlConnection();


        public string GetEmpId(string legajo)
        {
            string id;
            try
            {
                conn=con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT EmpId FROM Empleados WHERE legajo=" + legajo,conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                id = dr["EmpId"].ToString();
            }
            catch (SqlException)
            {
                throw new Exception("Error al consultar id de empleado a la base de datos");
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al consultar id de empleado");
            }
            conn.Close();
            return id;
        }
        public void GuardarRegis(DataTable regis)
        {
            string legajo;
            DateTime registro;
            string tipo;
            int reloj;
            try
            {
                foreach (DataRow fila in regis.Rows)
                {
                    legajo = (string)fila["Legajo"];
                    registro = (DateTime)fila["Registro"];
                    tipo = (string)fila["Tipo"];
                    reloj = (int)fila["Reloj"];
                    conn = con.Conectar();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Registraciones VALUES('" + legajo + "', '" + registro + "', '" + tipo + "', '" + reloj.ToString() + "');", conn);
                    cmd.ExecuteNonQuery();
                    cmd.CommandTimeout = 100;
                    conn.Close();
                }

            }
            catch (SqlException sqlex)
            {
            }
            catch (Exception ex)
            {
            }
            conn.Close();
        }
        }
}
