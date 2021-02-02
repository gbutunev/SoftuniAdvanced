using System;

namespace L2_7_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] triangle = new long[n][];

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    triangle[i] = new long[] { 1 };
                    continue;
                }

                long[] previousArray = triangle[i - 1];
                long[] currentArray = new long[i + 1];
                currentArray[0] = 1;
                currentArray[currentArray.Length - 1] = 1;
                for (int k = 1; k < currentArray.Length - 1; k++)
                {
                    currentArray[k] = previousArray[k - 1] + previousArray[k];
                }
                triangle[i] = currentArray;
            }

            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                Console.WriteLine(String.Join(" ", triangle[i]));
            }
        }
    }
}
