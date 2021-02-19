using System;
using System.Collections.Generic;
using System.Linq;

namespace E8_1_ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstCmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
            ListyIterator<string> iterator = new ListyIterator<string>(firstCmd);

            string cmd = Console.ReadLine();
            while(cmd != "END")
            {
                switch (cmd)
                {
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            iterator.Print();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                }
                cmd = Console.ReadLine();
            }
        }
    }
}
