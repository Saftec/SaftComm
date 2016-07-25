using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkManagement.Datos
{
    class CatalogoConfiguraciones
    {
        private Conexion con = new Conexion();
        private SqlConnection conn = new SqlConnection();

        public string GetConfig(int id)
        {
            string valor;
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT Valor FROM Configuracion WHERE ConfigId=" + id.ToString(),conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                valor = dr["Valor"].ToString();
                dr.Close();
            }
            catch(SqlException sqlEx)
            {
                throw new Exception("Error al consulta el valor de configuracion: " + id.ToString());
            }
            catch(Exception ex)
            {
                throw new Exception("Error desconocido al consultar el valor de configuracion: " + id.ToString());
            }
            return valor;
        }
    }
}
