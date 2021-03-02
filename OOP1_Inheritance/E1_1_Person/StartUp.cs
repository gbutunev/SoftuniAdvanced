using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person p;
            if (age > 15)
            {
                p = new Person(name, age);
            }
            else
            {
                p = new Child(name, age);
            }

            Console.WriteLine(p);
        }
    }
}