using System;
using System.Data;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorEmpleados
    {
        private CatalogoEmpleados ce; 
        public DataTable GetEmpleados()
        {
            ce = new CatalogoEmpleados();
            DataTable empleados = new DataTable();      
                 
            try
            {
                empleados = ce.Empleados();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return empleados;
        }

        public void BajaEmpleado(Empleado emp)
        {
            ce = new CatalogoEmpleados();
            CatalogoHuellas ch = new CatalogoHuellas();

            try
            {
                ce.Eliminar(emp);
                ch.EliminarHuella(emp.Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarEmpleado(Empleado emp)
        {
            ce = new CatalogoEmpleados();

            try
            {
                ce.Actualizar(emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void AgregarEmpleado(Empleado emp)
        {
            ce = new CatalogoEmpleados();

            try
            {
                ce.Agregar(emp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
