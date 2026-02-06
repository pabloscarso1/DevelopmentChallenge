namespace DevelopmentChallenge.Data.Classes.AbstractClasses
{
    public abstract class FormaUnicoLado : FormaGeometrica
    {
        public readonly decimal Lado;

        public FormaUnicoLado(decimal lado)
        {
            Lado = lado;
        }
    }
}
