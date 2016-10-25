using System;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicConfigExport
    {
        Config config = new Config();

        #region Getters
        public string GetCodEntrada()
        {
            string valor = string.Empty;
            try
            {
                valor=config.Read("Movimientos", "CodEntrada");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetCodSalida()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Movimientos", "CodSalida");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetPosMov()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Movimientos", "Posicion");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
         public string GetPosFecha()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Fecha", "Posicion");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetSeparadorFecha()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Fecha", "Separador");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetPosHora()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Hora", "Posicion");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetSeparadorHora()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Hora", "Separador");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetFormatoFecha()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Fecha", "Formato");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetFormatoHora()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Hora", "Formato");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetLongitudLegajo()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Legajo", "Completar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetPosLegajo()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Legajo", "Posicion");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetLongitudReloj()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Reloj", "Completar");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetPosReloj()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Reloj", "Posicion");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetSeparadorCampos()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("General", "Separador");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetPath()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("General", "Path");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public string GetPrefijoReloj()
        {
            string valor = string.Empty;
            try
            {
                valor = config.Read("Reloj", "Cadena");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        #endregion
        #region Setters
        public void SetCodEntrada(string cod)
        {
            try
            {
                config.Write("Movimientos", "CodEntrada", cod);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetCodSalida(string cod)
        {
            try
            {
                config.Write("Movimientos", "CodSalida", cod);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetPosMov(string pos)
        {
            try
            {
                config.Write("Movimientos", "Posicion", pos);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void SetPosFecha(string pos)
        {
            try
            {
                config.Write("Fecha", "Posicion", pos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetSeparadorFecha(string separador)
        {
            try
            {
                config.Write("Fecha", "Separador", separador);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetPosHora(string pos)
        {
            try
            {
                config.Write("Hora", "Posicion", pos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetSeparadorHora(string separador)
        {
            try
            {
                config.Write("Hora", "Separador", separador);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetFormatoFecha(string formato)
        {
            try
            {
                config.Write("Fecha", "Formato", formato);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetFormatoHora(string formato)
        {
            try
            {
                config.Write("Hora", "Formato", formato);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetLongitudLegajo(string largo)
        {
            try
            {
                config.Write("Legajo", "Completar", largo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetPosLegajo(string pos)
        {
            try
            {
                config.Write("Legajo", "Posicion", pos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetLongitudReloj(string largo)
        {
            try
            {
                config.Write("Reloj", "Completar", largo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetPosReloj(string pos)
        {
            try
            {
                config.Write("Reloj", "Posicion", pos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetSeparadorCampos(string separador)
        {
            try
            {
                config.Write("General", "Separador", separador);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetPathDescarga(string path)
        {
            try
            {
                config.Write("General", "Path", path);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void SetPrefijoReloj(string prefijo)
        {
            try
            {
                config.Write("Reloj", "Cadena", prefijo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
#endregion
    }
}
