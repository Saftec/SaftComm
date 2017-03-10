using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using Util;

namespace Database
{
    public class FactoryConnection
    {
        private static int cantConn;
        private static FactoryConnection _instancia;
        private static IDbConnection cnn;

        public static FactoryConnection Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new FactoryConnection();
                }
                return _instancia;
            }
        }

        private FactoryConnection()
        {

        }    

        private enum DBType
        {
            SQL,
            Access         
        }
        public IDbConnection GetConnection()
        {
            DBType dbtype = (DBType)Enum.Parse(typeof(DBType), ConfigurationManager.AppSettings["DatabaseType"]);
            try
            {
                switch (dbtype)
                {
                    case DBType.Access:
                        cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["CNS"].ConnectionString);
                        cnn.Open();
                        break;
                    case DBType.SQL:
                        cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CNS"].ConnectionString);
                        cnn.Open();
                        break;
                    default:
                        cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CNS"].ConnectionString);
                        cnn.Open();
                        break;
                }
                cantConn++;
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar la conexión a la base de datos", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar la conexión a la base de datos", "Fatal", ex);
            }
            return cnn;
        }

        public IDbCommand GetCommand(string command, IDbConnection cnn) //La conexión ya me llega abierta.
        {
            IDbCommand cmd;
            try
            {
                DBType dbtype = (DBType)Enum.Parse(typeof(DBType), ConfigurationManager.AppSettings["DatabaseType"]);
                switch (dbtype)
                {
                    case DBType.Access:
                        cmd = new OleDbCommand(command, (OleDbConnection)cnn);
                        break;

                    case DBType.SQL:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        break;

                    default:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        break;
                }
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar crear la consulta", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado durante la creación de la consulta", "Fatal", ex);
            }
            return cmd;
        }

        public DbDataReader GetReader(string command, IDbConnection cnn) //La conexión ya me llega abierta.
        {
            IDbCommand cmd;
            DbDataReader dr;
            try
            {
                DBType dbtype = (DBType)Enum.Parse(typeof(DBType), ConfigurationManager.AppSettings["DatabaseType"]);
                switch (dbtype)
                {
                    case DBType.Access:
                        cmd = new OleDbCommand(command, (OleDbConnection)cnn);
                        dr = (OleDbDataReader)cmd.ExecuteReader();
                        break;

                    case DBType.SQL:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        dr = (SqlDataReader)cmd.ExecuteReader();
                        break;

                    default:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        dr = (SqlDataReader)cmd.ExecuteReader();
                        break;
                }
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar leer datos de la base de datos.", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado durante la consulta a la base de datos.", "Fatal", ex);
            }
            return dr;
        }

        public void ReleaseConn()
        {
            try
            {
                cantConn--;
                if (cantConn == 0)
                {
                    cnn.Close();
                }
            }
            catch (DbException dbex)
            {
                throw new AppException("Error al intentar cerrar la conexión a la base de datos", "Error", dbex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar cerrar la conexión a la base de datos", "Fatal", ex);
            }

        }
        public bool TestConexion()
        {
            bool band = false;
            try
            {
                GetConnection();
                if (cnn.State == System.Data.ConnectionState.Open)
                {
                    band = true;
                }
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (SqlException sqlex)
            {
                throw new AppException("Error al conectar con la base de datos", "Error", sqlex);
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar conectar con la base de datos", "Fatal", ex);
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
