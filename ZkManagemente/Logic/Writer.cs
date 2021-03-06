﻿using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
using Util;

namespace Logic
{
    public class Writer
    {
        public FormatoExport Formato { get; set; }
        public Writer(FormatoExport fe) {
            Formato = fe;
        }
        
        public void EscribirRegistros(List<Fichada> fichadas)
        {
            string linea, hora, tipoMov, fecha, reloj, legajo;
            LogicConfigRutinas lcr = new LogicConfigRutinas(); // AGREGO PARA VERIFICAR SI TENGO QUE ESCRIBIR FICHERO DE COPIA EN CARPETA RAIZ.

            try
            {
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
                    using (StreamWriter w = File.AppendText(Formato.Path))
                        w.WriteLine(linea);

                    // SI ESTA ACTIVA LA CONFIG DEL FICHERO DE BK LO ESCRIBO EN EL PATH DE LA APP
                    if (ficheroCopia)
                    {
                        string pathBK = Directory.GetCurrentDirectory() + @"\Regs\";
                        string fileName = FileName(Formato.Path);
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

            linea[Formato.PosicionHora - 1] = hora;

            linea[Formato.PosicionMov - 1] = tipoMov;

            linea[Formato.PosicionFecha - 1] = fecha;

            linea[Formato.PosicionReloj - 1] = reloj;

            linea[Formato.PosicionLegajo - 1] = legajo;

            separador = LeerSeparador();

            return string.Join(separador, linea);
        }
        // este método reemplaza el separador por el caracter que corresponda y lo devuelve //
        private string LeerSeparador()
        {
            string separador = Formato.SeparadorCampos;
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

            string separador = Formato.SeparadorHora;
            if(separador=="ninguno") { separador = string.Empty; }

            switch (Formato.FormatoHora)
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

            string separador = Formato.SeparadorFecha;
            if(separador=="ninguno") { separador = string.Empty; }

            switch (Formato.FormatoFecha)
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
            if (Formato.LongitudLegajo > 0)
            {
                legajo=legajo.PadLeft(Formato.LongitudLegajo, '0');
            }
            return legajo;
        }
        private string FormatoModo(int modo)
        {
            string codigo;

            if (modo == 0)
            {
                codigo = Formato.CodEntrada;
            }
            else
            {
                codigo = Formato.CodSalida;
            }
            return codigo;
        }
        private string FormatoReloj(int reloj)
        {
            string relojFormateado = reloj.ToString();
            if (Formato.LongitudReloj > 0)
            {
                relojFormateado=reloj.ToString().PadLeft(Formato.LongitudReloj, '0');                
            }
            return (Formato.PrefijoReloj.ToUpper()+relojFormateado);
        }
    }
}