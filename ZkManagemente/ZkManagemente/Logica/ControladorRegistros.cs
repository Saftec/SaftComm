using System;
using System.Data;
using System.IO;
using System.Net;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorRegistros
    {
       // private CatalogoRegistros cr = new CatalogoRegistros();
        private CatalogoEmpleados ce = new CatalogoEmpleados();
        private ControladorConfiguraciones cc = new ControladorConfiguraciones();
        public void AparearRegis(DataTable regis)
        {
            //TENGO QUE BUSCAR EL EMPID DE C/U Y GUARDAR LINEA POR LINEA CON EMPID Y NO LEGAJO!!
           // cr.GuardarRegis(regis);
           foreach(DataRow fila in regis.Rows)
            {
                int id;
                DateTime fecha;
                Empleado emp = new Empleado();
                emp.Legajo = fila["Legajo"].ToString();
                id = ce.GetEmpId(emp);

            }


            string destino = "Regs-" + (DateTime.Now).ToString("yyyyMMdd-hhMM") + ".txt";
            SubirArchivoFTP(cc.GetConfig(2), destino);
        }
        public bool SubirArchivoFTP(string origen, string destino)
        {
            string server = cc.GetConfig(9);
            string user = cc.GetConfig(10);
            string pass = cc.GetConfig(11);
            string rutadestino = cc.GetConfig(12);
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(server + rutadestino + "/" + destino);
                request.UsePassive = false;
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(user, pass);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(origen);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                reqStream.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
