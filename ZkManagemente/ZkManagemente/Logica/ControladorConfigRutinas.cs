using System;
using ZkManagement.Datos;
using ZkManagement.Interfaz;

namespace ZkManagement.Logica
{
    class ControladorConfigRutinas
    {
        private CatalogoConfiguraciones cc;
        public void ActualizarConfigs(string[] valores)
        {
            cc = new CatalogoConfiguraciones();
            int i = 4;
            Principal principal = new Principal();
            try
            {                
                foreach (string v in valores)
                {
                    cc.SetConfig(i, v);
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
            cc = new CatalogoConfiguraciones();
            try
            {
                return cc.GetConfig(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
