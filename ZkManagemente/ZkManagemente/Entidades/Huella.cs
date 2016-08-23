using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkManagement.Entidades
{
    public class Huella
    {
        private string _huella;
        private string _legajo;
        private int _lengh;
        private int _fingerIndex;
        private int _flag;

        public Huella() { }

        public Huella(string template, string legajo, int fingerIndex, int lengh, int flag)
        {
            Template = template;
            Legajo = legajo;
            FingerIndex = fingerIndex;
            Lengh = lengh;
            Flag = flag;
        }
        #region Propiedades
        public string Template
        {
            get { return _huella; }
            set { _huella = value; }
        }
        public string Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        public int Lengh
        {
            get { return _lengh; }
            set { _lengh = value; }
        }
        public int FingerIndex
        {
            get { return _fingerIndex; }
            set { _fingerIndex = value; }
        }
        public int Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        #endregion
    }
}
