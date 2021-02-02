using System;
using System.Collections.Generic;
using System.Linq;

namespace E2_7_KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] board = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string curr = Console.ReadLine();
                for (int k = 0; k < size; k++)
                {
                    board[i, k] = curr[k];
                }
            }

            int mainCounter = 0;

            while (true)
            {
                int totalPossibleAttacks = 0;

                List<int[]> knights = new List<int[]>();
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (board[row, col] == 'K')
                        {
                            knights.Add(new int[] { row, col });
                        }
                    }
                }

                int bestAttacks = 0;
                int[] bestAttacksCoords = new int[2];
                int[][] movements = { new int[] { 1, 2 }, new int[] { 2, 1 }, new int[] { -2, 1 }, new int[] { -1, 2 }, new int[] { 1, -2 }, new int[] { 2, -1 }, new int[] { -2, -1 }, new int[] { -1, -2 } };
                foreach (var knight in knights)
                {
                    int currentAttacks = 0;

                    for (int i = 0; i < movements.Length; i++)
                    {
                        int x = knight[0] + movements[i][0];
                        int y = knight[1] + movements[i][1];

                        if (isValid(x, y, board))
                        {
                            if (board[x, y] == 'K')
                            {
                                currentAttacks++;
                                totalPossibleAttacks++;
                            }
                        }
                    }

                    if (currentAttacks > bestAttacks)
                    {
                        bestAttacks = currentAttacks;
                        bestAttacksCoords = knight;
                    }
                }

                if (bestAttacks != 0)
                {
                    board[bestAttacksCoords[0], bestAttacksCoords[1]] = '0';
                    mainCounter++;
                    totalPossibleAttacks -= bestAttacks;
                }

                if (totalPossibleAttacks == 0)
                {
                    break;
                }
            }

            Console.WriteLine(mainCounter);
        }

        private static bool isValid(int x, int y, char[,] board)
        {
            try
            {
                board[x, y].GetType();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




        //Solution if it should remove max numbers of knights (going from [0,0] to [n,n])

        //static void Main(string[] args)
        //{
        //    int size = int.Parse(Console.ReadLine());

        //    char[,] board = new char[size, size];

        //    for (int i = 0; i < size; i++)
        //    {
        //        string curr = Console.ReadLine();
        //        for (int k = 0; k < size; k++)
        //        {
        //            board[i, k] = curr[k];
        //        }
        //    }

        //    List<int[]> moved = new List<int[]>();

        //    int[][] movements = { new int[] { 1, 2 }, new int[] { 2, 1 }, new int[] { -2, 1 }, new int[] { -1, 2 }, new int[] { 1, -2 }, new int[] { 2, -1 }, new int[] { -2, -1 }, new int[] { -1, -2 } };

        //    int counter = 0;
        //    for (int i = 0; i < size; i++)
        //    {
        //        for (int k = 0; k < size; k++)
        //        {
        //            int[] currentCoords = { i, k };
        //            if (moved.Where(x => (x[0] == currentCoords[0] && x[1] == currentCoords[1])).FirstOrDefault() == null) //don't skip
        //            {
        //                for (int move = 0; move < movements.Length; move++)
        //                {
        //                    int x = i + movements[move][0];
        //                    int y = k + movements[move][1];

        //                    if (isValid(x, y, board))
        //                    {
        //                        if (board[x, y] == 'K')
        //                        {
        //                            board[i, k] = '0';
        //                            counter++;
        //                            moved.Add(new int[] { x, y });
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    Console.WriteLine(counter);
        //}

        //private static bool isValid(int x, int y, char[,] board)
        //{
        //    try
        //    {
        //        board[x, y].GetType();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}
