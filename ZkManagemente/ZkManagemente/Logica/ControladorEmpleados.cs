using System;
using System.Data;
using ZkManagement.Datos;

namespace ZkManagement.Logica
{
    class ControladorEmpleados
    {

        public DataTable GetEmpleados()
        {
            DataTable empleados = new DataTable();
            CatalogoEmpleados ce = new CatalogoEmpleados();
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
    }
}
