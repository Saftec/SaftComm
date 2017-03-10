using System;
using System.Data.SqlClient;
using Database;
using Util;

namespace Logic
{
    public class LogicConfigSQL
    {
        private SqlConnectionStringBuilder builder; // LO USO PARA RECUPERAR LOS PARAMETROS DENTRO DE LA CADENA
        private DataConfigFile dataConfigFile;
        private enum DBType
        {
            SaftComm,
            Saftime,
            Empty
        }

        private LogicConfigSQL() { } //PONGO CONSTRUCTOR VACIO PRIVADO PARA NO CREAR INSTANCIAS SIN ESPECIFICAR LA BD
        public LogicConfigSQL(string dbType)
        {
            dataConfigFile = new DataConfigFile();
            string conexion;
            DBType tipo = (DBType)Enum.Parse(typeof(DBType), dbType);
            switch (tipo)
            {
                case DBType.Saftime:
                    conexion = dataConfigFile.GetConnectionString("SaftimeDB");
                    builder = new SqlConnectionStringBuilder(conexion);
                    break;
                case DBType.SaftComm:
                    conexion = dataConfigFile.GetConnectionString("CNS");
                    builder = new SqlConnectionStringBuilder(conexion);
                    break;
                case DBType.Empty:
                    builder = new SqlConnectionStringBuilder();
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
            dataConfigFile = new DataConfigFile();
            try
            {
                // ARMO LA NUEVA CADENA CON LOS PARAMETROS //
                SqlConnectionStringBuilder cadena = new SqlConnectionStringBuilder();
                cadena.DataSource = server;
                cadena.InitialCatalog = catalogo;
                cadena.UserID = usuario;
                cadena.Password = password;

                DBType tipo = (DBType)Enum.Parse(typeof(DBType), type);
                switch (tipo)
                {
                    case DBType.Saftime:                        
                        result = dataConfigFile.SetConnectionString("SaftimeDB", cadena.ConnectionString);
                        break;
                    case DBType.SaftComm:
                        result = dataConfigFile.SetConnectionString("CNS", cadena.ConnectionString);
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
    }
}
