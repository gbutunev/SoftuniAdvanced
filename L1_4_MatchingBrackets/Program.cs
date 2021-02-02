using System;
using System.Collections.Generic;

namespace L1_4_MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expr = Console.ReadLine();

            Stack<int> indx = new Stack<int>();

            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    indx.Push(i);
                }
                else if (expr[i] == ')')
                {
                    int endInd = i;
                    int startInd = indx.Pop();

                    string current = expr.Substring(startInd, endInd - startInd + 1);
                    Console.WriteLine(current);
                }
            }
        }
    }
}
