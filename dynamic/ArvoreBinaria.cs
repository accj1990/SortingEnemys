namespace PesquisaEmMemoria.estruturas
{
    public class ArvoreBinaria
    {
        public No raiz;
        public ArvoreBinaria()
        {
            this.raiz = null!;
        }

        public void Inserir(int Valor)
        {
            if (this.raiz == null)
            {
                this.raiz = new No(Valor);
            }
            else
            {
                Inserir(Valor, raiz);
            }

        }

        public void Inserir(int Valor, No proximo)
        {
            if (proximo.Dir != null)
            {
                Inserir(Valor, proximo.Dir);
            }

            else if (proximo.Esq != null)
            {
                Inserir(Valor, proximo.Esq!);
            }
            else
            {
                if (Valor > proximo.Valor)
                {
                    proximo.Dir = new No(Valor);
                }
                else if (Valor <= proximo.Valor)
                {
                    proximo.Esq = new No(Valor);
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Raiz" + this.raiz.Valor);
            Mostrar(this.raiz);
        }

        private void Mostrar(No proximo)
        {
            if (proximo != null)
            {
                Mostrar(proximo.Esq);
                Console.WriteLine(proximo.Valor);
                Mostrar(proximo.Dir);
            }
        }
    }
}
