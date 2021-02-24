using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace E4_3_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("words.txt"))
            {
                string word = reader.ReadLine();
                while (word != null)
                {
                    words.Add(word, 0);
                    word = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line = reader.ReadToEnd().ToLower();

                string[] lineArray = line.Split(new String[] { " ", ",", ".", "?", "!", "-", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in lineArray)
                {
                    if (words.ContainsKey(word))
                    {
                        words[word]++;
                    }
                }
            }

            string actual = string.Empty;
            string expected = string.Empty;

            foreach (var item in words)
            {
                actual += $"{item.Key} - {item.Value}\n";
            }

            foreach (var item in words.OrderByDescending(x => x.Value))
            {
                expected += $"{item.Key} - {item.Value}\n";
            }

            File.WriteAllText("actualResult.txt", actual);
            File.WriteAllText("expectedResult.txt", expected);
        }
    }
}
