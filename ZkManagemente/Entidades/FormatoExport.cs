
namespace Entidades
{
    public class FormatoExport
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PosicionMov { get; set; }
        public string CodEntrada { get; set; }
        public string CodSalida { get; set; }
        public string PrefijoReloj { get; set; }
        public int LongitudReloj { get; set; }
        public int PosicionReloj { get; set; }
        public int LongitudLegajo { get; set; }
        public int PosicionLegajo { get; set; }
        public string SeparadorHora { get; set; }
        public int PosicionHora { get; set; }
        public string FormatoHora { get; set; }
        public string SeparadorFecha { get; set; }
        public int PosicionFecha { get; set; }
        public string FormatoFecha { get; set; }
        public string SeparadorCampos { get; set; }
        public string Path { get; set; }

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