using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Cuadrado : FormaUnicoLado
    {
        public Cuadrado(decimal lado) : base(lado)
        {
        }

        public override Forma Tipo => Forma.Cuadrado;

        public override decimal Perimetro => Lado * 4;

        public override decimal Area => Lado * Lado;
    }
}
