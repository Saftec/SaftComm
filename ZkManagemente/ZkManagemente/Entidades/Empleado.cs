using System;

namespace ZkManagement.Entidades
{
    public class Empleado
    {
        private string _nombre; 
        private string _tarjeta;
        private int _id;
        private string _legajo;
        private int _pin;
        private string _dni;

        //Propiedades//
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Tarjeta
        {
            get { return _tarjeta; }
            set { _tarjeta = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        public int Pin
        {
            get { return _pin; }
            set { _pin = value; }
        }
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
    }
}
