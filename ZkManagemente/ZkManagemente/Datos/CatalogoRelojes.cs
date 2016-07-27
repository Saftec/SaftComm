using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ZkManagement.Entidades;

namespace ZkManagement.Datos
{
    class CatalogoRelojes
    {
        private Conexion con = new Conexion();
        private SqlConnection conn = new SqlConnection();
        public List<Reloj> GetRelojes()
        {
            List<Reloj> relojes = new List<Reloj>();
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Relojes;", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Reloj r = new Reloj();
                    r.Clave = dr.IsDBNull(3) ? string.Empty : dr["Clave"].ToString();
                    r.DNS = dr.IsDBNull(5) ? string.Empty : dr["DNS"].ToString();
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

        public void AgregarReloj(Reloj r)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Relojes VALUES('" + r.Nombre + "', '" + r.DNS + "', '" + r.Ip + "', '" + r.Clave + "', " + r.Puerto + ", " + r.Numero + ")", conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al intentar agregar el reloj");
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al intentar agregar el reloj");
            }
            conn.Close();
        }

        public void ActualizarReloj(Reloj r)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("UPDATE Relojes SET Nombre='" + r.Nombre + "', DNS='" + r.DNS + "', IP='" + r.Ip + "', Clave='" + r.Clave + "', Puerto=" + r.Puerto + ", Numero=" + r.Numero + " WHERE IdReloj=" + r.Id, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al intentar actuailizar los datos del reloj");
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al intentar actualizar los datos del reloj");
            }
            conn.Close();
        }

        public void EliminarReloj(Reloj r)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("DELETE FROM Relojes WHERE IdReloj="+r.Id , conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al intentar eliminar el reloj");
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al intentar eliminar el reloj");
            }
            conn.Close();
        }
    }
}
