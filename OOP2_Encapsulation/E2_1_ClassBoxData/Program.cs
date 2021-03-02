using System;

namespace E2_1_ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Box box = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

                Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.GetVolume():F2}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
