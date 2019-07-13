using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    interface ICaixaEletronico
    {
        int Deposito(int nota, int quantidade);
        List<Nota> Saque(int valor);
        List<Nota> Saldo();
    }
}
