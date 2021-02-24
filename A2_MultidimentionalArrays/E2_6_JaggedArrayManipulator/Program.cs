using System;
using System.Linq;

namespace E2_6_JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x * 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArray[row] = jaggedArray[row].Select(x => x / 2).ToArray();
                    jaggedArray[row + 1] = jaggedArray[row + 1].Select(x => x / 2).ToArray();
                }
            }

            string[] cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (cmd[0] != "End")
            {
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int val = int.Parse(cmd[3]);

                if (checkCoords(row, col, jaggedArray))
                {
                    switch (cmd[0])
                    {
                        case "Add":
                            jaggedArray[row][col] += val;
                            break;
                        case "Subtract":
                            jaggedArray[row][col] -= val;
                            break;
                    }
                }

                cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(String.Join(" ", jaggedArray[i]));
            }
        }

        private static bool checkCoords(int row, int col, double[][] jaggedArray)
        {
            try
            {
                jaggedArray[row][col].GetType();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
