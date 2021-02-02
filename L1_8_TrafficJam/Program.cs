using System;
using System.Collections.Generic;

namespace L1_8_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();

            int number = int.Parse(Console.ReadLine());

            int carsPassed = 0;
            string input = Console.ReadLine();
            while(input.ToLower() != "end")
            {
                if (input.ToLower() == "green")
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        carsPassed++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
