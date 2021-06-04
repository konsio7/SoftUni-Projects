using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if(product == "coffee")
            {
                if(city == "Sofia")
                {
                    double price = 0.5;
                    Console.WriteLine(quantity * price);
                }
                else if(city == "Varna")
                {
                    double price = 0.45;
                    Console.WriteLine(quantity * price);
                }
                else if(city == "Plovdiv")
                {
                    double price = 0.4;
                    Console.WriteLine(quantity * price);
                }
            }
            else if(product == "water")
            {
                if (city == "Sofia")
                {
                    double price = 0.8;
                    Console.WriteLine(quantity * price);
                }
                else if (city == "Varna")
                {
                    double price = 0.7;
                    Console.WriteLine(quantity * price);
                }
                else if (city == "Plovdiv")
                {
                    double price = 0.7;
                    Console.WriteLine(quantity * price);
                }
            }
            else if(product == "beer")
            {
                if (city == "Sofia")
                {
                    double price = 1.2;
                    Console.WriteLine(quantity * price);
                }
                else if (city == "Varna")
                {
                    double price = 1.1;
                    Console.WriteLine(quantity * price);
                }
                else if (city == "Plovdiv")
                {
                    double price = 1.15;
                    Console.WriteLine(quantity * price);
                }
            }
            else if(product == "sweets")
            {
                if (city == "Sofia")
                {
                    double price = 1.45;
                    Console.WriteLine(quantity * price);
                }
                else if (city == "Varna")
                {
                    double price = 1.35;
                    Console.WriteLine(quantity * price);
                }
                else if (city == "Plovdiv")
                {
                    double price = 1.3;
                    Console.WriteLine(quantity * price);
                }
            }
            else if(product == "peanuts")
            {
                if (city == "Sofia")
                {
                    double price = 1.6;
                    Console.WriteLine(quantity * price);
                }
                else if (city == "Varna")
                {
                    double price = 1.55;
                    Console.WriteLine(quantity * price);
                }
                else if (city == "Plovdiv")
                {
                    double price = 1.5;
                    Console.WriteLine(quantity * price);
                }
            }
        }
    }
}
