using System;
using System.IO;

namespace ZkManagement.Logica
{
    class ControladorArchivos
    {
        private ControladorConfiguraciones cc = new ControladorConfiguraciones();

        public void EscribirRegistros(int nroDispositivo, int ioModo, int año, int mes, int dia, int horas, int minuto, String legajo, String path)
        {
            string linea;
            string hora;
            string tipoMov;
            int codError = 0;
            DateTime fecha = new DateTime(año, mes, dia);

            hora = FormatearHora(horas, minuto);
            path = cc.GetConfig(2);
            if (legajo.Length < 5) { legajo = legajo.PadLeft(5, '0'); } //COMPLETO EL LEGAJO CON CEROS
            if ((ioModo.ToString()).Length == 1) { tipoMov = ioModo.ToString().PadLeft(2, '0'); }
            else { tipoMov = ioModo.ToString(); }
            linea = "0" + nroDispositivo.ToString() + tipoMov + fecha.ToString("yyMMdd") + horas + legajo + "\n";
            try
            {
                using (StreamWriter w = File.AppendText(path))
                    w.WriteLine(linea);
            }

            catch (Exception)
            {
                throw new Exception("Error al intentar escribir el log de operaciones");
            }
        }

        private String FormatearHora(int hora, int minutos) //LE DOY EL FORMATO CORRECTO A LA FECHA Y HORA Y CONCATENO
        {
            string linea;
            if ((hora.ToString()).Length == 1) { linea = hora.ToString().PadLeft(2, '0'); }
            else { linea = hora.ToString(); }
            if ((minutos.ToString()).Length == 1) { linea = linea + minutos.ToString().PadLeft(2, '0'); }
            else { linea = linea + minutos.ToString(); }
            return linea;
        }

        #region Operaciones

        private void EscribirLog(String linea)
        {
            string path = cc.GetConfig(3);
            try
            {
                using (StreamWriter l = File.AppendText(path + "log.txt"))
                    l.WriteLine(DateTime.Now.ToString() + linea);
            }
            catch (IOException ex)
            {
            }

        }

        public void InicioSesion(String usuario)
        {
            //VER FORMATO EN FORMATO.TXT
            String linea;
            linea = "-----------------------------------------------------------------\n";
            EscribirLog(linea);
            linea = " ---------" + " Sesión Iniciada: " + usuario.ToUpper() + " ---------" + "\n";
            EscribirLog(linea);
        }

        public void SincronizarHora(int nroReloj)
        {
            String linea;
            linea = " Hora sincronizada con reloj: " + nroReloj;
            EscribirLog(linea);
        }

        public void Conexion(int nroReloj)
        {
            String linea;
            linea = " Conexión con Reloj: " + nroReloj.ToString().PadLeft(2, '0') + "\n";
            EscribirLog(linea);
        }

        public void Rutina(String tipo, String rutina)
        {
            String linea = "** " + tipo + " rutina de: " + rutina + " **";
            EscribirLog(linea);
        }

        public void IniciaDescarga()
        {
            EscribirLog(" Inicio de proceso de descarga de registros");
        }

        public void DescargaRegistros(int cantidad, String path)
        {
            string linea;
            linea = " Se descargaron:" + cantidad.ToString() + " registraciones al archivo: " + path;
            EscribirLog(linea);
        }

        public void BorradoRegistros(int cantidad)
        {
            String linea;
            linea = " Se borraron: " + cantidad.ToString() + " registros";
            EscribirLog(linea);
        }

        public void Desconectar(int nroReloj)
        {
            string linea = " Reloj " + nroReloj.ToString() + " desconectado.";
            EscribirLog(linea);
        }
        #endregion
    }
}