using ExemploHash;
using Sorting.reader;
using Sorting.sorting.efficient;
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

        /* Ordenado = BubbleSort.Sorting(Enemies);
         Console.WriteLine("BubbleSort");
         ExibirEnemys(Ordenado);
        */

        /*Ordenado = InsertionSort.Sorting(Enemies);
        Console.WriteLine("InsertionSort");
        ExibirEnemys(Ordenado);
        */

        /*Console.WriteLine("SelectionSort");
        Ordenado = SelectionSort.Sorting(Enemies);
        ExibirEnemys(Ordenado);
        */

        Console.WriteLine("QuickSort");
        Ordenado = QuickSort.Sorting(Enemies);
        ExibirEnemys(Ordenado);


        HashTree hashTree = new HashTree(5);

        hashTree.Adicionar(Enemies[3].GetName(), Enemies[3]);
        hashTree.Adicionar(Enemies[3].GetName(), Enemies[2]);
        hashTree.Adicionar(Enemies[3].GetName(), Enemies[0]);



        hashTree.Adicionar(Enemies[1].GetName(), Enemies[1]);
        Enemy e2 = Enemies[1];
        e2.SetAttack(5000);


        hashTree.Mostrar();


    }

    public static void ExibirEnemys(Enemy[] Enemies)
    {
        for (int i = 0; i < Enemies.Length; i++)
            Console.WriteLine("" + Enemies[i].GetName() + " " + Enemies[i].GetLevel());
    }
}
