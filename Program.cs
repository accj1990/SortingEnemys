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
        //Ordenado = BubbleSort.Sorting(Enemies);
        //Ordenado = InsertionSort.Sorting(Enemies);
        Ordenado = SelectionSort.Sorting(Enemies);

        for (int i = 0; i < Ordenado.Length; i++)
            Console.WriteLine("" +Ordenado[i].GetName() + " "+ Ordenado[i].GetLevel());


    }
}
