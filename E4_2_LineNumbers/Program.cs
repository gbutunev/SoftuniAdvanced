using System;
using System.IO;
using System.Text.RegularExpressions;

namespace E4_2_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    int n = 1;
                    Regex letterPattern = new Regex("[a-zA-Z]");
                    Regex punctPattern = new Regex(@"[.,!\?\-']");
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        int letterNum = letterPattern.Matches(line).Count;
                        int punctNum = punctPattern.Matches(line).Count;

                        writer.WriteLine($"Line {n}: {line} ({letterNum})({punctNum})");

                        n++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
