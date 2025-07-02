using SortingEnemys.enemys;

namespace Sorting.sorting.simple
{
    class SelectionSort
    {
        public static Enemy[] Sorting(Enemy[] vet)
        {
            int n = vet.Length;
            int min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vet[j].GetLevel() < vet[min].GetLevel())
                    {
                        min = j;
                    }
                }

                Enemy tmp = vet[i];
                vet[i] = vet[min];
                vet[min] = tmp;
            }

            return vet;
        }
    }
}
