using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double beerTotalPrice = beers * 1.20;
            double chipsPrice = 0.45 * beerTotalPrice;
            double chipsTotalPrice = Math.Ceiling(chips * chipsPrice);

            double totalPrice = beerTotalPrice + chipsTotalPrice;

            if(budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"{name} bought a snack and has {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"{name} needs {moneyNeeded:F2} more leva!");
            }
        }
    }
}
