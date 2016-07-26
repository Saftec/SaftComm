using System;
using ZkManagement.Datos;

namespace ZkManagement.Logica
{
    class ControladorConfiguraciones
    {
        private CatalogoConfiguraciones cc = new CatalogoConfiguraciones();
        public string GetConfig(int id)
        {            
            string valor;
            try
            {
                valor = cc.GetConfig(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;

        }

        public void SetConfig(int id, string valor)
        {
            try
            {
                cc.SetConfig(id, valor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
