using ByteBank.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Utilitarios
{
    public class ListaDeContas
    {
        private Corrente[] _itens;
        private int _proximaPosicao = 0;

        public ListaDeContas(int tamanhoInicial = 5)
        {
            this._itens = new Corrente[tamanhoInicial];
        }

        public void Adicionar(Corrente item)
        {
            Console.WriteLine($"Adicionado item na posição {this._proximaPosicao}");
            this.VerificarCapacidade(this._proximaPosicao + 1);
            this._itens[this._proximaPosicao] = item;
            this._proximaPosicao++;
        }

        public void GetCorrenteMaiorSaldo()
        {
            Corrente correnteMaiorSaldo = this._itens[0];

            for (int i = 0; i < this._itens.Length; i++)
            {
                if (this._itens[i]?.GetSaldo() > correnteMaiorSaldo?.GetSaldo())
                {
                    correnteMaiorSaldo = this._itens[i];
                }
            }

            Console.WriteLine($"A conta corrente com maior saldo é: {correnteMaiorSaldo?.GetSaldo()}");
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (this._itens.Length >= tamanhoNecessario)
            {
                return;
            }

            Console.WriteLine($"Aumentando a capacidade da lista!");

            Corrente[] novoItens = new Corrente[tamanhoNecessario];

            for (int i = 0; i < this._itens.Length; i++)
            {
                novoItens[i] = this._itens[i];
            }

            this._itens = novoItens;
        }

        public void Remover(Corrente conta)
        {
            int indiceItem = -1;

            for (int i = 0; i < this._proximaPosicao; i++)
            {
                Corrente contaAtual = this._itens[i];

                if (contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < this._proximaPosicao - 1; i++)
            {
                this._itens[i] = this._itens[i + 1];
            }

            _proximaPosicao--;
            this._itens[this._proximaPosicao] = null;
        }

        public void ExibeLista()
        {
            for (int i = 0; i < this._itens.Length; i++)
            {
                if (this._itens[i] != null)
                {
                    var conta = this._itens[i];

                    Console.WriteLine($"Índice[{i}] = Conta:{conta.Conta} - N° da Agência: {conta.NumeroAgencia}");
                }
            }
        }

        public Corrente RecuperarContaNoIndice(int indice)
        {
            if (indice < 0 || indice >= this._proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return this._itens[indice];
        }

        public int Tamanho
        {
            get
            {
                return this._proximaPosicao;
            }
        }

        public Corrente this[int indice]
        {
            get
            {
                return RecuperarContaNoIndice(indice);
            }
        }
    }
}
