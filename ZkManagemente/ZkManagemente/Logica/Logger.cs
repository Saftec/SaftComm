using log4net;
using System;
using System.IO;

namespace ZkManagement.Logica
{
    class Logger
    {
        private ControladorConfiguraciones cc = new ControladorConfiguraciones();
        private ILog logger = LogManager.GetLogger("");

        public void EscribirRegistros(int nroDispositivo, int ioModo, int año, int mes, int dia, int horas, int minuto, string legajo)
        {
            string linea;
            string hora;
            string tipoMov;
            DateTime fecha = new DateTime(año, mes, dia);
            string path = cc.GetConfig(2); //Obtengo path de descarga de registros

            hora = FormatearHora(horas, minuto);
            legajo = legajo.PadLeft(5, '0'); //COMPLETO EL LEGAJO CON CEROS
            tipoMov = ioModo.ToString().PadLeft(2, '0'); 
            linea = "0" + nroDispositivo.ToString() + tipoMov + fecha.ToString("yyMMdd") + horas + legajo + "\n";
            try
            {
                using (StreamWriter w = File.AppendText(path))
                    w.WriteLine(linea);
            }

            catch (Exception ex)
            {
                logger.Fatal(ex.Message);
                throw new Exception("Error al intentar escribir el archivo de registros");               
            }
        }

        private string FormatearHora(int hora, int minutos) //LE DOY EL FORMATO CORRECTO A LA FECHA Y HORA Y CONCATENO
        {
            string linea;
            if ((hora.ToString()).Length == 1) { linea = hora.ToString().PadLeft(2, '0'); }
            else { linea = hora.ToString(); }
            if ((minutos.ToString()).Length == 1) { linea = linea + minutos.ToString().PadLeft(2, '0'); }
            else { linea = linea + minutos.ToString(); }
            return linea;
        }

        #region Operaciones

        private void EscribirLog(string linea)
        {
            try
            {
                using (StreamWriter l = File.AppendText("Log.txt"))
                    l.WriteLine(DateTime.Now.ToString() + linea);
            }
            catch (IOException ioex)
            {
                logger.Error(ioex.Message);
                throw new Exception("Error al intentar escribir el log");                
            }
            catch(Exception ex)
            {
                logger.Fatal(ex.Message);
                throw new Exception("Error no controlado al intentar escribir el log");
            }

        }

        public void InicioSesion(string usuario)
        {
            //VER FORMATO EN FORMATO.TXT
            try
            {
                string linea;
                linea = "-----------------------------------------------------------------\n";
                EscribirLog(linea);
                linea = " ---------" + " Sesión Iniciada: " + usuario.ToUpper() + " ---------" + "\n";
                EscribirLog(linea);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void SincronizarHora(int nroReloj)
        {
            try
            {
                string linea;
                linea = " Hora sincronizada con reloj: " + nroReloj;
                EscribirLog(linea);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void Conexion(int nroReloj)
        {
            try
            {
                string linea;
                linea = " Conexión con Reloj: " + nroReloj.ToString().PadLeft(2, '0') + "\n";
                EscribirLog(linea);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Rutina(string tipo, string rutina)
        {
            try
            {
                string linea = "** " + tipo + " rutina de: " + rutina + " **";
                EscribirLog(linea);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void IniciaDescarga()
        {
            try
            {
                EscribirLog(" Inicio de proceso de descarga de registros");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DescargaRegistros(int cantidad)
        {
            try
            {
                ControladorConfiguraciones cc = new ControladorConfiguraciones();
                string path = cc.GetConfig(2);
                string linea;
                linea = " Se descargaron: " + cantidad.ToString() + " registraciones al archivo: " + path;
                EscribirLog(linea);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void BorradoRegistros(int cantidad)
        {
            try
            {
                string linea;
                linea = " Se borraron: " + cantidad.ToString() + " registros";
                EscribirLog(linea);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void Desconectar(int nroReloj)
        {
            try
            {
                string linea = " Reloj " + nroReloj.ToString().PadLeft(2, '0') + " desconectado.";
                EscribirLog(linea);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}