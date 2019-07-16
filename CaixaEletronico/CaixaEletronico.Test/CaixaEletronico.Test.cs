using CaixaEletronico.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CaixaEletronico.Test
{
    public class CaixaEletronico_Test
    {
        [Fact]
        public void Saque()
        {
            ICaixaEletronico caixaEletronico = new CaixaEletronico();
            Dictionary<TipoNota, int> saldo;

            Deposito deposito = new Deposito();
            deposito.Nota = TipoNota.Dez;
            deposito.QuantidadeNotas = 10;
            caixaEletronico.Deposito(deposito);

            saldo = caixaEletronico.Saldo();

            deposito.Nota = TipoNota.Vinte;
            deposito.QuantidadeNotas = 10;
            caixaEletronico.Deposito(deposito);

            saldo = caixaEletronico.Saldo();

            deposito.Nota = TipoNota.Cinquenta;
            deposito.QuantidadeNotas = 2;
            caixaEletronico.Deposito(deposito);

            saldo = caixaEletronico.Saldo();

            deposito.Nota = TipoNota.Dez;
            deposito.QuantidadeNotas = 10;
            caixaEletronico.Deposito(deposito);

            saldo = caixaEletronico.Saldo();

            Dictionary<TipoNota, int> nota = caixaEletronico.Saque(180);
            Dictionary<TipoNota, int> nota2 = caixaEletronico.Saque(180);

            saldo = caixaEletronico.Saldo();
        }
    }
}
