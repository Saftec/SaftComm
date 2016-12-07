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
            DataTemplates ch = new DataTemplates();
            List<Huella> huellas = new List<Huella>();
            try
            {
                reloj.CargarInfoUsuario(emp);
                reloj.AgregarHuellas(emp);                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
