using System;
using System.Collections.Generic;
using Database;
using Entidades;
using Util;

namespace Logic
{
    public class LogicRegistros
    {
        public List<string> AgregarRegis(List<Fichada> fichadas)
        {
            Writer writer = new Writer();
            List<string> desconocidos = new List<string>();

            try
            {
                writer.EscribirRegistros(fichadas);
                foreach (Fichada f in fichadas)
                {
                    // VALIDAR SI LO TENGO QUE BUSCAR EN SAFTIME O EN SAFTCOMM //
                    if (VerificarSaftime())
                    {
                        f.Empleado = DataEmpleadoSaftime.Instancia.GetIdByLegajo(f.Empleado);
                    }else
                    {
                        f.Empleado = DataEmpleado.Instancia.GetIdByLegajo(f.Empleado);
                    }
                    
                    // SI NO LO ENCONTRÓ AGREGO EL LEGAJO A DESCONOCIDOS //
                    if (f.Empleado.Id < 1)
                    {
                        desconocidos.Add(f.Empleado.Legajo);
                        continue;
                    }
                    DataEmpleado.Instancia.InsertarRegis(f);
                }
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error desconocido durante la descarga de registros.", "Fatal", ex);
            }
            return desconocidos;
        }

        private bool VerificarSaftime()
        {
            LogicConfigSaftime lcs = new LogicConfigSaftime();
            bool band = false;
            try
            {
                band = lcs.IsRegistros();
            }
            catch(AppException appex)
            {
                throw appex;
            }
            return band; 
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
