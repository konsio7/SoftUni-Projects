using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            switch (figureType)
            {
                case "square":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double area = a * a;
                        Math.Round(area);
                        Console.WriteLine(area);
                        break;
                    }
                case "rectangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double area = a * b;
                        Math.Round(area);
                        Console.WriteLine(area);
                        break;
                    }
                case "circle":
                    {
                        double r = double.Parse(Console.ReadLine());
                        double area = Math.PI * r * r;
                        Math.Round(area);
                        Console.WriteLine($"{area:F3}");
                        break;
                    }
                case "triangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        double area = (a * h) / 2;
                        Math.Round(area);
                        Console.WriteLine(area);
                        break;
                    }
                
            }


        }
    }
}
