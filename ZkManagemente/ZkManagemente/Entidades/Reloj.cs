using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkManagement.Entidades
{
    class Reloj
    {
        private int puerto;
        private int numero;
        private int id;
        private int clave;
        private string dns;
        private string ip;
        private string nombre;

        public string DNS
        {
            get { return dns; }
            set { dns = value; }
        }


        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }        

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }


        public int Puerto
        {
            get { return puerto; }
            set { puerto = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (this.GetType() != obj.GetType()) { return false; }

            Reloj r = (Reloj)obj;
            return (this.id == r.id);            
        }
    }
}
