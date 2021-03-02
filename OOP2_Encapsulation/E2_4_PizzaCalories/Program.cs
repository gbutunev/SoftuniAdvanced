using System;
using System.Collections.Generic;

namespace E2_4_PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = Console.ReadLine().Replace("Pizza ", "");
                string[] doughString = Console.ReadLine().Split();
                Dough dough = new Dough(doughString[1], doughString[2], int.Parse(doughString[3]));
                Pizza pizza = new Pizza(name, dough);

                string toppingString = Console.ReadLine();
                while (toppingString != "END")
                {
                    string[] split = toppingString.Split();
                    pizza.AddTopping(new Topping(split[1], int.Parse(split[2])));
                    toppingString = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():F2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
