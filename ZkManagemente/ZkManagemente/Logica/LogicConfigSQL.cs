using System;
using System.Configuration;
using System.Data.SqlClient;
using ZkManagement.Datos;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicConfigSQL
    {
        private SqlConnectionStringBuilder builder; // LO USO PARA RECUPERAR LOS PARAMETROS DENTRO DE LA CADENA

        private enum DBType
        {
            SaftComm,
            Saftime
        }

        private LogicConfigSQL() { } //PONGO CONSTRUCTOR VACIO PRIVADO PARA NO CREAR INSTANCIAS SIN ESPECIFICAR LA BD
        public LogicConfigSQL(string dbType)
        {
            string conexion;
            DBType tipo = (DBType)Enum.Parse(typeof(DBType), dbType);
            switch (tipo)
            {
                case DBType.Saftime:
                    conexion = ConfigurationManager.ConnectionStrings["SaftimeDB"].ToString();
                    builder = new SqlConnectionStringBuilder(conexion);
                    break;
                case DBType.SaftComm:
                    conexion = ConfigurationManager.ConnectionStrings["CNS"].ToString();
                    builder = new SqlConnectionStringBuilder(conexion);
                    break;
                default:
                    conexion = ConfigurationManager.ConnectionStrings["CNS"].ToString();
                    builder = new SqlConnectionStringBuilder(conexion);
                    break;
            }           
        }

        /*
         * VALIDO QUE BD TENGO QUE MODIFICAR (SAFTIME/SAFTCOMM)
         * ARMO LA NUEVA CADENA Y GUARDO EN EL APP.CONFIG
         * PRUEBO LA CONEXION
         */
        public bool SetConnectionString(string server, string catalogo, string usuario, string password, string type)
        {
            bool result = false;
            try
            {
                // ARMO LA NUEVA CADENA CON LOS PARAMETROS //
                SqlConnectionStringBuilder cadena = new SqlConnectionStringBuilder();
                cadena.DataSource = server;
                cadena.InitialCatalog = catalogo;
                cadena.UserID = usuario;
                cadena.Password = password;

                DBType tipo = (DBType)Enum.Parse(typeof(DBType), type);
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                switch (tipo)
                {
                    case DBType.Saftime:                        
                        config.ConnectionStrings.ConnectionStrings["SaftimeDB"].ConnectionString = cadena.ConnectionString;
                        config.Save(ConfigurationSaveMode.Modified, true);
                        ConfigurationManager.RefreshSection("connectionStrings");
                        result = ConnectionSaftime.Instancia.TestConexion();
                        break;
                    case DBType.SaftComm:
                        config.ConnectionStrings.ConnectionStrings["CNS"].ConnectionString = cadena.ConnectionString;
                        config.Save(ConfigurationSaveMode.Modified, true);
                        ConfigurationManager.RefreshSection("connectionStrings");
                        result = FactoryConnection.Instancia.TestConexion();
                        break;
                    default:
                        throw new AppException("El tipo de base de datos: " + type + " no existe.");
                }                          
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no esperado al probar la conexión con la base de datos " + catalogo, "Fatal", ex);
            }
            return result;
        }
        public string GetServidor()
        {
            return builder.DataSource;
        }
        public string GetCatalogo()
        {
            return builder.InitialCatalog;
        }
        public string GetUsuario()
        {
            return builder.UserID;
        }
        public string GetContraseña()
        {
            return builder.Password;
        }
        // ESTE METODO LO USO SOLAMENTE PARA LA CONFIGURACION DE LA BD DE SAFTCOMM //
        public bool IsSQL()
        {
            string value = ConfigurationManager.AppSettings["DatabaseType"].ToString();
            if (value.Trim().ToUpper() == "SQL")
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
