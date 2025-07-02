using Sorting.reader;
using Sorting.sorting.simple;
using SortingEnemys.enemys;

namespace SortingEnemys;


class Program
{
    public static void Main(string[] args)
    {
        string file = "enemys/enemys.txt";
        string caminhoAbsoluto = Path.GetFullPath(file);

        ReaderFile Arq = new ReaderFile(caminhoAbsoluto);

        Enemy[] Enemies = Arq.LerLinhaALinha(); //Desordenado

        for (int i = 0; i < Enemies.Length; i++)
            Console.WriteLine(Enemies[i].GetName());

        Enemy[] Ordenado;

        Ordenado = BubbleSort.Sorting(Enemies);
        Console.WriteLine("BubbleSort");
        ExibirEnemys(Ordenado);

        Ordenado = InsertionSort.Sorting(Enemies);
        Console.WriteLine("InsertionSort");
        ExibirEnemys(Ordenado);

        Console.WriteLine("SelectionSort");
        Ordenado = SelectionSort.Sorting(Enemies);
        ExibirEnemys(Ordenado);

    }

    public static void ExibirEnemys(Enemy[] Enemies)
    {
        for (int i = 0; i < Enemies.Length; i++)
            Console.WriteLine("" + Enemies[i].GetName() + " " + Enemies[i].GetLevel());
    }
}
