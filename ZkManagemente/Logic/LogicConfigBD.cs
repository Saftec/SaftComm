using System;
using System.Data.OleDb;
using Database;
using Util;

namespace Logic
{
    public class LogicConfigBD
    {
        private OleDbConnectionStringBuilder builder;
        private DataConfigFile dataConfigFile;
        public LogicConfigBD()
        {
            dataConfigFile = new DataConfigFile();
            try
            {
                string cadena = dataConfigFile.GetConnectionString("CNS");
                builder = new OleDbConnectionStringBuilder(cadena);
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Se produjo un error no controlado al leer la cadena de conexión.", "Fatal", ex);
            }
        }
        public bool IsSQL()
        {
            dataConfigFile = new DataConfigFile();
            string value;
            try
            {
                value = dataConfigFile.GetConfig("DatabaseType");
                if (value.Trim().ToUpper() == "SQL")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al consultar el tipo de base de datos.", "Fatal", ex);
            }
        }
        public string GetVersion()
        {
            string valor="";
            try
            {
                valor = DataConfigs.Instancia.GetConfig(1);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public void SetType(string type)
        {
            dataConfigFile = new DataConfigFile();
            try
            {
                dataConfigFile.SetConfig("DatabaseType", type);
            }
            catch(Exception ex)
            {
                throw new AppException("Error al intentar guardar el tipo de base de datos en archivo de configuracioens", "Fatal", ex);
            }
        }

        public string GetPath()
        {
            return builder.DataSource;
        }

        public bool SetConnection(string path)
        {
            dataConfigFile = new DataConfigFile();           
            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            bool test = false;
            try
            {
                builder.DataSource = path;
                builder.Provider = "Microsoft.ACE.OLEDB.12.0";
                builder.PersistSecurityInfo = false;
                test=dataConfigFile.SetConnectionString("CNS", builder.ConnectionString);
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
