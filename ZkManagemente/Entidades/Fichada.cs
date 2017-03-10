using System;

namespace Entidades
{
    public class Fichada
    {
        private DateTime _registro;
        private int _tipo;
        private string _movimiento;
        private Empleado _emp;
        private Reloj _reloj;       

        public Fichada()
        {
            _emp = new Empleado();
            _reloj = new Reloj();
            _movimiento = "Desconocido";
        }

        /*            1-->Salida
              0-->Entrada
              4-->Entrada T.E.
              5-->Salida T.E.        */
        public string Movimiento
        {
            get { return _movimiento; }
            set { _movimiento = value; }
        }
        public Empleado Empleado
        {
            get { return _emp; }
            set { _emp = value; }
        }
        public Reloj Reloj
        {
            get { return _reloj; }
            set { _reloj = value; }
        }
        public int Tipo
        {
            get { return _tipo; }
            set
            {
                switch(value)
                {
                    case 0:
                        _movimiento = "Entrada";
                        break;
                    case 1:
                        _movimiento = "Salida";
                        break;
                    case 4:
                        _movimiento = "Entrada TE";
                        break;
                    case 5:
                        _movimiento = "Salida TE";
                        break;
                }
                _tipo = value;
            }
        }
        public DateTime Registro
        {
            get { return _registro; }
            set { _registro = value; }
        }

    }
}
