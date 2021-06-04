using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            while (a < 1 || a > 100)
            {
                Console.WriteLine("Invalid number!");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {a}");
        }
    }
}
