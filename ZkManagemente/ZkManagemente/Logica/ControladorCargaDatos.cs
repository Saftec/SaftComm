using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorCargaDatos
    {

        public void CargarDatos(List<Empleado> empleados, Reloj reloj)
        {
            CatalogoHuellas ch = new CatalogoHuellas();
            List<Huella> huellas = new List<Huella>();
            try
            {
                reloj.CargarInfoUsuario(empleados);
                foreach (Empleado emp in empleados)
                {
                    huellas = ch.GetHuellas(emp.Id);
                    foreach(Huella h in huellas)
                    {
                        h.Legajo = emp.Legajo;
                    }
                    reloj.AgregarHuellas(huellas);
                }
                reloj.ActivarDispositivo();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
