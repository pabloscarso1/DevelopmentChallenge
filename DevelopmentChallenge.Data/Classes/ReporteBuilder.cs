using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.EscrituraSubClasses;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    public class ReporteBuilder : IReporteBuilder
    {
        private EscribirReporte _escribirReporte;

        public EscribirReporte Build(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Español:
                    _escribirReporte = new EscrituraEnCastellano();
                    break;
                case Idioma.Ingles:
                    _escribirReporte = new EscrituraEnIngles();
                    break;
                case Idioma.Italiano:
                    _escribirReporte = new EscrituraEnItaliano();
                    break;
            }

            return _escribirReporte;
        }
    }
}
