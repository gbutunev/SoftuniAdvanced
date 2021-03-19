using System;
using System.Collections.Generic;
using System.Linq;

namespace E3_5_BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthdays = new List<IBirthable>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Citizen":
                        birthdays.Add(new Citizen(input[1], int.Parse(input[2]), input[3], input[4]));
                        break;
                    case "Pet":
                        birthdays.Add(new Pet(input[1], input[2]));
                        break;
                    case "Robot":
                        Robot robot = new Robot(input[1], input[2]);
                        //whatever
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            string year = Console.ReadLine();

            foreach (var being in birthdays.Where(x=>x.Birthday.EndsWith(year)))
            {
                Console.WriteLine(being.Birthday);
            }
        }
    }
}
