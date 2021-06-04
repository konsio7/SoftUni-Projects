using System;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double fatherTime = double.Parse(Console.ReadLine());

            double totalCleaningTime = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
            double timeWithRest = totalCleaningTime + totalCleaningTime * 0.15;
            double leftTime = fatherTime - timeWithRest;

            Console.WriteLine($"Cleaning time: {timeWithRest:F2}");

            if(leftTime >= 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(leftTime):F0} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(leftTime)):F0} hours.");
            }
        }
    }
}
