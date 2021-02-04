using System;
using System.IO;

namespace E4_4_CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream readStream = new FileStream("copyMe.png", FileMode.Open, FileAccess.Read))
            {
                using (FileStream writeStream = new FileStream("copied.png", FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[512];
                    while (readStream.Position < readStream.Length)
                    {
                        readStream.Read(buffer, 0, buffer.Length);
                        writeStream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
