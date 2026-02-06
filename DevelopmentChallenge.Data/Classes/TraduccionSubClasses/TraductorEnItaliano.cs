using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes.TraduccionSubClasses
{
    public class TraductorEnItaliano : ITraductorFormas
    {
        public string Traducir(Forma forma, bool plural)
        {
            switch (forma)
            {
                case Forma.Cuadrado:
                    return plural ? "Quadrati" : "Quadrato";
                case Forma.Circulo:
                    return plural ? "Cerchi" : "Cerchio";
                case Forma.TrianguloEquilatero:
                    return plural ? "Triangoli" : "Triangolo";
                case Forma.Rectangulo:
                    return plural ? "Rettangoli" : "Rettangolo";
                case Forma.Trapecio:
                    return plural ? "Trapezi" : "Trapezio";
                default:
                    return string.Empty;
            }
        }
    }
}
