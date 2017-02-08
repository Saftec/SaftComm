using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class ControladorCargaDatos
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
