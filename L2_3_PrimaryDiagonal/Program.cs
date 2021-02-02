using System;
using System.Linq;

namespace L2_3_PrimaryDiagonal
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

                for (int k = 0; k < size; k++)
                {
                    matrix[i, k] = row[k];
                }
            }

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
