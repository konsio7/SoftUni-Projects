using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            if(type == "Premiere")
            {
                double ticketPrice = 12.00;
                double income = (rows * columns) * ticketPrice;
                Console.WriteLine($"{income:F2}");
            }
            else if(type == "Normal")
            {
                double ticketPrice = 7.50;
                double income = (rows * columns) * ticketPrice;
                Console.WriteLine($"{income:F2}");
            }
            else if(type == "Discount")
            {
                double ticketPrice = 5.00;
                double income = (rows * columns) * ticketPrice;
                Console.WriteLine($"{income:F2}");
            }
        }
    }
}
