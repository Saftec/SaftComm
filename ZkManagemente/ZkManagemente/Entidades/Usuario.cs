
namespace ZkManagement.Entidades
{
    public class Usuario
    {
        private string _usr;
        private string _pass;
        private int _nivel;
        private int _id;
        private string _permisos;

        //CONSTRUCTORES
        public Usuario(string usr, string pass,int nivel, int id)
        {           
            Usr = usr;
            Pass = pass;
            Nivel = nivel;
            Id = id;
        }

        public Usuario()
        {
        }

        //PROPIEDADES

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

        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }


        public string Usr
        {
            get { return _usr; }
            set { _usr = value; }
        }

        public string Permisos
        {
            get { return _permisos; }
            set { _permisos = value; }
        }


    }
}
