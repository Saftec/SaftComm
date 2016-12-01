using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class LogicReloj
    {
        public List<Reloj> TodosRelojes()
        {
            List<Reloj> relojes = new List<Reloj>();
            try
            {
                relojes = DataRelojes.Instancia.GetRelojes();
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
                if (r.Id > 0) { DataRelojes.Instancia.ActualizarReloj(r); }
                else { DataRelojes.Instancia.AgregarReloj(r); }
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
                DataRelojes.Instancia.EliminarReloj(r);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarBorrado(Reloj reloj, int cantidad)
        {
            DateTime fecha = DateTime.Now;
            ControladorLogin cl = new ControladorLogin();
            try
            {
                DataRelojes.Instancia.SetBorrado(cl.GetUsrId(), reloj.Id, cantidad, fecha);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
