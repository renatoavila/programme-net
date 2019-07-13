using Aula3.Domain;
using Aula3.Processos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Manager
{
    public class ClienteManager
    {
        private readonly IIRRF _irrf;
        private readonly ICadastro _cadastro;

        public  ClienteManager (IIRRF irrf, ICadastro cadastro)
        {
            _irrf = irrf;
            _cadastro = cadastro;
        }

        public void Processar(Cliente cliente)
        {
            _cadastro.Insere(cliente);
            _irrf.ValidaCpf(cliente.Cpf);
        }
    }
}
