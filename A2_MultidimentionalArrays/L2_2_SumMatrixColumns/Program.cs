using System;
using System.Linq;

namespace L2_2_SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = row[k];
                }
            }

            int[] sums = new int[cols];
            for (int i = 0; i < sums.Length; i++)
            {
                sums[i] = 0;
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    sums[i] += matrix[k, i];
                }
            }

            foreach(var el in sums)
            {
                Console.WriteLine(el);
            }
        }
    }
}
