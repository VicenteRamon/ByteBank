using bytebank.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Utilitario
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;
        private object get;

        public ListaDeContasCorrentes(int TamanhoInicial=5)
        {
            _itens = new ContaCorrente[TamanhoInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover (ContaCorrente conta) 
        {
            int posicao = 0;
            ContaCorrente contaAtual = conta;
            if (contaAtual != null)
            {
                for (int i = 0; i < _proximaPosicao; i++)
                {
                    if (_itens[i] == conta)
                    {
                        posicao = i;
                        break;                    
                    }
                }
                
                for (int i = posicao; i < _proximaPosicao-1; i++)
                {
                    _itens[i] = _itens[i + 1];
                }

                _proximaPosicao--;
                _itens[_proximaPosicao] = null;
               

            }
        }

        public void mostrar()
        {
          
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] !=null)
                {
                    var Conta = _itens[i];
                    Console.WriteLine($"indice: {i} conta:{Conta.Conta} {Conta.Titular}");
                }
                
            }
        }

        public ContaCorrente RecuperaIndice(int indice)
        {
            if (indice < 0 || indice > _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        public int Tamanho
        {
            get
           {
                return _proximaPosicao; 
           }
        }

    }
}
