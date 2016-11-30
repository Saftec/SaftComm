using System;

namespace ZkManagement.Entidades
{
    class Fichada
    {
        private DateTime _registro;
        private string _tipo;
        private Empleado _emp;
        private Reloj _reloj;       

        public Fichada()
        {
            _emp = new Empleado();
            _reloj = new Reloj();
        }

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public DateTime Registro
        {
            get { return _registro; }
            set { _registro = value; }
        }

    }
}
