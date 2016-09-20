using System;
using System.Data;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorEmpleados
    {
        public DataTable GetEmpleados()
        {
            DataTable empleados = new DataTable();      
                 
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
                ch.EliminarHuella(emp.Id);
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
