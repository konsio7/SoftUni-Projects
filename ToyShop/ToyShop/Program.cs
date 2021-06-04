using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int talkingDoll = int.Parse(Console.ReadLine());
            int teddyBear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            double totalSum = 0;
            double totalSum1 = 0;
            double rent = 0;
            double discount = 0;

            double sum = puzzle * 2.60 + talkingDoll * 3 + teddyBear * 4.10 + minion * 8.20 + truck * 2;

            int sumToy = puzzle + talkingDoll + teddyBear + minion * truck;
            if (sumToy >= 50)
            {
                discount = 0.25 * sum;
                totalSum = sum - discount;
                rent = 0.10 * totalSum;
                totalSum1 = totalSum - rent;

            }
            else
            {
                totalSum = sum;
                rent = 0.10 * totalSum;
                totalSum1 = totalSum - rent;
            }


            if(totalSum1 >= excursionPrice)
            {
                Console.WriteLine($"Yes! {(totalSum1 - excursionPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursionPrice - totalSum1:F2} lv needed.");
            }
        }
    }
}
