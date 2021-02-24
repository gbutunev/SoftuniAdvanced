using System;
using System.Linq;

namespace E2_2_SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] currRow = Console.ReadLine().Split(" ").ToArray();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = currRow[k];
                }
            }

            int totalSquares = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    if (matrix[i, k] == matrix[i, k + 1] &&
                        matrix[i, k] == matrix[i + 1, k] &&
                        matrix[i, k] == matrix[i + 1, k + 1])
                    {
                        totalSquares++;
                    }
                }
            }

            Console.WriteLine(totalSquares);
        }
    }
}
