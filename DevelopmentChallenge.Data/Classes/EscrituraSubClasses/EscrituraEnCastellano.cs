using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.TraduccionSubClasses;

namespace DevelopmentChallenge.Data.Classes.EscrituraSubClasses
{
    public class EscrituraEnCastellano : EscribirReporte
    {
        public EscrituraEnCastellano() : base(new TraductorEnCastellano())
        {
        }

        public override string EscribirMensajeInicial(bool hayFormas)
        {
            return (hayFormas ? "<h1>Reporte de formas</h1>" : "<h1>Lista vacía de formas!</h1>");
        }

        public override string EscribirMensajeReporte(FormaGeometrica forma, int cantidad, decimal perimetro, decimal area)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {Traducir(forma.Tipo, cantidad > 1)} | Area {FormatearDecimal(area)} | Perímetro {FormatearDecimal(perimetro)} <br/>";
            }

            return string.Empty;
        }

        public override string EscribirFooter(int cantidadFormas, decimal totalPerimetro, decimal totalArea)
        {
            return $"TOTAL:<br/>{cantidadFormas} formas Perímetro {FormatearDecimal(totalPerimetro)} Area {FormatearDecimal(totalArea)}";
        }
    }
}
