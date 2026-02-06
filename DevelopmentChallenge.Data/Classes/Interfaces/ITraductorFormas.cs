using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface ITraductorFormas
    {
        string Traducir(Forma forma, bool plural);
    }
}
