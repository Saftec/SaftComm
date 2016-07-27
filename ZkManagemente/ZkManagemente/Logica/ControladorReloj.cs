using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorReloj
    {
        private CatalogoRelojes cr = new CatalogoRelojes();
        public List<Reloj> TodosRelojes()
        {
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

        public void ModifReloj(Reloj r)
        {
            try
            {
                if (r.Id > 0) { cr.ActualizarReloj(r); }
                else { cr.AgregarReloj(r); }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarReloj(Reloj r)
        {
            try
            {
                cr.EliminarReloj(r);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
