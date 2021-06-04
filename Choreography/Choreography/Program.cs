using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = int.Parse(Console.ReadLine());
            double dancers = int.Parse(Console.ReadLine());
            double days = int.Parse(Console.ReadLine());

            double stepsPerDay = (steps / days) / steps;
            double stepsPercent = Math.Ceiling(stepsPerDay * 100);
            double stepsPerDancer = stepsPercent / dancers;

            if(stepsPercent < 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {stepsPerDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
