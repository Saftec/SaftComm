using System.Collections.Generic;
using System;

namespace Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tarjeta { get; set; }
        public string Pin { get; set; }
        public string DNI { get; set; }
        public int Privilegio { get; set; }
        public DateTime? Baja { get; set; }
        public int CantHuellas { get; set; }
        public List<Huella> Huellas { get; set; }

        public Empleado()
        {
            Huellas = new List<Huella>();
        }
    }
}