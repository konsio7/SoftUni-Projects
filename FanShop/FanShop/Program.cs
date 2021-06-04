using System;

namespace FanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string item = string.Empty;
            int totalSum = 0;

            for(int i = 1; i <= n; i++)
            {
                item = Console.ReadLine();
                int price = 0;
                switch(item)
                {
                    case "hoodie":
                        price = 30;
                        break;
                    case "keychain":
                        price = 4;
                        break;
                    case "T-shirt":
                        price = 20;
                        break;
                    case "flag":
                        price = 15;
                        break;
                    case "sticker":
                        price = 1;
                        break;
                }
                totalSum += price;
            }

            if(budget >= totalSum)
            {
                int moneyLeft = budget - totalSum;
                Console.WriteLine($"You bought {n} items and left with {moneyLeft} lv.");
            }
            else
            {
                int moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded} more lv.");
            }
        }
    }
}
