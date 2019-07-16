using CaixaEletronico.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEletronico
{
    public class CaixaEletronico : ICaixaEletronico
    {   /// <summary>
          /// Simula banco do caixa eletronico
         /// </summary>
        private Dictionary<TipoNota, int> _banco { get; set; }
        /// <summary>
        /// Instancia o banco no construtuor 
        /// </summary>
        public CaixaEletronico()
        {
            _banco = new Dictionary<TipoNota, int>();
        }
        /// <summary>
        /// Metodo que realiza o deposito no banco
        /// </summary>
        /// <param name="deposito"></param>
        public void Deposito(Deposito deposito)
        {
            if (_banco.ContainsKey(deposito.Nota))
            {
                _banco[deposito.Nota] = (int)_banco[deposito.Nota] + deposito.QuantidadeNotas;
            }
            else
            {
                _banco.Add(deposito.Nota, deposito.QuantidadeNotas);
            }
        }
        /// <summary>
        /// Metodo que retorna o dicionario de saldo
        /// </summary>
        /// <returns></returns>
        public Dictionary<TipoNota, int> Saldo()
        {
            return _banco;
        }
        /// <summary>
        /// Metodo que realiza o saque
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public Dictionary<TipoNota, int> Saque(int valor)
        {
            if (ValorSaldo() < valor)
            {
                // TODO: refatorar
                throw new System.Exception("Valor do saque superior ao saldo");
            }
            Dictionary<TipoNota, int> retorno = new Dictionary<TipoNota, int>();
            int contatorNotas;

            if (_banco.ContainsKey(TipoNota.Cinquenta))
            {
                contatorNotas = valor / (int)TipoNota.Cinquenta;

                if (contatorNotas > 0)
                {
                    if (contatorNotas > (int)_banco[TipoNota.Cinquenta])
                        contatorNotas = (int)_banco[TipoNota.Cinquenta];

                    if (contatorNotas > 0)
                    {
                        retorno.Add(TipoNota.Cinquenta, contatorNotas);
                        valor -= contatorNotas * (int)(TipoNota.Cinquenta);
                        _banco[TipoNota.Cinquenta] = (int)_banco[TipoNota.Cinquenta] - contatorNotas;
                    }
                }
            }

            if (_banco.ContainsKey(TipoNota.Vinte))
            {
                contatorNotas = valor / (int)TipoNota.Vinte;

                if (contatorNotas > 0)
                {
                    if (contatorNotas > (int)_banco[TipoNota.Vinte])
                        contatorNotas = (int)_banco[TipoNota.Vinte];

                    if (contatorNotas > 0)
                    {
                        retorno.Add(TipoNota.Vinte, contatorNotas);
                        valor -= contatorNotas * (int)(TipoNota.Vinte);
                        _banco[TipoNota.Vinte] = (int)_banco[TipoNota.Vinte] - contatorNotas;
                    }
                }
            }

            if (_banco.ContainsKey(TipoNota.Dez))
            {
                contatorNotas = valor / (int)TipoNota.Dez;
                if (contatorNotas > 0)
                {
                    if (contatorNotas > (int)_banco[TipoNota.Dez])
                        contatorNotas = (int)_banco[TipoNota.Dez];

                    if (contatorNotas > 0)
                    {
                        retorno.Add(TipoNota.Dez, contatorNotas);
                        valor -= contatorNotas * (int)(TipoNota.Dez);
                        _banco[TipoNota.Dez] = (int)_banco[TipoNota.Dez] - contatorNotas;
                    }
                }
            }

            return retorno;
        }
        /// <summary>
        /// Metodo para visualizar o valor total do saldo
        /// </summary>
        /// <returns></returns>
        private int ValorSaldo()
        {
            int retorno = _banco.Sum(x => x.Value * (int)x.Key);
            return retorno;
        }

    }
}
