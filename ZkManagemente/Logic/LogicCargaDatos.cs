using System;
using System.Collections.Generic;
using Entidades;
using Util;

namespace Logic
{
    public class LogicCargaDatos
    {

        public void CargarDatos(Empleado emp, Reloj reloj)
        {
            List<Huella> huellas = new List<Huella>();
            try
            {
                reloj.CargarInfoUsuario(emp);
                reloj.AgregarHuellas(emp);                
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException(ex.Message, "Fatal", ex);
            }

        }
    }
}
