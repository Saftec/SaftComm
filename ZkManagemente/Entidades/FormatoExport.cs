
namespace Entidades
{
    public class FormatoExport
    {
        private string _path;
        private string _separadorCampos;
        private string _formatoFecha;
        private int _posicionFecha;
        private string _separadorFecha;
        private string _formatoHora;
        private int _posicionHora;
        private string _separadorHora;
        private int _posicionLegajo;
        private int _longitudLegajo;
        private int _posicionReloj;
        private int _longitudReloj;
        private string _prefijoReloj;
        private string _codEntrada;
        private string _codSalida;
        private int _posicionMovimiento;
        private string _nombre;
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public int PosicionMov
        {
            get { return _posicionMovimiento; }
            set { _posicionMovimiento = value; }
        }
        public string CodSalida
        {
            get { return _codSalida; }
            set { _codSalida = value; }
        }
        public string CodEntrada
        {
            get { return _codEntrada; }
            set { _codEntrada = value; }
        }
        public string PrefijoReloj
        {
            get { return _prefijoReloj; }
            set { _prefijoReloj = value; }
        }
        public int LongitudReloj
        {
            get { return _longitudReloj; }
            set { _longitudReloj = value; }
        }
        public int PosicionReloj
        {
            get { return _posicionReloj; }
            set { _posicionReloj = value; }
        }
        public int LongitudLegajo
        {
            get { return _longitudLegajo; }
            set { _longitudLegajo = value; }
        }
        public int PosicionLegajo
        {
            get { return _posicionLegajo; }
            set { _posicionLegajo = value; }
        }
        public string SeparadorHora
        {
            get { return _separadorHora; }
            set { _separadorHora = value; }
        }
        public int PosicionHora
        {
            get { return _posicionHora; }
            set { _posicionHora = value; }
        }
        public string FormatoHora
        {
            get { return _formatoHora; }
            set { _formatoHora = value; }
        }
        public string SeparadorFecha
        {
            get { return _separadorFecha; }
            set { _separadorFecha = value; }
        }
        public int PosicionFecha
        {
            get { return _posicionFecha; }
            set { _posicionFecha = value; }
        }
        public string FormatoFecha
        {
            get { return _formatoFecha; }
            set { _formatoFecha = value; }
        }
        public string SeparadorCampos
        {
            get { return _separadorCampos; }
            set { _separadorCampos = value; }
        }
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public override string ToString()
        {
            return this.Nombre;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (this.GetType() != obj.GetType()) { return false; }

            FormatoExport f = (FormatoExport)obj;
            return (this.Id == f.Id);
        }
    }
}
