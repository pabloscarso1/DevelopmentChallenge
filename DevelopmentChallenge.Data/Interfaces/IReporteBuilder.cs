using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IReporteBuilder
    {
        EscribirReporte Build(Idioma idioma);
    }
}
