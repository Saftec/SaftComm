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
            bool saftime = false;      
                 
            try
            {
                if(!Boolean.TryParse(ConfigurationManager.AppSettings["Saftime"], out saftime))
                {
                    throw new AppException("Error al intentar leer la configuración de Saftime"); 
                }
                if (saftime)
                {
                    empleados = DataEmpleadoSaftime.GetInstancia().Empleados();
                }
                else
                {
                    empleados = DataEmpleado.GetInstancia().Empleados();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return empleados;
        }

        public void BajaEmpleado(Empleado emp)
        {
            CatalogoHuellas ch = new CatalogoHuellas();

            try
            {
                DataEmpleado.GetInstancia().Eliminar(emp);
                Huella h = new Huella();
                h.Empleado = emp;
                ch.EliminarHuella(h);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarEmpleado(Empleado emp)
        {
            try
            {
                DataEmpleado.GetInstancia().Actualizar(emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void AgregarEmpleado(Empleado emp)
        {

            try
            {
                DataEmpleado.GetInstancia().Agregar(emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
