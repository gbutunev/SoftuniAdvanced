using System;
using System.Collections.Generic;

namespace E1_10_Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int totalCount = 0;
            string cmd = Console.ReadLine();
            while (cmd != "END")
            {
                if (cmd == "green")
                {
                    int greenTime = greenLightDuration;
                    int freeTime = freeWindowDuration;

                    //while (freeTime > 0 || greenTime > 0) // 85/100
                    while(greenTime > 0 && cars.Count !=0)
                    {
                        if (cars.Count != 0) //useless now
                        {
                            string current = cars.Peek();
                            int currentLength = current.Length;

                            if (currentLength <= greenTime)
                            {
                                greenTime -= currentLength;
                                cars.Dequeue();
                                totalCount++;
                                continue;
                            }
                            if (currentLength <= greenTime + freeTime)
                            {
                                if (greenTime != 0) //can enter
                                {
                                    cars.Dequeue();
                                    totalCount++;
                                    freeTime = 0;
                                    greenTime = 0;
                                    continue;
                                }
                                else
                                {
                                    freeTime = 0;
                                    continue;
                                }
                            }
                            else //if (currentLength > greenTime + freeTime)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{current} was hit at {current[greenTime + freeTime]}.");
                                return;
                            }
                        }
                        else //also useless
                        {
                            greenTime = 0;
                            freeTime = 0;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(cmd);
                }

                cmd = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCount} total cars passed the crossroads.");

        }
    }
}
