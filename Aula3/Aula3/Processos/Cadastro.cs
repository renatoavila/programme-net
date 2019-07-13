using Aula3.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Processos
{
    public class Cadastro : ICadastro
    {
        public void Insere(Cliente cliente)
        {
            Console.WriteLine("Inserindo: {0}", cliente.Nome);
        }
    }
}
