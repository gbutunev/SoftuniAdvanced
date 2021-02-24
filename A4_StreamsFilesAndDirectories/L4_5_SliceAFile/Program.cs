using System;
using System.IO;

namespace L4_5_SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("sliceMe.txt", FileMode.Open))
            {
                int chunk = (int)(fs.Length / 4);

                for (int i = 0; i < 4; i++)
                {
                    byte[] buffer = new byte[4096];
                    int count = 0;

                    using (FileStream writer = new FileStream($"Part-{i + 1}.txt", FileMode.Create, FileAccess.Write))
                    {
                        while (count < chunk)
                        {
                            fs.Read(buffer, 0, buffer.Length);
                            writer.Write(buffer, 0, buffer.Length);
                            count += buffer.Length;
                        }

                        if (fs.Position != fs.Length && i==3)
                        {
                            int remainingBytes = (int)(fs.Length - fs.Position);
                            byte[] lastBuffer = new byte[remainingBytes];

                            fs.Read(lastBuffer, 0, lastBuffer.Length);
                            writer.Write(lastBuffer, 0, lastBuffer.Length);
                        }
                    }
                }
            }
        }
    }
}
