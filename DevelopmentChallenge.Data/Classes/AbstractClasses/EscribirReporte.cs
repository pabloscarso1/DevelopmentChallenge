using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Interfaces;

using System;

namespace DevelopmentChallenge.Data.Classes.AbstractClasses
{
    public abstract class EscribirReporte
    {
        private readonly ITraductorFormas _traductor;

        protected EscribirReporte(ITraductorFormas traductor)
        {
            _traductor = traductor;
        }

        public abstract string EscribirMensajeInicial(bool hayFormas);
        public abstract string EscribirMensajeReporte(FormaGeometrica forma, int cantidad, decimal perimetro, decimal area);
        public abstract string EscribirFooter(int cantidadFormas, decimal totalPerimetro, decimal totalArea);

        protected string FormatearDecimal(decimal valor)
        {
            return valor.ToString("#.##");
        }

        protected virtual string Traducir(Forma forma, bool plural)
        {
            return _traductor.Traducir(forma, plural);
        }
    }
}
