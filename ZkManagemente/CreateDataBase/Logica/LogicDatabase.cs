using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;

namespace CreateDataBase.Logica
{
    class LogicDatabase
    {
        public void CrearBase(string usuario, string pass, string servidor, string bd, string time)
        {
            string sqlConnectionString = "Data Source="+ servidor + ";Initial Catalog="+ bd +"; User ID="+usuario+";Password="+pass+"; Connection Timeout="+time;
            string script = File.ReadAllText(@"\CreateDB.sql");

            SqlConnection conn = new SqlConnection(sqlConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(script, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
