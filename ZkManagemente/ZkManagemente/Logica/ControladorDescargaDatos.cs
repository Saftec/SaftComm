using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorDescargaDatos
    {
        public void ActualizarInfo(Empleado emp)
        {
            if (emp.Pin==string.Empty)
            {
                emp.Pin = "NULL";
            }                   
            try
            {
                emp = DataEmpleado.Instancia.GetIdByLegajo(emp.Legajo);
                if (emp.Id > 0)
                {
                    DataEmpleado.Instancia.Actualizar(emp);              
                }
                else
                {
                    DataEmpleado.Instancia.Agregar(emp);
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
                huellas = reloj.ObtenerHuella(emp);
                total = huellas.Count;
                foreach (Huella h in huellas)
                {
                    h.Empleado = DataEmpleado.Instancia.GetIdByLegajo(h.Empleado.Legajo);
                    if (!ch.Existe(h))
                    {
                        ch.InsertarHuella(h);
                    }
                    else
                    {
                        ch.ActualizarHuella(h);
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
