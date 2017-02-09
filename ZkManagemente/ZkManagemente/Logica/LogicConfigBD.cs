using System.Configuration;
using System.Data.OleDb;
using ZkManagement.Datos;

namespace ZkManagement.Logica
{
    class LogicConfigBD
    {
        private OleDbConnectionStringBuilder builder;

        public LogicConfigBD()
        {
            string cadena = ConfigurationManager.ConnectionStrings["CNS"].ConnectionString;
            builder = new OleDbConnectionStringBuilder(cadena);
        }
        public bool IsSQL()
        {
            string value = ConfigurationManager.AppSettings["DatabaseType"].ToString();
            if (value.Trim().ToUpper() == "SQL")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetType(string type)
        {
            ConfigurationManager.AppSettings["DatabaseType"] = type;
        }

        public string GetPath()
        {
            return builder.DataSource;
        }

        public bool SetConnection(string path)
        {
            bool result = false;
            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            builder.DataSource = path;
            builder.Provider = "Microsoft.ACE.OLEDB.12.0";
            builder.PersistSecurityInfo = false;

            config.ConnectionStrings.ConnectionStrings["CNS"].ConnectionString = builder.ConnectionString;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
            result = FactoryConnection.Instancia.TestConexion();

            return result;
        }
    }
}
