using System;

namespace Developer.Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double[,] mat = new double[2, 3]; // [linha, coluna]
            Console.WriteLine($"tamanho matriz = {mat.Length}");
            Console.WriteLine($"total de linhas = {mat.Rank}");
            Console.WriteLine($"total de linhas = {mat.GetLength(0)}");
            Console.WriteLine($"total de colunas = {mat.GetLength(1)}");
            */


            /** criar uma matriz bidimensional
             * imprimir a matriz
             * imprimir numeros negativo
             * imprimir numeros na diagonal principal
             */
            Console.Write("Informe o tamanho da matriz: ");
            int Size = int.Parse(Console.ReadLine());
            int[,] MatTwo = new int[Size, Size];

            string matriz = "";
            string valuesNegative = "";
            string valuesDiagonal = "";
            
            for (int r = 0; r < MatTwo.GetLongLength(0); r++)
            {
                for (int c = 0; c < MatTwo.GetLongLength(1); c++)
                {
                    Console.Write($"Infome valor coluna: {r} - linha {c}: ");
                    MatTwo[r, c] = int.Parse(Console.ReadLine());

                    matriz += string.Concat($" {MatTwo[r, c]} ");

                    if (MatTwo[r, c] < 0)
                        valuesNegative += $" {MatTwo[r, c]} ";
                }
                matriz += "\n";
                valuesDiagonal += $" {MatTwo[r, r]} ";
            }
            
            Console.WriteLine($"MATRIZ BIDIMENSIONAL\n{matriz}");
            Console.WriteLine($"VALORES NEGATIVOS\n{valuesNegative}\n");
            Console.WriteLine($"VALORES DIAGONAL\n{valuesDiagonal}\n");
        }
    }
}
