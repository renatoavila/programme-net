using CaixaEletronico.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CaixaEletronico.Test
{
    public class CaixaEletronico_Test
    {
        [Theory]
        [InlineData(1, 2, 5)]
        [InlineData(3, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 5)]
        [InlineData(0, 0, 0)]
        public void Deposito(int qtdDez, int qtdVinte, int qtdCinquenta)
        {
            ICaixaEletronico caixaEletronico = new CaixaEletronico();
            Dictionary<TipoNota, int> saldo;

            Deposito deposito = new Deposito();
            deposito.Nota = TipoNota.Dez;
            deposito.QuantidadeNotas = qtdDez;
            caixaEletronico.Deposito(deposito);

            deposito.Nota = TipoNota.Vinte;
            deposito.QuantidadeNotas = qtdVinte;
            caixaEletronico.Deposito(deposito);

            deposito.Nota = TipoNota.Cinquenta;
            deposito.QuantidadeNotas = qtdCinquenta;
            caixaEletronico.Deposito(deposito);
            
            saldo = caixaEletronico.Saldo();

            Assert.True(qtdDez == saldo[TipoNota.Dez]);
            Assert.True(qtdVinte == saldo[TipoNota.Vinte]);
            Assert.True(qtdCinquenta == saldo[TipoNota.Cinquenta]);
        }

        [Theory]
        [InlineData(1, 2, 5, 10)]
        [InlineData(1, 2, 5, 20)]
        [InlineData(1, 2, 5, 50)]
        [InlineData(1, 2, 5, 180)]
        public void Saque(int qtdDez, int qtdVinte, int qtdCinquenta, int valorSaque)
        {
            ICaixaEletronico caixaEletronico = new CaixaEletronico();
            Dictionary<TipoNota, int> saldo;
            Dictionary<TipoNota, int> retornoSaque;

            Deposito deposito = new Deposito();
            deposito.Nota = TipoNota.Dez;
            deposito.QuantidadeNotas = qtdDez;
            caixaEletronico.Deposito(deposito);

            deposito.Nota = TipoNota.Vinte;
            deposito.QuantidadeNotas = qtdVinte;
            caixaEletronico.Deposito(deposito);

            deposito.Nota = TipoNota.Cinquenta;
            deposito.QuantidadeNotas = qtdCinquenta;
            caixaEletronico.Deposito(deposito);

            retornoSaque = caixaEletronico.Saque(valorSaque);

            saldo = caixaEletronico.Saldo();

            Assert.True(qtdDez == saldo[TipoNota.Dez] + (retornoSaque.ContainsKey(TipoNota.Dez) ? retornoSaque[TipoNota.Dez] : 0));
            Assert.True(qtdVinte == saldo[TipoNota.Vinte] + (retornoSaque.ContainsKey(TipoNota.Vinte) ? retornoSaque[TipoNota.Vinte] : 0));
            Assert.True(qtdCinquenta == saldo[TipoNota.Cinquenta] + (retornoSaque.ContainsKey(TipoNota.Cinquenta) ? retornoSaque[TipoNota.Cinquenta] : 0));
        }

        [Theory]
        [InlineData(10)]
        public void SaqueSemSaldoThrowsException(int valorSaque)
        {
            ICaixaEletronico caixaEletronico = new CaixaEletronico();
            Assert.Throws<Exception>(() => caixaEletronico.Saque(valorSaque));
        }

        [Theory]
        [InlineData(1, 2, 1, 1000)]
        [InlineData(0, 0, 0, 1000)]
        public void SaqueComSaldoThrowsException(int qtdDez, int qtdVinte, int qtdCinquenta, int valorSaque)
        {
            ICaixaEletronico caixaEletronico = new CaixaEletronico();
          
            Deposito deposito = new Deposito();
            deposito.Nota = TipoNota.Dez;
            deposito.QuantidadeNotas = qtdDez;
            caixaEletronico.Deposito(deposito);

            deposito.Nota = TipoNota.Vinte;
            deposito.QuantidadeNotas = qtdVinte;
            caixaEletronico.Deposito(deposito);

            deposito.Nota = TipoNota.Cinquenta;
            deposito.QuantidadeNotas = qtdCinquenta;
            caixaEletronico.Deposito(deposito);

            Assert.Throws<Exception>(() => caixaEletronico.Saque(valorSaque));
        }



    }
}
