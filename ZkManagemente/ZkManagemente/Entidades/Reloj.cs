
namespace ZkManagement.Entidades
{
   public class Reloj
    {
        private int puerto;
        private int numero;
        private int id;
        private string clave;
        private string dns;
        private string ip;
        private string nombre;

        public Reloj()
        {
        }

        public Reloj(int puerto, int numero, int id, string clave, string dns, string ip, string nombre)
        {
            this.puerto = puerto;
            this.numero = numero;
            this.id = id;
            this.clave = clave;
            this.dns = dns;
            this.ip = ip;
            this.nombre = nombre;
        }
        
        public string DNS
        {
            get { return dns; }
            set { dns = value; }
        }


        public string Clave
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
            return (this.Id == r.Id);            
        }
    }
}
