using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using ZkManagement.Datos;
using ZkManagement.Entidades;

namespace ZkManagement.Logica
{
    class ControladorRegistros
    {
        private CatalogoEmpleados ce = new CatalogoEmpleados();
        private ControladorConfiguraciones cc = new ControladorConfiguraciones();
        public List<string> AgregarRegis(DataTable regis)
        {
            List<string> desconocidos = new List<string>(); 
           foreach(DataRow fila in regis.Rows)
            {
                int id;
                int tipoMov;
                int reloj;
                DateTime fecha;
                reloj = Convert.ToInt32(fila["Reloj"]);
                try
                {
                    id = ce.GetEmpId(fila["Legajo"].ToString());
                    if (id < 1)
                    {
                        desconocidos.Add(fila["Legajo"].ToString());
                        break;
                    }

                        fecha = Convert.ToDateTime(fila["Registro"]);
                        tipoMov = Convert.ToInt32(fila["Tipo"]);
                        string tipo = "Desconocida"; 
           /*            1-->Salida
                         0-->Entrada
                         4-->Entrada T.E.
                         5-->Salida T.E.        */
                        switch (tipoMov)
                        {
                            case 0:
                                tipo = "Entrada";
                                break;
                            case 1:
                                tipo = "Salida";
                                break;
                            case 4:
                                tipo = "Entrada TE";
                                break;
                            case 5:
                                tipo = "Salida TE";
                                break;
                        }
                            ce.InsertarRegis(id, fecha, tipo , reloj);
                }
                catch(Exception ex)
                {
                    throw ex;
                }              
            }
            return desconocidos;
            /* string destino = "Regs-" + (DateTime.Now).ToString("yyyyMMdd-hhMM") + ".txt";
             SubirArchivoFTP(cc.GetConfig(2), destino);*/
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
