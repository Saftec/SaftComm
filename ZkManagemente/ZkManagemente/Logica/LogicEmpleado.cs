using System;
using System.Collections.Generic;
using System.Configuration;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicEmpleado
    {
        public List<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();     
                 
            try
            {
                if (VerificarSaftime())
                {
                    empleados = DataEmpleadoSaftime.Instancia.Empleados();
                }
                else
                {
                    empleados = DataEmpleado.Instancia.Empleados();
                }
                //empleados = DataEmpleado.Instancia.SetHuellas(empleados);
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

            try
            {
                if (VerificarSaftime())
                {
                    empleados = DataEmpleadoSaftime.Instancia.Empleados();
                }
                else
                {
                    empleados = DataEmpleado.Instancia.Empleados();
                }
                empleados = DataEmpleado.Instancia.SetHuellas(empleados);
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

        public void BajaEmpleado(Empleado emp)
        {
            DataTemplates ch = new DataTemplates();

            try
            {
                if (VerificarSaftime())
                {
                    DataEmpleadoSaftime.Instancia.Eliminar(emp);
                }
                else
                {
                    DataEmpleado.Instancia.Eliminar(emp);
                }
                Huella h = new Huella();
                h.Empleado = emp;
                ch.EliminarHuella(h);
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
                    DataEmpleadoSaftime.Instancia.Actualizar(emp);
                }
                else
                {
                    DataEmpleado.Instancia.Actualizar(emp);
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
                    DataEmpleadoSaftime.Instancia.Agregar(emp);
                }
                else
                {
                    DataEmpleado.Instancia.Agregar(emp);
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
            return lcs.IsEmpleados();
        }
    }
}
