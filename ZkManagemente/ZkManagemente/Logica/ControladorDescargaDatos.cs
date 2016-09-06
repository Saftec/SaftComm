using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorDescargaDatos
    {
        private CatalogoEmpleados ce = new CatalogoEmpleados();
        public void DescargarInfo(Empleado emp)
        {
                   
            try
            {
                emp.Id = ce.GetEmpId(emp.Legajo);
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
        public int AgregarHuella(Empleado emp, Reloj reloj)
        {
            /*Recibo todos los legajos seleccionados en el dgv junto con el reloj.
             * Por cada legajo obtengo una list con todas las huellas que tenga en el equipo.
             * Por cada legajo, consulto el empid. --> El legajo existe SI O SI en la BD ya que anteriormente descargué y guardé los datos del equipo.
             * Por cada huella guardo el empid, template, fingerindex, largo de la huella.
             * */
            CatalogoHuellas ch = new CatalogoHuellas();
            int total = 0;
            try
            {
                reloj.LeerTodasLasHuellas();
                List<Huella> huellas = new List<Huella>();
                huellas = reloj.ObtenerHuella(emp.Legajo);
                total += huellas.Count;
                foreach (Huella h in huellas)
                {
                    int id = ce.GetEmpId(h.Legajo);
                    if (!ch.Existe(h, id))
                    {
                        ch.InsertarHuella(h, id);
                    }
                    else
                    {
                        ch.ActualizarHuella(h, id);
                    }
                }                             
             }
            catch(Exception ex)
            {
                throw ex;
            }
            return total;
        }
    }
}
