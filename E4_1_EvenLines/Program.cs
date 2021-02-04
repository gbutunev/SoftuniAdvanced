using System;
using System.IO;
using System.Text.RegularExpressions;

namespace E4_1_EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                int n = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (n % 2 == 0)
                    {
                        line = Regex.Replace(line, @"[-,.!?]", "@");
                        string[] split = line.Split(" ");
                        Array.Reverse(split);

                        Console.WriteLine(String.Join(" ", split));
                    }

                    n++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
