﻿using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if(fruit == "banana")
            {
                if(day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    double price = 2.5;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if(day == "Saturday" || day == "Sunday")
                {
                    double price = 2.7;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "apple")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    double price = 1.2;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    double price = 1.25;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "orange")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    double price = 0.85;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    double price = 0.9;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapefruit")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    double price = 1.45;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    double price = 1.6;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "kiwi")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    double price = 2.7;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    double price = 3.0;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "pineapple")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    double price = 5.5;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    double price = 5.6;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapes")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    double price = 3.85;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    double price = 4.2;
                    Console.WriteLine($"{(price * quantity):F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
