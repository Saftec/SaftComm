
namespace Entidades
{
    public class Huella
    {
        private string _huella;
        private int _lengh;
        private int _fingerIndex;
        private int _flag;
        private Empleado _emp;

        public Huella()
        {
            _emp = new Empleado();
        }

        public Huella(string template, Empleado emp, int fingerIndex, int lengh, int flag)
        {
            Empleado = emp;
            Template = template;
            FingerIndex = fingerIndex;
            Lengh = lengh;
            Flag = flag;
        }
        #region Propiedades
        public Empleado Empleado
        {
            get { return _emp; }
            set { _emp = value; }
        }

        public string Template
        {
            get { return _huella; }
            set { _huella = value; }
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
