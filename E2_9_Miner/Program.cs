using System;

namespace E2_9_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            int totalCoal = 0;

            string[,] field = new string[n, n];
            for (int row = 0; row < n; row++)
            {
                string[] currRow = Console.ReadLine().Split();
                for (int col = 0; col < n; col++)
                {
                    if (currRow[col] == "c")
                    {
                        totalCoal++;
                    }
                    field[row, col] = currRow[col];
                }
            }

            int[] miner = new int[2];
            int coalSum = 0;
            //find miner
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (field[i, k] == "s")
                    {
                        miner[0] = i;
                        miner[1] = k;
                    }
                }
            }

            foreach (var cmd in commands)
            {
                int[] newCoords = Move(field, cmd, miner[0], miner[1]);
                if (newCoords[0] == miner[0] && newCoords[1] == miner[1])
                {
                    continue;
                }
                else
                {
                    miner[0] = newCoords[0];
                    miner[1] = newCoords[1];

                    switch (field[miner[0], miner[1]])
                    {
                        case "c":
                            coalSum++;
                            field[miner[0], miner[1]] = "*";
                            break;
                        case "e":
                            Console.WriteLine($"Game over! ({miner[0]}, {miner[1]})");
                            return;

                    }
                }
            }
            if (coalSum == totalCoal)
            {
                Console.WriteLine($"You collected all coals! ({miner[0]}, {miner[1]})");
            }
            else
            {
                Console.WriteLine($"{totalCoal - coalSum} coals left. ({miner[0]}, {miner[1]})");
            }
        }

        public static int[] Move(string[,] matrix, string direction, int row, int col)
        {
            int newRow = row;
            int newCol = col;
            switch (direction)
            {
                case "up":
                    newRow -= 1;
                    if (IsValid(matrix, newRow, newCol))
                    {
                        return new int[] { newRow, newCol };
                    }
                    break;
                case "down":
                    newRow += 1;
                    if (IsValid(matrix, newRow, newCol))
                    {
                        return new int[] { newRow, newCol };
                    }
                    break;
                case "left":
                    newCol -= 1;
                    if (IsValid(matrix, newRow, newCol))
                    {
                        return new int[] { newRow, newCol };
                    }
                    break;
                case "right":
                    newCol += 1;
                    if (IsValid(matrix, newRow, newCol))
                    {
                        return new int[] { newRow, newCol };
                    }
                    break;
            }
            return new int[] { row, col };
        }

        public static bool IsValid(string[,] matrix, int row, int col)
        {
            try
            {
                matrix[row, col].GetType();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
