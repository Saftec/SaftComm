using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZkManagement.Entidades;

namespace ZkManagement.Datos
{
    class CatalogoRelojes
    {
        public List<Reloj> GetRelojes()
        {
            List<Reloj> relojes = new List<Reloj>();
            Conexion con = new Conexion();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Relojes;", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Reloj r = new Reloj();
                 //   r.Clave = Convert.ToInt32(dr.IsDBNull(3) ? '0' : dr["Clave"]);
                 //   r.DNS = dr.IsDBNull(5) ? string.Empty : dr["DNS"].ToString();
                    r.Id  = Convert.ToInt32(dr["IdReloj"]);
                    r.Ip = dr["IP"].ToString();
                    r.Nombre = dr["Nombre"].ToString();
                    r.Puerto = Convert.ToInt32(dr["Puerto"]);
                    r.Numero = Convert.ToInt32(dr["Numero"]);
                    relojes.Add(r);
                }
                dr.Close();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            conn.Close();
            return relojes;           
        }
    }
}
