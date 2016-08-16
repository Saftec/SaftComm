using System;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorSincronizacion
    {
        private CatalogoEmpleados ce = new CatalogoEmpleados();
        public void DescargarInfo(Empleado emp)
        {
                   
            try
            {
                emp.Id = ce.GetEmpId(emp);
                if (emp.Id > 0)
                {
                    ce.Actualizar(emp);              
                }
                else
                {
                    ce.Agregar(emp);
                    emp.Id = ce.GetEmpId(emp);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }                       
        }

        public void Agregarhuella(string legajo, string huella)
        {
            CatalogoHuellas ch = new CatalogoHuellas();
            Empleado emp = new Empleado();
            emp.Huella = huella;
            emp.Legajo = legajo;
            try
            {
                emp.Id = ce.GetEmpId(emp); //El legajo tiene que estar SI O SI, ya que anteriormente agregué los que eran nuevos.
                ch.InsertarHuella(emp); 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
