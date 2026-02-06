using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes.TraduccionSubClasses
{
    public class TraductorEnCastellano : ITraductorFormas
    {
        public string Traducir(Forma forma, bool plural)
        {
            switch (forma)
            {
                case Forma.Cuadrado:
                    return plural ? "Cuadrados" : "Cuadrado";
                case Forma.Circulo:
                    return plural ? "Círculos" : "Círculo";
                case Forma.TrianguloEquilatero:
                    return plural ? "Triángulos" : "Triángulo";
                case Forma.Rectangulo:
                    return plural ? "Rectángulos" : "Rectángulo";
                case Forma.Trapecio:
                    return plural ? "Trapecios" : "Trapecio";
                default:
                    return string.Empty;
            }
        }
    }
}
