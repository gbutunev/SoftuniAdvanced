using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace E4_5_DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> files = new Dictionary<string, Dictionary<string, long>>();

            string[] fileNames = Directory.GetFiles("../../../../");

            foreach (var fileName in fileNames)
            {
                FileInfo currentInfo = new FileInfo(fileName);

                string name = currentInfo.Name;
                long size = currentInfo.Length;
                string ext = currentInfo.Extension;

                if (!files.ContainsKey(ext))
                {
                    files.Add(ext, new Dictionary<string, long>());
                }
                files[ext].Add(name, size);
            }

            string pathToDesktop = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "report.txt");
            using (StreamWriter writer = new StreamWriter(pathToDesktop))
            {
                foreach (var item in files.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
                {
                    writer.WriteLine(item.Key);
                    foreach (var file in item.Value.OrderBy(x=>x.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value / 1024.0}kb");
                    }
                }
            }
        }
    }
}
