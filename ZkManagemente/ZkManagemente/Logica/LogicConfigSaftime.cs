using System;
using System.Configuration;
using System.Data.SqlClient;
using ZkManagement.Datos;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicConfigSaftime
    {
        private string conexion = null;
        private SqlConnectionStringBuilder builder;
        public LogicConfigSaftime()
        {
            conexion = ConfigurationManager.ConnectionStrings["SaftimeDB"].ToString();
            builder = new SqlConnectionStringBuilder(conexion);
        }

        public string GetServidor()
        {
            if (conexion == null || builder == null)
            {
                throw new AppException("Error al intentar obtener los datos de la conexión.");
            }
            return builder.DataSource;
        }
        public string GetCatalogo()
        {
            if (conexion == null || builder == null)
            {
                throw new AppException("Error al intentar obtener los datos de la conexión.");
            }
            return builder.InitialCatalog;
        }
        public string GetUsuario()
        {
            if (conexion == null || builder == null)
            {
                throw new AppException("Error al intentar obtener los datos de la conexión.");
            }
            return builder.UserID;
        }
        public string GetContraseña()
        {
            if (conexion == null || builder == null)
            {
                throw new AppException("Error al intentar obtener los datos de la conexión.");
            }
            return builder.Password;
        }
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
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
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
        public void SetConnectionString(string server, string catalogo, string usuario, string password)
        {
            SqlConnectionStringBuilder cadena = new SqlConnectionStringBuilder();
            cadena.DataSource = server;
            cadena.InitialCatalog = catalogo;
            cadena.UserID = usuario;
            cadena.Password = password;
            //ConfigurationManager.ConnectionStrings["SaftimeDB"] = cadena.ConnectionString;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["SaftimeDB"].ConnectionString = cadena.ConnectionString;
            ConnectionStringsSection constringsec = config.ConnectionStrings;
            constringsec.SectionInformation.ProtectSection("DataProtectionConfigurationProvider"); //Encripto y guardo la nueva cadena de conexión.
            config.Save();
        }
    }
}
