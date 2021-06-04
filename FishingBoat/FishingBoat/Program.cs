using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double springPrice = 3000;
            double summerPrice = 4200;
            double winterPrice = 2600;

            double currentPrice = 0;
            double finalCurrentPrice = 0;

            if(season == "Spring")
            {
                if(fishers <= 6)
                {
                    currentPrice = springPrice - (springPrice * 0.1);
                }
                else if(fishers > 6 && fishers <= 11)
                {
                    currentPrice = springPrice - (springPrice * 0.15);
                }
                else if(fishers > 11)
                {
                    currentPrice = springPrice - (springPrice * 0.25);
                }
            }
            else if(season == "Summer" || season =="Autumn")
            {
                if (fishers <= 6)
                {
                    currentPrice = summerPrice - (summerPrice * 0.1);
                }
                else if (fishers > 6 && fishers <= 11)
                {
                    currentPrice = summerPrice - (summerPrice * 0.15);
                }
                else if (fishers > 11)
                {
                    currentPrice = summerPrice - (summerPrice * 0.25);
                }
            }
            else if(season == "Winter")
            {
                if (fishers <= 6)
                {
                    currentPrice = winterPrice - (winterPrice * 0.1);
                }
                else if (fishers > 6 && fishers <= 11)
                {
                    currentPrice = winterPrice - (winterPrice * 0.15);
                }
                else if (fishers > 11)
                {
                    currentPrice = winterPrice - (winterPrice * 0.25);
                }
            }

            if(fishers % 2 == 0 && season != "Autumn")
            {
                finalCurrentPrice = finalCurrentPrice - (currentPrice * 0.05);
            }
            else
            {
                finalCurrentPrice = currentPrice;
            }

            if(budget >= finalCurrentPrice)
            {
                double moneyLeft = budget - finalCurrentPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = finalCurrentPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
            }
        }
    }
}
