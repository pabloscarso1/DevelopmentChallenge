using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Circulo : FormaUnicoLado
    {
        public Circulo(decimal diametro) : base(diametro)
        {
        }

        public override Forma Tipo => Forma.Circulo;

        public override decimal Perimetro => (decimal)Math.PI* Lado;

        public override decimal Area => (decimal)Math.PI * (Lado / 2) * (Lado/ 2);
    }
}
