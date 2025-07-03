using SortingEnemys.enemys;

namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        public static Enemy[] Sorting(Enemy[] enemys)
        {
            int n = enemys.Length;

            // Constrói o heap (máximo)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(enemys, n, i);

            // Extrai os elementos um por um
            for (int i = n - 1; i > 0; i--)
            {
                Swap(enemys, 0, i);           // Move o maior para o fim
                Heapify(enemys, i, 0);        // Reorganiza o heap reduzido
            }

            return enemys;
        }

        private static void Heapify(Enemy[] enemys, int n, int i)
        {
            int maior = i;
            int esq = 2 * i + 1;
            int dir = 2 * i + 2;

            if (esq < n && enemys[esq].GetAttack() > enemys[maior].GetAttack())
                maior = esq;

            if (dir < n && enemys[dir].GetAttack() > enemys[maior].GetAttack())
                maior = dir;

            if (maior != i)
            {
                Swap(enemys, i, maior);
                Heapify(enemys, n, maior);
            }
        }

        private static void Swap(Enemy[] enemys, int i, int j)
        {
            Enemy temp = enemys[i];
            enemys[i] = enemys[j];
            enemys[j] = temp;
        }
    }
}
