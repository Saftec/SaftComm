using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorReloj
    {

        public List<Reloj> TodosRelojes()
        {
            CatalogoRelojes cr = new CatalogoRelojes();
            List<Reloj> relojes = new List<Reloj>();
            try
            {
                relojes = cr.GetRelojes();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            return relojes;
        }
    }
}
