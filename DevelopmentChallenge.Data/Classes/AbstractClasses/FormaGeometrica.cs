using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.AbstractClasses
{
    public abstract class FormaGeometrica
    {
        public abstract Forma Tipo { get; }
        public abstract decimal Perimetro { get; }
        public abstract decimal Area { get; }
    }
}
