using System;
using System.Collections.Generic;
using System.Text;

namespace Teste1
{

    static class Calculadora
    {
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static int Subtracao(int x, int y)
        {
            return x - y;
        }

        public static int Multiplicacao(int x, int y)
        {
            return x * y;
        }


        public static decimal Divisao(int x, int y)
        {
            // esse método tem uma "sacada" que é usar um cast para transformar para decimal
            // se não usar o cast o valor retorna zerado, porque no C# a divisão de dois valores do tipo int é igual a int
            return (decimal)x / y;
        }
    }

}
