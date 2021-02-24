using System;
using System.Linq;

namespace E7_8_Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split();
            string[] line2 = Console.ReadLine().Split();
            string[] line3 = Console.ReadLine().Split();

            string town = string.Join(" ", line1.ToList().Skip(3));

            Threeuple<string, string, string> tuple1 = new Threeuple<string, string, string>(line1[0] + " " + line1[1], line1[2], town);
            Console.WriteLine(tuple1.ToString());
            Threeuple<string, int, bool> tuple2 = new Threeuple<string, int, bool>(line2[0], int.Parse(line2[1]), line2[2] == "drunk");
            Console.WriteLine(tuple2.ToString());
            Threeuple<string, double, string> tuple3 = new Threeuple<string, double, string>(line3[0], double.Parse(line3[1]), line3[2]);
            Console.WriteLine(tuple3.ToString());
        }
    }
}
