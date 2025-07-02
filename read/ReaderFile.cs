using SortingEnemys.enemys;

namespace Sorting.reader
{
    class ReaderFile
    {
        public string pathFile;
        public ReaderFile()
        {
            pathFile = "";
        }
        public ReaderFile(string pathFile)
        {
            this.pathFile = pathFile;
        }

        public string LerTodoArquivo()
        {
            return File.ReadAllText(this.pathFile); ;
        }

        public Enemy[] LerLinhaALinha()
        {
            int n = GetNumLinhas();
            string[] linhas;
            Enemy[] enemies = new Enemy[n]; //Crie um vetor com o numero de linhas n
            Enemy e;
            int i = 0, j = 0;
            foreach (var linha in File.ReadLines(this.pathFile))
            {
                linhas = linha.Split(",");
                e = new Enemy(linhas[i], int.Parse(linhas[i + 1]), int.Parse(linhas[i + 2]), int.Parse(linhas[i + 3]), int.Parse(linhas[i + 4]), int.Parse(linhas[i + 5]));
                enemies[j] = e;
                j++;
            }

            return enemies;
        }

        public int GetNumLinhas()
        {
            return File.ReadLines(this.pathFile).Count();
        }
    }
}
