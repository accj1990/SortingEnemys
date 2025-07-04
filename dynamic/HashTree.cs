using PesquisaEmMemoria.estruturas;
using SortingEnemys.enemys;

namespace ExemploHash
{
    public class EntradaA<T> where T : IComparable<T>
    {
        public T? Chave;
        public ArvoreBinaria Arvore;

        public EntradaA(T chave)
        {
            Chave = chave;
            Arvore = new ArvoreBinaria();
        }

        public void Inserir(Enemy valor)
        {
            Arvore.Inserir(valor);
        }

        public void Remover(Enemy valor)
        {
            Arvore.Remover(valor);
        }

        public void Mostrar()
        {
            Arvore.Mostrar();
        }
    }

    public class HashTree
    {
        public EntradaA<string>[] hash;
        public int TAM = 5;
        public HashTree(int tam)
        {
            TAM = tam;
            hash = new EntradaA<string>[TAM];
        }

        private int ObterIndice(string chave)
        {
            int hash = chave!.GetHashCode();
            return Math.Abs(hash) % TAM;
        }

        public void Adicionar(string chave, Enemy valor)
        {
            int indice = ObterIndice(chave);

            if (ContemChave(chave))
            {
                hash[indice].Inserir(valor);
            }
            else
            {
                hash[indice] = new EntradaA<string>(chave);
                hash[indice].Inserir(valor);
            }
        }

        public void Remover(string chave, Enemy valor)
        {
            int indice = ObterIndice(chave);

            if (ContemChave(chave))
            {
                hash[indice].Remover(valor);
            }
            else
            {
                throw new Exception("Não é possível remover, pois a chave não existe");
            }
        }

        public bool ContemChave(string chave)
        {
            int indice = ObterIndice(chave);

            return hash[indice] != null && hash[indice].Chave != null ? true : false;
        }

        public void Mostrar()
        {
            for (int i = 0; i < TAM; i++)
            {
                if (hash[i] != null)
                    hash[i].Mostrar();
            }
        }
    }
}