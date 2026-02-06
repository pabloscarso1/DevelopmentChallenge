using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class TrianguloEquilatero : FormaUnicoLado
    {
        public TrianguloEquilatero(decimal lado) : base(lado)
        {
        }

        public override Forma Tipo => Forma.TrianguloEquilatero;

        public override decimal Perimetro => Lado * 3;

        public override decimal Area => ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
    }
}
