using System;
using Database;
using Util;

namespace Logic
{
    public class LogicConfigSaftime
    {
        private DataConfigs dataConfigs;
        public bool IsEmpleados()
        {
            dataConfigs = new DataConfigs();
            string valor;
            bool parse;
            try
            {
                valor = dataConfigs.GetConfig(10);
                if (!bool.TryParse(valor, out parse))
                {
                    throw new AppException("Error al intentar convertir el valor de la configuración.");
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar consultar la configuración.", "Fatal", ex);
            }
            return parse;
        }
        public bool IsRegistros()
        {
            dataConfigs = new DataConfigs();
            string valor;
            bool parse;
            try
            {
                valor = dataConfigs.GetConfig(11);
                if (!bool.TryParse(valor, out parse))
                {
                    throw new AppException("Error al intentar convertir el valor de la configuración.");
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar consultar la configuración.", "Fatal", ex);
            }
            return parse;
        }
        public void SetEstadoRegistros(bool estado)
        {
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(11, estado.ToString());
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar guardar la configuración.", "Fatal", ex);
            }
        }
        public void SetEstadoEmpleados(bool estado)
        {
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(10, estado.ToString());
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar guardar la configuración.", "Fatal", ex);
            }
        }
    }
}
