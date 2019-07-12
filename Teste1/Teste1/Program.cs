using System;

namespace Teste1
{
    /// <summary>
    /// Classe principal
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 

            int soma = Calculadora.Soma(2, 2);
            int subtracao = Calculadora.Subtracao(2, 2);
            int multiplicacao = Calculadora.Multiplicacao(2, 2);
            // atenção ao tipo "decimal" do método Divisao
            decimal divicao = Calculadora.Divisao(2, 3);
            Console.WriteLine("soma ={0}, subtracao={1}, multiplicacao={2}, divicao={3}", soma, subtracao, multiplicacao, divicao);
             
        }
    }
}
