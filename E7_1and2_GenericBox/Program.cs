using System;

namespace E7_1and2_GenericBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
        }

        static void Task1()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                Console.WriteLine(box.ToString());
            }
        }

        static void Task2()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(box.ToString());
            }
        }
    }
}
