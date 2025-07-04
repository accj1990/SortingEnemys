using SortingEnemys.enemys;

namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        public static Enemy[] Sorting(Enemy[] enemys)
        {
            if (enemys.Length <= 1)
                return enemys;

            int meio = enemys.Length / 2;

            Enemy[] esquerda = new Enemy[meio];
            Enemy[] direita = new Enemy[enemys.Length - meio];

            Array.Copy(enemys, 0, esquerda, 0, meio);
            Array.Copy(enemys, meio, direita, 0, enemys.Length - meio);

            //esquerda = Sort(esquerda);
            //direita = Sort(direita);

            return Merge(esquerda, direita);
        }

        private static Enemy[] Merge(Enemy[] esquerda, Enemy[] direita)
        {
            int total = esquerda.Length + direita.Length;
            Enemy[] resultado = new Enemy[total];

            int i = 0, j = 0, k = 0;

            while (i < esquerda.Length && j < direita.Length)
            {
                if (esquerda[i].GetLevel() <= direita[j].GetLevel())
                    resultado[k++] = esquerda[i++];
                else
                    resultado[k++] = direita[j++];
            }

            while (i < esquerda.Length)
                resultado[k++] = esquerda[i++];

            while (j < direita.Length)
                resultado[k++] = direita[j++];

            return resultado;
        }
    }
}
