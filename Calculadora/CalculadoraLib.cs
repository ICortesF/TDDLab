using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class CalculadoraLib
    {
        public T Suma<T>(T parOperando1, T parOperando2)

        {
            dynamic num1 = parOperando1;
            dynamic num2 = parOperando2;

            return num1 + num2;
        }

        public decimal Resta(decimal parOperando1, decimal parOperando2)
        {
            return parOperando1 - parOperando2;
        }

    }
}
