
namespace ZkManagement.Entidades
{
    class Usuario
    {
        private string _usr;
        private string _pass;
        private int _nivel;

        public int nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }


        public string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }


        public string usr
        {
            get { return _usr; }
            set { _usr = value; }
        }

    }
}
