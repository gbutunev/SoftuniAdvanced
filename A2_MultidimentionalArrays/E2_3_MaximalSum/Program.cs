using System;
using System.Linq;

namespace E2_3_MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = currRow[k];
                }
            }

            int largestSum = int.MinValue;
            int[] largestCoords = { -1, -1 };

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 2; k++)
                {
                    //current coords: i, k
                    int currSum = 0;

                    for (int r = 0; r < 3; r++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            currSum += matrix[i + r, k + c];
                        }
                    }

                    if (currSum > largestSum)
                    {
                        largestSum = currSum;
                        largestCoords[0] = i;
                        largestCoords[1] = k;
                    }
                }
            }

            Console.WriteLine($"Sum = {largestSum}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{matrix[largestCoords[0] + i, largestCoords[1]]} {matrix[largestCoords[0] + i, largestCoords[1]+1]} {matrix[largestCoords[0] + i, largestCoords[1]+2]}");
            }
        }
    }
}
