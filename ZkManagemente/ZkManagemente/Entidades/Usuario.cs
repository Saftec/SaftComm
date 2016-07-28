
namespace ZkManagement.Entidades
{
    class Usuario
    {
        private string _usr;
        private string _pass;
        private int _nivel;
        private string _permisos;

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
