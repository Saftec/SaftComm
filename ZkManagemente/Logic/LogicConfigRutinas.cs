using System;
using Database;
using Util;

namespace Logic
{
    public class LogicConfigRutinas
    {
        private DataConfigFile dataConfigFile;
        private DataConfigs dataConfigs;

        #region GettersConfigs
        public bool IsBorradoRegs()
        {
            dataConfigs = new DataConfigs();
            bool valor = false;
            try
            {
                if (!Boolean.TryParse(dataConfigs.GetConfig(3), out valor))
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
                throw new AppException("Error no controlado al verificar las configuraciones de la base de datos", "Fatal", ex);
            }
            return valor;
        }
        public bool IsDescarga()
        {
            bool valor = false;
            dataConfigFile = new DataConfigFile();
            try
            {

                if (!Boolean.TryParse(dataConfigFile.GetConfig("Descarga"), out valor))
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
            dataConfigFile = new DataConfigFile();
            try
            {
                if (!Boolean.TryParse(dataConfigFile.GetConfig("Fichero"), out valor))
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
            dataConfigs = new DataConfigs();
            bool valor = false;
            try
            {
                if(!Boolean.TryParse(dataConfigs.GetConfig(4), out valor))
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
            dataConfigs = new DataConfigs();
            bool valor = false;
            try
            {
                if (!Boolean.TryParse(dataConfigs.GetConfig(6), out valor))
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
            dataConfigs = new DataConfigs();
            try
            {
                return dataConfigs.GetConfig(5);
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
            dataConfigs = new DataConfigs();
            try
            {
                return dataConfigs.GetConfig(7);
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
            dataConfigs = new DataConfigs();
            bool valor = false;
            try
            {
                if (!Boolean.TryParse(dataConfigs.GetConfig(10), out valor))
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
            dataConfigs = new DataConfigs();
            try
            {
                return dataConfigs.GetConfig(8);
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
            dataConfigs = new DataConfigs();
            try
            {
                return dataConfigs.GetConfig(9);
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

        public void SetBorrarRegistros(bool valor)
        {
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(3, valor.ToString());
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en la base de datos", "Fatal", ex);
            }
        }
        public void SetDescarga(bool valor)
        {
            dataConfigFile = new DataConfigFile();
            try
            {
                dataConfigFile.SetConfig("Descarga", valor.ToString());
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar guardar configuración en archivo de configuraciones", "Fatal", ex);
            }
        }
        public void SetFicheroCopia(bool valor)
        {
            dataConfigFile = new DataConfigFile();
            try
            {
                dataConfigFile.SetConfig("Fichero", valor.ToString());   
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
        public void SetEstadoRutinaRegs(bool valor)
        {
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(4, valor.ToString());
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
        public void SetEstadoRutinaHs(bool valor)
        {
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(6, valor.ToString());
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
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(5, valor);
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
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(7, valor);
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
        public void SetEstadoRango(bool valor)
        {
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(10, valor.ToString());
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
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(8, valor);
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
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(9, valor);
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
