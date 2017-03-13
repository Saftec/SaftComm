using System;
using System.Collections.Generic;
using Database;
using Entidades;
using Util;

namespace Logic
{
    public class LogicDescargaDatos
    {
        private DataEmpleado dataEmpleado;
        private DataEmpleadoSaftime dataEmpleadoSaftime;
        private DataTemplates dataTemplates;
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
                    dataEmpleadoSaftime = new DataEmpleadoSaftime();
                    emp = dataEmpleadoSaftime.GetIdByLegajo(emp);
                    if (emp.Id > 0)
                    {
                        dataEmpleadoSaftime.Actualizar(emp);
                    }
                    else
                    {
                        dataEmpleadoSaftime.Agregar(emp);
                    }
                }
                else
                {
                    dataEmpleado = new DataEmpleado();
                    emp = dataEmpleado.GetIdByLegajo(emp);
                    if (emp.Id > 0)
                    {
                        dataEmpleado.Actualizar(emp);
                    }
                    else
                    {
                        dataEmpleado.Agregar(emp);
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
            dataTemplates = new DataTemplates();
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
                        dataEmpleadoSaftime = new DataEmpleadoSaftime();
                        h.Empleado = dataEmpleadoSaftime.GetDataByLegajo(h.Empleado);
                    }
                    else
                    {
                        dataEmpleado = new DataEmpleado();
                        h.Empleado = dataEmpleado.GetDataByLegajo(h.Empleado);
                    }
                    
                    if (!dataTemplates.Existe(h))
                    {
                        dataTemplates.InsertarHuella(h);
                    }
                    else
                    {
                        dataTemplates.ActualizarHuella(h);
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
