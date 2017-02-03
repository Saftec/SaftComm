using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class DataFormatos
    {
        public FormatoExport GetById(int id)
        {
            FormatoExport f = new FormatoExport();
            IDataReader dr = null;
            string query = "SELECT * FROM Formatos WHERE IdFormato=" + id + ";";
            try
            {
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                if (dr.Read())
                {
                    f.Nombre = dr["Nombre"].ToString();
                    f.Id = Convert.ToInt32(dr["IdFormato"]);
                    f.CodEntrada = dr["CodEntrada"].ToString();
                    f.CodSalida = dr["CodSalida"].ToString();
                    f.FormatoFecha = dr["FormatoFecha"].ToString();
                    f.FormatoHora = dr["FormatoHora"].ToString();
                    f.LongitudLegajo = Convert.ToInt32(dr["LongitudLegajo"]);
                    f.LongitudReloj = Convert.ToInt32(dr["LongitudReloj"]);
                    f.Path = dr["Path"].ToString();
                    f.PosicionFecha = Convert.ToInt32(dr["PosicionFecha"]);
                    f.PosicionHora = Convert.ToInt32(dr["PosicionHora"]);
                    f.PosicionLegajo = Convert.ToInt32(dr["PosicionLegajo"]);
                    f.PosicionMov = Convert.ToInt32(dr["PosicionMovimiento"]);
                    f.PosicionReloj = Convert.ToInt32(dr["PosicionReloj"]);
                    f.PrefijoReloj = dr["PrefijoReloj"].ToString();
                    f.SeparadorCampos = dr["SeparadorCampos"].ToString();
                    f.SeparadorFecha = dr["SeparadorFecha"].ToString();
                    f.SeparadorHora = dr["SeparadorHora"].ToString();
                } else
                {
                    throw new AppException("No se pudo encontrar el formato activo en la tabla formatos.");
                }
            }                        
            catch(AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar obtener el formato activo", "Error", dbEx);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar obtener el formato activo", "Fatal", ex);
            }
            finally
            {
                try
                {
                    if (dr != null)
                    {
                        dr.Dispose();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            return f;
 }

        public List<FormatoExport> GetFormatos()
        {
            List<FormatoExport> formatos = new List<FormatoExport>();
            IDataReader dr = null;
            string query = "SELECT * FROM Formatos;";
            try
            {
                dr = FactoryConnection.Instancia.GetReader(query, FactoryConnection.Instancia.GetConnection());
                while (dr.Read())
                {
                    FormatoExport f = new FormatoExport();
                    f.Nombre = dr["Nombre"].ToString();
                    f.Id = Convert.ToInt32(dr["IdFormato"]);
                    f.CodEntrada = dr["CodEntrada"].ToString();
                    f.CodSalida = dr["CodSalida"].ToString();
                    f.FormatoFecha = dr["FormatoFecha"].ToString();
                    f.FormatoHora = dr["FormatoHora"].ToString();
                    f.LongitudLegajo = Convert.ToInt32(dr["LongitudLegajo"]);
                    f.LongitudReloj = Convert.ToInt32(dr["LongitudReloj"]);
                    f.Path = dr["Path"].ToString();
                    f.PosicionFecha = Convert.ToInt32(dr["PosicionFecha"]);
                    f.PosicionHora = Convert.ToInt32(dr["PosicionHora"]);
                    f.PosicionLegajo = Convert.ToInt32(dr["PosicionLegajo"]);
                    f.PosicionMov = Convert.ToInt32(dr["PosicionMovimiento"]);
                    f.PosicionReloj = Convert.ToInt32(dr["PosicionReloj"]);
                    f.PrefijoReloj = dr["PrefijoReloj"].ToString();
                    f.SeparadorCampos = dr["SeparadorCampos"].ToString();
                    f.SeparadorFecha = dr["SeparadorFecha"].ToString();
                    f.SeparadorHora = dr["SeparadorHora"].ToString();

                    formatos.Add(f);
                }
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar consultar los datos de los formatos", "Error", dbEx);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar consultar los datos de los formatos", "Fatal", ex);
            }
            finally
            {
                try
                {
                    if (dr != null)
                    {
                        dr.Dispose();
                    }
                    FactoryConnection.Instancia.ReleaseConn();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            return formatos;
        }
        public void Delete(FormatoExport f)
        {
            IDbCommand cmd = null;
            string query = "DELETE FROM Formatos WHERE IdFormato=" + f.Id;

            try
            {
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar eliminar el formato de la base de datos", "Error", dbEx);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar eliminar el formato", "Fatal", ex);
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
        public void Update(FormatoExport f)
        {
            IDbCommand cmd = null;
            string query = "UPDATE Formatos SET Nombre='" + f.Nombre + "', CodEntrada='" + f.CodEntrada + "', CodSalida='" + f.CodSalida + "', FormatoFecha='" + f.FormatoFecha + "', FormatoHora='" + f.FormatoHora + "', LongitudLegajo=" + f.LongitudLegajo + ", LongitudReloj=" + f.LongitudReloj + ", SeparadorFecha='" + f.SeparadorFecha + "', " + 
                "Path='" + f.Path + "', PosicionFecha=" + f.PosicionFecha + ", PosicionHora=" + f.PosicionHora + ", PosicionLegajo=" + f.PosicionLegajo + ", PosicionMovimiento=" + f.PosicionMov + ", PosicionReloj=" + f.PosicionReloj + ", PrefijoReloj='" + f.PrefijoReloj + "', SeparadorCampos='" + f.SeparadorCampos + "', SeparadorHora='" + f.SeparadorHora + 
                "' WHERE IdFormato=" + f.Id;

            try
            {
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();              
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar actualizar los datos de los formatos", "Error", dbEx);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar actualizar los datos de los formatos", "Fatal", ex);
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
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Insert(FormatoExport f)
        {
            IDbCommand cmd = null;
            string query = "INSERT INTO Formatos (Nombre, CodEntrada, CodSalida, FormatoFecha, FormatoHora, LongitudLegajo, LongitudReloj, SeparadorFecha, Path, PosicionFecha, PosicionHora, PosicionLegajo, PosicionMovimiento, PosicionReloj, PrefijoReloj, SeparadorCampos, SeparadorHora)" + 
                "VALUES ('" + f.Nombre + "', '" + f.CodEntrada + "', '" + f.CodSalida + "', '" + f.FormatoFecha + "', '" + f.FormatoHora + "', " + f.LongitudLegajo + ", " + f.LongitudReloj + ", '" + f.SeparadorFecha + "', '" + f.Path + "', " + f.PosicionFecha + ", " + f.PosicionHora + ", " + f.PosicionLegajo +
                ", " + f.PosicionMov + ", " + f.PosicionReloj + ", '" + f.PrefijoReloj + "', '" + f.SeparadorCampos +"', '" + f.SeparadorHora + "');";

            try
            {
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                cmd.ExecuteNonQuery();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (DbException dbEx)
            {
                throw new AppException("Error al intentar agregar el formato a la tabla", "Error", dbEx);
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar agregar el nuevo formato", "Fatal", ex);
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
