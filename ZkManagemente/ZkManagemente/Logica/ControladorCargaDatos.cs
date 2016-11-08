using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorCargaDatos
    {

        public void CargarDatos(Empleado emp, Reloj reloj)
        {
            CatalogoHuellas ch = new CatalogoHuellas();
            List<Huella> huellas = new List<Huella>();
            try
            {
                reloj.CargarInfoUsuario(emp);
                huellas = ch.GetHuellas(emp.Id);
                foreach(Huella h in huellas)
                    {
                        h.Empleado = emp;
                    }
                reloj.AgregarHuellas(huellas);                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
