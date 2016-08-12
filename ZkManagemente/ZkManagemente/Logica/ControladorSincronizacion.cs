using System;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorSincronizacion
    {

        public void DescargarInfo(Empleado emp)
        {
            CatalogoEmpleados ce = new CatalogoEmpleados();
            CatalogoHuellas ch = new CatalogoHuellas();

            try
            {
                emp.Id = ce.GetEmpId(emp);
                if (emp.Id > 0)
                {
                    ce.Actualizar(emp);
                    ch.InsertarHuella(emp);
                }
                else
                {
                    ce.Agregar(emp);
                    emp.Id = ce.GetEmpId(emp);
                    ch.InsertarHuella(emp);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }                       
        }
    }
}
