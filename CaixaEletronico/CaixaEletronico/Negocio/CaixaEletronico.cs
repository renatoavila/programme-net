using CaixaEletronico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEletronico
{
    public class CaixaEletronico : ICaixaEletronico
    {
        #region Propriedades

        /// <summary>
        /// Simula banco do caixa eletronico
        /// </summary>
        private Dictionary<TipoNota, int> Banco { get; set; }

        #endregion

        public CaixaEletronico()
        {
            Banco = new Dictionary<TipoNota, int>();
        }

        #region Implementação

        /// <summary>
        /// Metodo que realiza o deposito no banco
        /// </summary>
        /// <param name="deposito"></param>
        public void Deposito(Deposito deposito)
        {
            if (Banco.ContainsKey(deposito.Nota))
            {
                Banco[deposito.Nota] = (int)Banco[deposito.Nota] + deposito.QuantidadeNotas;
            }
            else
            {
                Banco.Add(deposito.Nota, deposito.QuantidadeNotas);
            }
        }

        /// <summary>
        /// Metodo que retorna o dicionario de saldo
        /// </summary>
        /// <returns></returns>
        public Dictionary<TipoNota, int> Saldo()
        {
            return Banco;
        }
       
        /// <summary>
        /// Metodo que realiza o saque
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public Dictionary<TipoNota, int> Saque(int valor)
        {
            if (this.ValorSaldo() < valor)
            {
                // TODO: refatorar
                throw new System.Exception("Valor do saque superior ao saldo");
            }
            var retorno = new Dictionary<TipoNota, int>();

            var list = Enum.GetValues(typeof(TipoNota)).Cast<TipoNota>().OrderByDescending(x => (int)x);
            foreach (var item in list)
            {
                this.EncontraNotas(item, ref valor, ref retorno);
            }

            return retorno;
        }

        #endregion

        #region Métodos Privados

        /// <summary>
        /// Metodo para visualizar o valor total do saldo
        /// </summary>
        /// <returns></returns>
        private int ValorSaldo()
        {
            int retorno = Banco.Sum(x => x.Value * (int)x.Key);
            return retorno;
        }

        private void EncontraNotas(TipoNota nota, ref int valor, ref Dictionary<TipoNota, int> retorno)
        {
            int contatorNotas;
            if (Banco.ContainsKey(nota))
            {
                contatorNotas = valor / (int)nota;
                if (contatorNotas > 0)
                {
                    if (contatorNotas > (int)Banco[nota])
                        contatorNotas = (int)Banco[nota];

                    if (contatorNotas > 0)
                    {
                        retorno.Add(nota, contatorNotas);
                        valor -= contatorNotas * (int)(nota);
                        Banco[nota] = (int)Banco[nota] - contatorNotas;
                    }
                }
            }

        }

        #endregion
    }
}
