using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using ZkManagement.Util;

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
                SqlCommand cmd = new SqlCommand("SELECT Clave, DNS, IdReloj, IP, Nombre, Puerto, Numero FROM Relojes;", conn);
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
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al consultar datos de los relojes");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al consultar datos de los relojes");
            }
            conn.Close();
            return relojes;           
        }

        public void AgregarReloj(Reloj r)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Relojes (Nombre, DNS, IP, Clave, Puerto, Numero) VALUES('" + r.Nombre + "', '" + r.DNS + "', '" + r.Ip + "', '" + r.Clave + "', " + r.Puerto + ", " + r.Numero + ")", conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                if (sqlex.Number == 2627)
                {
                    throw new Exception("Este valor no puede estar duplicado");
                }
                else
                {
                    throw new Exception("Error al intentar agregar el equipo en la tabla relojes");
                }              
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
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
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                if (sqlex.Number == 2601)
                {
                    throw new Exception("Este valor no puede estar duplicado");
                }
                else
                {
                    throw new Exception("Error al intentar actualizar los datos del equipo en la tabla relojes");
                }
            }
            catch (Exception ex) 
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
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
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw new Exception("Error al intentar eliminar el reloj");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar eliminar el reloj");
            }
            conn.Close();
        }

        public void SetBorrado(int idUsuario, int idReloj, int cantidad, DateTime fecha)
        {

            try
            {
                conn = con.Conectar();
                string query = "INSERT INTO Borrado (IdUsuario, IdReloj, Cantidad, Fecha) VALUES(" + idUsuario.ToString() + ", " + idReloj.ToString() + ", " + cantidad.ToString() + ", '" + fecha.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                Logger.GetLogger().Error(sqlex.StackTrace);
                throw sqlex;
                //throw new Exception("Error al actualizar la tabla borrado");
            }
            catch (Exception ex) 
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar actualizar la tabla borrado");
            }
                conn.Close();
        }
    }
}
