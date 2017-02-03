using System;
using System.Configuration;
using ZkManagement.Datos;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicConfigRutinas
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
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al verificar el archivo de configuraciones", "Fatal", ex);
            }
            return valor;
        }
        public bool IsFicheroCopia()
        {
            bool valor = false;
            try
            {
                if (!Boolean.TryParse(ConfigurationManager.AppSettings["Fichero"].ToString(), out valor))
                {
                    throw new AppException("Error al intentar convertir los tipos de datos");
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al verificar el archivo de configuraciones", "Fatal", ex);
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
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al verificar el archivo de configuraciones", "Fatal", ex);
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
            catch(AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido durante la consulta de configuraciones", "Fatal", ex);
            }
            return valor;
        }
        public string GetIntervaloRegs()
        {
            try
            {
                return DataConfigs.Instancia.GetConfig(5);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido durante la consulta de configuraciones", "Fatal", ex);
            }
        }
        public string GetIntervaloHs()
        {
            try
            {
                return DataConfigs.Instancia.GetConfig(7);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido durante la consulta de configuraciones", "Fatal", ex);
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
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido durante la consulta de configuraciones", "Fatal", ex);
            }
            return valor;
        }
        public string GetHoraInicioRango()
        {
            try
            {
                return DataConfigs.Instancia.GetConfig(8);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido durante la consulta de configuraciones", "Fatal", ex);
            }
        }
        public string GetHoraFinRango()
        {
            try
            {
                return DataConfigs.Instancia.GetConfig(9);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error desconocido durante la consulta de configuraciones", "Fatal", ex);
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
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        public void SetFicheroCopia(bool valor)
        {
            try
            {
                ConfigurationManager.AppSettings["Fichero"] = valor.ToString();
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        public void SetEstadoRutinaRegs(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(4, valor);
            }
            catch(AppException apepx)
            {
                throw apepx;
            }
            catch(Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        public void SetEstadoRutinaHs(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(6, valor);
            }
            catch (AppException apepx)
            {
                throw apepx;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        public void SetIntervaloRegs(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(5, valor);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        public void SetIntervaloHs(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(7, valor);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        public void SetEstadoRango(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(10, valor);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        public void SetInicioRango(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(8, valor);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        public void SetFinRango(string valor)
        {
            try
            {
                DataConfigs.Instancia.SetConfig(9, valor);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        #endregion
    }
}
