using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace E1_9_SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("");
            Stack<string> changes = new Stack<string>();
            

            int n = int.Parse(Console.ReadLine());
            string[] cmd;
            for (int i = 0; i < n; i++)
            {
                cmd = Console.ReadLine().Split(" ");
                switch (cmd[0])
                {
                    case "1":
                        {
                            changes.Push(text.ToString());
                            text.Append(cmd[1]);
                            break;
                        }
                    case "2":
                        {
                            changes.Push(text.ToString());
                            int count = int.Parse(cmd[1]);

                            text.Remove(text.Length - count, count);
                            break;
                        }
                    case "3":
                        {
                            int index = int.Parse(cmd[1]);
                            Console.WriteLine(text[index-1]);
                            break;
                        }
                    case "4":
                        {
                            text.Clear();
                            text.Append(changes.Pop());
                            break;
                        }
                }
            }
        }
    }
}
