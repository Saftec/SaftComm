using System;
using System.Collections.Generic;
using Database;
using Entidades;
using Util;

namespace Logic
{
    public class LogicEmpleado
    {
        private DataEmpleado dataEmpleado;
        private DataEmpleadoSaftime dataEmpleadoSaftime;
        private DataTemplates dataTemplates;
        public List<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();     
                 
            try
            {
                if (VerificarSaftime())
                {
                    dataEmpleadoSaftime = new DataEmpleadoSaftime();
                    empleados = dataEmpleadoSaftime.Empleados();
                }
                else
                {
                    dataEmpleado = new DataEmpleado();
                    empleados = dataEmpleado.Empleados();
                }
                //empleados = dataEmpleado.SetHuellas(empleados);
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error desconocido al consultar los empleados", "Fatal", ex);
            }
            return empleados;
        }

        public List<Empleado> GetEmpleadosWithTemplates()
        {
            List<Empleado> empleados = new List<Empleado>();
            dataEmpleado = new DataEmpleado();
            try
            {
                if (VerificarSaftime())
                {
                    dataEmpleadoSaftime = new DataEmpleadoSaftime();
                    empleados = dataEmpleadoSaftime.Empleados();
                }
                else
                {
                    empleados = dataEmpleado.Empleados();
                }
                empleados = dataEmpleado.SetHuellas(empleados);
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al consultar los empleados", "Fatal", ex);
            }
            return empleados;

        }

        public void BajaEmpleado(List<Empleado> empleados)
        {
            dataTemplates = new DataTemplates();
            try
            {
                if (VerificarSaftime())
                {
                    dataEmpleadoSaftime = new DataEmpleadoSaftime();
                    dataEmpleadoSaftime.Eliminar(empleados);
                }
                else
                {
                    dataEmpleado = new DataEmpleado();
                    dataEmpleado.Eliminar(empleados);
                }
                foreach(Empleado emp in empleados)
                {
                    Huella h = new Huella();
                    h.Empleado = emp;
                    dataTemplates.EliminarHuella(h);
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido durante la baja.", "Fatal", ex);
            }
        }

        public void ActualizarEmpleado(Empleado emp)
        {
            try
            {
                if (VerificarSaftime())
                {
                    dataEmpleadoSaftime = new DataEmpleadoSaftime();
                    dataEmpleadoSaftime.Actualizar(emp);
                }
                else
                {
                    dataEmpleado = new DataEmpleado();
                    dataEmpleado.Actualizar(emp);
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido durante la actualización del empleado.", "Fatal", ex);
            }
        }
        public void AgregarEmpleado(Empleado emp)
        {

            try
            {
                if (VerificarSaftime())
                {
                    dataEmpleadoSaftime = new DataEmpleadoSaftime();
                    dataEmpleadoSaftime.Agregar(emp);
                }
                else
                {
                    dataEmpleado = new DataEmpleado();
                    dataEmpleado.Agregar(emp);
                }                
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al intentar agregar el empleado", "Fatal", ex);
            }
        }

        //VERIFICA SI TENGO QUE TRABAJAR CON LA BD DE SAFTIME
        private bool VerificarSaftime()
        {
            LogicConfigSaftime lcs = new LogicConfigSaftime();
            bool valor = false;
            try
            {
                valor = lcs.IsEmpleados();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
    }
}
