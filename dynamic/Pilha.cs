using AlocacaoDinamica.classes;

namespace AlocacaoDinamica
{
    public class Pilha
    {
        public Celula topo;

        public Pilha()
        {
            this.topo = null;
        }
        // Inserir na pilha
        public bool Inserir(int valor)
        {
            if (topo == null)
            {
                this.topo = new Celula(valor);
                return true;
            }
            else
            {
                Celula tmp = new Celula(valor);
                tmp.prox = topo;
                this.topo = tmp;
                return true;
            }
        }

        // Remover na pilha
        public int? Remover()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia");
                return -1;
            }
            else
            {
                int? valor = topo.valor;
                Celula tmp = topo.prox;
                topo = topo.prox;
                tmp = null;
                return valor;
            }
        }

        // Mostrar pilha
        public void Mostrar()
        {
            for (Celula i = topo; i != null; i = i.prox)
            {
                Console.WriteLine(i.valor);
            }

        }
    }
}
