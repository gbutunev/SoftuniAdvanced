using System;
using System.Collections.Generic;

namespace E7_5and6_GenericCountMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task5();
            Task6();
        }

        private static void Task5()
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                boxes.Add(new Box<string>(Console.ReadLine()));
            }

            string input = Console.ReadLine();
            int count = 0;

            foreach (var item in boxes)
            {
                if (item.IsLargerThan(input))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        private static void Task6()
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                boxes.Add(new Box<double>(double.Parse(Console.ReadLine())));
            }

            double input = double.Parse(Console.ReadLine());
            int count = 0;

            foreach (var item in boxes)
            {
                if (item.IsLargerThan(input))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
