using System.Net;
using System.Text.RegularExpressions;

namespace ZkManagement.Util
{
    class Validate
    {
        public bool TimeFormat(string [] textos)
        {
            bool band = true;
            Regex validar = new Regex("^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            foreach (string t in textos)
            {
                if (validar.IsMatch(t.Trim()))
                {
                    band = false;
                }
            }
            return band;
        }
        public bool NotEmpty(string[] textos)
        {
            bool band = true;
            foreach(string t in textos)
            {
                if (t == string.Empty)
                {
                    band = false;
                }
            }
            return band;
        }

        public bool NumerosEnteros(string[] textos)
        {
            bool band = true;
            Regex validar = new Regex("[^0-9]");
            foreach (string t in textos)
            {
                if (validar.IsMatch(t.Trim()))
                {
                    band = false;
                }
            }
            return band;
        }

        public bool DireccionIP(string [] textos)
        {
            bool band = true;
            IPAddress ip = new IPAddress(new byte[] { 0, 0, 0, 0 });
            foreach (string t in textos)
            {
                if (!IPAddress.TryParse(t, out ip))
                {
                    band = false;
                }
            }
            return band;
        }

        public bool NumerosDecimales(string [] textos)
        {
            Regex validar = new Regex(@"[\d]([.,][\d])?");
            bool band = true;
            foreach(string t in textos)
            {
                if (!validar.IsMatch(t))
                {
                    band = false;
                }
            }
            return band;
        }

        public bool MaxLength(string[] textos, int min, int max)
        {
            bool band = true;
            
            foreach(string t in textos)
            {
                if (t.Length<min || t.Length > max)
                {
                    band = false;
                }
            }
            return band;
        }

    }
}
