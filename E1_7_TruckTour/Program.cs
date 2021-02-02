using System;
using System.Collections.Generic;
using System.Linq;

namespace E1_7_TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> stations = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                int[] currentInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                stations.Enqueue(currentInput);
            }

            for (int i = 0; i < n; i++)
            {
                //for (int k = 0; k < i; k++)
                //{
                //    stations.Enqueue(stations.Dequeue());
                //}

                int fuel = 0;
                bool isValid = true;
                for (int trip = 0; trip < n+1; trip++)
                {
                    int[] currentData = stations.Dequeue();
                    stations.Enqueue(currentData);
                    int loadedFuel = currentData[0];
                    int distance = currentData[1];

                    fuel += loadedFuel;
                    if (fuel >= distance)
                    {
                        fuel -= distance;
                        continue;
                    }
                    else
                    {
                        isValid = false;
                    }
                }
                
                if (isValid)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
