
using System;
using Util;

namespace Entidades
{
    public class Usuario
    {
        #region Propiedades

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usr { get; set; }
        private string _pass;
        public string PassDecrypt
        {
            get
            {
                return Security.DesEncriptar(_pass);
            }
            set
            {
                _pass = value;
            }
        }
        public string PassEncrypt
        {
            get
            {
                return _pass;
            }
            set
            {
                _pass = Security.Encriptar(value);
            }
        }
        public int Nivel { get; set; }
        public string Permisos { get; set; }
        public DateTime? UltimoAcceso { get; set; }

        #endregion

        #region Constructores

        public Usuario(string usr, string pass, int nivel, int id)
        {
            Usr = usr;
            PassDecrypt = pass;
            Nivel = nivel;
            ID = id;
        }

        public Usuario(string usr, int nivel, int id)
        {
            Usr = usr;
            Nivel = nivel;
            ID = id;
        }
        public Usuario() { }

        #endregion
    }
}
