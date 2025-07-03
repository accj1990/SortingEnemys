using SortingEnemys.enemys;

namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        public static Enemy[] Sorting(Enemy[] enemys)
        {
            int n = enemys.Length;

            // Começa com um intervalo grande e vai reduzindo
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    Enemy temp = enemys[i];
                    int j = i;

                    // Move elementos maiores que temp para frente do gap
                    while (j >= gap && enemys[j - gap].GetLevel() > temp.GetLevel())
                    {
                        enemys[j] = enemys[j - gap];
                        j -= gap;
                    }

                    enemys[j] = temp;
                }
            }

            return enemys;
        }
    }
}
