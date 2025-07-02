using SortingEnemys.enemys;

namespace Sorting.sorting.simple
{
    class BubbleSort
    {

        public static Enemy[] Sorting (Enemy[] vet)
        {
           int n = vet.Length;
;

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (vet[j].GetLevel() < vet[j - 1].GetLevel())
                    {
                        Enemy tmp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = tmp;
                    }
                }
            }

            return vet;
        }
    }
}
