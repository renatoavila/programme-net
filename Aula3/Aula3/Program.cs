using Aula3.Domain;
using Aula3.Manager;
using Aula3.Processos;
using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            var irrf = new IRRF();
            var cadastro = new Cadastro();
            var clienteManager = new ClienteManager(irrf, cadastro);

            var cliente = new Cliente()
            {
                Cpf = "08598003697",
                Nome = "Renato"
            };
            clienteManager.Processar(cliente);

            Console.ReadKey();
        }
    }
}
