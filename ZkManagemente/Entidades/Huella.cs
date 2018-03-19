
namespace Entidades
{
    public class Huella
    {
        #region Propiedades

        public string Template { get; set; }
        public int Lengh { get; set; }
        public int FingerIndex { get; set; }
        public int Flag { get; set; }
        public Empleado Empleado { get; set; }

        #endregion

        #region Constructores

        public Huella()
        {
            Empleado = new Empleado();
        }

        public Huella(string template, Empleado emp, int fingerIndex, int lengh, int flag)
        {
            Empleado = emp;
            Template = template;
            FingerIndex = fingerIndex;
            Lengh = lengh;
            Flag = flag;
        }

        #endregion
    }
}