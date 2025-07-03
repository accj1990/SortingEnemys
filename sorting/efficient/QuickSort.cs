using SortingEnemys.enemys;

namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        // passagem por valor, porém no caso de array a passagem é por referência
        public static Enemy[] Sorting(Enemy[] vet)
        {
            QuickSorting(vet, 0, vet.Length - 1);
            return vet;
        }

        private static int Partition(Enemy[] vet, int esq, int dir)
        {
            Enemy pivot = vet[dir];
            int i = esq - 1;

            for (int j = esq; j <= dir - 1; j++)
            {
                if (vet[j].GetLevel() < pivot.GetLevel())
                {
                    i++;
                    Swap(vet, i, j);
                }
            }

            Swap(vet, i + 1, dir);
            return i + 1;
        }

        private static void Swap(Enemy[] vet, int i, int j)
        {
            Enemy temp = vet[i];
            vet[i] = vet[j];
            vet[j] = temp;
        }

        private static void QuickSorting(Enemy[] vet, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(vet, low, high);
                QuickSorting(vet, low, pi - 1);
                QuickSorting(vet, pi + 1, high);
            }
        }
    }
}