using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Trapecio : FormaMultiplesLados
    {
        public decimal BaseMenor { get; }
        public decimal LadoIzquierdo { get; }
        public decimal LadoDerecho { get; }

        public override Forma Tipo => Forma.Trapecio;

        public override decimal Perimetro => LadoBase + BaseMenor + LadoIzquierdo + LadoDerecho;

        public override decimal Area => ((LadoBase + BaseMenor) / 2) * Altura;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoIzquierdo, decimal ladoDerecho)
            : base(baseMayor, altura)
        {
            BaseMenor = baseMenor;
            LadoIzquierdo = ladoIzquierdo;
            LadoDerecho = ladoDerecho;
        }
    }
}
