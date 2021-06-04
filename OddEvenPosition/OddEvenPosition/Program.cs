using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenSum = 0;

            for(int i = 1; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if(i % 2  == 0)
                {
                    if(num > evenMax)
                    {
                        evenMax = num;
                    }
                    else if(num < evenMin)
                    {
                        evenMin = num;
                    }
                    if(n < 3)
                    {
                        evenMin = 0;
                        evenMax = 0;
                    }
                    evenSum += num;
                }
                else
                {
                    if(num > oddMax)
                    {
                        oddMax = num;
                    }
                    else if(num < oddMin)
                    {
                        oddMin = num;
                    }
                    oddSum += num;
                }
            }
            string oddMinNo = string.Empty;
            string oddMaxNo = string.Empty;
            string evenMinNo = string.Empty;
            string evenMaxNo = string.Empty;

            if(evenMin > 0)
            Console.WriteLine($"OddSum = {oddSum}, OddMin = {oddMin}, OddMax = {oddMax}, EvenSum = {evenSum}, EvenMin = {evenMin}, EvenMax = {evenMax}");
            else if(evenMin <= 0)
            {
                Console.WriteLine($"OddSum = {oddSum}, OddMin = {oddMin}, OddMax = {oddMax}, EvenSum = {evenSum}, EvenMin = No, EvenMax = No");
            }
            else if(oddMin <= 0)
            {
                Console.WriteLine($"OddSum = {oddSum}, OddMin = No, OddMax = No, EvenSum = {evenSum}, EvenMin = {evenMin}, EvenMax = {evenMax}");
            }
            else if(evenMin <= 0 && oddMin <= 0)
            {
                Console.WriteLine($"OddSum = {oddSum}, OddMin = No, OddMax = No, EvenSum = {evenSum}, EvenMin = No, EvenMax = No");
            }
        }
    }
}
