using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Rectangulo : FormaMultiplesLados
    {
        public Rectangulo(decimal ladoBase, decimal altura) : base(ladoBase, altura)
        {
        }

        public override Forma Tipo => Forma.Rectangulo;

        public override decimal Perimetro => 2 * (LadoBase + Altura);

        public override decimal Area => LadoBase * Altura;
    }
}
