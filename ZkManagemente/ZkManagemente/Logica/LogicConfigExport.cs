using System;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicConfigExport
    {
        Config config = new Config();

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
