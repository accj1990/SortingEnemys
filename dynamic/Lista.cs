using SortingEnemys.dynamic;
using SortingEnemys.enemys;

namespace AlocacaoDinamica
{
    public class Lista
    {
        public Celula? primeiro;
        public Celula? ultimo;

        public Lista()
        {
            this.primeiro = this.ultimo = null;
            //this.primeiro = this.ultimo = new Celula(-1);
        }

        public void InserirInicio(Enemy valor)
        {
            if (primeiro == ultimo)
            {
                primeiro = ultimo = new Celula(valor);
                ultimo = ultimo.prox;
            }
            else if (ultimo == null)
            {
                Celula tmp = new Celula(valor);
                tmp.prox = primeiro;
                primeiro = tmp;
                ultimo = primeiro.prox;
                tmp = null;
            }
            else
            {
                Celula tmp = new Celula(valor);
                tmp.prox = primeiro;
                primeiro = tmp;
                tmp = null;
            }
        }

        public void InserirFim(Enemy valor)
        {
            if (primeiro == ultimo)
            {
                primeiro = ultimo = new Celula(valor);
                ultimo = ultimo.prox;
            }
            else
            {
                ultimo!.prox = new Celula(valor);
                ultimo = ultimo.prox;
            }
        }
        public void InserirPosicao(Enemy valor, int pos)
        {
            int cont = 0;
            Celula i;
            for (i = primeiro!; i != null && i.prox != null && cont < pos - 1; i = i!.prox!, cont++) ;

            Celula tmp = new Celula(valor);

            if (i == primeiro)
            {
                tmp.prox = primeiro;
                primeiro = tmp;
            }
            else
            {
                tmp.prox = i.prox;
                i.prox = tmp;
            }
        }

        public Enemy RemoverInicio()
        {
            Enemy valor = null;
            if (primeiro == ultimo & primeiro == null)
            {
                Console.WriteLine("Não é possível remover, pois a lista está vazia.");
            }
            else if (primeiro == ultimo)
            {
                valor = primeiro!.valor!;
                primeiro = ultimo = null;

            }
            else
            {
                valor = primeiro!.valor!;
                Celula tmp = primeiro!.prox!;
                primeiro.prox = null;
                primeiro = tmp;
            }

            return valor;
        }
        public Enemy RemoverFim()
        {
            Enemy valor = null;
            if (ultimo == null)
            {
                Console.WriteLine("Lista vazia não posso remover.");
            }
            else
            {
                valor = ultimo!.valor!;
                Celula i;
                for (i = primeiro!; i != null && i.prox != ultimo; i = i.prox!) ;

                ultimo = i;
                i.prox = null;
            }

            return valor;
        }

        public void RemoverPosicao(int pos)
        {
            if (pos < 0)
            {
                Console.WriteLine("Posição inválida ou não existe.");
            }

            int cont = 0;
            Celula i;
            for (i = primeiro!; i.prox != null && cont >= 0 && cont < pos - 1; i = i!.prox!, cont++) ;

            if (cont == pos)
            {
                primeiro = ultimo = null;
            }
            else
            {
                if (cont + 1 < pos)
                {
                    Console.WriteLine("Não é possível remover, posição inválida.");
                }
                else
                {
                    Celula tmp = i;
                    i.prox = i!.prox!.prox!;
                    tmp = null;
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine(" ");
            for (Celula i = primeiro!; i != null; i = i.prox!)
            {
                Console.Write(i.valor + " ");
            }
            Console.WriteLine(" ");
        }
        // Mostrar
    }
}
