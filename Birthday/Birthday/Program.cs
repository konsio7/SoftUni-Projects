using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double capacity = length * width * height;
            double totalLitres = capacity * 0.001;
            double calculatedPercent = percent * 0.01;
            double litersNeeded = totalLitres * (1 - calculatedPercent);

            Console.WriteLine($"{litersNeeded:F3}");
        }
    }
}
