using System;
using System.Linq;

namespace E2_8_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] currRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int k = 0; k < n; k++)
                {
                    matrix[i, k] = currRow[k];
                }
            }

            string[] bombs = Console.ReadLine().Split(" ");
            foreach (var bomb in bombs)
            {
                int[] inputCoords = bomb.Split(",").Select(int.Parse).ToArray();
                int bX = inputCoords[0];
                int bY = inputCoords[1];

                BombCells(matrix, bX, bY, matrix[bX, bY]);
            }

            int aliveCells = 0;
            int aliveSum = 0;

            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    aliveCells++;
                    aliveSum += item;
                }
            }

            //print
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {aliveSum}");
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write($"{matrix[i, k]} ");
                }
                Console.WriteLine();
            }
        }

        public static void BombCells(int[,] matrix, int bombX, int bombY, int power)
        {
            if (matrix[bombX, bombY] > 0)
            {
                for (int i = -1; i < 2; i++)
                {
                    for (int k = -1; k < 2; k++)
                    {
                        if (IsValid(matrix, bombX + i, bombY + k))
                        {
                            if (matrix[bombX + i, bombY + k] > 0)
                            {
                                matrix[bombX + i, bombY + k] -= power;
                            }
                        }
                    }
                }
            }
            
        }

        public static bool IsValid(int[,] matrix, int x, int y)
        {
            try
            {
                matrix[x, y].GetType();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
