using System;
using Util;

namespace Entidades
{
    public class Usuario : BaseEntity
    {
        private string _pass;

        //CONSTRUCTORES
        public Usuario(string usr, string pass,int nivel, int id)
        {           
            Usr = usr;
            PassDecrypt = pass;
            Nivel = nivel;
            Id = id;
        }

        public Usuario(string usr, int nivel, int id)
        {
            Usr = usr;
            Nivel = nivel;
            Id = id;
        }

        public Usuario()
        {
        }

        public string Usr { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Permisos { get; set; }

        public DateTime? UltimoAcceso { get; set; }

        public int Nivel { get; set; }

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
    }
}
