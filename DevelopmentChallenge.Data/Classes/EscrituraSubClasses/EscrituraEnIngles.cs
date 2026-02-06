using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.TraduccionSubClasses;

namespace DevelopmentChallenge.Data.Classes.EscrituraSubClasses
{
    public class EscrituraEnIngles : EscribirReporte
    {
        public EscrituraEnIngles() : base(new TraductorEnIngles())
        {
        }

        public override string EscribirMensajeInicial(bool hayFormas)
        {
            return (hayFormas ? "<h1>Shapes report</h1>" : "<h1>Empty list of shapes!</h1>");
        }

        public override string EscribirMensajeReporte(FormaGeometrica forma, int cantidad, decimal perimetro, decimal area)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {Traducir(forma.Tipo, cantidad > 1)} | Area {FormatearDecimal(area)} | Perimeter {FormatearDecimal(perimetro)} <br/>";
            }

            return string.Empty;
        }

        public override string EscribirFooter(int cantidadFormas, decimal totalPerimetro, decimal totalArea)
        {
            return $"TOTAL:<br/>{cantidadFormas} shapes Perimeter {FormatearDecimal(totalPerimetro)} Area {FormatearDecimal(totalArea)}";
        }
    }
}
