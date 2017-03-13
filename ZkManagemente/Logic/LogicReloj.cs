using System;
using System.Collections.Generic;
using Database;
using Entidades;
using Util;

namespace Logic
{
    public class LogicReloj
    {
        private DataRelojes dataRelojes;
        public List<Reloj> TodosRelojes()
        {
            dataRelojes = new DataRelojes();
            List<Reloj> relojes = new List<Reloj>();
            try
            {
                relojes = dataRelojes.GetRelojes();
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
            dataRelojes = new DataRelojes();
            try
            {
                if (r.Id > 0) { dataRelojes.ActualizarReloj(r); }
                else { dataRelojes.AgregarReloj(r); }
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
            dataRelojes = new DataRelojes();
            try
            {
                dataRelojes.EliminarReloj(r);
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
            dataRelojes = new DataRelojes();
            DateTime fecha = DateTime.Now;
            try
            {
                dataRelojes.SetBorrado(LogicLogin.Usuario.Id, reloj.Id, cantidad, fecha);
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
