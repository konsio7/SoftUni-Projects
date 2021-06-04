using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeFor1Meter = double.Parse(Console.ReadLine());

            double swimmingTime = distance * timeFor1Meter;
            double waterResistance = Math.Floor(distance / 15);
            double waterResistanceDelay =waterResistance * 12.5;
            double totalSwimmingTime = swimmingTime + waterResistanceDelay;

            if(recordInSeconds > totalSwimmingTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSwimmingTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalSwimmingTime - recordInSeconds):F2} seconds slower.");
            }
        }
    }
}
