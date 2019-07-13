namespace LibraryCalc_12
{
    /// <summary>
    /// Classe usada para operações matemáticas b
    /// </summary>
    public class Calculadora : ICalculadora
    {
        public int Soma(int x, int y)
        {
            return x + y;
        }

        public int Subtracao(int x, int y)
        {
            return x - y;
        }

        public int Multiplicacao(int x, int y)
        {
            return x * y;
        }

        public double Divisao(double x, double y)
        {
            // esse método tem uma "sacada" que é usar um cast para transformar para decimal
            // se não usar o cast o valor retorna zerado, porque no C# a divisão de dois valores do tipo int é igual a int
            return  x / y;
        }

        public int Soma(int x, int y, int z)
        {
            return x + y + z;
        }

        public int Subtracao(int x, int y, int z)
        {
            return x - y - z;
        }
    }
}
