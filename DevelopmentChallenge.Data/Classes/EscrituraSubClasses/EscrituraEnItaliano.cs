using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.TraduccionSubClasses;

namespace DevelopmentChallenge.Data.Classes.EscrituraSubClasses
{
    public class EscrituraEnItaliano : EscribirReporte
    {
        public EscrituraEnItaliano() : base(new TraductorEnItaliano())
        {
        }

        public override string EscribirMensajeInicial(bool hayFormas)
        {
            return (hayFormas ? "<h1>Rapporto delle forme</h1>" : "<h1>Elenco vuoto di forme!</h1>");
        }

        public override string EscribirMensajeReporte(FormaGeometrica forma, int cantidad, decimal perimetro, decimal area)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {Traducir(forma.Tipo, cantidad > 1)} | Area {FormatearDecimal(area)} | Perimetro {FormatearDecimal(perimetro)} <br/>";
            }

            return string.Empty;
        }

        public override string EscribirFooter(int cantidadFormas, decimal totalPerimetro, decimal totalArea)
        {
            return $"TOTALE:<br/>{cantidadFormas} forme Perimetro {FormatearDecimal(totalPerimetro)} Area {FormatearDecimal(totalArea)}";
        }
    }
}
