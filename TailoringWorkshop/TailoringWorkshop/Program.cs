using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double tablesLength = double.Parse(Console.ReadLine());
            double tablesWidth = double.Parse(Console.ReadLine());

            double coversArea = tables * (tablesLength + 2 * 0.30) * (tablesWidth + 2 * 0.30);
            double squaresArea = tables * (tablesLength / 2) * (tablesLength / 2);

            double priceInDollars = coversArea * 7 + squaresArea * 9;
            double priceInLeva = priceInDollars * 1.85;

            Console.WriteLine($"{priceInDollars:F2} USD");
            Console.WriteLine($"{priceInLeva:F2} BGN");
        }
    }
}
