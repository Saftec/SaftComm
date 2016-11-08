using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorEmpleados
    {
        public List<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();      
                 
            try
            {
                empleados = CatalogoEmpleados.GetInstancia().Empleados();
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
                CatalogoEmpleados.GetInstancia().Eliminar(emp);
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
                CatalogoEmpleados.GetInstancia().Actualizar(emp);
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
                CatalogoEmpleados.GetInstancia().Agregar(emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
