using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Processos
{
    public class IRRF : IIRRF
    {
        public bool ValidaCpf(string cpf)
        {
            Console.WriteLine("CPF OK: {0}", cpf);
            return true;
        }
    }
}
