using System.Net;
using System.Text.RegularExpressions;

namespace ZkManagement.Util
{
    class Validate
    {
        public bool IsEmpty(string[] textos)
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
        public bool IsEmpty(string texto)
        {
            bool band = true;
            if (texto == string.Empty)
            {
                band = false;
            }
            return band;
        }

        public bool NumerosEnteros(string[] textos)
        {
            bool band = true;
            Regex validar = new Regex("[^0-9]");
            foreach (string t in textos)
            {
                if (!validar.IsMatch(t))
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
        public bool DireccionIP(string texto)
        {
            bool band = true;
            IPAddress ip = new IPAddress(new byte[] { 0, 0, 0, 0 });
            if (!IPAddress.TryParse(texto, out ip))
            {
                band = false;
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

    }
}
