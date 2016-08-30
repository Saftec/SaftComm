using log4net;
using System;
using System.IO;

namespace ZkManagement.Logica
{
    class EscribirArchivo
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
    }
}