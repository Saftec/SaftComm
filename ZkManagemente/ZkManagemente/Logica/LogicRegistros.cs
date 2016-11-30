using System;
using System.Collections.Generic;
using System.Configuration;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicRegistros
    {
        private DataEmpleado ce = new DataEmpleado();
        private ControladorConfiguraciones cc = new ControladorConfiguraciones();
        public List<string> AgregarRegis(List<Fichada> fichadas)
        {
            Writer writer = new Writer();
            List<string> desconocidos = new List<string>();

            try
            {
                foreach (Fichada f in fichadas)
                {
                    writer.EscribirRegistros(f);
                    string legajo = f.Empleado.Legajo;

                    // VALIDAR SI LO TENGO QUE BUSCAR EN SAFTIME O EN SAFTCOMM //
                    if (VerificarSaftime())
                    {
                        f.Empleado = DataEmpleadoSaftime.GetInstancia().GetIdByLegajo(legajo);
                    }else
                    {
                        f.Empleado = DataEmpleado.GetInstancia().GetIdByLegajo(legajo);
                    }
                    
                    // SI NO LO ENCONTRÓ AGREGO EL LEGAJO A DESCONOCIDOS //
                    if (f.Empleado.Id < 1)
                    {
                        desconocidos.Add(legajo);
                        continue;
                    }
                    DataEmpleado.GetInstancia().InsertarRegis(f);

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return desconocidos;
        }

        private bool VerificarSaftime()
        {
            bool resul = false;
            if (!Boolean.TryParse(ConfigurationManager.AppSettings["Saftime"], out resul))
            {
                throw new AppException("Error al intentar leer la configuración de Saftime");
            }
            return resul;
        }

        //Subir archivo a FTP
        /* public bool SubirArchivoFTP(string origen, string destino)
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

         }*/
    }
}
