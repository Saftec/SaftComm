
using System;
using Util;

namespace Entidades
{
    public class Usuario
    {
        private string _usr;
        private string _pass;
        private int _nivel;
        private int _id;
        private string _permisos;
        private string _nombre;
        private string _apellido;
        private DateTime? _ultimoAcceso;

        //CONSTRUCTORES
        public Usuario(string usr, string pass,int nivel, int id)
        {           
            _usr = usr;
            PassDecrypt = pass;
            _nivel = nivel;
            _id = id;
        }

        public Usuario(string usr, int nivel, int id)
        {
            _usr = usr;
            _nivel = nivel;
            _id = id;
        }
        public Usuario()
        {
        }

        //PROPIEDADES

        public DateTime? UltimoAcceso
        {
            get { return _ultimoAcceso; }
            set { _ultimoAcceso = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

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


        public string Usr
        {
            get { return _usr; }
            set { _usr = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Permisos
        {
            get { return _permisos; }
            set { _permisos = value; }
        }

        internal string ToUpper()
        {
            throw new NotImplementedException();
        }
    }
}
