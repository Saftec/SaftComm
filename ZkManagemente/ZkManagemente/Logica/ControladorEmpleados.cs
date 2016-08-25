using System;
using System.Data;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorEmpleados
    {
        private CatalogoEmpleados ce = new CatalogoEmpleados();
        public DataTable GetEmpleados()
        {
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
            try
            {
                if (emp.Id > 0)
                {
                    ce.Actualizar(emp);
                }
                else
                {
                    ce.Agregar(emp);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }
    }
}
