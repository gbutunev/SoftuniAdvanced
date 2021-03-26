using System;

namespace L7_1to4_Stealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();

            // Task 1. Stealer
            Console.WriteLine(spy.StealFieldInfo("L7_1to4_Stealer.Hacker", "username", "password"));
            Console.WriteLine();

            // Task 2. High Quality Mistakes
            Console.WriteLine(spy.AnalyzeAccessModifiers("L7_1to4_Stealer.Hacker"));
            Console.WriteLine();

            // Task 3. Mission Private Impossible
            Console.WriteLine(spy.RevealPrivateMethods("L7_1to4_Stealer.Hacker"));
            Console.WriteLine();

            // Task 4. Collector
            Console.WriteLine(spy.CollectGettersAndSetters("L7_1to4_Stealer.Hacker"));
            Console.WriteLine();
        }
    }
}
