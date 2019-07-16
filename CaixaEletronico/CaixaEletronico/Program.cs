using CaixaEletronico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEletronico
{
    class Program
    {   /// <summary>
        ///  Intancia do Caixa eletronica
        /// </summary>
        private static ICaixaEletronico caixaEletronico { get; set; }
        static void Main(string[] args)
        {
            caixaEletronico = new CaixaEletronico();

            var continuar = true;
            do
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
            } while (continuar);
        }

        private static void GetTelaSaldo()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Caixa Eletrônico");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Saldo");
            Dictionary<TipoNota, int> saldo = caixaEletronico.Saldo();
            if (saldo.Count == 0)
            {
                Console.WriteLine("Saldo zerado");
            }
            foreach (var item in saldo)
            {

                Console.WriteLine(GetNotaExtenso("Saldo",item.Key.ToString(),item.Value));
            }
            Console.ReadLine();
        }

        private static void GetTelaSaque()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Caixa Eletrônico");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Saque");
            Console.Write("Digite o valor que deseja sacar: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                Dictionary<TipoNota, int> notasSacadas = caixaEletronico.Saque(valor);

                foreach (var item in notasSacadas)
                {
                    Console.WriteLine(GetNotaExtenso("Saque",item.Key.ToString(), item.Value));
     
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            
            Console.ReadLine();
        }

        private static void GetTelaDesposito()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Caixa Eletrônico");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Depósito");
            Console.WriteLine("1 - Notas de 10");
            Console.WriteLine("2 - Notas de 20");
            Console.WriteLine("3 - Notas de 50");
            Console.WriteLine("4 - Voltar");
            Console.WriteLine();
            Console.Write("Selecione a opção: ");
            var continuar = true;

            Deposito deposito = new Deposito();
            do
            {

                string opcaoDigitado = Console.ReadLine();
                switch (opcaoDigitado)
                {
                    case "1":
                        deposito.Nota = TipoNota.Dez;
                        Console.Write("Quantidade de notas de 10: ");
                        continuar = false;
                        break;

                    case "2":
                        deposito.Nota = TipoNota.Vinte;
                        Console.Write("Quantidade de notas de 20: ");
                        continuar = false;
                        break;

                    case "3":
                        deposito.Nota = TipoNota.Cinquenta;
                        Console.Write("Quantidade de notas de 50: ");
                        continuar = false;
                        break;

                    case "4":
                        //valorDaNota = 0;
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }

            } while (continuar);

            if (deposito.Nota != null)
            {
                int valorDigitado = Convert.ToInt32(Console.ReadLine());
                deposito.QuantidadeNotas = valorDigitado;
                caixaEletronico.Deposito(deposito);
            }
        }

        private static string GetTelaInicial()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Caixa Eletrônico");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Saldo detalhado");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();
            Console.Write("Selecione a opção: ");
            return Console.ReadLine();
        }

        private static string GetNotaExtenso(string tipo,string nota, int valor)
        {
            return $"{tipo} de {valor} notas de {nota}";
        }


    }
}
