using System;

namespace E7_7_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split();
            string[] line2 = Console.ReadLine().Split();
            string[] line3 = Console.ReadLine().Split();

            Tuple<string, string> tuple1 = new Tuple<string, string>(line1[0] + " " + line1[1], line1[2]);
            Console.WriteLine(tuple1.ToString());
            Tuple<string, int> tuple2 = new Tuple<string, int>(line2[0], int.Parse(line2[1]));
            Console.WriteLine(tuple2.ToString());
            Tuple<int, double> tuple3 = new Tuple<int, double>(int.Parse(line3[0]), double.Parse(line3[1]));
            Console.WriteLine(tuple3.ToString());

        }
    }
}
