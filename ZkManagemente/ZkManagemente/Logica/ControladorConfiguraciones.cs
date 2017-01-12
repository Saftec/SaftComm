using System;
using ZkManagement.Datos;
using ZkManagement.Util;

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
            catch(AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar consultar una configuración a la base de datos.", "Fatal", ex);
            }
            return valor;

        }

        public void SetConfig(int id, string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(id, valor);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar guardar una configuración en la base de datos.", "Fatal", ex);
            }
        }
    }
}
