using SortingEnemys.enemys;

namespace SortingEnemys.dynamic
{
    public class Celula
    {
        public Enemy? valor;
        public Celula? prox;

        public Celula()
        {
            this.valor = null;
            this.prox = null;
        }

        public Celula(Enemy valor)
        {
            this.valor = valor;
        }

    }
}
