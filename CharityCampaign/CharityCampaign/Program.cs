using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakersCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            double cakesSum = cakesCount * 45;
            double wafflesSum = wafflesCount * 5.80;
            double pancakesSum = pancakesCount * 3.20;

            double totalSum = (cakesSum + wafflesSum + pancakesSum) * bakersCount;

            double result = (totalSum * days) - ((totalSum * days) / 8);

            Console.WriteLine($"{result:F2}");
        }
    }
}
