using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace L4_3_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using (StreamReader sr = new StreamReader("words.txt"))
            {
                string[] inputWords = sr.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in inputWords)
                {
                    words.Add(word, 0);
                }
            }

            using (StreamReader sr = new StreamReader("text.txt"))
            {

                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] currentWords = Regex.Split(line.ToLower(), @"[ ,!\?\.-]");

                    foreach (var el in currentWords)
                    {
                        if (words.ContainsKey(el))
                        {
                            words[el]++;
                        }
                    }

                    line = sr.ReadLine();
                }
            }

            using (StreamWriter sr = new StreamWriter("output.txt"))
            {
                foreach (var el in words.OrderByDescending(x => x.Value))
                {
                    sr.WriteLine($"{el.Key} - {el.Value}");
                }
            }
        }
    }
}

