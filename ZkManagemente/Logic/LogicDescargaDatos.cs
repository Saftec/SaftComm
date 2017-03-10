using System;
using System.Collections.Generic;
using Database;
using Entidades;
using Util;

namespace Logic
{
    public class LogicDescargaDatos
    {
        public void ActualizarInfo(Empleado emp)
        {
            if (emp.Pin==string.Empty)
            {
                emp.Pin = "NULL";
            }                   
            try
            {
                if (IsSaftime())
                {
                    emp = DataEmpleadoSaftime.Instancia.GetIdByLegajo(emp);
                    if (emp.Id > 0)
                    {
                        DataEmpleadoSaftime.Instancia.Actualizar(emp);
                    }
                    else
                    {
                        DataEmpleadoSaftime.Instancia.Agregar(emp);
                    }
                }
                else
                {
                    emp = DataEmpleado.Instancia.GetIdByLegajo(emp);
                    if (emp.Id > 0)
                    {
                        DataEmpleado.Instancia.Actualizar(emp);
                    }
                    else
                    {
                        DataEmpleado.Instancia.Agregar(emp);
                    }
                }
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado durante la actualización del empleado.", "Fatal", ex);
            }                       
        }
        public int AgregarHuella(Empleado emp, Reloj reloj)
        {
            /*Recibo todos los legajos seleccionados en el dgv junto con el reloj.
             * Por cada legajo obtengo una list con todas las huellas que tenga en el equipo.
             * Por cada legajo, consulto el empid. --> El legajo existe SI O SI en la BD ya que anteriormente descargué y guardé los datos del equipo.
             * Por cada huella guardo el empid, template, fingerindex, largo de la huella.
             * */
            int total = 0;
            try
            {
                reloj.LeerTodasLasHuellas();
                List<Huella> huellas = new List<Huella>();
                huellas = reloj.ObtenerHuella(emp);
                total = huellas.Count;
                foreach (Huella h in huellas)
                {
                    if (IsSaftime())
                    {
                        h.Empleado = DataEmpleadoSaftime.Instancia.GetDataByLegajo(h.Empleado);
                    }
                    else
                    {
                        h.Empleado = DataEmpleado.Instancia.GetDataByLegajo(h.Empleado);
                    }
                    
                    if (!DataTemplates.Instancia.Existe(h))
                    {
                        DataTemplates.Instancia.InsertarHuella(h);
                    }
                    else
                    {
                        DataTemplates.Instancia.ActualizarHuella(h);
                    }
                }                             
             }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado durante la actualización de huellas", "Fatal", ex);
            }
            return total;
        }

        private bool IsSaftime()
        {
            LogicConfigSaftime lcs = new LogicConfigSaftime();
            bool valor = false;
            try
            {
                valor = lcs.IsEmpleados();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return valor;
        }
    }
}
