using System;
using System.Collections.Generic;

namespace E2_3_ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleString = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productString = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            try
            {
                foreach (var item in peopleString)
                {
                    string[] parts = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    people.Add(parts[0], new Person(parts[0], decimal.Parse(parts[1])));
                }
                foreach (var item in productString)
                {
                    string[] parts = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    products.Add(parts[0], new Product(parts[0], decimal.Parse(parts[1])));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string input = Console.ReadLine();
            while(input != "END")
            {
                string[] parts = input.Split();

                if (people.ContainsKey(parts[0]) && products.ContainsKey(parts[1]))
                {
                    people[parts[0]].PurchaseProduct(products[parts[1]]);
                }

                input = Console.ReadLine();
            }
            
            foreach(var person in people.Values)
            {
                Console.WriteLine(person);
            }
        }
    }
}
