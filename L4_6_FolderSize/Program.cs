using System;
using System.IO;

namespace L4_6_FolderSize
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string dirPath = @"../../../TestFolder";

            Console.WriteLine(GetFolderSize(dirPath) / 1024.0 / 1024.0);
        }

        public static long GetFolderSize(string path)
        {
            long size = 0;
            string[] files = Directory.GetFiles(path);
            string[] folders = Directory.GetDirectories(path);

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                size += info.Length;
            }

            //this part is not in the task
            foreach (var folder in folders)        
            {
                size += GetFolderSize(folder);
            }
            return size;
        }
    }
}
