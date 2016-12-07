using System;
using ZkManagement.Datos;

namespace ZkManagement.Logica
{
    class ControladorConfiguraciones
    {
        public string GetConfig(int id)
        {            
            string valor;
            try
            {
                valor = DataConfigs.Instancia.GetConfig(id);
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
                DataConfigs.Instancia.SetConfig(id, valor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
