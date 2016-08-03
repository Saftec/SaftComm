using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net;
using ZkManagement.Datos;

namespace ZkManagement.Logica
{
    class ControladorRegistros
    {
        private CatalogoRegistros cr = new CatalogoRegistros();
        public void AparearRegis(DataTable regis)
        {
            //TENGO QUE BUSCAR EL EMPDID DE C/U Y GUARDAR LINEA POR LINEA CON EMPID Y NO LEGAJO!!
            cr.GuardarRegis(regis);
            SubirArchivoAFTP();
        }
        public bool SubirArchivoAFTP()
        {
            ControladorConfiguraciones cc = new ControladorConfiguraciones();
            string origen = @"C:\Users\Sergio\Desktop\Regs.cpc";
            //Almacenar datos de FTP en la base de datos//
            string server = ConfigurationManager.AppSettings.Get("Servidor");
            string user = ConfigurationManager.AppSettings.Get("Usuario");
            string pass = ConfigurationManager.AppSettings.Get("Password");
            string rutadestino = ConfigurationManager.AppSettings.Get("PathFtp");
            string nombredestino = "Regs-" + (DateTime.Now).ToString("yyyyMMdd-hhMM") + ".txt";
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(server + rutadestino + "/" + nombredestino);
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
