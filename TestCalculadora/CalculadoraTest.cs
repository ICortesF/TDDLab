using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Calculadora;

namespace TestCalculadora
{

    public class CalculadoraTest
    {
        [Fact]
        public void TestSuma()
        {
            // arange
            var Calculadora = new CalculadoraLib();

            // act
            var ResultadoSuma = Calculadora.Suma(1.12345m, 2.23456m);

            // asert
            Assert.Equal(3.35801m, ResultadoSuma);

        }

        [Fact]
        public void TestResta()
        {
            // arange
            var Calculadora = new CalculadoraLib();

            // act
            var ResultadoSuma = Calculadora.Resta(2.23456m, 1.12345m);

            // asert
            Assert.Equal(1.11111m, ResultadoSuma);

        }
    }
}
