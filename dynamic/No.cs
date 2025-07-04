using SortingEnemys.enemys;

namespace PesquisaEmMemoria
{
    public class No
    {
        public Enemy Valor { get; set; }
        public No Esq;
        public No Dir;

        public No(Enemy Valor)
        {
            this.Valor = Valor;
            this.Esq = this.Dir = null!;
        }
    }
}
