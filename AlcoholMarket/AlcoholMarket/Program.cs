using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = (0.5 * whiskeyPrice);
            double winePrice = rakiaPrice - (rakiaPrice * 0.4);
            double beerPrice = rakiaPrice - (rakiaPrice * 0.8);

            double rakiaSum = rakiaQuantity * rakiaPrice;
            double wineSum = wineQuantity * winePrice;
            double beerSum = beerQuantity * beerPrice;
            double whiskeySum = whiskeyQuantity * whiskeyPrice;

            double totalSum = rakiaSum + wineSum + beerSum + whiskeySum;

            Console.WriteLine($"{totalSum:F2}");


        }
    }
}
