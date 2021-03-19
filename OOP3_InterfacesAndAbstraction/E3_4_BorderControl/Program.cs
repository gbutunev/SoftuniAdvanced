using System;
using System.Collections.Generic;
using System.Linq;

namespace E3_4_BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> objects = new List<IIdentifiable>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 3)
                {
                    objects.Add(new Citizen(parts[0], int.Parse(parts[1]), parts[2]));
                }
                else if (parts.Length == 2)
                {
                    objects.Add(new Robot(parts[0], parts[1]));
                }
                input = Console.ReadLine();
            }
            string ending = Console.ReadLine();

            foreach (var obj in objects.Where(x=>x.Id.EndsWith(ending)))
            {
                Console.WriteLine(obj.Id);
            }
        }
    }
}
