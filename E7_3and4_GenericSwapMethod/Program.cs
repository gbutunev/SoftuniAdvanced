using System;
using System.Collections.Generic;
using System.Linq;

namespace E7_3and4_GenericSwapMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task3();
            Task4();
        }

        static void Task3()
        {
            List<Box<string>> boxes = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                boxes.Add(new Box<string>(Console.ReadLine()));
            }

            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var temp = boxes[indices[0]];
            boxes[indices[0]] = boxes[indices[1]];
            boxes[indices[1]] = temp;

            boxes.ForEach(x => Console.WriteLine(x.ToString()));
        }

        static void Task4()
        {
            List<Box<int>> boxes = new List<Box<int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                boxes.Add(new Box<int>(int.Parse(Console.ReadLine())));
            }

            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var temp = boxes[indices[0]];
            boxes[indices[0]] = boxes[indices[1]];
            boxes[indices[1]] = temp;

            boxes.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
