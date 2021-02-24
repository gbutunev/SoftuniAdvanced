using System;
using System.Linq;

namespace L2_5_SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(", ");
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = row[k];
                }
            }

            int biggestSum = int.MinValue;
            int[] biggestCoords = { -1, -1 };

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    int currentSum = matrix[i, k] + matrix[i, k + 1] + matrix[i + 1, k] + matrix[i + 1, k + 1];

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        biggestCoords[0] = i;
                        biggestCoords[1] = k;
                    }
                }
            }

            Console.WriteLine($"{matrix[biggestCoords[0], biggestCoords[1]]} {matrix[biggestCoords[0], biggestCoords[1] + 1]}");
            Console.WriteLine($"{matrix[biggestCoords[0] + 1, biggestCoords[1]]} {matrix[biggestCoords[0] + 1, biggestCoords[1] + 1]}");
            Console.WriteLine(biggestSum);

        }
    }
}
