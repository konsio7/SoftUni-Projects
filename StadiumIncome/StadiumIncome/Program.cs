using System;

namespace StadiumIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int sector = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double totalIncome = capacity * ticketPrice;
            double sectorIncome = totalIncome / sector;
            double charity = (totalIncome - (sectorIncome * 0.75)) / 8;

            Console.WriteLine($"Total income - {totalIncome:F2} BGN");
            Console.WriteLine($"Money for charity - {charity:F2} BGN");
        }
    }
}
