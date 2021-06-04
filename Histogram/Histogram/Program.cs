using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    counter1++;
                }
                else if(num >= 200 && num < 400)
                {
                    counter2++;
                }
                else if(num >= 400 && num < 600)
                {
                    counter3++;
                }
                else if(num >= 600 && num < 800)
                {
                    counter4++;
                }
                else if(num >= 800)
                {
                    counter5++;
                }
            }
            double p1 = (1.00 * counter1 / n) * 100;
            double p2 = (1.00 * counter2 / n) * 100;
            double p3 = (1.00 * counter3 / n) * 100;
            double p4 = (1.00 * counter4 / n) * 100;
            double p5 = (1.00 * counter5 / n) * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
