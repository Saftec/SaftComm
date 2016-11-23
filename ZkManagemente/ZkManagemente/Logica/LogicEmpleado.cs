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

        public List<Empleado> GetEmpleadosWithTemplates()
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                if (VerificarSaftime())
                {
                    empleados = DataEmpleadoSaftime.GetInstancia().Empleados();
                }
                else
                {
                    empleados = DataEmpleado.GetInstancia().Empleados();
                }
                foreach (Empleado e in empleados)
                {
                    e.Huellas = DataEmpleado.GetInstancia().SetHuellas(e);
                }
            }
            catch (Exception ex)
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
                if (VerificarSaftime())
                {
                    DataEmpleadoSaftime.GetInstancia().Eliminar(emp);
                }
                else
                {
                    DataEmpleado.GetInstancia().Eliminar(emp);
                }
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
                if (VerificarSaftime())
                {
                    DataEmpleadoSaftime.GetInstancia().Actualizar(emp);
                }
                else
                {
                    DataEmpleado.GetInstancia().Actualizar(emp);
                }
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
                if (VerificarSaftime())
                {
                    DataEmpleadoSaftime.GetInstancia().Agregar(emp);
                }
                else
                {
                    DataEmpleado.GetInstancia().Agregar(emp);
                }                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //VERIFICA SI TENGO QUE TRABAJAR CON LA BD DE SAFTIME
        private bool VerificarSaftime()
        {
            bool resul=false;
            if (!Boolean.TryParse(ConfigurationManager.AppSettings["Saftime"], out resul))
            {
                throw new AppException("Error al intentar leer la configuración de Saftime");
            }
            return resul;
        }
    }
}
