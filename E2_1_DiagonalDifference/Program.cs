using System;
using System.Linq;

namespace E2_1_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = row[k];
                }
            }

            int diag1 = 0;
            int diag2 = 0;

            for (int i = 0; i < size; i++)
            {
                diag1 += matrix[i, i];
            }

            for (int i = 0; i < size; i++)
            {
                diag2 += matrix[i, matrix.GetLength(1) - 1 - i];
            }

            Console.WriteLine(Math.Abs(diag1 - diag2));
        }
    }
}
