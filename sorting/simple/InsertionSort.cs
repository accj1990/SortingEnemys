using SortingEnemys.enemys;

namespace Sorting.sorting.simple
{
    class InsertionSort
    {
        public static Enemy[] Sorting(Enemy[] vet)
        {
            int j;
            Enemy x;
            int n = vet.Length;
            for (int i = 1; i < n; i++)
            {
                x = vet[i];
                j = i - 1;
                while (j >= 0 && vet[j].GetLevel() > x.GetLevel())
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = x;
            }
            return vet;
        }
    }
}
