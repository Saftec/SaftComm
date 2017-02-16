using System;
using System.Collections.Generic;
using System.IO;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class Writer
    {
        private FormatoExport fe;
        public void EscribirRegistros(List<Fichada> fichadas)
        {
            string linea, hora, tipoMov, fecha, reloj, legajo;
            LogicConfigRutinas lcr = new LogicConfigRutinas(); // AGREGO PARA VERIFICAR SI TENGO QUE ESCRIBIR FICHERO DE COPIA EN CARPETA RAIZ.

            try
            {                         
                ObtenerFormatoActual();
                bool ficheroCopia = lcr.IsFicheroCopia();
                foreach(Fichada f in fichadas)
                {
                    // FORMATEO CADA CAMPO //
                    hora = FormatoHora(f.Registro.Hour, f.Registro.Minute);
                    fecha = FormatoFecha(f.Registro.Year, f.Registro.Month, f.Registro.Day);
                    legajo = FormatoLegajo(f.Empleado.Legajo);
                    tipoMov = FormatoModo(f.Tipo);
                    reloj = FormatoReloj(f.Reloj.Numero);
                    linea = FormatoLinea(hora, tipoMov, fecha, reloj, legajo);

                    // ESCRIBO LA LINEA //
                    using (StreamWriter w = File.AppendText(fe.Path))
                        w.WriteLine(linea);

                    // SI ESTA ACTIVA LA CONFIG DEL FICHERO DE BK LO ESCRIBO EN EL PATH DE LA APP
                    if (ficheroCopia)
                    {
                        string pathBK = Directory.GetCurrentDirectory() + @"\Regs\";
                        string fileName = FileName(fe.Path);
                        FileInfo fi = new FileInfo(pathBK);
                        if (!fi.Directory.Exists)
                        {
                            System.IO.Directory.CreateDirectory(fi.DirectoryName);
                        }
                        using (StreamWriter w = File.AppendText(pathBK + "BK_" + DateTime.Now.ToString("yyMMddhhmmss") + "_" + fileName))
                            w.WriteLine(linea);                      
                    }
                }                             
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al intentar escribir el archivo de registros", "Fatal", ex);               
            }
        }

        private string FileName(string path)
        {
            string[] directories = path.Split(Path.DirectorySeparatorChar);
            string name = string.Empty;

            name = directories[directories.Length - 1];
            return name;
        }
        private string FormatoLinea(string hora, string tipoMov, string fecha, string reloj, string legajo)
        {
            string separador;

            string[] linea = new string[5];

            linea[fe.PosicionHora - 1] = hora;

            linea[fe.PosicionMov - 1] = tipoMov;

            linea[fe.PosicionFecha - 1] = fecha;

            linea[fe.PosicionReloj - 1] = reloj;

            linea[fe.PosicionLegajo - 1] = legajo;

            separador = LeerSeparador();

            return string.Join(separador, linea);
        }

        // este método reemplaza el separador por el caracter que corresponda y lo devuelve //
        private string LeerSeparador()
        {
            string separador = fe.SeparadorCampos;
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

            string separador = fe.SeparadorHora;
            if(separador=="ninguno") { separador = string.Empty; }

            switch (fe.FormatoHora)
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

            string separador = fe.SeparadorFecha;
            if(separador=="ninguno") { separador = string.Empty; }

            switch (fe.FormatoFecha)
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
            if (fe.LongitudLegajo > 0)
            {
                legajo=legajo.PadLeft(fe.LongitudLegajo, '0');
            }
            return legajo;
        }

        private string FormatoModo(int modo)
        {
            string codigo;

            if (modo == 0)
            {
                codigo = fe.CodEntrada;
            }
            else
            {
                codigo = fe.CodSalida;
            }
            return codigo;
        }

        private string FormatoReloj(int reloj)
        {
            string relojFormateado = reloj.ToString();
            if (fe.LongitudReloj > 0)
            {
                relojFormateado=reloj.ToString().PadLeft(fe.LongitudReloj, '0');                
            }
            return (fe.PrefijoReloj.ToUpper()+relojFormateado);
        }

        private void ObtenerFormatoActual()
        {
            LogicFormatos lf = new LogicFormatos();
            try
            {
                fe = lf.GetFormatoActivo();
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al consultar formato activo", "Fatal", ex);
            }
        }
    }
}