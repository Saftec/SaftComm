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

        public void Update(FormatoExport formato)
        {
            IDbCommand cmd = null;
            string query = "UPDATE Formatos SET Nombre=@nombre, CodEntrada=@codEntrada, CodSalida=@codSalida, FormatoFecha=@formatoFecha, FormatoHora=@formatoHora, LongitudLegajo=@longitudLegajo, LongitudReloj=@longitudReloj, SeparadorFecha=@separadorFecha, " + 
                "Path=@path, PosicionFecha=@posicionFecha, PosicionHora=@posicionHora, PosicionLegajo=@posicionLegajo, PosicionMovimiento=@posicionMovimiento, PosicionReloj=@posicionReloj, PrefijoReloj=@prefijoReloj, SeparadorCampos=@separadorCampos, SeparadorHora=@separadorHora" + 
                "WHERE IdFormato=@idFormato";

            try
            {
                cmd = FactoryConnection.Instancia.GetCommand(query, FactoryConnection.Instancia.GetConnection());
                var parameter = cmd.CreateParameter();

                parameter.ParameterName = "@nombre";
                parameter.Value = formato.Nombre;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@codEntrada";
                parameter.Value = formato.CodEntrada;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@codSalida";
                parameter.Value = formato.CodSalida;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@formatoFecha";
                parameter.Value = formato.FormatoFecha;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@formatoHora";
                parameter.Value = formato.FormatoHora;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@longitudLegajo";
                parameter.Value = formato.LongitudLegajo;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@longitudReloj";
                parameter.Value = formato.LongitudReloj;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@separadorFecha";
                parameter.Value = formato.SeparadorFecha;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@path";
                parameter.Value = formato.Path;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@posicionFecha";
                parameter.Value = formato.PosicionFecha;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@separadorHora";
                parameter.Value = formato.PosicionHora;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@separadorFecha";
                parameter.Value = formato.SeparadorFecha;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@posicionLegajo";
                parameter.Value = formato.PosicionLegajo;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@posicionMovimiento";
                parameter.Value = formato.PosicionMov;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@posicionReloj";
                parameter.Value = formato.PosicionReloj;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@prefijoReloj";
                parameter.Value = formato.PrefijoReloj;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@separadorCampos";
                parameter.Value = formato.SeparadorCampos;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@separadorHora";
                parameter.Value = formato.SeparadorHora;
                cmd.Parameters.Add(parameter);

                parameter.ParameterName = "@idFormato";
                parameter.Value = formato.Id;
                cmd.Parameters.Add(parameter);
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
    }
}
