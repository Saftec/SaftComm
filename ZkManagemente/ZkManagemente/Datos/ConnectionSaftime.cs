using System;
using System.Configuration;
using System.Data.SqlClient;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class ConnectionSaftime
    {
        private static ConnectionSaftime _instancia;
        private static SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["saftimeDB"].ConnectionString);

        private ConnectionSaftime() { }
        public static ConnectionSaftime Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ConnectionSaftime();
                }
                return _instancia;
            }
        }
        public SqlConnection GetConn()
        {
            try
            {
                _conn.Open();
            }
            catch (SqlException sqlex)
            {
                throw new AppException("Error al intentar conectar a la base de datos Saftime", "Error", sqlex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar conectar a la base de datos de Saftime", "Fatal", ex);
            }
            return _conn;
        }

        public void ReleaseConn()
        {
            try
            {
               _conn.Close();
            }
            catch (SqlException sqlex)
            {
                throw new AppException("Error al intentar cerrar la conexión a la base de datos de Saftime", "Error", sqlex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar cerrar la conexión a la base de datos de Saftime", "Fatal", ex);
            }
        }
        public bool TestConexion()
        {
            bool band = false;
            try
            {
                // ACTUALIZO EL CONNECTION STRING PORQUE SI SE MODIFICÓ SEGUIA USANDO LA MISMA
                _conn.ConnectionString = ConfigurationManager.ConnectionStrings["saftimeDB"].ConnectionString;

                GetConn();
                if (_conn.State == System.Data.ConnectionState.Open)
                {
                    band = true;
                }
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch (SqlException sqlex)
            {
                throw new AppException("Error al conectar con la base de datos de Saftime", "Error", sqlex);
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al intentar conectar con la base de datos de Saftime", "Fatal", ex);
            }
            finally
            {
                try
                {
                    ReleaseConn();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return band;
        }
    }
}
