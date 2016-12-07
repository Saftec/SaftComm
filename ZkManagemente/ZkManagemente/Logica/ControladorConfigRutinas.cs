using System;
using System.Configuration;
using ZkManagement.Datos;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class ControladorConfigRutinas
    {
        #region GettersConfigs
        public bool IsDescarga()
        {
            bool valor = false;
            try
            {
                if (!Boolean.TryParse(ConfigurationManager.AppSettings["Descarga"].ToString(), out valor))
                {
                    throw new AppException("Error al intentar convertir los tipos de datos");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public bool GetEstadoRutinaRegs()
        {
            bool valor = false;
            try
            {
                if(!Boolean.TryParse(DataConfigs.Instancia.GetConfig(4), out valor))
                {
                    throw new AppException("Error al intentar convertir los tipos de datos");                    
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public bool GetEstadoRutinaHs()
        {
            bool valor = false;
            try
            {
                if (!Boolean.TryParse(DataConfigs.Instancia.GetConfig(6), out valor))
                {
                    throw new AppException("Error al intentar convertir los tipos de datos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetIntervaloRegs()
        {
            try
            {
                return DataConfigs.Instancia.GetConfig(5);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetIntervaloHs()
        {
            try
            {
                return DataConfigs.Instancia.GetConfig(7);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool GetEstadoRango()
        {
            bool valor = false;
            try
            {
                if (!Boolean.TryParse(DataConfigs.Instancia.GetConfig(10), out valor))
                {
                    throw new AppException("Error al intentar convertir los tipos de datos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetHoraInicioRango()
        {
            try
            {
                return DataConfigs.Instancia.GetConfig(8);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetHoraFinRango()
        {
            try
            {
                return DataConfigs.Instancia.GetConfig(9);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region SettersConfigs

        public void SetDescarga(bool valor)
        {
            try
            {
                ConfigurationManager.AppSettings["Descarga"] = valor.ToString();
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar guardar configuración en archivo de configuraciones");
            }
        }
        public void SetEstadoRutinaRegs(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(4, valor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void SetEstadoRutinaHs(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(6, valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetIntervaloRegs(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(5, valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetIntervaloHs(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(7, valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetEstadoRango(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(10, valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetInicioRango(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(8, valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetFinRango(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(9, valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
