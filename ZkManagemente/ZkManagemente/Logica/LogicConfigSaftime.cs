using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZkManagement.Datos;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicConfigSaftime
    {
        public bool IsEmpleados()
        {
            string valor;
            bool parse;
            try
            {
                valor = DataConfigs.Instancia.GetConfig(10);
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
            string valor;
            bool parse;
            try
            {
                valor = DataConfigs.Instancia.GetConfig(11);
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
            try
            {
                DataConfigs.Instancia.SetConfig(11, estado.ToString());
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
            try
            {
                DataConfigs.Instancia.SetConfig(10, estado.ToString());
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
