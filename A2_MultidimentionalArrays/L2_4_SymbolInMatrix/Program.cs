using System;
using System.Linq;

namespace L2_4_SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();

                for (int k = 0; k < size; k++)
                {
                    matrix[i, k] = row[k];
                }
            }

            char symbol = Console.ReadLine()[0];

            int[] coords = { -1, -1 };
            bool isFound = false;
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    if (matrix[i,k] == symbol)
                    {
                        coords = new int[]{ i, k };
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (coords[0] == -1)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
            else
            {
                Console.WriteLine($"({coords[0]}, {coords[1]})");
            }
        }
    }
}
