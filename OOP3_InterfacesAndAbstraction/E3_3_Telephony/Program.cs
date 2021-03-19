using System;
using System.Collections.Generic;
using System.Linq;

namespace E3_3_Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] sites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            SmartPhone smartPhone = new SmartPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (string number in phoneNumbers)
            {
                if (number.Length == 10)
                {
                    Console.WriteLine(smartPhone.Call(number));
                }
                else
                {
                    Console.WriteLine(stationaryPhone.Call(number));
                }
            }

            foreach (string site in sites)
            {
                Console.WriteLine(smartPhone.Browse(site));
            }
        }
    }
}
