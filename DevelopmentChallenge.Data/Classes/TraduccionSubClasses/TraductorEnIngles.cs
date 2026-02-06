using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes.TraduccionSubClasses
{
    public class TraductorEnIngles : ITraductorFormas
    {
        public string Traducir(Forma forma, bool plural)
        {
            switch (forma)
            {
                case Forma.Cuadrado:
                    return plural ? "Squares" : "Square";
                case Forma.Circulo:
                    return plural ? "Circles" : "Circle";
                case Forma.TrianguloEquilatero:
                    return plural ? "Triangles" : "Triangle";
                case Forma.Rectangulo:
                    return plural ? "Rectangles" : "Rectangle";
                case Forma.Trapecio:
                    return plural ? "Trapezoids" : "Trapezoid";
                default:
                    return string.Empty;
            }
        }
    }
}
