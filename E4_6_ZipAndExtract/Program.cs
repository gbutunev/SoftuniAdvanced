using System;
using System.IO.Compression;

namespace E4_6_ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToZip = @".\zipThis";
            string zipPath = @".\zipped.zip";
            string pathToUnzip = @".\unzipHere";

            ZipFile.CreateFromDirectory(pathToZip, zipPath);
            ZipFile.ExtractToDirectory(zipPath, pathToUnzip);
        }
    }
}
