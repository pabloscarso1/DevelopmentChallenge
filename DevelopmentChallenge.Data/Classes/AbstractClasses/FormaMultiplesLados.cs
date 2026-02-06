namespace DevelopmentChallenge.Data.Classes.AbstractClasses
{
    public abstract class FormaMultiplesLados : FormaGeometrica
    {
        public decimal LadoBase;
        public decimal Altura;

        protected FormaMultiplesLados()
        {
        }

        protected FormaMultiplesLados(decimal ladoBase, decimal altura)
        {
            LadoBase = ladoBase;
            Altura = altura;
        }
    }
}
