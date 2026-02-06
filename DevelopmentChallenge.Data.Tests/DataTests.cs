using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.AbstractClasses;
using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.FormasGeometricas;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.That(
                new FormaGeometricaAdmin(
                    new List<FormaGeometrica>(),
                    new ReporteBuilder()
                    ).Imprimir(Idioma.Español),
                Is.EqualTo("<h1>Lista vacía de formas!</h1>"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.That(
                new FormaGeometricaAdmin(
                    new List<FormaGeometrica>(),
                    new ReporteBuilder()
                    ).Imprimir(Idioma.Ingles),
                Is.EqualTo("<h1>Empty list of shapes!</h1>"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = new FormaGeometricaAdmin(cuadrados, new ReporteBuilder()).Imprimir(Idioma.Español);

            Assert.That(resumen,
                Is.EqualTo("<h1>Reporte de formas</h1>1 Cuadrado | Area 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Area 25"));
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = new FormaGeometricaAdmin(cuadrados, new ReporteBuilder()).Imprimir(Idioma.Ingles);

            Assert.That(resumen,
                Is.EqualTo("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35"));
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = new FormaGeometricaAdmin(formas, new ReporteBuilder()).Imprimir(Idioma.Ingles);

            Assert.That(resumen,
                Is.EqualTo(
                    "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65"));
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = new FormaGeometricaAdmin(formas, new ReporteBuilder()).Imprimir(Idioma.Español);

            Assert.That(resumen,
                Is.EqualTo(
                    "<h1>Reporte de formas</h1>2 Cuadrados | Area 29 | Perímetro 28 <br/>2 Círculos | Area 13,01 | Perímetro 18,06 <br/>3 Triángulos | Area 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Area 91,65"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnItaliano()
        {
            var formas = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = new FormaGeometricaAdmin(formas, new ReporteBuilder()).Imprimir(Idioma.Italiano);

            Assert.That(resumen,
                Is.EqualTo("<h1>Rapporto delle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 forme Perimetro 20 Area 25"));
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(4, 2, 3, 3, 3)
            };

            var resumen = new FormaGeometricaAdmin(formas, new ReporteBuilder()).Imprimir(Idioma.Español);

            Assert.That(resumen,
                Is.EqualTo("<h1>Reporte de formas</h1>1 Trapecio | Area 9 | Perímetro 12 <br/>TOTAL:<br/>1 formas Perímetro 12 Area 9"));
        }

        [TestCase]
        public void TestResumenListaConDosTrapeciosEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(4, 2, 3, 3, 3),
                new Trapecio(4, 2, 3, 3, 3)
            };

            var resumen = new FormaGeometricaAdmin(formas, new ReporteBuilder()).Imprimir(Idioma.Ingles);

            Assert.That(resumen,
                Is.EqualTo("<h1>Shapes report</h1>2 Trapezoids | Area 18 | Perimeter 24 <br/>TOTAL:<br/>2 shapes Perimeter 24 Area 18"));
        }
    }
}
