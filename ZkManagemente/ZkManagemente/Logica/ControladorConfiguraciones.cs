using System;
using System.Data.SqlClient;
using ZkManagement.Datos;

namespace ZkManagement.Logica
{
    class ControladorConfiguraciones
    {

        public string GetConfig(int id)
        {
            CatalogoConfiguraciones cc = new CatalogoConfiguraciones();
            string valor;
            try
            {
                valor = cc.GetConfig(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;

        }

        public void SetConfig(int id, string valor)
        {

        }
    }
}
