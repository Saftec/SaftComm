using System;
using System.Configuration;
using Util;

namespace Database
{
    public class DataConfigFile
    {
        public string GetConfig(string name)
        {
            string value = null;
            try
            {
                value = ConfigurationManager.AppSettings[name].ToString();
                if (value == null)
                {
                    throw new AppException("No se pudo recuperar el valor de la configuración: " + name);
                }
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Se produjo un error desconocido al intentar leer el archivo de configuraciones.", "Fatal", ex);
            }
            return value;
        }

        public void SetConfig(string name, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings[name].Value = value.ToString();
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch(Exception ex)
            {
                throw new AppException("Se produjo un error desconocido al intentar escribir el archivo de configuraciones.", "Fatal", ex);
            }
        }

        public string GetConnectionString(string name)
        {
            string value = null;
            try
            {
                value = ConfigurationManager.ConnectionStrings[name].ConnectionString;
                if (value == null)
                {
                    throw new AppException("No se pudo recuperar la cadena de conexión del archivo de configuraciones.");
                }
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Se produjo un error no controlado al intentar recuperar la cadena de conexión.", "Fatal", ex);
            }
            return value;
        }

        public bool SetConnectionString(string name, string connectionString)
        {
            bool test = false;
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings[name].ConnectionString = connectionString;
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");
                test = FactoryConnection.Instancia.TestConexion();
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Se produjo un error no controlado al intentar actualizar la cadena de conexión.", "Fatal", ex);
            }
            return test;
        }
    }
}
