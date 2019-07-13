using System;
using Xunit;

namespace LibraryCalc_12.Tests
{
    public class CalculadoraTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(20, 55)]
        [InlineData(-50, 0)]
        [InlineData(-4, 2)]
        [InlineData(4, 2)]
        public void SomaSucesso(int x, int y)
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Soma(x, y);
            Assert.True((x + y) == resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(20, 55, 5)]
        [InlineData(-50, 0, 5)]
        [InlineData(-4, 2, 8)]
        [InlineData(4, 2, 4)]
        public void SomaTresSucesso(int x, int y, int z)
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Soma(x, y, z);
            Assert.True((x + y + z) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(20, 55)]
        [InlineData(-50, 0)]
        [InlineData(-4, 2)]
        [InlineData(4, 2)]
        public void SubtracaoSucesso(int x, int y)
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Subtracao(x, y);
            Assert.True((x - y) == resultado);
        }

        [Theory]
        [InlineData(1, 2, 7)]
        [InlineData(20, 55, 4)]
        [InlineData(-50, 0, 9)]
        [InlineData(-4, 2, 8)]
        [InlineData(4, 2, 2)]
        public void SubtracaoTresSucesso(int x, int y, int z)
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Subtracao(x, y, z);
            Assert.True((x - y - z) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(20, 55)]
        [InlineData(-50, 0)]
        [InlineData(-4, 2)]
        [InlineData(4, 2)]
        public void MultiplicacaoSucesso(int x, int y)
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Multiplicacao(x, y);
            Assert.True((x * y) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(20, 55)]
        [InlineData(-50, 1)]
        [InlineData(-4, 2)]
        [InlineData(4, 2)]
        public void DivisaoSucesso(double x, double y)
        {
            var calculadora = new Calculadora();
            double resultado = calculadora.Divisao(x, y);
            Assert.True(x / y == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(20, 55)]
        [InlineData(-50, 0)]
        [InlineData(-4, 2)]
        [InlineData(4, 2)]
        public void SomaErro(int x, int y)
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Soma(x, y);
            Assert.False((x + y) != resultado);
        }
    }
}
