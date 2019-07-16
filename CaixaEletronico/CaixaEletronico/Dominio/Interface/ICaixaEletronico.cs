using CaixaEletronico.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public interface ICaixaEletronico
    {
        void Deposito(Deposito deposito);
        Dictionary<TipoNota, int> Saque(int valor);
        Dictionary<TipoNota, int> Saldo();
    }
}
