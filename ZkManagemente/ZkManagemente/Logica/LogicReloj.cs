using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Util;

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
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error desconocido al consultar los relojes.", "Fatal", ex);
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
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error desconocido al modificar reloj.", "Fatal", ex);
            }

        }

        public void EliminarReloj(Reloj r)
        {
            try
            {
                DataRelojes.Instancia.EliminarReloj(r);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido al eliminar reloj.", "Fatal", ex);
            }
        }

        public void ActualizarBorrado(Reloj reloj, int cantidad)
        {
            DateTime fecha = DateTime.Now;
            LogicLogin cl = new LogicLogin();
            try
            {
                DataRelojes.Instancia.SetBorrado(cl.GetUsrId(), reloj.Id, cantidad, fecha);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido durante el borrado.", "Fatal", ex);
            }
        }
    }
}
