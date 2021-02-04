using System;
using System.IO;

namespace L4_1_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = string.Empty;

            using (StreamReader sr = new StreamReader("Input.txt"))
            {
                int n = 0;
                string line = sr.ReadLine();
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        if (n % 2 != 0)
                        {
                            sw.WriteLine(line);
                        }

                        n++;
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
