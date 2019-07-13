using System;

namespace LibraryCalc_UsandoPacote
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryCalc_12.Calculadora calculadora = new LibraryCalc_12.Calculadora();
            int i = calculadora.Soma(2, 9, 9);
             
            Console.WriteLine("soma: {0}",  i);
            Console.ReadKey();

        }
    }
}
