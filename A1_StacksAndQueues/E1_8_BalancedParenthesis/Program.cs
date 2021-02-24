using System;
using System.Collections.Generic;

namespace E1_8_BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> parenthesis = new Stack<char>();

            bool isValid = true;
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if (current == '(' || current == '[' || current == '{')
                {
                    parenthesis.Push(current);
                }
                else if(parenthesis.Count == 0)
                {
                    isValid = false;
                    break;
                }
                else
                {
                    if (current == ')' && parenthesis.Peek() == '(' ||
                        current == ']' && parenthesis.Peek() == '[' ||
                        current == '}' && parenthesis.Peek() == '{')
                    {
                        parenthesis.Pop();
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (parenthesis.Count != 0)
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
