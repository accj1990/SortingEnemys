namespace PesquisaEmMemoria
{
    public class No
    {
        public int Valor { get; set; }
        public No Esq;
        public No Dir;

        public No(int Valor)
        {
            this.Valor = Valor;
            this.Esq = this.Dir = null!;
        }
    }
}
