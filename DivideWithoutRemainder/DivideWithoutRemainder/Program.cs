using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counterDivideBy2 = 0;
            int counterDivideBy3 = 0;
            int counterDivideBy4 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if(num % 2 == 0)
                {
                    counterDivideBy2++;
                }
                if(num % 3 == 0)
                {
                    counterDivideBy3++;
                }
                if(num % 4 == 0)
                {
                    counterDivideBy4++;
                }
            }
            double percentDivideBy2 = (counterDivideBy2 * 1.0 / n) * 100;
            double percentDivideBy3 = (counterDivideBy3 * 1.0 / n) * 100;
            double percentDivideBy4 = (counterDivideBy4 * 1.0 / n) * 100;

            Console.WriteLine($"{percentDivideBy2:F2}%");
            Console.WriteLine($"{percentDivideBy3:F2}%");
            Console.WriteLine($"{percentDivideBy4:F2}%");
        }
    }
}
