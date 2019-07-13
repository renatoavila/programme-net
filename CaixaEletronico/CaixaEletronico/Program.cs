using System;

namespace CaixaEletronico
{
    class Program
    {

        static void Main(string[] args)
        {
            var continuar = true;
            while (continuar)
            {
                var menu = GetTelaInicial();

                switch (menu)
                {
                    case "1":
                        GetTelaDesposito();
                        break;
                    case "2":
                        GetTelaSaque();
                        break;
                    case "3":
                        GetTelaSaldo();
                        break;
                    case "4":
                        Console.Clear();
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
            }
        }

        private static void GetTelaSaldo()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Caixa Eletrônico");
            Console.WriteLine("Saldo");
            Console.ReadLine();
        }

        private static void GetTelaSaque()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Caixa Eletrônico");
            Console.WriteLine("Saque");
            Console.ReadLine();
        }

        private static void GetTelaDesposito()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Caixa Eletrônico");
            Console.WriteLine("Depósito");
            Console.WriteLine("1 - Notas de 10");
            Console.WriteLine("2 - Notas de 20");
            Console.WriteLine("3 - Notas de 50");
            Console.WriteLine("4 - Voltar");
            Console.Write("Selecione a opção: ");
            var continuar = true;
            while (continuar)
            {
                string opcaoDigitado = Console.ReadLine();
                int valorDaNota;
                switch (opcaoDigitado)
                {
                    case "1":
                            valorDaNota = 10;
                            continuar = false;
                        break;

                    case "2":
                        valorDaNota = 20;
                        continuar = false;
                    case "3":
                        valorDaNota = 50;
                        continuar = false;
                        break;

                    case "4":
                        valorDaNota = 0;
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
            }



            Console.ReadLine();
        }

        private static string GetTelaInicial()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Caixa Eletrônico");
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Saldo detalhado");
            Console.WriteLine("4 - Sair");
            Console.Write("Selecione a opção: ");
            return Console.ReadLine();
        }


    }
}
