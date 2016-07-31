using System;
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
        private bool SubirArchivoAFTP()
        {
            ControladorConfiguraciones cc = new ControladorConfiguraciones();
            string origen = cc.GetConfig(2);
            //Almacenar datos de FTP en la base de datos//
            string server = @"ftp://186.125.73.38/";
            string user = "invitado";
            string pass = "invitado";
            string rutadestino = @"usb1_4/";
            string nombredestino = "Log.txt";
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server + rutadestino + nombredestino);
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
