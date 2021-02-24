using System;
using System.IO;

namespace L4_2_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("Input.txt"))
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    string line = sr.ReadLine();
                    int n = 1;
                    while (line != null)
                    {
                        sw.WriteLine($"{n++}. {line}");

                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
