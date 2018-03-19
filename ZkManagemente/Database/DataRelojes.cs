using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Entidades;
using Util;

namespace Database
{
    public class DataRelojes
    {
        private string query = string.Empty;
        public List<Reloj> GetRelojes()
        {
            List<Reloj> relojes = new List<Reloj>();
            IDataReader dr = null;

            try
            {
                query = "SELECT Clave, DNS, IdReloj, IP, Nombre, Puerto, Numero, Rutina, IdFormato FROM Relojes;";
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                while (dr.Read())
                {
                    Reloj r = new Reloj();
                    r.Id = Convert.ToInt32(dr["IdReloj"]);
                    r.Nombre = dr["Nombre"].ToString();
                    r.Numero = Convert.ToInt32(dr["Numero"]);
                    r.IP = dr["IP"].ToString();
                    r.Puerto = Convert.ToInt32(dr["Puerto"]);
                    r.DNS = dr.IsDBNull(dr.GetOrdinal("DNS")) ? string.Empty : dr["DNS"].ToString();
                    r.Clave = dr.IsDBNull(dr.GetOrdinal("Clave")) ? string.Empty : dr["Clave"].ToString();
                    r.Rutina = Convert.ToBoolean(dr["Rutina"]);
                    r.IdFormato = Convert.ToInt32(dr["IdFormato"]);
                    relojes.Add(r);
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al consultar datos de los relojes", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al consultar datos de los relojes", "Fatal", ex);
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
            return relojes;           
        }

        public void AgregarReloj(Reloj r)
        {
            IDbCommand cmd = null;
            try
            {
                query = "INSERT INTO Relojes (Nombre, DNS, IP, Clave, Puerto, Numero, Rutina) VALUES('" + r.Nombre + "', '" + r.DNS + "', '" + r.IP + "', '" + Security.Encriptar(r.Clave) + "', " + r.Puerto + ", " + r.Numero + ", '" + r.Rutina.ToString() + "')";
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar agregar el equipo en la tabla relojes", "Error", dbex);         
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar agregar el reloj", "Fatal", ex);
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

        public void ActualizarReloj(Reloj r)
        {
            IDbCommand cmd = null;
            try
            {
                query = "UPDATE Relojes SET Nombre='" + r.Nombre + "', DNS='" + r.DNS + "', IP='" + r.IP + "', Clave='" + Security.Encriptar(r.Clave) + "', Puerto=" + r.Puerto + ", Numero=" + r.Numero + ", Rutina='" + r.Rutina +"', IdFormato = " + r.IdFormato + " WHERE IdReloj=" + r.Id;
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar actualizar los datos del equipo en la tabla relojes", "Error", dbex);
            }
            catch (Exception ex) 
            {
                throw new AppException("Error desconocido al intentar actualizar los datos del reloj", "Fatal", ex);
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

        public void EliminarReloj(Reloj r)
        {
            IDbCommand cmd = null;
            try
            {
                query = "DELETE FROM Relojes WHERE IdReloj=" + r.Id;
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar eliminar el reloj", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar eliminar el reloj", "Fatal", ex);
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

        public void SetBorrado(int idUsuario, int idReloj, int cantidad, DateTime fecha)
        {
            IDbCommand cmd = null;
            try
            {
                query = "INSERT INTO Borrado (IdUsuario, IdReloj, Cantidad, Fecha) VALUES(" + idUsuario.ToString() + ", " + idReloj.ToString() + ", " + cantidad.ToString() + ", '" + fecha.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al actualizar la tabla borrado", "Error", dbex);
            }
            catch (Exception ex) 
            {
                throw new AppException("Error desconocido al intentar actualizar la tabla borrado", "Fatal", ex);
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
    }
}
