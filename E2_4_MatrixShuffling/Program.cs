using System;
using System.Linq;

namespace E2_4_MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] currRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = currRow[k];
                }
            }

            string cmd = Console.ReadLine();
            while (cmd != "END")
            {
                if (cmdIsValid(cmd, matrix))
                {
                    string[] temp = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    int[] coords1 = { int.Parse(temp[1]), int.Parse(temp[2]) };
                    int[] coords2 = { int.Parse(temp[3]), int.Parse(temp[4]) };

                    string tempVal = matrix[coords1[0], coords1[1]];
                    matrix[coords1[0], coords1[1]] = matrix[coords2[0], coords2[1]];
                    matrix[coords2[0], coords2[1]] = tempVal;

                    printMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                cmd = Console.ReadLine();
            }
        }

        private static void printMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (k==matrix.GetLength(1)-1)
                    {
                        Console.Write(matrix[i,k]);
                    }
                    else
                    {
                        Console.Write($"{matrix[i,k]} ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static bool cmdIsValid(string cmd, string[,] matrix)
        {
            string[] parts = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (parts[0] != "swap")
            {
                return false;
            }
            if (parts.Length != 5)
            {
                return false;
            }
            try
            {
                matrix[int.Parse(parts[1]), int.Parse(parts[2])].GetType();
                matrix[int.Parse(parts[3]), int.Parse(parts[4])].GetType();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
