using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceOfFlower = 0;

            if(type == "Roses")
            {
                priceOfFlower = 5;
            }
            else if(type == "Dahlias")
            {
                priceOfFlower = 3.8;
            }
            else if(type == "Tulips")
            {
                priceOfFlower = 2.80;
            }
            else if(type == "Narcissus")
            {
                priceOfFlower = 3;
            }
            else if(type == "Gladiolus")
            {
                priceOfFlower = 2.5;
            }

            double totalPrice = flowers * priceOfFlower;

            if(flowers > 80 && type == "Roses")
            {
                totalPrice = totalPrice - 0.1 * totalPrice;
            }
            else if(flowers > 90 && type == "Dahlias")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if(flowers > 80 && type == "Tulips")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if(flowers < 120 && type == "Narcissus")
            {
                totalPrice = totalPrice + 0.15 * totalPrice;
            }
            else if(flowers < 80 && type == "Gladiolus")
            {
                totalPrice = totalPrice + 0.2 * totalPrice;
            }

            if(budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowers} {type} and {leftMoney:F2} leva left.");
            }
            else
            {
                double needMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
            }
        }
    }
}
