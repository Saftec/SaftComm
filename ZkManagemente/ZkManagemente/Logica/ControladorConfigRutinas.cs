using System;
using ZkManagement.Datos;
using ZkManagement.Interfaz;

namespace ZkManagement.Logica
{
    class ControladorConfigRutinas
    {
        public void ActualizarConfigs(string[] valores)
        {
            int i = 4;
            Principal principal = new Principal();
            try
            {                
                foreach (string v in valores)
                {
                    CatalogoConfiguraciones.GetInstancia().SetConfig(i, v);
                    i++;
                }
                principal.InicializarTimers();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public string GetConfig(int id)
        {
            try
            {
                return CatalogoConfiguraciones.GetInstancia().GetConfig(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
