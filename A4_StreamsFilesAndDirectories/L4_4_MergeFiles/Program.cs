using System;
using System.IO;

namespace L4_4_MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                StreamReader reader1 = new StreamReader("FileOne.txt");
                StreamReader reader2 = new StreamReader("FileTwo.txt");

                string line1 = reader1.ReadLine();
                string line2 = reader2.ReadLine();

                while (true)
                {
                    
                    if (line1 != null && line2 != null) 
                    {
                        sw.WriteLine(line1);
                        sw.WriteLine(line2);

                        line1 = reader1.ReadLine();
                        line2 = reader2.ReadLine();
                    }
                    //continue even with uneven lines
                    else if(line1 == null && line2 != null)
                    {
                        sw.WriteLine(line2);
                        line2 = reader2.ReadLine();
                    }
                    else if (line1 != null && line2 == null)
                    {
                        sw.WriteLine(line1);
                        line1 = reader1.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }

                reader1.Close();
                reader2.Close();
            }
        }
    }
}
