using System;
using System.Linq;

namespace E2_5_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[size[0], size[1]];

            string snake = Console.ReadLine();

            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        matrix[i, k] = snake[counter++];
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                }
                else
                {
                    for (int k = matrix.GetLength(1) - 1; k >= 0; k--)
                    {
                        matrix[i, k] = snake[counter++];
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k]);
                }
                Console.WriteLine();
            }
        }
    }
}
