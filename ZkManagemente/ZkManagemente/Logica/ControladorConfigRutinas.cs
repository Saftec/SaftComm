using System;
using ZkManagement.Datos;

namespace ZkManagement.Logica
{
    class ControladorConfigRutinas
    {
        #region GettersConfigs
        public string GetEstadoRutinaRegs()
        {
            try
            {
                return CatalogoConfiguraciones.GetInstancia().GetConfig(4);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public string GetEstadoRutinaHs()
        {
            try
            {
                return CatalogoConfiguraciones.GetInstancia().GetConfig(6);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetIntervaloRegs()
        {
            try
            {
                return CatalogoConfiguraciones.GetInstancia().GetConfig(5);
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
                return CatalogoConfiguraciones.GetInstancia().GetConfig(7);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetEstadoRango()
        {
            try
            {
                return CatalogoConfiguraciones.GetInstancia().GetConfig(10);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetHoraInicioRango()
        {
            try
            {
                return CatalogoConfiguraciones.GetInstancia().GetConfig(8);
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
                return CatalogoConfiguraciones.GetInstancia().GetConfig(9);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region SettersConfigs
        public void SetEstadoRutinaRegs(string valor)
        {
            try
            {
                CatalogoConfiguraciones.GetInstancia().SetConfig(4, valor);
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
                CatalogoConfiguraciones.GetInstancia().SetConfig(6, valor);
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
                CatalogoConfiguraciones.GetInstancia().SetConfig(5, valor);
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
                CatalogoConfiguraciones.GetInstancia().SetConfig(7, valor);
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
                CatalogoConfiguraciones.GetInstancia().SetConfig(10, valor);
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
                CatalogoConfiguraciones.GetInstancia().SetConfig(8, valor);
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
                CatalogoConfiguraciones.GetInstancia().SetConfig(9, valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
