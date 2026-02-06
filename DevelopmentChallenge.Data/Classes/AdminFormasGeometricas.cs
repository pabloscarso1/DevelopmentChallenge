using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class AdminFormasGeometricas
    {
        private readonly List<FormaGeometrica> _formas;
        private readonly IReporteBuilder _reporteBuilder;
        private EscribirReporte _reporte;

        public AdminFormasGeometricas(IEnumerable<FormaGeometrica> formas, IReporteBuilder reporteBuilder = null)
        {
            _formas = formas?.ToList() ?? new List<FormaGeometrica>();
            _reporteBuilder = reporteBuilder ?? new ReporteBuilder();
        }

        public void AgregarForma(FormaGeometrica forma)
        {
            _formas.Add(forma);
        }

        public string Imprimir(Idioma idioma)
        {
            _reporte = _reporteBuilder.Build(idioma);

            var sb = new StringBuilder();
            sb.Append(_reporte.EscribirMensajeInicial(_formas.Any()));

            if (_formas.Any())
            {
                int cantidadTotal = 0;
                decimal perimetroTotal = 0;
                decimal areaTotal = 0;

                var grupos = _formas.GroupBy(x => x.Tipo);
                foreach (var grupo in grupos)
                {
                    int cantidadTotalForma = 0;
                    decimal perimetroTotalForma = 0;
                    decimal areaTotalForma = 0;

                    foreach (var forma in grupo)
                    {
                        cantidadTotalForma++;
                        perimetroTotalForma += forma.Perimetro;
                        areaTotalForma += forma.Area;
                    }

                    cantidadTotal += cantidadTotalForma;
                    perimetroTotal += perimetroTotalForma;
                    areaTotal += areaTotalForma;

                    var formaReferencia = grupo.First();
                    sb.Append(_reporte.EscribirMensajeReporte(formaReferencia, cantidadTotalForma, perimetroTotalForma, areaTotalForma));
                }

                sb.Append(_reporte.EscribirFooter(cantidadTotal, perimetroTotal, areaTotal));
            }

            return sb.ToString();
        }
    }
}
