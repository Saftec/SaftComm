using System;

namespace Entidades
{
    public class Fichada
    {
        public DateTime Registro { get; set; }
        public string Movimiento { get; set; }
        public Empleado Empleado { get; set; }
        public Reloj Reloj { get; set; }
        private int _tipo;
        public int Tipo
        {
            get { return _tipo; }
            set
            {
                switch (value)
                {
                    case 0:
                        Movimiento = "Entrada";
                        break;
                    case 1:
                        Movimiento = "Salida";
                        break;
                    case 4:
                        Movimiento = "Entrada TE";
                        break;
                    case 5:
                        Movimiento = "Salida TE";
                        break;
                }
                _tipo = value;
            }
        }

        public Fichada()
        {
            Empleado = new Empleado();
            Reloj = new Reloj();
            Movimiento = "Desconocido";
        }
    }
}