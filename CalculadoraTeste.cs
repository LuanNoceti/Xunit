using Xunit;

namespace Projeto_Xunit
{
    public class CalculadoraTeste
    {
        [Fact]
        public void TestarSomar()
        {
            // Given

            // When
            double resultado = Calculadora.Somar(13, 10);

            // Then
            Assert.Equal(23, resultado);
        }

        [Fact]
        public void TesteSubtrair()
        {
            // Given

            // When
            double resultado = Calculadora.Subtrair(13, 10);

            // Then
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void TesteMultiplicar()
        {
            // Given

            // When
            double resultado = Calculadora.Multiplicar(13, 10);

            // Then
            Assert.Equal(130, resultado);
        }

        [Fact]
        public void TesteDividir()
        {
            // Given

            // When
            double resultado = Calculadora.Dividir(10, 5);

            // Then
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void TesteDividir2()
        {
            // Given

            // When
            double resultado = Calculadora.Dividir(10, 0);

            // Then
            Assert.Equal(Double.PositiveInfinity, resultado);
        }
    }
}
