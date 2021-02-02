using System;
using System.Linq;

namespace L2_6_JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] array = new int[rows][];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                array[i] = row;
            }

            string cmd = Console.ReadLine();
            while(cmd.ToLower() != "end")
            {
                string[] parts = cmd.Split(" ");
                string func = parts[0].ToLower();
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int val = int.Parse(parts[3]);
                if (isValid(row, col, array))
                {
                    if (func == "add")
                    {
                        array[row][col] += val;
                    }
                    else if (func == "subtract")
                    {
                        array[row][col] -= val;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                cmd = Console.ReadLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(String.Join(" ", array[i]));
            }
        }

        private static bool isValid(int row, int col, int[][] array)
        {
            try
            {
                array[row][col].GetType();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
