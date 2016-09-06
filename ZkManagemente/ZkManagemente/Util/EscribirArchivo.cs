using log4net;
using System;
using System.IO;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class EscribirArchivo
    {
        private ControladorConfiguraciones cc = new ControladorConfiguraciones();
        private Config config = new Config();
        private ILog logger = LogManager.GetLogger("");

        public void EscribirRegistros(int nroDispositivo, int ioModo, int año, int mes, int dia, int horas, int minuto, string legajo)
        {
            string path = cc.GetConfig(2); //Obtengo path de descarga de registros

            string linea, hora, tipoMov, fecha, reloj;         

            hora = FormatoHora(horas, minuto);
            fecha = FormatoFecha(año, mes, dia);
            legajo = FormatoLegajo(legajo);
            tipoMov = FormatoModo(ioModo);
            reloj = FormatoReloj(nroDispositivo);
            linea = FormatoLinea(hora, tipoMov, fecha, reloj, legajo);
 
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

        private string FormatoLinea(string hora, string tipoMov, string fecha, string reloj, string legajo)
        {
            string separador;
            int indice;
            string[] linea = new string[5];

            indice = Convert.ToInt32(config.Read("Hora", "Posicion"));
            linea[indice - 1] = hora;
            indice = Convert.ToInt32(config.Read("Movimientos", "Posicion"));
            linea[indice - 1] = tipoMov;
            indice = Convert.ToInt32(config.Read("fecha", "Posicion"));
            linea[indice - 1] = fecha;
            indice = Convert.ToInt32(config.Read("Reloj", "Posicion"));
            linea[indice - 1] = reloj;
            indice = Convert.ToInt32(config.Read("Legajo", "Posicion"));
            linea[indice - 1] = legajo;

            separador = LeerSeparador();

            return string.Join(separador, linea);
        }

        private string LeerSeparador()
        {
            string separador = config.Read("General", "Separador");

            switch (separador)
            {
                case "ninguno":
                    separador = string.Empty;
                    break;
                case "tab":
                    separador = "\t";
                    break;
                case "espacio":
                    separador = " ";
                    break;
            }
            return separador;
        }
        private string FormatoHora(int hora, int minutos) //LE DOY EL FORMATO CORRECTO A LA FECHA Y HORA Y CONCATENO
        {
            string horaFormateada = string.Empty;
            string formato = config.Read("Hora", "Formato");

            string separador = config.Read("Hora", "Separador");
            if(separador=="ninguno") { separador = string.Empty; }

            switch (formato)
            {
                case "hhmm":
                    horaFormateada = hora.ToString().PadLeft(2,'0') + separador + minutos.ToString().PadLeft(2,'0');
                    break;
                case "mmhh":
                    horaFormateada = minutos.ToString().PadLeft(2,'0') + separador + hora.ToString().PadLeft(2,'0');
                    break;
            }
            return horaFormateada;

        }

        private string FormatoFecha(int año, int mes, int dia)
        {
            string fecha = string.Empty;
            string formato = config.Read("Fecha", "Formato");

            string separador = config.Read("Fecha", "Separador");
            if(separador=="ninguno") { separador = string.Empty; }

            switch (formato)
            {
                case "yyyymmdd":
                        fecha = año.ToString().PadLeft(4,'0') + separador + mes.ToString().PadLeft(2, '0') + separador + dia.ToString().PadLeft(2,'0');
                    break;
                case "ddmmyyyy":
                    fecha = dia.ToString().PadLeft(2, '0') + separador + mes.ToString().PadLeft(2, '0') + separador + año.ToString().PadLeft(4, '0');
                    break;
                case "ddmmyy":
                    fecha = dia.ToString().PadLeft(2, '0') + separador + mes.ToString().PadLeft(2, '0') + separador + año.ToString().Substring(2, 2);
                    break;
                case "yymmdd":
                    fecha = año.ToString().Substring(2,2) + separador + mes.ToString().PadLeft(2, '0') + separador + dia.ToString().PadLeft(2, '0');
                    break;
            }
            return fecha;
        }
        
        private string FormatoLegajo(string legajo)
        {
            int total = Convert.ToInt32(config.Read("Legajo", "Completar"));
            if (total > 0)
            {
                legajo=legajo.PadLeft(total, '0');
            }
            return legajo;
        }

        private string FormatoModo(int modo)
        {
            string codigo;

            if (modo == 0)
            {
                codigo = config.Read("Movimientos", "CodEntrada");
            }
            else
            {
                codigo = config.Read("Movimientos", "CodSalida");
            }
            return codigo;
        }

        private string FormatoReloj(int reloj)
        {         
            string cadena = config.Read("Reloj", "Cadena");            
            int total = Convert.ToInt32(config.Read("Reloj", "Completar"));
            string relojFormateado = cadena + reloj.ToString();
            if (total > 0)
            {
                relojFormateado=reloj.ToString().PadLeft(total, '0');                
            }
            return relojFormateado;
        }
    }
}