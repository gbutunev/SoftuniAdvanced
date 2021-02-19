using System;
using System.Collections.Generic;
using System.Linq;

namespace E2_10_RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] field = new char[inputSize[0], inputSize[1]];
            int[] player = new int[2];


            for (int row = 0; row < field.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = input[col];
                    if (input[col] == 'P')
                    {
                        player[0] = row;
                        player[1] = col;
                    }
                }
            }
            field[player[0], player[1]] = '.';

            char[] moves = Console.ReadLine().ToCharArray();

            foreach (var move in moves)
            {
                BunnyExpansion(field);
                int oldR = player[0];
                int oldC = player[1];
                player = MovePlayer(player, move);

                if (IsValid(field, player[0], player[1]))
                {
                    if (field[player[0], player[1]] == '.')
                    {
                        //field[player[0], player[1]] = 'P';
                        //field[oldR, oldC] = '.';
                    }
                    if (field[player[0], player[1]] == 'B')
                    {
                        PrintField(field);
                        Console.WriteLine($"dead: {player[0]} {player[1]}");
                        return;
                    }
                }
                else
                {
                    //field[oldR, oldC] = '.';
                    PrintField(field);
                    Console.WriteLine($"won: {oldR} {oldC}");
                    return;
                }
            }
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static int[] MovePlayer(int[] player, char move)
        {
            switch (move)
            {
                case 'U':
                    return new int[] { player[0] - 1, player[1] };
                case 'D':
                    return new int[] { player[0] + 1, player[1] };
                case 'L':
                    return new int[] { player[0], player[1] - 1 };
                case 'R':
                    return new int[] { player[0], player[1] + 1 };
                default:
                    return null;
            }
        }

        private static void BunnyExpansion(char[,] field)
        {
            List<int[]> bunnies = new List<int[]>();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        bunnies.Add(new int[] { row, col });
                    }
                }
            }

            foreach (var bunny in bunnies)
            {
                int row = bunny[0];
                int col = bunny[1];

                if (IsValid(field, row - 1, col))
                {
                    field[row - 1, col] = 'B';
                }
                if (IsValid(field, row + 1, col))
                {
                    field[row + 1, col] = 'B';
                }
                if (IsValid(field, row, col - 1))
                {
                    field[row, col - 1] = 'B';
                }
                if (IsValid(field, row, col + 1))
                {
                    field[row, col + 1] = 'B';
                }
            }
        }

        public static bool IsValid(char[,] matrix, int row, int col)
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
