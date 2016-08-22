using System;
using System.Collections.Generic;
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

        public void AgregarHuella(string legajo, string huella)
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

        public int AgregarHuella(List<string> legajos, Reloj reloj)
        {
            /*Recibo todos los legajos seleccionados en el dgv junto con el reloj.
             * Por cada legajo obtengo una list con todas las huellas que tenga en el equipo.
             * Por cada legajo, consulto el empid. --> El legajo existe SI O SI en la BD ya que anteriormente descargué y guardé los datos del equipo.
             * Por cada huella guardo el empid + template. (FALTA TRAER EL FINGERINDEX!!!)
             * */
            CatalogoHuellas ch = new CatalogoHuellas();
            int total = 0;

            try
            {
                reloj.LeerTodasLasHuellas();
                for(int i=0; i<legajos.Count; i++)
                {
                    List<string> huellas = new List<string>();
                    huellas = reloj.ObtenerHuella(legajos[i]);
                    if (huellas.Count>0)
                    {
                        Empleado emp = new Empleado();
                        emp.Legajo = legajos[i];
                        emp.Id = ce.GetEmpId(emp);
                        total += huellas.Count;
                        for(int j=0; j<huellas.Count; j++)
                        {
                            emp.Huella = huellas[j];                         
                            ch.InsertarHuella(emp);
                        }
                    }                                   
                }
                reloj.ActivarDispositivo();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return total;
        }
    }
}
